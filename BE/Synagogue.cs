using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Synagogue : IComparable
    {
        public string name { get; set; }
        public string address { get; set; }
        public string note { get; set; }
        public Nosah nosah;
        public List<Pray> prays = new List<Pray>();

        public int CompareTo(object obj)
        {
            return name.CompareTo(((Synagogue)obj).name);
        }

        //public List<Pray> Shacrit = new List<Pray>();
        //public List<Pray> Minha = new List<Pray>();
        //public List<Pray> Arvit = new List<Pray>();
    }
}
