using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10lb
{
    internal class Program
    {
        delegate bool MyDelBool(int a);
        delegate double MyDelDouble(double a);
        delegate bool ProgDayCheck(DateTime date);
        delegate int AnalyseArr(int[] arr);
        static void Main(string[] args)
        {
            Random r = new Random();
            MyDelBool IsEven = delegate (int a)
            {
                return a % 2 == 0;
            };
            MyDelDouble GetPow2 = delegate (double a)
            {
                return a * a;
            };
            Console.WriteLine(GetPow2(2));
            MyDelDouble GetPow3 = t=>Math.Pow(t, 3);
            Console.WriteLine(GetPow3(3));
            ProgDayCheck IsProgDay = date => date.DayOfYear == 256;
            Console.WriteLine(IsProgDay(new DateTime(2023,09,13)));
            AnalyseArr GetMax = arr => arr.Max();
            AnalyseArr GetMin = arr => arr.Min();
            AnalyseArr GetOddNumber = arr =>
            {
                int count = 0;
                foreach (var i in arr)
                {
                    if (i % 2 == 1) count++;
                }
                return count;
            };
            {
                int[] arr = new int[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(0, 100);
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();
                Console.WriteLine(GetMax(arr));
                Console.WriteLine(GetMin(arr));
                Console.WriteLine(GetOddNumber(arr));
            }





            Console.ReadKey();
        }
    }
}
