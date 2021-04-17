using System;
using Lesson6Library;
using System.Collections.Generic;


namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            User user = new User("Олег", 23);
            user.PrintHello();
            List<User> users = new List<User>();
            users.Add(user);
            users.Add(new User("Петя", 25));
            users.Add(new User("Аня", 24));
            users.Add(new User("Наташа", 26));
            users.Add(new User("Вася", 30));
            if (!DataBase.SaveUsers(users))
                Console.WriteLine("Нам не удалось сохранить файл :(");
            List<User> users2 = DataBase.LoadUsers();
            if(users2 == null)
                Console.WriteLine("Что-то пошло не так. У нас нет списка! :(");
            foreach (var u in users2)
            {
                u.PrintHello();
            }
        }
    }
}
