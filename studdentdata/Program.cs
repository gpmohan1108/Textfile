using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace studentdata
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            //string data = @"D:\sort and search\studentdata.txt";
            string data = File.ReadAllText("D:\\sort and search\\studentdata.txt");
            Console.WriteLine(data);
        }
    }
}
