using System;
using AutomobileLibrary;
namespace lab10
{
	public class TestCollections
	{
        LinkedList<Car> collection1 = new();
        LinkedList<string> collection2 = new();

        Dictionary<Automobile, Car> collection3 = new();
        Dictionary<string, Car> collection4 = new();


        const int collectionsLength = 1000;

        const int indexFirst = 0;
        const int indexMid = collectionsLength / 2 - 1;
        const int indexLast = collectionsLength - 1;

        Car first, mid, last;
        Car nonexistent = new("не существует", 2000, "не существует", 0, 0, new IdNumber(0), 0, 0);

        public TestCollections()
        {
            for (int i = 0; i < collectionsLength; i++)
            {
                Car c = new();
                c.RandomInit();
                c.Brand += i.ToString();
                collection1.AddLast(c);
                collection2.AddLast(c.GetBase.ToString());
                collection3.Add(c.GetBase, c);
                collection4.Add(c.GetBase.ToString(), c);
                if (i == indexFirst)
                    first = c;
                if (i == indexMid)
                    mid = c;
                if (i == indexLast)
                    last = c;
            }
        }

        public LinkedList<Car> Collection1 { get => this.collection1; }   // автосвойство для получения коллекции 1
        public LinkedList<string> Collection2 { get => this.collection2; }    // автосвойство для получения коллекции 2
        public Dictionary<Automobile, Car> Collection3 { get => this.collection3; }                     // автосвойство для получения коллекции 3
        public Dictionary<string, Car> Collection4 { get => this.collection4; }                         // автосвойство для получения коллекции 4

        public Car First { get => this.first; }   // автосвойство для получения первого элемента
        public Car Mid { get => this.mid; }       // автосвойство для получения центрального элемента
        public Car Last { get => this.last; }     // автосвойство для получения последнего элемента
        public Car Nonexistent { get => this.nonexistent; }

       
	}
}

