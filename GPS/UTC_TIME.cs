using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS
{
    public class UTC_TIME
    {
        public byte[] year;
        public byte[] month;
        public byte[] day;
        public byte[] hour;
        public byte[] minute;
        public byte[] second;
        public byte[] UTC(byte[] utc_time)
        {
            Console.WriteLine(utc_time[0]);
            return utc_time;
        }
    }
}
