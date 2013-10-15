using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using SimplesE.Model.Core;

namespace SimplesE.BasicIntegrationConsole {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("iniciando");

            var factory = new ChannelFactory<SimplesEService.ICoreService>("WSHttpBinding_ICoreService");
            
            var channel = factory.CreateChannel();

            User newUser = new User();
            newUser.Name = DateTime.Now.Second.ToString();

            var result = channel.InsertUser(newUser);

            Console.WriteLine(result.Completed);
            Console.WriteLine("executado");
            Console.ReadLine();
        }
    }
}
