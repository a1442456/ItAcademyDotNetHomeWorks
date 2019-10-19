using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Persons;

namespace Task1.Airport
{
    class CheckInOperator
    {
        Person _person;
        public CheckInOperator(Person person)
        {
            _person = person;

            try
            {
                CheckPersonPasport();
                CheckTicket();
                CheckWeight();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Person: {0} {1} have next problem: {2}", _person.FirstName, _person.Surname, ex.Message));
                throw new Exception("Check-in is canceled");
            }
        }

        private void CheckPersonPasport()
        {
            if (_person.Pasport == null)
            {
                throw new Exception("You have no passport!!!");
            }
            if(_person.Pasport.FirstName != _person.FirstName || _person.Pasport.Surname != _person.Surname)
            {
                throw new Exception("Person and Passport data doesn't match");
            }
        }

        private void CheckTicket()
        {
            if (_person.Ticket == null)
            {
                throw new Exception("You have no ticket.");
            }
        }

        private void CheckWeight()
        {
            if (_person.PersonBaggage.Weight >= 25)
            {
                throw new Exception("Overloaded baggage.");
            }
        }

        public Ticket GetTicket(Person person)
        {
            Ticket ticket = new Ticket(person);
            return ticket;
        }
    }
}
