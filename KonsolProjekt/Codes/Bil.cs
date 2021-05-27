
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOPGAVE2.Codes
{
    sealed class Bil:Motorkøretøj
    {
        #region Property Fields

        private string _nummerpladeNr;

        public string GetNrPlate()
        {
            return _nummerpladeNr;
        }

        public void SetNrPlade(string value)
        {
            _nummerpladeNr = value;
        }
        #endregion

        public string Mærke { get; set; }

        public Bil(string numberplate, string brand)
        {
            SetNrPlade(numberplate);
            SetEjerInfo("Uttam U", 20202020);
            Mærke = brand;
        }

        public Bil(string numberplate, string brand, DateTime yearofRelease) : base(yearofRelease)
        {
            SetNrPlade(numberplate);
            SetEjerInfo("Umesh U",30303030);
            Mærke = brand;           
        }

        public override void SetEjerInfo(string navn, int tlf)
        {
            KontaktInfo = new EjerensKontaktInfo(navn, tlf);
        }

    }
}
