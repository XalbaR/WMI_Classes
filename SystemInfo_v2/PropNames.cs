using System;
using System.Management;

namespace SystemInfo_v2
{
    public static class PropNames
    {
        public static void Props(string win32Query)
        {
            var query = new ObjectQuery(win32Query);
            var searcher = new ManagementObjectSearcher(query);


            List<string> namesValuesList = new List<string>();

            foreach (var obj in searcher.Get())
            {
                foreach (var prop in obj.Properties)
                {
                    var propName = prop.Name;
                    namesValuesList.Add(prop.Name.ToString());
                }
            }

            foreach (var lis in namesValuesList)
            {
                Console.WriteLine(lis.ToString());
            }

            
        }


    }
}
