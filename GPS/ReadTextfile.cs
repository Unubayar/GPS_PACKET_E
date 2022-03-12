using System;
using System.Globalization;
using System.Text;



namespace GPS
{
    public class ReadTextfile
    {
        public static void Main()
        {
            String hexString = "404056003247512d31363031303633380110060a130a2a080f3e40440a7089e616cf005004d03101010505050006000101000018a5a6a7a8a9aaf2adaeafb0b16162636465666768696a6b6c060a130a2a0753e80d0a";

            // converting string to byte array
            byte[] packet = ConvertHexStringToByteArray(hexString);

            // create new GPS_Packet object
            GPS_Packet gps = new GPS_Packet(packet);

            // DISPLAYING DATA HERE
            Console.WriteLine(gps.check_packet(packet));
        }

        // convert hex string to byte array
        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }



            byte[] data = new byte[hexString.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }



            return data;
        }
    }
}