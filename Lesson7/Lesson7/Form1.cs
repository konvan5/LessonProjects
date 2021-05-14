using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {
        public UserPresenter userPresenter;
        public int n = 0;
        public Form1()
        {
            InitializeComponent();
            UserModel userModel = new UserModel();
            // TeamModel teamModel = new ...
            userPresenter = new UserPresenter(this, userModel);
            //teamPresenter = new TeamPresenter(this, teamModel, userModel);
            ListBoxUsersEditUpdate();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            ((Button)sender).Text = (n++).ToString();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Leave";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Enter";
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Button button11 = new Button();
            button11.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(600, 350);
            button11.Name = "button11";
            button11.Size = new Size(269, 115);
            button11.Text = "Моя новая кнопка";
            button11.UseVisualStyleBackColor = true;
            button11.MouseClick += new MouseEventHandler(this.button1_MouseClick);
            Controls.Add(button11);
        }

        private void buttonUsersUpdate_Click(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            foreach (var user in userPresenter.UserGetList())
                listBoxUsers.Items.Add(user);
        }

        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            int age = 0;
            if (textBoxUserAgeAdd.Text.Trim() == "" || textBoxUserNameAdd.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!");
                return;
            }
            if(!int.TryParse(textBoxUserAgeAdd.Text, out age))
            {
                MessageBox.Show("Не получилось прочесть возраст!", "Ошибка!");
                return;
            }
            string name = textBoxUserNameAdd.Text.Trim();
            userPresenter.UserAdd(name, age);
            ListBoxUsersEditUpdate();
        }
        private void ListBoxUsersEditUpdate()
        {
            listBoxUsersEdit.Items.Clear();
            foreach (var user in userPresenter.UserGetList())
                listBoxUsersEdit.Items.Add(user);
        }

        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            if((User)listBoxUsersEdit.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления!", "Ошибка выбора!");
                return;
            }
            //User.users.Remove((User)listBoxUsersEdit.SelectedItem);
            ListBoxUsersEditUpdate();
        }

        private void listBoxUsersEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            if((User)listBoxUsersEdit.SelectedItem == null)
            {
                textBoxUserAgeEdit.Text = "";
                textBoxUserNameEdit.Text = "";
            }
            else
            {
                textBoxUserAgeEdit.Text = ((User)listBoxUsersEdit.SelectedItem).Age.ToString();
                textBoxUserNameEdit.Text = ((User)listBoxUsersEdit.SelectedItem).Name;
            }
        }

        private void buttonUserEdit_Click(object sender, EventArgs e)
        {
            int age = 0;
            if ((User)listBoxUsersEdit.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для редактирования!", "Ошибка выбора!");
                return;
            }
            User user = (User)listBoxUsersEdit.SelectedItem;
            if (textBoxUserAgeEdit.Text.Trim() == "" || textBoxUserNameEdit.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка!");
                return;
            }
            if (!int.TryParse(textBoxUserAgeEdit.Text, out age))
            {
                MessageBox.Show("Не получилось прочесть возраст!", "Ошибка!");
                return;
            }
            string name = textBoxUserNameEdit.Text.Trim();
            user.Age = age;
            user.Name = name;
            userPresenter.UserEdit(listBoxUsersEdit.SelectedIndex, name, age);
            ListBoxUsersEditUpdate();
        }
    }
}
