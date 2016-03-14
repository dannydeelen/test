using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace PracticumOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(PracticumOpdracht.MyService)))
            {
                host.Open();
                Console.ReadKey();
            }
        }
    }
}
