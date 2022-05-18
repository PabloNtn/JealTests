using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            int validate = 0;
            int number = 0;
            
            Console.WriteLine($"Insert a number: ");
            value = Console.ReadLine();

            while (int.TryParse(value, out validate) == false)
            {
               Console.WriteLine("Insert a number: ");
               value = Console.ReadLine();
            }
            number = Convert.ToInt32(value);

            string result = Calculate(number);

            Console.WriteLine("\nResult: ");
            Console.WriteLine(result);

            Console.ReadKey();
        }
        public static string Calculate(int value)
        {
            int previous = 0;
            int next = 2;
            string result = "";

            while(next < value)
            {
                previous = next;
                result += "2";
                next *= 2;
            }

            result += "" + (value - previous);


            return result;
        }
    }
}
