namespace ОАИП_Лаба_1
{
    partial class Task2
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTaylorValue = new System.Windows.Forms.TextBox();
            this.textBoxAccurateValue = new System.Windows.Forms.TextBox();
            this.textBoxInaccuracy = new System.Windows.Forms.TextBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(150, 68);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(116, 36);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Высчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прибл. значение по ряду Тейлора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Точное значение:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Погрешность вычислений:";
            // 
            // textBoxTaylorValue
            // 
            this.textBoxTaylorValue.Location = new System.Drawing.Point(253, 140);
            this.textBoxTaylorValue.Name = "textBoxTaylorValue";
            this.textBoxTaylorValue.ReadOnly = true;
            this.textBoxTaylorValue.Size = new System.Drawing.Size(148, 22);
            this.textBoxTaylorValue.TabIndex = 4;
            // 
            // textBoxAccurateValue
            // 
            this.textBoxAccurateValue.Location = new System.Drawing.Point(253, 168);
            this.textBoxAccurateValue.Name = "textBoxAccurateValue";
            this.textBoxAccurateValue.ReadOnly = true;
            this.textBoxAccurateValue.Size = new System.Drawing.Size(148, 22);
            this.textBoxAccurateValue.TabIndex = 5;
            // 
            // textBoxInaccuracy
            // 
            this.textBoxInaccuracy.Location = new System.Drawing.Point(253, 196);
            this.textBoxInaccuracy.Name = "textBoxInaccuracy";
            this.textBoxInaccuracy.ReadOnly = true;
            this.textBoxInaccuracy.Size = new System.Drawing.Size(148, 22);
            this.textBoxInaccuracy.TabIndex = 6;
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(95, 40);
            this.textBox_X.MaxLength = 10;
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(100, 22);
            this.textBox_X.TabIndex = 7;
            this.textBox_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_X.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            // 
            // textBox_N
            // 
            this.textBox_N.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_N.Location = new System.Drawing.Point(214, 40);
            this.textBox_N.MaxLength = 10;
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(100, 22);
            this.textBox_N.TabIndex = 8;
            this.textBox_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_N.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Значение Х:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кол-во слагаемых N:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(283, 224);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(118, 28);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Дальше -> 3";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(413, 258);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.textBoxInaccuracy);
            this.Controls.Add(this.textBoxAccurateValue);
            this.Controls.Add(this.textBoxTaylorValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Name = "Task2";
            this.Text = "Задача 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTaylorValue;
        private System.Windows.Forms.TextBox textBoxAccurateValue;
        private System.Windows.Forms.TextBox textBoxInaccuracy;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nextButton;
    }
}