using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5.Aray_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                var commandArgs = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                }
                else if (commandArgs[0] == "addMany")
                {
                    numbers.InsertRange(int.Parse(commandArgs[1]),
                        commandArgs.Skip(2).Select(int.Parse).ToList());
                }
                else if (commandArgs[0] == "contains")
                {
                    int number = int.Parse(commandArgs[1]);

                    Console.WriteLine(numbers.IndexOf(number));
                }
                else if (commandArgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                }
                else if (commandArgs[0] == "shift")
                {
                    int number = int.Parse(commandArgs[1]);
                    List<int> neList = numbers;

                    for (int i = 0; i < number % numbers.Count; i++)
                    {
                        int lastNumber = numbers[0];

                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }

                        numbers[numbers.Count - 1] = lastNumber;
                    }


                }
                else if (commandArgs[0] == "sumPairs")
                {

                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }

                }

                command = Console.ReadLine();

            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}