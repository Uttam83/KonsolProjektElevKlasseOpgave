
using OOPOPGAVE2.Codes;
using System;

namespace OOPOPGAVE2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil = new("BP20200", "Mercedis");
            Console.WriteLine($"Mærke: {bil.Mærke}, nummerplade nr: {bil.GetNrPlate()}");

            Bil bil2 = new("BP20200", "Mercedis", new DateTime(2012,1,1));
            Console.WriteLine($"Mærke: {bil2.Mærke}, nummerplade nr: {bil2.GetNrPlate()}, Årgang:{bil2.Årgang.ToString("dd.MM.yyyy")}, Bilens alder: {bil2.Alder} år gammel.");
        }
    }
}
