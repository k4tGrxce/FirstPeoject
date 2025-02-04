namespace ОАИП_Лаба_1
{
    partial class Task1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.finalLabel = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_Z = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(125, 78);
            this.textBox_X.MaxLength = 3;
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(28, 22);
            this.textBox_X.TabIndex = 0;
            this.textBox_X.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите координаты в ячейки\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выясним, существует ли треугольник с длинами x, y, z.\r\n";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(125, 120);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(96, 35);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Проверить";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Location = new System.Drawing.Point(122, 169);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(124, 16);
            this.finalLabel.TabIndex = 4;
            this.finalLabel.Text = "Жду координаты..";
            this.finalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(159, 78);
            this.textBox_Y.MaxLength = 3;
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(28, 22);
            this.textBox_Y.TabIndex = 5;
            this.textBox_Y.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            // 
            // textBox_Z
            // 
            this.textBox_Z.Location = new System.Drawing.Point(193, 78);
            this.textBox_Z.MaxLength = 3;
            this.textBox_Z.Name = "textBox_Z";
            this.textBox_Z.Size = new System.Drawing.Size(28, 22);
            this.textBox_Z.TabIndex = 6;
            this.textBox_Z.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Z";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(284, 160);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(114, 25);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "Дальше -> 2";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 194);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Z);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_X);
            this.Name = "Task1";
            this.Text = "Задача 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_Z;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nextButton;
    }
}

