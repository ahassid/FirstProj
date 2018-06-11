using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FactoryBL
    {
        static BLImp bl = null;

        public static BLImp GetBL()
        {
            if (bl == null)
                bl = new BLImp();
            return bl;
        }
    }
}
