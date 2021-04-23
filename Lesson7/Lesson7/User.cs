using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class User
    {
        public static List<User> users = new List<User>();
        static User()
        {
            users.Add(new User("Олег", 22));
            users.Add(new User("Настя", 20));
            users.Add(new User("Петя", 30));
        }
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
}
