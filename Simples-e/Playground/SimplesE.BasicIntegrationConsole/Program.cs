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
            
            var factory = new ChannelFactory<SimplesEService.ICoreService>("WSHttpBinding_ICoreService");
            
            var channel = factory.CreateChannel();

            User newUser = new User();

            var result = channel.InsertUser(newUser);
        }
    }
}
