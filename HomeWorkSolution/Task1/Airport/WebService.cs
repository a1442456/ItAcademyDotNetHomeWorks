using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Persons;

namespace Task1.Airport
{
    class WebService
    {
        public Ticket GetTicket(Person owner)
        {
            Ticket ticket = new Ticket(owner);
            return ticket;
        }
    }
}
