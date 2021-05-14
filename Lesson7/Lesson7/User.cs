﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {Age} лет";
        }
    }

    public class UserModel
    {
        public List<User> Users = new List<User>();
        private string UsersPath = "users.txt";
        public UserModel()
        {
            Users.Add(new User("Олег", 22));
            Users.Add(new User("Настя", 20));
            Users.Add(new User("Петя", 30));
            // Или подгрузка данных из файла UsersPath
        }

        public void UserAdd(string name, int age)
        {
            if (Users.Any(u => u.Name == name && u.Age == age))
                throw (new Exception("Данный пользователь уже существует!"));
            Users.Add(new User(name, age));
        }

        public List<User> UserRemove(User user)
        {
            Users.Remove(user);
            return Users;
        }

        public List<User> UserEdit(int index, string name, int age)
        {
            Users[index].Name = name;
            Users[index].Age = age;
            return Users;
        }

    }
}
