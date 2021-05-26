using System;
using System.Collections.Generic;
using System.Text;

namespace KonsolProjekt
{
    public class H1ElevKlasse
    {
        public record KontaktInfo(string name, string telefonNr);

        Bil model;
        public H1ElevKlasse()
        {
            model = new Bil()
            {
                Fornavn = "John",
                Efternavn="Smith",
                Køn = 'M',
                Telefonnr = "78 78 78 78",
                Fødelsesdato = DateTime.Parse("1980-10-10"),
                H1Afslutdato = DateTime.Parse("2021-06-25"),
                AlleH1Fag = new string[] {"SQL", "Programmering", "NetVærk"}
            };
        }

        public Bil GetElevInfo()
        {
            var elevInfo = new Bil();
            try
            {
                elevInfo = model;
            }
            catch (Exception e)
            {
                Console.WriteLine("obs! der sket en fejl");
                Console.WriteLine("Fejlen er: " + e.Message);
            }
            return elevInfo;
        }

        public KontaktInfo GetElevKontaktInfo()
        {
            string fullName = model.Fornavn + " " + model.Efternavn;
            string tlf = model.Telefonnr;

            KontaktInfo kontt = new KontaktInfo(fullName, tlf);
            return kontt;
        }
    }
}
