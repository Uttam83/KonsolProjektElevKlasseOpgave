using OOPOPGAVE3.Codes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPOPGAVE3
{
    class Program
    {
        static void Main(string[] args)
        {
            // lists
            List<Bil> biler = new List<Bil>();

            Bil bil = new("AB20200", "Audi", new DateTime(2017, 12, 12));
            Console.WriteLine($"Mærke: {bil.Mærke}, nummerplade nr. {bil.GetNummerPlade()}");
            if (bil.ErrorMsg != null)
            {
                //Console.WriteLine($"Bil {bil.GetNummerPlade()} {bil.ErrorMsg}.");
            }
            biler.Add(bil);


            Bil bil2 = new("AB20200", "Audi", new DateTime(2015, 8, 1), new DateTime(2018, 01, 01));
            //Console.WriteLine($"\n\nMærke: {bil2.Mærke}, nummerplade nr. {bil2.GetNummerPlade()}, årgang: {bil2.Årgang.ToString("dd.MM.yyyy")}, bilens alder: {bil2.Alder} år gammel.");
            if (bil2.ErrorMsg != null)
            {
                Console.WriteLine($"Bil {bil2.GetNummerPlade()}{bil2.ErrorMsg}.");
            }
            biler.Add(bil2);


            Bil bil3 = new("XY20200", "Toyota", new DateTime(2016, 01, 01));
            Console.WriteLine($"\n\nMærke: {bil3.Mærke}, nummerplade nr. {bil3.GetNummerPlade()}");
            if (bil.ErrorMsg != null)
            {
                Console.WriteLine($"Bil {bil3.GetNummerPlade()} {bil3.ErrorMsg}.");
            }
            biler.Add(bil3);



            // Opretelse en søgning i listen og returner bilen med mærke Audi.

            Bil result = biler.FirstOrDefault(b => b.Mærke == "Audi");

            result.GetNummerPlade();

            Console.WriteLine($"\n\nDin Søgning (Mærke):  {result.Mærke}  \n\t   Nummerpladen er: {result.GetNummerPlade()}");




       

           

           

            


        }
    }
}