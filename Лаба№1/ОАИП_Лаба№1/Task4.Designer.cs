namespace ОАИП_Лаба_1
{
    partial class Task4
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
            this.listBox_Matrix = new System.Windows.Forms.ListBox();
            this.rotateMatrixButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.createMatrixButton = new System.Windows.Forms.Button();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Matrix
            // 
            this.listBox_Matrix.FormattingEnabled = true;
            this.listBox_Matrix.ItemHeight = 16;
            this.listBox_Matrix.Items.AddRange(new object[] {
            " "});
            this.listBox_Matrix.Location = new System.Drawing.Point(12, 130);
            this.listBox_Matrix.Name = "listBox_Matrix";
            this.listBox_Matrix.Size = new System.Drawing.Size(333, 308);
            this.listBox_Matrix.TabIndex = 0;
            // 
            // rotateMatrixButton
            // 
            this.rotateMatrixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rotateMatrixButton.Location = new System.Drawing.Point(12, 63);
            this.rotateMatrixButton.Name = "rotateMatrixButton";
            this.rotateMatrixButton.Size = new System.Drawing.Size(120, 61);
            this.rotateMatrixButton.TabIndex = 1;
            this.rotateMatrixButton.Text = "Повернуть матрицу на 90гр.";
            this.rotateMatrixButton.UseVisualStyleBackColor = false;
            this.rotateMatrixButton.Click += new System.EventHandler(this.rotateMatrixButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(225, 444);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(120, 30);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Дальше -> 5";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // createMatrixButton
            // 
            this.createMatrixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.createMatrixButton.Location = new System.Drawing.Point(261, 63);
            this.createMatrixButton.Name = "createMatrixButton";
            this.createMatrixButton.Size = new System.Drawing.Size(84, 61);
            this.createMatrixButton.TabIndex = 3;
            this.createMatrixButton.Text = "Создать новую матрицу";
            this.createMatrixButton.UseVisualStyleBackColor = false;
            this.createMatrixButton.Click += new System.EventHandler(this.createMatrixButton_Click);
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(201, 66);
            this.textBox_Width.MaxLength = 3;
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(54, 22);
            this.textBox_Width.TabIndex = 4;
            this.textBox_Width.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(201, 102);
            this.textBox_Height.MaxLength = 3;
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(54, 22);
            this.textBox_Height.TabIndex = 5;
            this.textBox_Height.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Высота";
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(363, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Height);
            this.Controls.Add(this.textBox_Width);
            this.Controls.Add(this.createMatrixButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.rotateMatrixButton);
            this.Controls.Add(this.listBox_Matrix);
            this.Name = "Task4";
            this.Text = "Задача 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Matrix;
        private System.Windows.Forms.Button rotateMatrixButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button createMatrixButton;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}