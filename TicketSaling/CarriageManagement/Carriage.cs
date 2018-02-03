using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSaling.CarriageManagement
{
    class Carriage
    {
        public int carVolume;       //车厢总容量
        public string carType;      //车厢型号
        public int volPerSector;    //指的是每个小区域能有几个乘客，比如硬座软座4个，卧铺则是上中下3个
        public int numSector;       //小区域数
        public Carriage(string carType,int carVolume,int volPerSector)
        {
            this.carVolume = carVolume;
            this.carType = carType;
            this.volPerSector = volPerSector;
            this.numSector = this.carVolume / this.volPerSector;
/*            
            for(int i=0;i<=numSector-1;i++)
            {
                for(int j=0;j<=volPerSector-1;j++)
                {
                    location[i, j] = (i + 1).ToString() + (65+ j);//这一步用来标识每个位置的号码 从1A开始
                }
            }
*/
        }
    }
}
