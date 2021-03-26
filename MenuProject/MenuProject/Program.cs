using System;
using System.Collections.Generic;

namespace MenuProject
{
    class Program
    {
        static public string[] MenuStrings =
        {
            "1 - Вывод списка",
            "2 - Добавление элемента",
            "3 - Поиск элемента по номеру",
            "4 - Выход"
        };
        static public void PrintMenu()
        {
            Console.Clear();
            foreach (var menuString in MenuStrings)
            {
                Console.WriteLine(menuString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        static public void PrintList(List<string> list)
        {
            Console.Clear();
            if (list.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (string elem in list)
                {
                    Console.WriteLine(elem);
                }
            }
            Console.WriteLine("Для прехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public string GetElem()
        {
            Console.Clear();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            while(name.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести имя: ");
                name = Console.ReadLine();
            }
            return name;
        }
        static public void FindElemByIndex(List<string> list)
        {
            Console.Clear();
            if (list.Count == 0)
            {
                Console.WriteLine("Список пуст. Искать нечего.");
            }
            else
            {
                Console.Write("Введите номер элемента в пределах [{0}, {1}], который желаете найти: ", 1, list.Count); 
                int findElemIndex = int.Parse(Console.ReadLine()) - 1;
                while (findElemIndex < 0 || findElemIndex >= list.Count)
                {
                    Console.Write("Введите номер элемента в пределах [{0}, {1}], который желаете найти: ", 1, list.Count);
                    findElemIndex = int.Parse(Console.ReadLine()) - 1;
                }
                Console.WriteLine("Элемент под номером {0} найден: {1}", (findElemIndex+1), list[findElemIndex]);
            }
            Console.WriteLine("Для прехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        PrintList(names);
                        break;
                    case ConsoleKey.D2:
                        names.Add(GetElem());
                        break;
                    case ConsoleKey.D3:
                        FindElemByIndex(names);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D4);
            Console.WriteLine("Удачи!");
        }
    }
}
