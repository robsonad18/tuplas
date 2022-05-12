using System;
using System.Collections.Generic;

namespace TublasBaltaio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tupla1 = new Tuple<string, int, bool>("Texto", 7, false);
            var tupla2 = Tuple.Create<string, int>("Texto", 7);
            var tupla3 = ("Texto", 7);
            (string, double) tupla4 = ("texto", 3.5);

            Console.WriteLine(tupla4.Item2);

            (string Nome, string Sobrenome) tupla5 = ("Robson", "Lucas");
            Console.WriteLine($"Meu nome é {tupla5.Nome} {tupla5.Sobrenome}");

            var tupla6 = (4.5, new List<string>());
            tupla6.Item2.Add("Texto 1");
            tupla6.Item2.Add("Texto 2");

            foreach(var item in tupla6.Item2)
                Console.WriteLine(item);

            SayMyName(("Robson", "Barranco"));
        }

        static void SayMyName((string FirstName, string LastName) name)
            => Console.WriteLine($"{name.FirstName} {name.LastName}"); 
    }
}
