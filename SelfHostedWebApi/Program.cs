using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Hosting;

namespace SelfHostedWebApi {
    class Program {
        private static void Main(string[] args) {
            // base uri
            string baseUri = "http://localhost:8080";

            Console.WriteLine("Starting web api server");
            WebApp.Start<WebApiStartup>(baseUri);            
            Console.WriteLine("Server running at {0}", baseUri);
            Console.ReadLine();
        }
    }
}
