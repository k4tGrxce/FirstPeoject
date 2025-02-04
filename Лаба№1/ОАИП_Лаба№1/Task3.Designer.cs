namespace ОАИП_Лаба_1
{
    partial class Task3
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
            this.calculateMatrixButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.textBoxSumma = new System.Windows.Forms.TextBox();
            this.listBox_Matrix = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // calculateMatrixButton
            // 
            this.calculateMatrixButton.Location = new System.Drawing.Point(361, 74);
            this.calculateMatrixButton.Name = "calculateMatrixButton";
            this.calculateMatrixButton.Size = new System.Drawing.Size(136, 43);
            this.calculateMatrixButton.TabIndex = 0;
            this.calculateMatrixButton.Text = "Посчитать";
            this.calculateMatrixButton.UseVisualStyleBackColor = true;
            this.calculateMatrixButton.Click += new System.EventHandler(this.calculateMatrixButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вычислить сумму тех из ее элементов, расположенных на главной\r\nдиагонали и выше н" +
    "её, которые превосходят по величине все\r\nэлементы, расположенные ниже главной ди" +
    "агонали.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сумма элементов:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(361, 388);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(136, 26);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Дальше -> 4";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // textBoxSumma
            // 
            this.textBoxSumma.Location = new System.Drawing.Point(150, 388);
            this.textBoxSumma.Name = "textBoxSumma";
            this.textBoxSumma.ReadOnly = true;
            this.textBoxSumma.Size = new System.Drawing.Size(148, 22);
            this.textBoxSumma.TabIndex = 5;
            // 
            // listBox_Matrix
            // 
            this.listBox_Matrix.FormattingEnabled = true;
            this.listBox_Matrix.ItemHeight = 16;
            this.listBox_Matrix.Items.AddRange(new object[] {
            " "});
            this.listBox_Matrix.Location = new System.Drawing.Point(19, 128);
            this.listBox_Matrix.Name = "listBox_Matrix";
            this.listBox_Matrix.Size = new System.Drawing.Size(278, 244);
            this.listBox_Matrix.TabIndex = 6;
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(521, 426);
            this.Controls.Add(this.listBox_Matrix);
            this.Controls.Add(this.textBoxSumma);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateMatrixButton);
            this.Name = "Task3";
            this.Text = "Задача 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateMatrixButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox textBoxSumma;
        private System.Windows.Forms.ListBox listBox_Matrix;
    }
}