using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PT_Lab6_Server
{
    public class Program
    {
        UdpClient server;
        List<IPEndPoint> clients;

        static void Main()
        {
            var program = new Program
            {
                server = new UdpClient(13131),
                clients = new List<IPEndPoint>()
            };

            var listenTask = Task.Factory.StartNew(() => program.Listen());
            var collectTask = Task.Factory.StartNew(() => program.Collect());
            var sendTask = Task.Factory.StartNew(() => program.Send());

            Console.WriteLine("Server available at: " + ((IPEndPoint)program.server.Client.LocalEndPoint).Port);

            Task.WaitAll(listenTask, collectTask, sendTask);
        }

        private void Listen()
        {
            while (true)
            {

            }
        }

        private void Collect()
        {

        }

        private void Send()
        {

        }
    }
}
