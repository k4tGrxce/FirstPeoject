using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОАИП_Лаба_1
{
    public partial class Task3 : Form
    {
        const int MATRIX_SIZE = 3;

        public Task3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// я сосу хуй в этой функции
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        private int FindMaxBelowDiagonal(int[,] matrix, int size)
        {
            int max = int.MinValue;
            for (int i = 1; i < size; i++) 
            {
                for (int j = 0; j < i; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

        private int SumAboveDiagonal(int[,] matrix, int size, int maxBelowDiagonal)
        {
            int sum = 0;
            for (int i = 0; i < size; i++) // главная диагональ или выше
            {
                for (int j = i; j < size; j++)
                {
                    if (matrix[i, j] > maxBelowDiagonal)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, new Task4());
        }

        private void calculateMatrixButton_Click(object sender, EventArgs e)
        {
            int[,] matrix = Global.GenerateRandomMatrix(MATRIX_SIZE, MATRIX_SIZE);
            Global.PrintMatrixTo(listBox_Matrix, matrix);

            int maxBelowDiagonal = FindMaxBelowDiagonal(matrix, MATRIX_SIZE);
            int sum = SumAboveDiagonal(matrix, MATRIX_SIZE, maxBelowDiagonal);

            if (sum <= 0)
            {
                MessageBox.Show("На главной диагонали и выше нет элементов, удовлетворяющих условию.");
                return;
            }

            textBoxSumma.Text = sum.ToString("F2");
        }
    }
}
