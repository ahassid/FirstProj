using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        void addPray(Pray p);
        void addSynagogue(Synagogue s);
        void deletePray(Pray p);
        void deleteSynagogue(Synagogue s);
        IEnumerable<Pray> GetAllPrays();
        IEnumerable<Synagogue> GetAllSynagogues();
        Synagogue GetSynagogue(string s);
        IEnumerable<Pray> PrayByKind(Synagogue s, KindPray kp);
        IEnumerable<Pray> PrayByTime(DateTime time, KindPray kp);
        IEnumerable<IGrouping<KindPray, Pray>> PraysGroupByKind();
        IEnumerable<IGrouping<Nosah, Synagogue>> SynagogueGroupByNosah();
    }
}
