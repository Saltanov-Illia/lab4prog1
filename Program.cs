using System;
using System.Text;

namespace lab4_Block2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть рядок: ");
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            for ( int i = 0; i < input.Length; i++)
            {
                char c = char.ToLower(input[i]);
                if (c >= 'a' && c <= 'i')
                {
                    int digit = c - 'a' + 1;
                    result.Append(digit);
                }
            }
            Console.WriteLine("Результат: " + result.ToString());
        }        
    }
}