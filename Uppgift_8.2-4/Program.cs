using System;
using Uppgift_8._2_4;

namespace Uppgift_8_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Förnamn = "Olle";
            p1.Efternamn = "Wessman";
            Console.WriteLine("Fulla namnet: " + p1.FulltNamn());

            p1.Födelsedatum = new DateTime(2005, 4, 29);
            Console.WriteLine($"Hen är {(p1.ÄrMyndig() ? "" : "inte ")}myndig");

            p1.Längd = 1.73f;
            p1.Vikt = 69;
            Console.WriteLine($"Hens BMI är {p1.BMI()}.");
        }
    }
}