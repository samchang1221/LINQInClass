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
            Console.WriteLine("Enter some numbers to order descending:(ex:1,2,3,4,5,6)");
            string read = Console.ReadLine();
            var rd = read.Split(',');
            List<MyData> list = new List<MyData>();
            foreach (var item in rd)
            {
                list.AddRange(CreateList(item));
            }
            var order = list.Select(x=>x.str);
            var reverse_order = order.Reverse();
            Console.WriteLine(String.Join(",", reverse_order));
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
