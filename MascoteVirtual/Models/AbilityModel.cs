using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascoteVirtual.Models
{
    public class AbilityModel
    {
        public AbilityName ability { get; set; }

        public class AbilityName
        {
            public string name { get; set; }
        }
    }
}
