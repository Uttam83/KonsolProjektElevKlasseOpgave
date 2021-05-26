using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopOPGAVE1.Codes
{


    struct AgeCounter
    {

        public int? Alder { get; set; }

        public AgeCounter(DateTime yearofRelease)
        {
            Alder = null;
            Alder = GetAge(yearofRelease);
        }

        private int? GetAge(DateTime yearofRelease)
        {
            return DateTime.Now.Year - yearofRelease.Year;
        }
    }



}