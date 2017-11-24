using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleWCFServiceClient.SimpleWCFServiceReference;

namespace SimpleWCFServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentServiceClient client = new StudentServiceClient();

            var name = client.GetName();

            Console.WriteLine("Name of the student is " + name);
        }
    }
}
