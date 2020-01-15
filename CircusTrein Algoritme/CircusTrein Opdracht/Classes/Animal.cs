using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein_Opdracht.Classes
{
    public class Animal
    {
        public string Species { get; set; } 
        public int Size { get; set; }
        public bool Carnivoor { get; set; }

        public Animal(string species, int size, bool carnivoor)
        {
            Species = species;
            Size = size;
            Carnivoor = carnivoor;
        }
    }
}
