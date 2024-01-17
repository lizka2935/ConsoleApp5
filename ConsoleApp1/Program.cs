using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            string a = Console.ReadLine();

            a = a.ToUpper();

            a = a.Replace(" ", "");

            a = a.Replace("C", "С");
            a = a.Replace("B", "В");
            a = a.Replace("Y", "У");
            a = a.Replace("E", "Е");
            a = a.Replace("K", "К");
            a = a.Replace("M", "М");
            a = a.Replace("H", "Н");
            a = a.Replace("O", "О");
            a = a.Replace("P", "Р");
            a = a.Replace("T", "Т");
            a = a.Replace("X", "Х");
            a = a.Replace("A", "А");

            if (a.Length==9)
            {
               
            }

            string[] reg = { "1", "4", "02", "102", "3", "5", "6", "7", "8", "9", "10", "11", "111", "82", "12", "13", "113", "14", "15", "16", "116", "17", "18", "19", "95", "21", "121", "22", "75", "80", "41", "23", "93", "123", "24", "124", "84", "88", "59", "81", "159", "25", "125", "26", "126", "27", "28", "29", "30", "31", "32", "33", "34", "134", "35", "36", "136", "37", "38", "138", "85", "39", "91", "40", "42", "142", "43", "44", "45", "46", "47", "48", "49", "50", "90", "150", "190", "750", "51", "52", "152", "53", "54", "154", "55", "56", "57", "58", "60", "61", "161", "62", "63", "163", "64", "164", "65", "66", "96", "196", "67", "68", "69", "70", "71", "72", "73", "173", "74", "174", "76", "77", "97", "99", "177", "197", "199", "777", "78", "98", "178", "92", "79", "83", "86", "186", "87", "89", "94" };
            if (!char.IsDigit(a[1]) || !char.IsDigit(a[2]) || !char.IsDigit(a[3]))
            {
                Console.WriteLine("HFJHJHDF");
            }
            if (char.IsDigit(a[0]) || char.IsDigit(a[4]) || char.IsDigit(a[5]))
            {
                Console.WriteLine("FGHJKL");
            }
            string b = string.Concat(a[6], a[7], a[8]);

            for (int i = 0; i < reg.Length; i++)
            {
                if (b == reg[i])
                {
                    r = r+1;
                }
            }
            if(r==1)
            {
                Console.WriteLine("lox");
            }
           








           
            Console.WriteLine(a.Length);
        }
    }
   }
