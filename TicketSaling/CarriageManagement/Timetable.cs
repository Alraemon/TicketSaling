using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSaling.CarriageManagement
{
    class Timetable
    {
        public string no, train, from, to, time;
        public int length;
        public double price;
        public Timetable(string timeNo,string trainName,string from,string to,string time,string hour,string minute,string price)
        {
            this.no = timeNo;
            this.train = trainName;
            this.from = from;
            this.to = to;
            this.time = time;
            this.length = int.Parse(hour)*60+int.Parse(minute);
            this.price = double.Parse(price);
        }
    }
}
