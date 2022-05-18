using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            int validate = 0;
            int[] numbers = new int[2];
            for (int x = 1; x <= 2; x++)
            {
                Console.WriteLine($"Insert the {x}° number: ");
                value = Console.ReadLine();
                while (int.TryParse(value, out validate) == false)
                {
                    Console.WriteLine($"Insert valid value for the {x}° number: ");
                    value = Console.ReadLine();
                }
                numbers[x - 1] = Convert.ToInt32(value);

            }
            int firstNumber = Convert.ToInt32(numbers[0]);
            int secondNumber = Convert.ToInt32(numbers[1]);

            string result = Simplify(firstNumber, secondNumber);

            Console.WriteLine(result);

            Console.ReadKey();
        }
        public static string Simplify(int firstNumber, int secondNumber)
        {
            int newfirstNumber = firstNumber;
            int newsecondNumber = secondNumber;
            int divide = 2;

            if(firstNumber == 1)
            {
                return "" + firstNumber + "/" + secondNumber;
            }

            while(firstNumber >= divide && firstNumber != 1)
            {
                if (firstNumber % divide == 0 && secondNumber % divide == 0)
                {
                    firstNumber = firstNumber / divide;
                    secondNumber = secondNumber / divide;
                }
                else
                {
                    divide++;
                }


                if (divide > (firstNumber / 2) && divide < firstNumber)
                {
                    divide = firstNumber;
                }
                
            }

            return "" + firstNumber + "/" + secondNumber;
        }
    }
}
