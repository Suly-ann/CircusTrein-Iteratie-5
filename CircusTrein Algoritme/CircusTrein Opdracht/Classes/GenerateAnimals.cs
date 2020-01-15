using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein_Opdracht.Classes
{
    public class GenerateAnimals
    {
        public List<Animal> CreateList()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("olifant", 5, false));
            animals.Add(new Animal("poes", 1, true));
            animals.Add(new Animal("tijger", 3, true));
            animals.Add(new Animal("hond", 3, true));
            animals.Add(new Animal("app", 1, false));
            return animals;
        }

        public List<Wagon> CreateSortedList()
        {
            List<Wagon> wagons = new List<Wagon>();
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal("poes", 1, true));
            wagon.AddAnimal(new Animal("olifant", 5, false));
            wagons.Add(wagon);

            wagon = new Wagon();
            wagon.AddAnimal(new Animal("tijger", 3, true));
            wagons.Add(wagon);

            wagon = new Wagon();
            wagon.AddAnimal(new Animal("hond", 3, true));
            wagons.Add(wagon); 
            
            wagon = new Wagon();
            wagon.AddAnimal(new Animal("app", 1, false));
            wagons.Add(wagon);
            return wagons;
        }
    }
}
