using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DnsQueryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string dn = "checkip.dyndns.org";
            Console.ReadKey();
            while (true)
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers["User-Agent"] = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)";

                    // Download data.
                    string value = client.DownloadString("http://" + dn);

                    // Write values.
                    Console.WriteLine("--- WebClient result ---");
                    Console.WriteLine(value.Length);
                    Console.WriteLine(value);
                }
                Console.ReadKey();
            }


        }
    }
}
