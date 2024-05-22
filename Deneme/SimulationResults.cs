using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class SimulationResults
    {
        public int TypeAUserCount { get; set; }
        public int TypeBUserCount { get; set; }
        public long AverageDurationTypeA { get; set; }
        public long AverageDurationTypeB { get; set; }
        public int DeadlocksTypeA { get; set; }
        public int DeadlocksTypeB { get; set; }
    }
}
