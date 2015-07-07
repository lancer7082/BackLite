using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackLite.Data.Models;

namespace BackLite.Tests
{
    class Program
    {
        public static void Main(string[] args)
        {
            BackLiteEntities context = new BackLiteEntities();
            
            //select clients
            var clients = from c in context.Clients where c.ClientId <= 10 select c;
            foreach (var c in clients)
                Console.WriteLine(String.Format("{0} {1} {2}", c.FirstName, c.LastName, c.Email));

//*
            //edit client
            var client = context.Clients.FirstOrDefault<Client>();
            client.Email = "123@3456.ab";
            context.SaveChanges();
//*/

            Console.WriteLine("To exit, press any key . . .");
            Console.ReadKey();
        }
    }
}
