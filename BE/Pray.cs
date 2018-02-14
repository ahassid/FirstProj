using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pray : IComparable
    {
        public KindPray pray;
        public Synagogue synag;
        public DateTime time;

        public int CompareTo(object obj)
        {
            return time.CompareTo(((Pray)obj).time);
        }
    }
}
