using System;
using System.Collections.Generic;
using System.Text;

namespace KonsolProjekt
{
    public class ElevModel
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public char Køn { get; set; }
        public string Telefonnr { get; set; }
        public DateTime Fødelsesdato { get; set; }
        public string[] AlleH1Fag { get; set; }
        public DateTime H1Afslutdato { get; set; }

    }
}
