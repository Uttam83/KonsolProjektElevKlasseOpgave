
using KonsolProjekt.Codes;
using OOPOPGAVE3.Codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOPGAVE3.Codes
{
    sealed class Bil : Motorkøretøj, ISynsInfo
    {
        #region Property fields

        private string _nummerPlade;

        #endregion

        #region Properties

        public string ErrorMsg { get; set; }
        public string Mærke { get; set; }

        public DateTime? SidstSynet { get; set; }

        #endregion

        #region Constructors

        public Bil(string nummerPlade, string mærke, DateTime? sidstSynet)
        {
            SetNummerPlade(nummerPlade);
            SetEjerInfo("Uttam U", 20202020);
            Mærke = mærke;
            SidstSynet = sidstSynet;
            TjekkeForSynsDato();
        }

        public Bil(string nummerPlade, string brand, DateTime årgang, DateTime? sidstSynet) : base(årgang)
        {
            SetNummerPlade(nummerPlade);
            SetEjerInfo("Umesh M", 30303030);
            Mærke = brand;
            Årgang = årgang;
            SidstSynet = sidstSynet;
            TjekkeForSynsDato();
        }

        private void TjekkeForSynsDato()
        {
            DateTime? næsteSynDato = NæsteSynDato();

            try
            {
                if (næsteSynDato != null)
                {
                    throw new Exception($"skal synes den {(DateTime)næsteSynDato:dd.MM.yyyy}");
                }
            }
            catch (Exception exc)
            {
                ErrorMsg = exc.Message;
            }
        }

        #endregion

        public string GetNummerPlade()
        {
            return _nummerPlade;
        }

        public void SetNummerPlade(string value)
        {
            _nummerPlade = value;
        }

        public override void SetEjerInfo(string navn, int tlf)
        {
            KontaktInfo = new EjerensKontaktInfo(navn, tlf);
        }

        internal static object getInventory()
        {
            throw new NotImplementedException();
        }

        public DateTime? NæsteSynDato()
        {
            AgeCounter ac = new AgeCounter((DateTime)SidstSynet);
            if (ac.Alder > 2)
            {
                return DateTime.Now.AddMonths(3);
            }
            else
            {
                return null;
            }
        }
    }
}
