using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOPGAVE2.Codes
{
    struct AgeCounter
    {
        public int? Alder { get; set; }

        public AgeCounter(DateTime yearofRelease):this()
        {
            Alder = GetAge(yearofRelease);
        }

        private int? GetAge(DateTime yearofRelease)
        {
            return DateTime.Now.Year - yearofRelease.Year;
        }
    }



}
