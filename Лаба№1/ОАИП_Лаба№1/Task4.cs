using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОАИП_Лаба_1
{
    public partial class Task4 : Form
    {
        int[,] matrix = null;

        public Task4()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e) =>
            Global.OpenForm(this, new Task5());

        private void rotateMatrixButton_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Матрица не создана!");
                return;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] rotatedMatrix = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rotatedMatrix[j, rows - 1 - i] = matrix[i, j];
                }
            }

            matrix = rotatedMatrix;

            Global.PrintMatrixTo(listBox_Matrix, matrix);
        }

        private void createMatrixButton_Click(object sender, EventArgs e)
        {
            int width = Global.GetValidNumber(textBox_Width.Text);
            int height = Global.GetValidNumber(textBox_Height.Text);

            if (width == 0 || height == 0)
            {
                MessageBox.Show("Значения не могут быть пустыми или меньше 0!");
                return;
            }

            matrix = Global.GenerateRandomMatrix(width, height);

            Global.PrintMatrixTo(listBox_Matrix, matrix);
        }

        private void textBox_keyDown(object sender, KeyEventArgs e) =>
             Global.HandleKeyCode_OnlyNumber(sender, e);
    }
}
