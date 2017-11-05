using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //var listOfNumbers = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //var number = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //bool check = false;

            //foreach (var number in listOfNumbers)
            //{
            //    if (number == number[2])
            //    {
            //        Console.WriteLine("YES!");
            //        return;
            //    }

            //for (int i = 0; i < number.Count; i++)
            //{
            //    for (int j = i; j < listOfNumbers.Count - 1; j++)
            //    {

            //    }

            //}

            var numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var digit = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var outputList = new List<int>();

            for (int i = 0; i < digit[0]; i++)
            {
                outputList.Add(numberList[i]);
            }

            outputList.RemoveRange(0, digit[1]);

            foreach (var number in outputList)
            {
                if (number == digit[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }

            }
            Console.WriteLine("NO!");

        }
    }
}




