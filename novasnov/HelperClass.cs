using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novasnov
{
    internal class HelperClass
    {
        public static Random rand { get; set; }
        
        public static int GetState()
        {
            return rand.Next(0, 3);
        }
    }
}
