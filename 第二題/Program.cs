using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers to sort odd or even:(ex:1,2,3,4,5,6)");
            string read = Console.ReadLine();
            var rd = read.Split(',');
            List<MyData> list = new List<MyData>();
            foreach (var item in rd)
            {
                list.AddRange(CreateList(item));
            }
            var odd = list.Where(x => x.num % 2 == 1).Select(x => x.num);
            var even = list.Where(x => x.num % 2 == 0).Select(x => x.num);
            Console.WriteLine($"odd {String.Join(",", odd)}");
            Console.WriteLine($"even {String.Join(",", even)}");
            Console.ReadKey();
        }
        static List<MyData> CreateList(string rd)
        {
            return new List<MyData>()
            {
                new MyData{ num = Convert.ToInt32(rd) },
            };
        }
        class MyData
        {
            public int num { get; set; }
        }
    }
}
