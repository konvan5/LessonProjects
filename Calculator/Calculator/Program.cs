using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int digit1 = 0, digit2;
                Console.Write("Введите 1 число: ");
                digit1 = int.Parse(Console.ReadLine());
                Console.Write("Введите 2 число: ");
                digit2 = int.Parse(Console.ReadLine());
                Console.Write("Введите операцию (+, -, /, *, %): ");
                char action = char.Parse(Console.ReadLine());
                int result = 0;
                switch (action)
                {
                    case '+':
                        result = digit1 + digit2;
                        break;
                    case '-':
                        result = digit1 - digit2;
                        break;
                    case '/':
                        result = digit1 / digit2;
                        break;
                    case '*':
                        result = digit1 * digit2;
                        break;
                    case '%':
                        result = digit1 % digit2;
                        break;
                }
                Console.WriteLine($"{digit1} {action} {digit2} = {result}");
            } while (true);
        }
    }
}

