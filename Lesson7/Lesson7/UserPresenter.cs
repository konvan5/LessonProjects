using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lesson7
{
    public class UserPresenter
    {
        public UserModel model;
        public Form1 View;
        public UserPresenter(Form1 view, UserModel userModel)
        {
            View = view;
            model = userModel;
        }
        public void UserAdd(string name, int age)
        {
            try
            {
                if (name.Trim() != "")
                    model.UserAdd(name, age);
                else
                {
                    MessageBox.Show("Ошибка! Данные введены не верно!", "Ошибка!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        public List<User> UserGetList()
        {
            return model.Users;
        }
        public void UserEdit(int index, string name, int age)
        {
            try
            {
                if (name.Trim() != "" && index >= 0)
                    model.UserEdit(index, name, age);
                else
                {
                    MessageBox.Show("Ошибка! Данные введены не верно!", "Ошибка!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }

        public void UserAdd2(TextBox textBoxUserAgeAdd, TextBox textBoxUserNameAdd)
        {
            int age = 0;
            if (textBoxUserAgeAdd.Text.Trim() == "" || textBoxUserNameAdd.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!");
                return;
            }
            if (!int.TryParse(textBoxUserAgeAdd.Text, out age))
            {
                MessageBox.Show("Не получилось прочесть возраст!", "Ошибка!");
                return;
            }
            string name = textBoxUserNameAdd.Text.Trim();
            try
            {
                model.UserAdd(name, age);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
            View.ListBoxUsersEditUpdate();
        }
    }
}
