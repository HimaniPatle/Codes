using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueObject
{
    class PerDetails
    {
        public string Name;
        public int Age;

        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
}
