﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Dal;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi.Entities.Directions.Response;
using GoogleMapsApi;

namespace BL
{
    public class IBL
    {
        IDal D;
        #region Add Funcs
        public void addPray(Pray p)
        {
            D.addPray(p);
        }

        public void addSynagogue(Synagogue s)
        {
            D.addSynagogue(s);
        }
        #endregion
        #region Delete Funcs
        public void deletePray(Pray p)
        {
            D.deletePray(p);
            if (p.synag.prays.Count == 0)
                throw new Exception("Currently There R No Prays At That Synagogue - Maybe U Should Delete It..");
        }

        public void deleteSynagogue(Synagogue s)
        {
            if (s.prays != null)
                throw new Exception("There R Prays At That Synagogue - Pls Delete Them First!");
            D.deleteSynagogue(s);
        }
        #endregion

        public IEnumerable<Pray> PrayByKind(KindPray kp)
        {
            return D.getAllPrays(p => p.pray == kp);
        }

        public IEnumerable<Pray> PrayByTime(DateTime time, KindPray kp)
        {
            var condition1 = D.getAllPrays(p => p.time.CompareTo(time) >= 0);
            var condition2 = D.getAllPrays(p => p.pray == kp);
            var result = from item1 in condition1
                         from item2 in condition2
                         where (item1.pray == item2.pray && item1.synag == item2.synag && item1.time == item2.time)
                         select item2;
            return result;
        }

        public IEnumerable<IGrouping<KindPray, Pray>> PraysGroupByKind()
        {
            return from item in D.getAllPrays()
                   orderby (item.pray)
                   group item by (item.pray);
        }

        public IEnumerable<IGrouping<Nosah, Synagogue>> SynagogueGroupByNosah()
        {
            return from item in D.getAllSynagogues()
                   orderby (item.nosah)
                   group item by (item.nosah);
        }

        // Get The Distance Between 2 Places
        public static int CalculateDistance(string source, string dest)
        {
            var drivingDirectionRequest = new DirectionsRequest
            {
                TravelMode = TravelMode.Walking,
                Origin = source,
                Destination = dest,
            };

            DirectionsResponse drivingDirections = GoogleMaps.Directions.Query(drivingDirectionRequest);
            Route route = drivingDirections.Routes.First();
            Leg leg = route.Legs.First();
            return leg.Distance.Value;
        }
    }
}
