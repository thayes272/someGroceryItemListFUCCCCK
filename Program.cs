using System;
using System.Collections.Generic;

namespace shoppingListThing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); // making list
            WriteLine("What should you add to the shopping list?"); //asking dumb shit questions
            for (int i = 0; i < 10; i++)
            {
                var input = Console.ReadLine(); // reading input
                list.Add(input); // adding that shit cuz yks
            }
            //input.ToString();
            Console.Clear();
            outputList(list);


        }

        static void WriteLine(string input)
        {
            Console.WriteLine(input);
        }

        static void outputList(List<string> list)
        {
            string output = string.Join(Environment.NewLine, list.ToArray());
            WriteLine(output);
        }
    }
}
