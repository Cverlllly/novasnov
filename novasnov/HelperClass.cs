using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novasnov
{
    internal class HelperClass
    {
        public static Random rand = new Random();
        
        public static int GetState()
        {
            int rand_value = Convert.ToInt32(rand.Next(0, 3));
            return rand_value;
        }
    }
}
