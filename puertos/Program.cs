﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Net.Http;
using Flurl.Http;


namespace puertos
{
    class Program
    {


        static void Main(string[] args)
        {
            Server server;
            server = new Server("http://www.aigames.host", "s9kmhgad", "training",300 );

            bot bot = new bot(server);


            
            bot.start();
            
            Console.Out.WriteLine("done");

            Console.Read();






        }


        
        
    }
}
