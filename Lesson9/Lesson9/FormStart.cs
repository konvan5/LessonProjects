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
    public partial class FormStart : Form
    {
        public int size = 3;
        public int winLength = 3;
        public FormStart()
        {
            InitializeComponent();
            numericUpDownWinLength.Maximum = numericUpDownSize.Value;
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            size = (int)numericUpDownSize.Value;
            numericUpDownWinLength.Maximum = numericUpDownSize.Value;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void numericUpDownWinLength_ValueChanged(object sender, EventArgs e)
        {
            winLength = (int)numericUpDownWinLength.Value;
        }
    }
}
