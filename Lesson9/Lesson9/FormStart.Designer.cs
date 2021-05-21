
namespace Lesson9
{
    partial class FormStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelWinLength = new System.Windows.Forms.Label();
            this.numericUpDownWinLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWinLength)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(54, 201);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(269, 52);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownSize.Location = new System.Drawing.Point(54, 49);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(269, 43);
            this.numericUpDownSize.TabIndex = 1;
            this.numericUpDownSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownSize.ValueChanged += new System.EventHandler(this.numericUpDownSize_ValueChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSize.Location = new System.Drawing.Point(54, 9);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(180, 37);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Размер поля:";
            // 
            // labelWinLength
            // 
            this.labelWinLength.AutoSize = true;
            this.labelWinLength.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWinLength.Location = new System.Drawing.Point(54, 105);
            this.labelWinLength.Name = "labelWinLength";
            this.labelWinLength.Size = new System.Drawing.Size(233, 37);
            this.labelWinLength.TabIndex = 4;
            this.labelWinLength.Text = "Счет для победы:";
            // 
            // numericUpDownWinLength
            // 
            this.numericUpDownWinLength.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownWinLength.Location = new System.Drawing.Point(54, 145);
            this.numericUpDownWinLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownWinLength.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownWinLength.Name = "numericUpDownWinLength";
            this.numericUpDownWinLength.Size = new System.Drawing.Size(269, 43);
            this.numericUpDownWinLength.TabIndex = 3;
            this.numericUpDownWinLength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownWinLength.ValueChanged += new System.EventHandler(this.numericUpDownWinLength_ValueChanged);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelWinLength);
            this.Controls.Add(this.numericUpDownWinLength);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormStart";
            this.Text = "Крестики нолики настройки";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWinLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelWinLength;
        private System.Windows.Forms.NumericUpDown numericUpDownWinLength;
    }
}