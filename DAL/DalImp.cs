using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;
using Dal;
using DAL;

namespace Dal
{
    public class DalImp : Idal
    {

        public DalImp()
        {
            new DataSource();
        }

        #region Get Funcs
        public Synagogue getSynagogue(string name)
        {
            return DataSource.synagogue.Find(s => s.name == name);
        }

        public IEnumerable<Pray> getPrays(Synagogue s, KindPray kp)
        {
            return s.prays.Where(p => p.pray == kp);
        }

        public Pray GetPray(Synagogue s, DateTime time)
        {
            return s.prays.Find(p => p.time == time);
        }

        #endregion
        #region Add Funcs
        public void addSynagogue(Synagogue s)
        {
            if (getSynagogue(s.name) == null)
                DataSource.synagogue.Add(s);
        }

        public void addPray(Pray p)
        {
            Synagogue s = getSynagogue(p.synag.name);
            if (s.prays.Find(m => m.time == p.time) == null)
                return;

            s.prays.Add(p);
            DataSource.pray.Add(p);

            //    if (p.pray == KindPray.Shacrit)
            //    s.Shacrit.Add(p);
            //else if (p.pray == KindPray.Minha)
            //    s.Minha.Add(p);
            //else s.Arvit.Add(p);

        }
        #endregion
        #region Delete Funcs
        public void deletePray(Pray p)
        {
            if (GetPray(p.synag, p.time) != null)
                DataSource.pray.Remove(p);
            else throw new Exception("That Pray Does Not Exist");

        }

        public void deleteSynagogue(Synagogue s)
        {
            if (getSynagogue(s.name) != null)
                DataSource.synagogue.Remove(s);
            else throw new Exception("That Synagogue Does Not Exist");
        }
        #endregion
        #region 'Get All' Funcs
        public IEnumerable<Pray> getAllPrays(Func<Pray, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.pray.AsEnumerable();
            return DataSource.pray.Where(predicat);
        }

        public IEnumerable<Synagogue> getAllSynagogues(Func<Synagogue, bool> predicat = null)
        {
            if (predicat == null)
                return DataSource.synagogue.AsEnumerable();
            return DataSource.synagogue.Where(predicat);
        }
        #endregion
    }
}
