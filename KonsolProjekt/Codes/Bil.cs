using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopOPGAVE1.Codes
{
    class Bil
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

        public int? Alder { get; set; }



        public Bil(string numberplate, string brand)
        {
            SetNrPlade(numberplate);

            Mærke = brand;

        }

        public Bil(string numberplate, string brand, DateTime yearofRelease)
        {
            SetNrPlade(numberplate);
            Mærke = brand;

            AgeCounter ac = new(yearofRelease);
            Alder = ac.Alder;

        }

    }
}
