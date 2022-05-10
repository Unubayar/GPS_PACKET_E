using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GPS
{
    public class GPSEventData
    {
        public byte[] reportId { get; set; } = new byte[2];
        public byte[] gpsData { get; set; } = new byte[21];
        public byte[] ODBModule { get; set; } = new byte[4];
        public byte[] fireware { get; set; } = new byte[4];

        public byte[] hardware { get; set; } = new byte[4]; 
        public byte[] editedNumber { get; set; } = new byte[1];
        public byte[] editedNumberArr;
        public string dateTime;
        public GPSEventData(byte[] eDate)
        {
            reportId = eDate[0..2];
            gpsData = eDate[2..23];
            ODBModule = eDate[23..27];
            fireware = eDate[27..31];
            hardware = eDate[31..35];
            editedNumber = eDate[35..36];
            editedNumberArr = eDate[36..(eDate.Length - 6)];
        }
    }
}
