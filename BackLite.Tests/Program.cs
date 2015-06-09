using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackLite.Models;

namespace BackLite.Tests
{
    class Program
    {
        public static void Main(string[] args)
        {
            BackLiteEntities context = new BackLiteEntities();
            var clients = from c in context.Clients where c.ClientId <= 10 select c;
            foreach (var c in clients)
                Console.WriteLine(c.FirstName);
            Console.WriteLine("To exit, press any key . . .");
            Console.ReadKey();
        }
    }
}
