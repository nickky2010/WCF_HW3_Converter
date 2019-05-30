using Converter;
using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(new ConverterService());
            host.Open();
            Console.WriteLine("Service is waiting for customer requests...");
            Console.ReadKey();
            host.Close();
        }
    }
}
