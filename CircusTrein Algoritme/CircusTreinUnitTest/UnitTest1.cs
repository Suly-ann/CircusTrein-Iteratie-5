using CircusTrein_Opdracht.Classes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CircusTreinUnitTest
{
    public class Tests
    {
        private GenerateAnimals generate = new GenerateAnimals();
        private Algortime algortime;

        [SetUp]
        public void Setup()
        {
            algortime = new Algortime(generate.CreateList());
        }

        [Test]
        public void TestAll()
        {
            List<Wagon> expected = generate.CreateSortedList();
            List<Wagon> output = algortime.Run().Wagons;
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].ToString(), output[i].ToString());
            }
        }

        [Test]
        public void TestPlaceCarnivoor()
        {
            //Maak een nieuwe trein en lijst met dieren. Tellen het aantal wagons dat je terugkrijgt.
            Assert.AreEqual(algortime.PlaceCarnivoor(new Train(), generate.CreateList()).Wagons.Count, 3);
        }

        [Test]
        public void TestPlaceHerbivoor()
        {
            //Maak een nieuwe trein en lijst met dieren. Tellen het aantal wagons dat je terugkrijgt.
            Assert.AreEqual(algortime.PlaceHerbivoor(new Train(), generate.CreateList()).Wagons.Count, 1);
        }

    }
}