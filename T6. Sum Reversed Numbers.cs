using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //long result = Console.ReadLine()
            //    .Split()
            //    .Select(a =>)
            //    .Sum();

            //Console.WriteLine();

            List<string> nums = Console.ReadLine().Split().ToList();
            List<int> reversed = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                string number = nums[i];
                string reversedString = reverseTheString(number);
                int num = int.Parse(reversedString);
                reversed.Add(num);
            }
            Console.WriteLine(reversed.Sum());
        }

        private static string reverseTheString(string number)
        {
            char[] arr=number.ToCharArray();
            char[] reversed = arr.Reverse().ToArray();
            string reversedString = string.Join("", reversed);
            return reversedString;
        }
    }
}
