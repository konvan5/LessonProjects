using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lesson10
{
    public partial class Form1 : Form
    {
        public UserPresenter userPresenter;
        public Form1()
        {
            InitializeComponent();
            UserModel userModel = new UserModel();
            userPresenter = new UserPresenter(this, userModel);
            ListBoxUsersEditUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxUsersEditUpdate();
        }
        public void ListBoxUsersEditUpdate()
        {
            listBoxUsersEdit.Items.Clear();
            foreach (var user in userPresenter.UserGetList())
                listBoxUsersEdit.Items.Add(user);
        }

        private void listBoxUsersEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((User)listBoxUsersEdit.SelectedItem == null)
            {
                textBoxName.Text = "";
                textBoxAge.Text = "";
            }
            else
            {
                textBoxAge.Text = ((User)listBoxUsersEdit.SelectedItem).Age.ToString();
                textBoxName.Text = ((User)listBoxUsersEdit.SelectedItem).Name;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            userPresenter.UserAdd(textBoxAge, textBoxName);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int age = 0;
            if ((User)listBoxUsersEdit.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для редактирования!", "Ошибка выбора!");
                return;
            }
            User user = (User)listBoxUsersEdit.SelectedItem;
            if (textBoxName.Text.Trim() == "" || textBoxAge.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!");
                return;
            }
            if (!int.TryParse(textBoxAge.Text, out age))
            {
                MessageBox.Show("Не получилось прочесть возраст!", "Ошибка!");
                return;
            }
            string name = textBoxName.Text.Trim();
            userPresenter.UserEdit(listBoxUsersEdit.SelectedIndex, name, age);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if ((User)listBoxUsersEdit.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления!", "Ошибка выбора!");
                return;
            }
            userPresenter.UserRemove((User)listBoxUsersEdit.SelectedItem);
            ListBoxUsersEditUpdate();
        }
    }
}
