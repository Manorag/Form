using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRegistro
{
    public class Base
    {
        public int Numero { get; set; }
        public string?Name { get; set; }
        static int i = 1, k = 1;

        public static Queue<Base> esperacaja = new Queue<Base>();
        public static Queue<Base> esperaservice = new Queue<Base>();
    }

}
