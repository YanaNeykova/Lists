namespace P03_Search_for_a_Number
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            //var collection = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //var number = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //bool cheked = false;

            //for (int i = 0; i < number.Count; i++)
            //{
            //    for (int j = i; j < collection.Count - 1; j++)
            //    {
            //        if (collection[j] != number[i])
            //        {
            //            cheked = true;

            //        }
            //        else
            //        {
            //            cheked = false;
            //            break;
            //        }
            //    }
            //}
            //if (cheked == true)
            //{
            //    Console.WriteLine("NO!");
            //}
            //else
            //{
            //    Console.WriteLine("YES!");
            //}
            //var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //var bombArgs = Console.ReadLine().Split().Select(int.Parse).ToList();

            //int index = numbers.IndexOf(bombArgs[0]);

            //for (int i = 0; i < numbers.Count; i++)
            //{

            //    numbers[index] = 0;

            //    if (numbers[i]==bombArgs[i])
            //    {
            //        for (int j = 0; j < bombArgs[1]; j++)
            //        { 
            //            if (i+j<=0)
            //            {
            //                break;
            //            }
            //        numbers[i + j] = 0;

            //        }
            //        for (int k = 0; k < bombArgs[1]; k++)
            //        {
            //            if (i+k==numbers.Count)
            //            {
            //                break;
            //            }
            //            numbers[i + k] = 0;

            //        }
            //    }
            //}
            //Console.WriteLine();
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = input[0];
            int lenght = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    int leftindex = Math.Max(i - lenght, 0);
                    int rightindex = Math.Min(i + lenght, numbers.Count - 1);

                    numbers.RemoveRange(i, rightindex - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftindex, i - leftindex);
                    i = 0;
                }

            }
            Console.WriteLine(string.Join("", numbers.Sum()));

        }
    }
}
