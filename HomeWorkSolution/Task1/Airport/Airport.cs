using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Persons;

namespace Task1.Airport
{
    class Airport
    {
        CheckInOperator _checkin;
        PasportControlOperator _pasportOperator;
        SecurityCheckOperator _securityCheckOperator;
        Person _passenger;

        public Airport(Person passenger)
        {
            _passenger = passenger;

            try
            {
                _checkin = new CheckInOperator(_passenger);
                _securityCheckOperator = new SecurityCheckOperator(_passenger);
                _pasportOperator = new PasportControlOperator(_passenger, _passenger.Pasport);
                Console.WriteLine("Welcome on the board");
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Person: {0} {1} have next problem: {2}", _passenger.FirstName, _passenger.Surname, ex.Message));
            }
        }
    }
}
