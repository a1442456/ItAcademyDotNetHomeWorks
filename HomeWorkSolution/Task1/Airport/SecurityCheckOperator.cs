using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Persons;
using Task1.Things;

namespace Task1.Airport
{
    class SecurityCheckOperator
    {
        Person _person;
        List<Thing> _dangerThings = new List<Thing>();
        public SecurityCheckOperator(Person person)
        {
            _person = person;
            ConfigureDangerList();
            try
            {
                SecurityCheck();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Person: {0} {1} have next problem: {2}", _person.FirstName, _person.Surname, ex.Message));
                throw new Exception("Security check is canceled.");
            }
        }

        public void SecurityCheck()
        {
            foreach (Thing personThing in _person.PersonBaggage.Things)
            {
                foreach (Thing dangerThing in _dangerThings)
                {
                    if (personThing.GetType() == dangerThing.GetType())
                    {
                        throw new Exception("Danger things has been found.");
                    }
                }
            }
        }

        private void ConfigureDangerList()
        {
            _dangerThings.Add(new Gun());
            _dangerThings.Add(new Drugs());
        }
    }
}
