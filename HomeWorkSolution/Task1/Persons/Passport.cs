using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Persons
{
    class Passport
    {
        private Guid _identityNum;
        private string _firstName;
        private string _surname;

        public Passport(string name, string surname)
        {
            _firstName = name;
            _surname = surname;
            _identityNum = Guid.NewGuid();
        }

        public Guid IdentityNum
        {
            get { return _identityNum; }
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string Surname
        {
            get { return _surname; }
        }
    }
}
