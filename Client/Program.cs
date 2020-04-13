using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcService1; //numele server-ului

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string name;
            Console.WriteLine("Va rugam introduceti numele: ");
            name = Console.ReadLine();
            var input = new HelloRequest { Name = name };
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            await client.SayHelloAsync(input);
        }
    }
}
