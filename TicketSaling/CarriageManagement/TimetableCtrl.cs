using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TJU.SoftCourse;

namespace TicketSaling.CarriageManagement
{
    class TimetableCtrl : OleDbConn
    {
        public void saveTimetable(Timetable tt)
        {
            string sql = "INSERT INTO tblTime(timeID,trainName,[from],[to],time,length,price) VALUES ('";
            sql += tt.no + "','" + tt.train + "','" + tt.from + "','" + tt.to + "','" + tt.time + "','" + tt.length + "','" + tt.price + "')";
            execNonQuery(sql);
        }
        public void delTimetable(string timeID)
        {
            string sql = "DELETE FROM tblTime WHERE timeID='";
            sql += timeID + "'";
            execNonQuery(sql);
        }
        public List<object[]> loadTimetable()
        {
            string sql = "SELECT * FROM tblTime";
            List<object[]> temp = execQuery(sql);
            for (int i = 0; i < temp.Count; i++)
            {
                temp[i][5] = ((int.Parse(temp[i][5].ToString()) - (int.Parse(temp[i][5].ToString()) % 60)) / 60 + "小时" + (int.Parse(temp[i][5].ToString()) % 60)).ToString() + "分钟";
            }
            return temp;
        }
        public string loadTrainName(string timeID)
        {
            string sql = "SELECT trainName FROM tblTime WHERE timeID='";
            sql += timeID + "'";
            return execQuery(sql)[0][0].ToString();
        }
    }
}
