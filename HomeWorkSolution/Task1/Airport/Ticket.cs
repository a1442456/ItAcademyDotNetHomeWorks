using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Persons;

namespace Task1.Airport
{
    class Ticket
    {
        Person _owner;
        Guid _ticketNum;

        public Ticket(Person owner)
        {
            _owner = owner;
            _ticketNum = Guid.NewGuid();
        }

        public Person Owner
        {
            get { return _owner; }
        }

        public Guid TicketNum
        {
            get { return _ticketNum; }
        }
    }
}
