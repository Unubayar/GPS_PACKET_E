using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS
{
    public class GPS_INFO
    {
        UTC_TIME utc = new();
        public byte[] utc_time { get; set; }
        public byte[] status { get; set; }  
        public byte[] latitude { get; set; }
        public byte[] longitude { get; set; }
        public byte[] speed { get; set; }
        public byte[] course { get; set; }
        public string high { get; set; }
        public byte[] GPS(byte[] info)
        {
            utc_time = utc.UTC(info[0..5]);
            status = info[5..6];
            latitude = info[6..10];
            Console.WriteLine(info[0] + "GPS INFO");

            return info;
        }
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}
