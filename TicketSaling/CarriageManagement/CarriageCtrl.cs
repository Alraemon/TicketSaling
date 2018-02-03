using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TJU.SoftCourse;

namespace TicketSaling.CarriageManagement
{
    class CarriageCtrl:OleDbConn
    {
        public bool saveCarriage(Carriage car)
        {
            string sql = "INSERT INTO tblCarriage(carType,carVolume,volPerSector) VALUES ('";
            sql += car.carType + "','" + car.carVolume.ToString() + "','" + car.volPerSector.ToString() + "')";
            return execNonQuery(sql);
        }
        public List<object[]> loadCarriage()
        {
            string sql = "SELECT * FROM tblCarriage";
            List<object[]> typeList= execQuery(sql);
            return typeList;
        }
        public bool delCarriage(string carType)
        {
            string sql = "DELETE FROM tblCarriage WHERE carType='";
            sql += carType + "'";
            return execNonQuery(sql);
        }
    }
}
