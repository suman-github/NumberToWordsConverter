using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordsConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string isNegative = "";
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter a Number to convert to words");
                    string input = Console.ReadLine();
                    if(input == "exit") break;
                    int number = Convert.ToInt32(input);

                    if (number == 0)
                    {
                        Console.WriteLine("ZERO");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine("MINUS " + ConvertNumberToWords.ConvertNumbertoWords(Math.Abs(number)));
                    }
                    else
                    {
                        Console.WriteLine("{0}", isNegative + ConvertNumberToWords.ConvertNumbertoWords(number));
                    }
                }
                //Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
