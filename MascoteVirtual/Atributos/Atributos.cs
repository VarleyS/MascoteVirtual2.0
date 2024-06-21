using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascoteVirtual.Atributos
{
    public class Atributos
    {
        public int Min{ get; set; }
        public int Max { get; set; }
        public int Value { get; set; }


        public Atributos(int min, int max, int value) 
        {
            Min = min;
            Max = max;
            Value = value;
        }
    }
}
