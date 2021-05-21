using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9
{
    public partial class FormGame : Form
    {
        public Button[,] buttons;
        private char playerSymbol = 'X';
        private int moveCount = 0;
        private int moveNumber = 0;
        private int winLength = 0;
        public FormGame()
        {
            InitializeComponent();
            InitAndGo();
        }

        public void InitAndGo()
        {
            this.Hide();
            DeleteButtons();
            FormStart form = new FormStart();
            if (form.ShowDialog() == DialogResult.OK)
            {
                int size = form.size;
                winLength = form.winLength;
                buttons = new Button[size, size];
                int width = (this.Width - 15) / size; // отступ
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                        buttons[i, j] = new Button();
                        buttons[i, j].Margin = new Padding(0);
                        buttons[i, j].Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
                        buttons[i, j].Location = new Point(width * j, width * i);
                        buttons[i, j].Name = "button" + i + j;
                        buttons[i, j].Size = new Size(width-1, width-3);
                        buttons[i, j].TabIndex = i * size + j;
                        buttons[i, j].Text = "";
                        buttons[i, j].UseVisualStyleBackColor = true;
                        buttons[i, j].Click += new EventHandler(button_Click);
                        Controls.Add(buttons[i, j]);
                    }
                playerSymbol = 'X';
                moveCount = size * size;
                moveNumber = 0;
                this.Show();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void DeleteButtons()
        {
            if (buttons != null)
                foreach (Button button in buttons)
                { 
                    button.Dispose();
                }
        }

        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
                for (int j = 0; j < buttons.GetLength(1); j++)
                    if(buttons[i, j] == (Button)sender)
                    {
                        buttons[i, j].Text = playerSymbol.ToString();
                        buttons[i, j].Enabled = false;
                        if (IsEnd(i, j))
                            return;
                    }
            NextPlayer();
        }

        private void NextPlayer()
        {
            playerSymbol = (playerSymbol == 'X') ? '0' : 'X';
            moveNumber++;
            if(moveNumber == moveCount)
            {
                MessageBox.Show("Ничья!", "Конец игры");
                InitAndGo();
            }
        }

        private bool IsEnd(int i, int j)
        {
            if(1 + DirectionPointCount(i, j, 1, 0) + DirectionPointCount(i, j, -1, 0) >= winLength
                || 1 + DirectionPointCount(i, j, 0, 1) + DirectionPointCount(i, j, 0, -1) >= winLength
                || 1 + DirectionPointCount(i, j, 1, 1) + DirectionPointCount(i, j, -1, -1) >= winLength
                || 1 + DirectionPointCount(i, j, 1, -1) + DirectionPointCount(i, j, -1, 1) >= winLength)
            {
                MessageBox.Show("Выиграл игрок " + playerSymbol + "!", "Конец игры");
                InitAndGo();
                return true;
            }
            return false;
        }

        private int DirectionPointCount(int iStart, int jStart, int iChange, int jChange)
        {
            int points = 0;
            for (int i = iStart + iChange, j = jStart + jChange;
                i >= 0 && j >= 0 && i < buttons.GetLength(0) && j < buttons.GetLength(1);
                i += iChange, j += jChange)
                if (buttons[i, j].Text == playerSymbol.ToString())
                    points++;
                else break;
            return points;
        }
    }
}
