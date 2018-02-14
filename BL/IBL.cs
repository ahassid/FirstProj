using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Dal;

namespace BL
{
    public class IBL
    {
        IDal D;
        public void addPray(Pray p)
        {
            D.addPray(p);
        }

        public void addSynagogue(Synagogue s)
        {
            D.addSynagogue(s);
        }
    }
}
