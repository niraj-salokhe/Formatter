

using Library;
using System;

namespace Formatter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter source filename:");
            string src = Console.ReadLine();

            Console.Write("Enter destination filename:");
            string dst = Console.ReadLine();


            FileLibrary l = new FileLibrary(new ServiceObject() { src=src,dst=dst});
            ResponseData resp =  l.WriteToFile();
            Console.WriteLine("Result:" + resp.result + " StatusCode:" + resp.statusCode);



            Console.ReadKey();
        }
    }
}
