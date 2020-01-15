using CircusTrein_Opdracht.Classes;
using System;
using System.Collections.Generic;

namespace CircusTrein_Opdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateAnimals generateAnimals = new GenerateAnimals();
            List<Animal> animals = generateAnimals.CreateList();
            Algortime algortime = new Algortime(animals);
            Train train = algortime.Run();
            foreach(Wagon wagon in train.Wagons)
            {
                Console.WriteLine(wagon.ToString());
            }

        }

       
    }
}
