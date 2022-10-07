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
        public static int i = 1;
        public static int k = 1;

        public static Queue<Base> esperacaja = new Queue<Base>();
        public static Queue<Base> esperaservice = new Queue<Base>();
        public static Queue<Base> atendidoscaja = new Queue<Base>();
        public static Queue<Base> atendidosservice = new Queue<Base>();
    }

}
