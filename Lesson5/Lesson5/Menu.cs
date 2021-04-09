using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public static class Menu
    {
        static private string[] MenuStrings { get; set; } =
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
        static public void PrintList(List<Player> list)
        {
            Console.Clear();
            if (list.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (Player elem in list)
                {
                    Console.WriteLine(elem.Name);
                }
            }
            Console.WriteLine("Для прехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public Player GetElem()
        {
            Console.Clear();
            Console.Write("Введите имя: ");
            Player player = new Player();
            player.Name = Console.ReadLine();
            while (player.Name.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести имя: ");
                player.Name = Console.ReadLine();
            }
            return player;
        }
        static public void FindElemByIndex(List<Player> list)
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
                Console.WriteLine("Элемент под номером {0} найден: {1}", (findElemIndex + 1), list[findElemIndex]);
            }
            Console.WriteLine("Для прехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        public static void Start()
        {
            List<Player> players = new List<Player>();
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        PrintList(players);
                        break;
                    case ConsoleKey.D2:
                        players.Add(GetElem());
                        break;
                    case ConsoleKey.D3:
                        FindElemByIndex(players);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D4);
            Console.WriteLine("Удачи!");
        }

    }
}
