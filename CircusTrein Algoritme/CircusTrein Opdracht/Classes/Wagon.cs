using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein_Opdracht.Classes
{
    public class Wagon
    {
        public List<Animal> Animals { get; set; }
        private static readonly int Capacity = 10;

        public Wagon()
        {
            Animals = new List<Animal>();
        }
        public int CheckSpace()
        {
            int size = 0;
            if (Animals.Count > 0)
            {
                foreach (Animal a in Animals)
                {
                    size += a.Size;
                }
            }
            return size;
        }

        public bool AddHerbivoor(Animal animal)
        {
            foreach (Animal a in Animals)
            {
                if (a.Carnivoor && a.Size >= animal.Size)
                {
                    return false;
                }
            }

            return AddAnimal(animal);
        }

        public bool AddAnimal(Animal animal)
        {
            if (CheckSpace() + animal.Size <= Capacity)
            {
                Animals.Add(animal);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string combinedString = "";

            foreach (Animal a in Animals)
            {
                combinedString += a.Species + ", ";
            }
            return "Wagon " + ": " + combinedString + CheckSpace();
        }
    }
}
