
namespace Lesson7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.buttonUsersUpdate = new System.Windows.Forms.Button();
            this.labelUsers = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.tabPageUsersEdit = new System.Windows.Forms.TabPage();
            this.textBoxUserAgeEdit = new System.Windows.Forms.TextBox();
            this.textBoxUserNameEdit = new System.Windows.Forms.TextBox();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.labelUserAgeAdd = new System.Windows.Forms.Label();
            this.textBoxUserAgeAdd = new System.Windows.Forms.TextBox();
            this.labelUserNameAdd = new System.Windows.Forms.Label();
            this.textBoxUserNameAdd = new System.Windows.Forms.TextBox();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.labelUsersEdit = new System.Windows.Forms.Label();
            this.listBoxUsersEdit = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPageUsersEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(662, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(662, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 122);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(662, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(281, 118);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUsers);
            this.tabControl1.Controls.Add(this.tabPageUsersEdit);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 533);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.buttonUsersUpdate);
            this.tabPageUsers.Controls.Add(this.labelUsers);
            this.tabPageUsers.Controls.Add(this.listBoxUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 24);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(635, 505);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Список пользователей";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // buttonUsersUpdate
            // 
            this.buttonUsersUpdate.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUsersUpdate.Location = new System.Drawing.Point(429, 355);
            this.buttonUsersUpdate.Name = "buttonUsersUpdate";
            this.buttonUsersUpdate.Size = new System.Drawing.Size(203, 132);
            this.buttonUsersUpdate.TabIndex = 2;
            this.buttonUsersUpdate.Text = "Обновить\r\nсписок";
            this.buttonUsersUpdate.UseVisualStyleBackColor = true;
            this.buttonUsersUpdate.Click += new System.EventHandler(this.buttonUsersUpdate_Click);
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsers.Location = new System.Drawing.Point(33, 19);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(376, 46);
            this.labelUsers.TabIndex = 1;
            this.labelUsers.Text = "Список пользователей";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 37;
            this.listBoxUsers.Location = new System.Drawing.Point(33, 68);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(390, 411);
            this.listBoxUsers.TabIndex = 0;
            // 
            // tabPageUsersEdit
            // 
            this.tabPageUsersEdit.Controls.Add(this.textBoxUserAgeEdit);
            this.tabPageUsersEdit.Controls.Add(this.textBoxUserNameEdit);
            this.tabPageUsersEdit.Controls.Add(this.buttonUserEdit);
            this.tabPageUsersEdit.Controls.Add(this.buttonUserDelete);
            this.tabPageUsersEdit.Controls.Add(this.labelUserAgeAdd);
            this.tabPageUsersEdit.Controls.Add(this.textBoxUserAgeAdd);
            this.tabPageUsersEdit.Controls.Add(this.labelUserNameAdd);
            this.tabPageUsersEdit.Controls.Add(this.textBoxUserNameAdd);
            this.tabPageUsersEdit.Controls.Add(this.buttonUserAdd);
            this.tabPageUsersEdit.Controls.Add(this.labelUsersEdit);
            this.tabPageUsersEdit.Controls.Add(this.listBoxUsersEdit);
            this.tabPageUsersEdit.Location = new System.Drawing.Point(4, 24);
            this.tabPageUsersEdit.Name = "tabPageUsersEdit";
            this.tabPageUsersEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsersEdit.Size = new System.Drawing.Size(635, 505);
            this.tabPageUsersEdit.TabIndex = 1;
            this.tabPageUsersEdit.Text = "Изменение состава пользователей";
            this.tabPageUsersEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxUserAgeEdit
            // 
            this.textBoxUserAgeEdit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserAgeEdit.Location = new System.Drawing.Point(543, 343);
            this.textBoxUserAgeEdit.Name = "textBoxUserAgeEdit";
            this.textBoxUserAgeEdit.Size = new System.Drawing.Size(89, 43);
            this.textBoxUserAgeEdit.TabIndex = 13;
            // 
            // textBoxUserNameEdit
            // 
            this.textBoxUserNameEdit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserNameEdit.Location = new System.Drawing.Point(361, 343);
            this.textBoxUserNameEdit.Name = "textBoxUserNameEdit";
            this.textBoxUserNameEdit.Size = new System.Drawing.Size(176, 43);
            this.textBoxUserNameEdit.TabIndex = 12;
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUserEdit.Location = new System.Drawing.Point(361, 392);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(247, 107);
            this.buttonUserEdit.TabIndex = 11;
            this.buttonUserEdit.Text = "Изменить\r\nвыбранного";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUserDelete.Location = new System.Drawing.Point(361, 217);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(247, 107);
            this.buttonUserDelete.TabIndex = 10;
            this.buttonUserDelete.Text = "Удалить\r\nвыбранного";
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
            // 
            // labelUserAgeAdd
            // 
            this.labelUserAgeAdd.AutoSize = true;
            this.labelUserAgeAdd.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserAgeAdd.Location = new System.Drawing.Point(498, 41);
            this.labelUserAgeAdd.Name = "labelUserAgeAdd";
            this.labelUserAgeAdd.Size = new System.Drawing.Size(141, 46);
            this.labelUserAgeAdd.TabIndex = 9;
            this.labelUserAgeAdd.Text = "Возраст";
            // 
            // textBoxUserAgeAdd
            // 
            this.textBoxUserAgeAdd.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserAgeAdd.Location = new System.Drawing.Point(543, 90);
            this.textBoxUserAgeAdd.Name = "textBoxUserAgeAdd";
            this.textBoxUserAgeAdd.Size = new System.Drawing.Size(89, 43);
            this.textBoxUserAgeAdd.TabIndex = 8;
            // 
            // labelUserNameAdd
            // 
            this.labelUserNameAdd.AutoSize = true;
            this.labelUserNameAdd.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserNameAdd.Location = new System.Drawing.Point(383, 41);
            this.labelUserNameAdd.Name = "labelUserNameAdd";
            this.labelUserNameAdd.Size = new System.Drawing.Size(86, 46);
            this.labelUserNameAdd.TabIndex = 7;
            this.labelUserNameAdd.Text = "Имя";
            // 
            // textBoxUserNameAdd
            // 
            this.textBoxUserNameAdd.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserNameAdd.Location = new System.Drawing.Point(361, 90);
            this.textBoxUserNameAdd.Name = "textBoxUserNameAdd";
            this.textBoxUserNameAdd.Size = new System.Drawing.Size(176, 43);
            this.textBoxUserNameAdd.TabIndex = 6;
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUserAdd.Location = new System.Drawing.Point(361, 139);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(186, 62);
            this.buttonUserAdd.TabIndex = 5;
            this.buttonUserAdd.Text = "Добавить";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click2);
            // 
            // labelUsersEdit
            // 
            this.labelUsersEdit.AutoSize = true;
            this.labelUsersEdit.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsersEdit.Location = new System.Drawing.Point(18, 18);
            this.labelUsersEdit.Name = "labelUsersEdit";
            this.labelUsersEdit.Size = new System.Drawing.Size(376, 46);
            this.labelUsersEdit.TabIndex = 4;
            this.labelUsersEdit.Text = "Список пользователей";
            // 
            // listBoxUsersEdit
            // 
            this.listBoxUsersEdit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxUsersEdit.FormattingEnabled = true;
            this.listBoxUsersEdit.ItemHeight = 37;
            this.listBoxUsersEdit.Location = new System.Drawing.Point(18, 67);
            this.listBoxUsersEdit.Name = "listBoxUsersEdit";
            this.listBoxUsersEdit.Size = new System.Drawing.Size(337, 411);
            this.listBoxUsersEdit.TabIndex = 3;
            this.listBoxUsersEdit.SelectedValueChanged += new System.EventHandler(this.listBoxUsersEdit_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Тема 7";
            this.tabControl1.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            this.tabPageUsersEdit.ResumeLayout(false);
            this.tabPageUsersEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TabPage tabPageUsersEdit;
        private System.Windows.Forms.Button buttonUsersUpdate;
        private System.Windows.Forms.Label labelUserAgeAdd;
        private System.Windows.Forms.TextBox textBoxUserAgeAdd;
        private System.Windows.Forms.Label labelUserNameAdd;
        private System.Windows.Forms.TextBox textBoxUserNameAdd;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Label labelUsersEdit;
        private System.Windows.Forms.ListBox listBoxUsersEdit;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Button buttonUserEdit;
        private System.Windows.Forms.TextBox textBoxUserAgeEdit;
        private System.Windows.Forms.TextBox textBoxUserNameEdit;
    }
}

