using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Persons;

namespace Task1.Airport
{
    class PasportControlOperator
    {
        Person _person;
        Passport _pasport;
        public PasportControlOperator(Person person, Passport pasport)
        {
            _person = person;
            _pasport = pasport;
            try
            {
                IsValidateSuccessfull();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Person: {0} {1} have next problem: {2}", _person.FirstName, _person.Surname, ex.Message));
                throw new Exception("Pasport control is canceled");
            }
        }

        public void IsValidateSuccessfull()
        {
            if (_person.FirstName != _pasport.FirstName || _person.Surname != _pasport.Surname)
                throw new Exception("Person and Passport data doesn't match");
        }
    }
}
