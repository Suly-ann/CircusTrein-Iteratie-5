using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein_Opdracht.Classes
{
    public class Train
    {
        public List<Wagon> Wagons { get; set; }

        public Train()
        {
            Wagons = new List<Wagon>();
        }

    }
}
