using System;

namespace KonsolProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization of H1ElevKlasse class
            H1ElevKlasse elevKlasse = new H1ElevKlasse();

            //Call the method with the elevKlasse object
            var elevInfo = elevKlasse.GetElevInfo();

            Console.WriteLine("Klasse eksempel \n");
            Console.WriteLine("-------------------------");


            Console.WriteLine(
                "Fornavn: "+ elevInfo.Fornavn +
                "\n Efternavn: " + elevInfo.Efternavn +
                "\n Telefon: " + elevInfo.Telefonnr +
                "\n Anden H1 Fag: " + elevInfo.AlleH1Fag[1]+
                "\n H1Afslutdato: " + elevInfo.H1Afslutdato
                );

            Console.WriteLine("\nStruct eksempel ");
            Console.WriteLine("------------------------- \n");


            //Initialize struct with a parameter
            StructKlasse udregningStruct = new StructKlasse(elevInfo.H1Afslutdato);

            //call method with the struct object
            var datoTilbage = udregningStruct.BeregnAfslutDato();
            Console.WriteLine("Education will be Finished in:  {0} days",datoTilbage);

           


            Console.WriteLine("\n Records eksempel ");
            Console.WriteLine("------------------------- \n");
            string navn = elevKlasse.GetElevKontaktInfo().name;
            string tlf = elevKlasse.GetElevKontaktInfo().telefonNr;
            Console.WriteLine($"{ navn}, { tlf}");



            Console.WriteLine("\n\npress any key to exit");
            Console.ReadLine();
        }
    }
}
