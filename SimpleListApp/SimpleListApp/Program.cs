using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();

            list.Add(5);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(41);
            list.Add(42);
            list.Add(43);
            list.Add(44);
            list.Add(45);
            list.Add(46);
            list.Add(47);
            list.Add(48);
            list.Add(49);
            list.Add(40);

            Console.WriteLine(list.Count);
        }
    }
}
