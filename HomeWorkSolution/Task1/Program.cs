using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Things;
using Task1.Persons;
using Task1.Airport;
using Task1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person anton = new Person("Anton", "Krasnikov");
            anton.PersonBaggage = new Baggage(PackTheBaggage());
            anton.Ticket = new WebService().GetTicket(anton);
            Airport airport = new Airport(anton);

            Console.ReadLine();
        }

        static List<Thing> PackTheBaggage()
        {
            List<Thing> things = new List<Thing>();
            things.Add(new Alcohol());
            things.Add(new Drugs());
            things.Add(new Gun());
            things.Add(new Orange());
            things.Add(new Сlothes());

            return things;
        }
    }
}
