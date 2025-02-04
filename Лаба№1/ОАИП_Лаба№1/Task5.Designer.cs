namespace ОАИП_Лаба_1
{
    partial class Task5
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
            this.exchangeButton = new System.Windows.Forms.Button();
            this.textBox_Hours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Minutes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AllMinutes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exchangeButton
            // 
            this.exchangeButton.Location = new System.Drawing.Point(109, 105);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(124, 37);
            this.exchangeButton.TabIndex = 0;
            this.exchangeButton.Text = "Перевести";
            this.exchangeButton.UseVisualStyleBackColor = true;
            this.exchangeButton.Click += new System.EventHandler(this.exchangeButton_Click);
            // 
            // textBox_Hours
            // 
            this.textBox_Hours.Location = new System.Drawing.Point(90, 77);
            this.textBox_Hours.MaxLength = 2;
            this.textBox_Hours.Name = "textBox_Hours";
            this.textBox_Hours.Size = new System.Drawing.Size(79, 22);
            this.textBox_Hours.TabIndex = 1;
            this.textBox_Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Hours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Часы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Минуты:";
            // 
            // textBox_Minutes
            // 
            this.textBox_Minutes.Location = new System.Drawing.Point(175, 77);
            this.textBox_Minutes.MaxLength = 2;
            this.textBox_Minutes.Name = "textBox_Minutes";
            this.textBox_Minutes.Size = new System.Drawing.Size(79, 22);
            this.textBox_Minutes.TabIndex = 3;
            this.textBox_Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Minutes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Всего минут:";
            // 
            // textBox_AllMinutes
            // 
            this.textBox_AllMinutes.Location = new System.Drawing.Point(109, 163);
            this.textBox_AllMinutes.Name = "textBox_AllMinutes";
            this.textBox_AllMinutes.ReadOnly = true;
            this.textBox_AllMinutes.Size = new System.Drawing.Size(124, 22);
            this.textBox_AllMinutes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Перевод времени в минуты\r\n";
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(365, 207);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_AllMinutes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Minutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Hours);
            this.Controls.Add(this.exchangeButton);
            this.Name = "Task5";
            this.Text = "Задача 5";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exchangeButton;
        private System.Windows.Forms.TextBox textBox_Hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Minutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AllMinutes;
        private System.Windows.Forms.Label label4;
    }
}