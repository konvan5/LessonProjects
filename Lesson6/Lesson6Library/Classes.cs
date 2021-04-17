using System;
using System.IO;
using System.Collections.Generic;

namespace Lesson6Library
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void PrintHello()
        {
            Console.WriteLine($"Hello! Im {Name}! Мне {Age} лет!");
        }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    public static class DataBase
    {
        public static string userPath { get; set; } = "D:\\DataBaseUsers.txt";
        public static bool SaveUsers(List<User> users)
        {
            StreamWriter fileIn;
            try
            {
                fileIn = new StreamWriter(userPath);
                foreach (var user in users)
                {
                    fileIn.WriteLine(user.Name);
                    fileIn.WriteLine(user.Age);
                }
                fileIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}");
                return false;
            }
            return true;
        }

        public static List<User> LoadUsers()
        {
            List<User> users = new List<User>();
            StreamReader fileOut;
            try
            {
                if (File.Exists(userPath))
                {
                    fileOut = new StreamReader(userPath);
                    while (!fileOut.EndOfStream)
                    {
                        string name = fileOut.ReadLine();
                        int age = int.Parse(fileOut.ReadLine());
                        users.Add(new User(name, age));
                    }
                    fileOut.Close();
                }
                else 
                    throw new Exception("Файла не существует!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}");
                return null;
            }
            return users;
        }

        public class Sklad
        {
            public Dictionary<Product, int> Products = new Dictionary<Product, int>(); // key - продукт, value - кол-во
            public bool GiveMe(Product product, int count)
            {
                return true;
                "12345-----".PadRight(10, '-');
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public string Resume { get; set; }
            public double Price { get; set; }
        }
    }
}
