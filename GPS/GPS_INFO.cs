using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS
{
    public class GPS_INFO
    {
        UTC_TIME utcTime = new();
        public UTC_TIME utc_time { get; set; }
        public string status { get; set; }  
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double speed { get; set; }
        public double course { get; set; }
        public double high { get; set; }
        public bool isLatt = false;
        public bool isLong = false;
        public byte[] GPS(byte[] info)
        {
            string binary = Convert.ToString(info[2], 2);
            var lastfour = binary.Substring(binary.Length-4);
            Console.WriteLine(lastfour + "  binary ");
            byte[] arrLatt = info[7..11];
            double conLat = BitConverter.ToUInt32(arrLatt);
            double conLong = BitConverter.ToUInt32(info[11..15]);
            double conSpeed = BitConverter.ToUInt16(info[15..17]);
            double conCourse = BitConverter.ToUInt16(info[17..19]);
            int conHigh = BitConverter.ToUInt16(info[19..21]); 
            if (0 <= conLat && conLat <= 90 * 3600000)
            {
                //   latitude = (double) Convert.ToInt32(conLat) / 3600000;
                Console.WriteLine(conLat/3600000);
                if (0 <= conLong && conLong <= 90 * 18000000)
                {
                    //   lon gitude = (double) Convert.ToInt32(conLong) / 3600000;
                    if (0 <= conSpeed && conSpeed <= 65535)
                    {
                        speed = (conSpeed / 51.5) * 1.852;
                        if (0 <= conCourse && conCourse <= 3599)
                        {
                            course = conCourse / 10;
                            if (-32767 <= conHigh && conHigh <= 32767)
                            {
                                high = conHigh / 10;
                            }
                        }
                    }
                }
                
            }
           

            return info;
        }
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}
