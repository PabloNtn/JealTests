using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int validateInt = 0;
            int arraySize = 0;
            string value = "";


            Console.WriteLine("Number of words you want to insert: ");
            value = Console.ReadLine();

            while (int.TryParse(value, out validateInt) == false)
            {
                Console.WriteLine($"\nInsert a number:");
                value = Console.ReadLine();
            }

            arraySize = Convert.ToInt32(value);
            string[] words = new string[arraySize];


            for (int count = 0; count < arraySize; count++)
            {
                Console.WriteLine($"\nInsert the word number {count + 1}:");
                value = Console.ReadLine();

                while (Regex.IsMatch(value, @"^[a-zA-Z]*$") == false)
                {
                    Console.WriteLine("\nInsert a valid word with letters(a-z or A-Z) only: ");
                    value = Console.ReadLine();
                }
                words[count] = value;
            }
            var result = UpperCase(words);

            Console.WriteLine("\nResult:");
            Console.WriteLine(string.Join("\n", result));
            Console.ReadKey();
        }
        public static string[] UpperCase(string[] array)
        {
            int listLength = array.Count();
            string[] arrayUpperCase = new string[listLength];

            for (int count = 0; count < listLength; count++)
            {
                string down = array[count].ToLower();
                arrayUpperCase[count] = char.ToUpper(down[0]) + down.Substring(1);
            }
            return arrayUpperCase;
        }
    }
}
