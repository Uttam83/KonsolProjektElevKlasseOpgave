using oopOPGAVE1.Codes;
using System;

namespace oopOPGAVE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil = new("BP20200", "Mercedis");
            Console.WriteLine($"Mærke: {bil.Mærke}, nummerplade nr. {bil.GetNrPlate()}");

            bil = new("BP20200", "Mercedis", new DateTime(2012, 1, 1));
            Console.WriteLine($"Mærke: {bil.Mærke}, nummerplade nr. {bil.GetNrPlate()}, bilens alder: {bil.Alder} år gammel.");
        }
    }
}
