using System;

namespace MokytojoKlasesObjektas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mokytojas teacher = new Mokytojas("Vardenė", "Pavardenė", "2c", "Pradinių klasių mokytoja", 14, "aukštasis");

            Console.WriteLine("Mokytojo vardas: " + teacher.Vardas);
            Console.WriteLine("Mokytojo pavardė: " + teacher.Pavarde);
            Console.WriteLine("Mokytojo auklėjimo klasė: " + teacher.Klase);
            Console.WriteLine("Mokytojo pareigos: " + teacher.Pareigos);
            Console.WriteLine("Mokytojo stažas: " + teacher.Stazas + "m.");
            Console.WriteLine("Mokytojo išsilavinimas: " + teacher.Issilavinimas);
            Console.WriteLine("------------------------------------------------");
            Mokytojas teacher2 = new Mokytojas("Jonas", "Jonaitis", "12a", "Matematikos mokytojas", 22, "aukštesnysis");
            Console.WriteLine("Mokytojo vardas: " + teacher2.Vardas);
            Console.WriteLine("Mokytojo pavardė: " + teacher2.Pavarde);
            Console.WriteLine("Mokytojo auklėjimo klasė: " + teacher2.Klase);
            Console.WriteLine("Mokytojo pareigos: " + teacher2.Pareigos);
            Console.WriteLine("Mokytojo stažas: " + teacher2.Stazas + "m.");
            Console.WriteLine("Mokytojo išsilavinimas: " + teacher2.Issilavinimas);



        }
    }
}