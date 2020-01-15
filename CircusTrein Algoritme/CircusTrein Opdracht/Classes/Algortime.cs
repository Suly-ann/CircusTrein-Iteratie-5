using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein_Opdracht.Classes
{
    public class Algortime
    {
        public Train Train { get; set; }

        public List<Animal> Animals { get; set; }

        public Algortime(List<Animal> animals)
        {
            Animals = animals;
            Train = new Train();
        }

        public Train Run()
        {
            Train = PlaceCarnivoor(Train, Animals);
            Train = PlaceHerbivoor(Train, Animals);
            return Train;
        }

        public Train PlaceCarnivoor(Train train, List<Animal> animals)
        {
            foreach (Animal a in animals)
            {
                if (a.Carnivoor)
                {
                    Wagon wagon = new Wagon();
                    wagon.AddAnimal(a);
                    train.Wagons.Add(wagon);

                }
            }
            return train;
        }

        public Train PlaceHerbivoor(Train train, List<Animal> animals)
        {
            foreach (Animal a in animals)
            {
                if (!a.Carnivoor)
                {
                    bool placed = false;
                    int i = 0;
                    while (!placed && i < train.Wagons.Count)
                    {
                        placed = train.Wagons[i].AddHerbivoor(a);
                        i++;

                    }
                    if (!placed)
                    {
                        Wagon wagon = new Wagon();
                        placed = wagon.AddHerbivoor(a);
                        train.Wagons.Add(wagon);
                    }
                }
            }
            return train;
        }
    }
}
