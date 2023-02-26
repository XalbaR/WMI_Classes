using System;
using System.Linq;
using System.Management;

namespace SystemInfo_v2
{
    class ListWmiClasses
    {
        public static void List()
        {
            var ns = new ManagementScope("\\root");
            ns.Connect();

            var query = new ObjectQuery("select * from meta_class");
            var searcher = new ManagementObjectSearcher(ns, query);

            var classes = searcher.Get().Cast<ManagementClass>()
                             .Where(c => c.SystemProperties["__CLASS"].Value.ToString().StartsWith("Win32_"))
                             .Select(c => c.SystemProperties["__CLASS"].Value.ToString())
                             .OrderBy(c => Guid.NewGuid())
                             .Take(100);

            foreach (var cls in classes)
            {
                Console.WriteLine(cls);
            }

            Console.ReadLine();
        }
    }
}
