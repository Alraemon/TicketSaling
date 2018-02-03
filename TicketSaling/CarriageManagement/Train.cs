using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSaling.CarriageManagement
{
    public class Train
    {
        public string trainName;
        public string[,] trainInfo;
        public int index;
        public Train()
        {
            trainInfo = new string[15, 2];   //一列火车车厢类型一般不会超过15种
            index = 0;
        }
        public void addName(string trainName)
        {
            this.trainName = trainName;
        }
        public void addType(string carType,string carNum)
        {
            trainInfo[index, 0] = carType;
            trainInfo[index, 1] = carNum;
            index++;
        }

    }
}
