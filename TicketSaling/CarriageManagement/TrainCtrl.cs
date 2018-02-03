using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TJU.SoftCourse;

namespace TicketSaling.CarriageManagement
{
    class TrainCtrl:OleDbConn
    {
        public void saveTrain(Train t)
        {
            for (int i = 0; i <= t.index - 1; i++)
            {
                string sqlVol = "SELECT carVolume FROM tblCarriage WHERE carType='" + t.trainInfo[i, 0] + "'";
                string totalVolume = (int.Parse(execQuery(sqlVol)[0][0].ToString()) * int.Parse(t.trainInfo[i, 1])).ToString(); //意在求出该列火车每种型号车厢构成的总容量
                string sqlIns = "INSERT INTO tblTrain(trainName,carType,carNum,volume) VALUES ('";
                sqlIns += t.trainName + "','" + t.trainInfo[i, 0] + "','" + t.trainInfo[i, 1] +"','"+totalVolume+ "')";
                execNonQuery(sqlIns);
            }
        }
        public void delTrain(string trainName)
        {
            string sql = "DELETE FROM tblTrain WHERE trainName='";
            sql += trainName + "'";
            execNonQuery(sql);
        }
        public List<object[]> loadTrain(string trainName)
        {
            string sql = "SELECT * FROM tblTrain WHERE trainName='";
            sql += trainName + "'";
            List<object[]> trainList = execQuery(sql);
            return trainList;
        }
        public List<object[]> loadTrainSum(string trainName)
        {
            string sql = "SELECT SUM(volume) FROM tblTrain WHERE trainName='";
            sql += trainName + "'";
            List<object[]> trainList = execQuery(sql);
            return trainList;
        }
        public List<object[]> loadTrainName()
        {
            string sql = "SELECT DISTINCT trainName FROM tblTrain";
            List<object[]> trainList = execQuery(sql);
            return trainList;
        }
        public List<object[]> loadVolume()
        {
            string sql = "SELECT trainName,SUM(volume) AS total FROM tblTrain GROUP BY trainName";
            return execQuery(sql);
        }
    }
}
