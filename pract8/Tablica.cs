using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pract8
{
    internal  class Tablica
    {
        public Tablica(string a, double b,int c)
        {
            nameid = a;
            time = b;
            errors = c;

            
        }

        public static List<Tablica> tabs = new ();


        public  string nameid;
        public double time;
        public int errors;
    
    }
}
