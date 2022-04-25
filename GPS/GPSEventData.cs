using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS
{
    internal class GPSEventData
    {
        public GPSEventData(byte[] eDate)
        {
            Console.WriteLine(eDate[0].ToString());
        }
    }
}
