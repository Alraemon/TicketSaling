using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSaling.TicketManagement
{
    class Ticket
    {
        public string ticketID, passName, passID, timeID;
        public Ticket(string ticketID,string passName,string passID,string timeID)
        {
            this.ticketID = ticketID;
            this.passName = passName;
            this.passID = passID;
            this.timeID = timeID;
        }
    }
}
