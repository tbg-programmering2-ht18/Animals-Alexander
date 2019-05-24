using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalUppgift
{
    class Program
    {
        public static List<Animal> Animals = new List<Animal>();
        private static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {
            //lägger till innehåll för Animals listan
            Animals.Add(new Dog("Voffe"));
            Animals.Add(new Cat("Nisse"));
            Animals.Add(new Bird("VadFanDöperManEnFågel"));
            Animals.Add(new Dog("Voffe II"));

            Console.WriteLine("God afton \nDu kommer tilldelas ett av fyra djur \nTryck på en knapp för att fortsätta (esc för att avsluta)");




            ConsoleKey key = Console.ReadKey().Key;
            while (key != ConsoleKey.Escape)
            {
                int n = getrandom.Next(0, Animals.Count - 1);
                Console.WriteLine("\nDitt djur blev:");
                Console.WriteLine(Animals[n].Show());
                Console.WriteLine("Tryck på en knapp för att fortsätta (esc för att avsluta): \n");
                key = Console.ReadKey().Key;

            }
        }
    }
}