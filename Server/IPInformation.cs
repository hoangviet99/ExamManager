using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class IPInformation
    {
        public static string FirstIP = "";
        public static string LastIP = "";

        public static List<string> GetListIPInRange()
        {
            List<string> listIP = new List<string>();
            string[] items = FirstIP.Split('.');
            string firstIPPart = items[0] + "." + items[1] + "." + items[2] + ".";
            for (int i = 0; i <= CountIP(); i++)
            {
                listIP.Add(firstIPPart + ((int)(int.Parse(items[3]) + i)).ToString());
            }
            return listIP;
        }

        public static int CountIP()
        {
            string[] ip1 = FirstIP.Split('.');
            string[] ip2 = LastIP.Split('.');
            int firstIndex = int.Parse(ip1[3]);
            int lastIndex = int.Parse(ip2[3]);
            return lastIndex - firstIndex;
        }
    }
}
