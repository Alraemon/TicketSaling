using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TJU.SoftCourse;

namespace TicketSaling.TicketManagement
{
    class TicketCtrl:OleDbConn
    {
        public void saveTicket(Ticket t)
        {
            string sqlIns = "INSERT INTO tblTicket(ticketID,passName,passID,timeID) VALUES ('";
            sqlIns += t.ticketID + "','" + t.passName + "','" + t.passID + "','" + t.timeID + "')";
            execNonQuery(sqlIns);
        }
        public List<object[]> loadTicket()
        {
            string sqlQuery = "SELECT * FROM tblTicket";
            return execQuery(sqlQuery);
        }
        public int loadMaxId()
        {
            string sql = "SELECT MAX(ticketID) FROM tblTicket";
            List <object[]> temp= execQuery(sql);
            if (temp==null )
                return 0;
            else
                return int.Parse(temp[0][0].ToString());
        }
        public void delTicket(string ticketId)
        {
            string sql = "DELETE FROM tblTicket WHERE ticketID='";
            sql += ticketId + "'";
            execNonQuery(sql);
        }
        public List<object[]> serachTicketFromTimeId(string timeID)
        {
            string sql = "SELECT * FROM tblTicket WHERE timeID='";
            sql += timeID + "'";
            return execQuery(sql);
        }
        public List<object[]> serachTicketFromPassId(string passID)
        {
            string sql = "SELECT * FROM tblTicket WHERE passID='";
            sql += passID + "'";
            return execQuery(sql);
        }
    }
}
