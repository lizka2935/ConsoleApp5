using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int s1 = 0;
            int s2 = 0;
            string b = Console.ReadLine();
            string g = Console.ReadLine();
            string[] a = { "А", "В", "Е", "К", "М", "Н", "О", "Р", "С", "Т", "У", "Х"};
            int[] num = { 1, 2 , 3, 4, 5 , 6 , 7, 8, 9, 10, 11, 12};

            for(int i=0; i<a.Length;i++)
            {
                if (Convert.ToInt64( b[0]) == Convert.ToInt64( a[i]))
                {
                    s1= i;
                }
                if (Convert.ToInt64(b[4]) == Convert.ToInt64(a[i]))
                {
                    s2 = i;
                }
                Console.WriteLine($"{s1} {s2}");
            }

        }
    }
}
