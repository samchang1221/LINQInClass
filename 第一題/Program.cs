using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 第一題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers to order descending:(ex:12,18,13,23,32)");
            string read = Console.ReadLine();
            var rd = read.Split(',');
            List<MyData> list = new List<MyData>();
            foreach (var item in rd)
            {
                list.AddRange(CreateList(item));
            }
            var order = list.Select(x=>x.str).Reverse();
            Console.WriteLine(String.Join(",", order));
            Console.ReadKey();
        }
        static List<MyData> CreateList(string rd)
        {
            return new List<MyData>()
            {
                new MyData{ str =rd },
            };
        }
        class MyData
        {
            public string str { get; set; }
        }
    }
}
