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
        public byte[] high { get; set; }
        public byte[] GPS(byte[] info)
        {
            utc_time = utc.UTC(info[0..6]);
            status = info[6..7];
            latitude = info[7..11];
            longitude = info[11..15];
            speed = info[15..17];
            course = info[17..19];
            high = info[19..21];
            Console.WriteLine(info[0] + "GPS INFkO");
            return info;
        }
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}
