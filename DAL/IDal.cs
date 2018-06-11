using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface Idal
    {
        Synagogue getSynagogue(string name);
        IEnumerable<Pray> getPrays(Synagogue s, KindPray kp);
        Pray GetPray(Synagogue s, DateTime time);
        void addSynagogue(Synagogue s);
        void addPray(Pray p);
        void deletePray(Pray p);
        void deleteSynagogue(Synagogue s);
        IEnumerable<Synagogue> getAllSynagogues(Func<Synagogue, bool> predicat = null);
        IEnumerable<Pray> getAllPrays(Func<Pray, bool> predicat = null);
    }
}
