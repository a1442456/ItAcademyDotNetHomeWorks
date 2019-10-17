using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Persons
{
    class Person
    {
        private string _firstName;
        private string _surName;
        private Pasport _pasport;
        private Baggage _baggage;

        public Person(string name, string surname)
        {
            _firstName = name;
            _surName = surname;
            _pasport = new Pasport(name, surname);
        }

        public Baggage PersonBaggage
        {
            get
            {
                if (_baggage != null)
                    return _baggage;
                else
                {
                    _baggage = new Baggage(new List<Thing>());
                    return _baggage;
                }
            }
            set { _baggage = value; }
        }

        public Pasport Pasport
        {
            get { return _pasport; }
        }

        public string Surname
        {
            get { return _surName; }
        }

        public string FirstName
        {
            get { return _firstName; }
        }

    }
}
