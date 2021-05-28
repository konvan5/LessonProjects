using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Lesson10
{
    public static class UserDB
    {
        public static SqlConnection sqlConnection = new SqlConnection(
            "Data Source=KONVAN5\\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True");
        public static List<User> DatabaseLoad()
        {
            List<User> users = new List<User>();
            string sql = "SELECT name, age FROM students";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    int age = reader.GetInt32(1);
                    users.Add(new User(name, age));
                }
            }
            sqlConnection.Close();
            return users;
        }
        public static void DatabaseSave(List<User> users)
        {
            string sql = "DELETE  FROM students";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
                sql = "INSERT students VALUES";
                foreach (var user in users)
                {
                    if (sql[sql.Length - 1] == ')')
                        sql += ",";
                    sql += $" ('{user.Name}', {user.Age})";
                }
                command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw(new Exception("Ошибка при сохранении!"));
            }

            sqlConnection.Close();
        }

        public static void DatabaseUserDelete(User user)
        {
            string sql = $"DELETE FROM students WHERE name = '{user.Name}' AND age = {user.Age}";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            int DeletedCount = command.ExecuteNonQuery();
            sqlConnection.Close();
            if (DeletedCount > 1)
                throw (new Exception("Удалили больше 1 юзера!"));
            else if (DeletedCount == 0)
                throw (new Exception("Юзера нет в базе данных!"));
        }

        public static void DatabaseUserUpdate(User user, string name, int age)
        {
            string sql = $"UPDATE students SET name = '{name}', age = {age} WHERE name = '{user.Name}' AND age = {user.Age}";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            int UpdatedCount = command.ExecuteNonQuery();
            sqlConnection.Close();
            if (UpdatedCount > 1)
                throw (new Exception("Изменили больше чем 1 юзера!"));
            else if (UpdatedCount == 0)
                throw (new Exception("Юзера нет в базе данных!"));
        }

    }
}
