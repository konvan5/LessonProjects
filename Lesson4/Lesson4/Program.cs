using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            List<int> list = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                list.Add(rand.Next(-5, 6));
            }
            list.Distinct().OrderBy(x => x).Last();
            foreach (var elem in list)
            {
                Console.Write(elem +" ");
            }
            Console.WriteLine();
            Console.Write("Введите число: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Число имеет неверный формат! Введите его снова: ");
            }
        }
    }
}
