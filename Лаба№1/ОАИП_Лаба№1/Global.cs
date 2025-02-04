using System;
using System.Windows.Forms;

namespace ОАИП_Лаба_1
{
    public static class Global
    {
        public static void OpenForm(Form thisForm, Form nextForm)
        {
            if (thisForm == null || nextForm == null)
                return;

            nextForm.Show();
            thisForm.Hide();
        }

        public static int GetValidNumber(string value)
        {
            if (int.TryParse(value, out int result))
                return result;
            return 0;
        }

        public static void HandleKeyCode_OnlyNumber(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete ||
                e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                return;

            char keyChar = (char)e.KeyCode;
            if (!char.IsDigit(keyChar))
                e.SuppressKeyPress = true;
        }

        public static int[,] GenerateRandomMatrix(int width, int height)
        {
            var matrix = new int[width, height];
            var random = new Random();
            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }
            return matrix;
        }

        public static void PrintMatrixTo(ListBox listBox, int[,] matrix)
        {
            listBox.Items.Clear();

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                var rowValues = "";

                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    rowValues += matrix[i, j].ToString() + " ";
                }

                listBox.Items.Add(rowValues);
            }
        }
    }
}
