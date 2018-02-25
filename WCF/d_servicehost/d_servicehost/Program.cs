using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_firstService;
using System.ServiceModel;

namespace d_servicehost
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(b_firstService.WorkCar), new Uri("http://localhost:8733/Design_Time_Addresses/b_firstService/Service1/"));
            host.AddServiceEndpoint(typeof(b_firstService.IWorkCar), new BasicHttpBinding(), "");
            host.Open();
            Console.WriteLine("Служба запущена");
            Console.ReadLine();
            host.Close();

        }
    }
}
