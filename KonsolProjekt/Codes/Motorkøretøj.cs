using OOPOPGAVE2.Codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOPGAVE2.Codes
{
    abstract class Motorkøretøj
    {
        public record EjerensKontaktInfo(string navn, int tlf);
        public DateTime årgang;

        protected EjerensKontaktInfo KontaktInfo { get; set; }
        public int? Alder { get; set; }
        public DateTime Årgang
        {
            get
            {
                return årgang;
            }
            set
            {
                årgang = value;

                AgeCounter ac = new(årgang);
                Alder = ac.Alder;
            }
        }

        public Motorkøretøj()
        {
        }

        public Motorkøretøj(DateTime årgang)
        {
            Årgang = årgang;
        }

        public abstract void SetEjerInfo(string navn, int tlf);
    }
}
