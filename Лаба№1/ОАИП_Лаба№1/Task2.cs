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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
                result *= i;
            return result;
        }

        static double CalculateTaylorSin(double x, int n)
        {
            double result = 0;

            for (int i = 0; i < n; i++)
            {
                int termExponent = 2 * i + 1;
                double term = Math.Pow(-1, i) * Math.Pow(x, termExponent) / Factorial(termExponent);
                result += term;
            }

            return result;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int x = Global.GetValidNumber(textBox_X.Text);
            int n = Global.GetValidNumber(textBox_N.Text);

            double approximateSin = CalculateTaylorSin(x, n);
            double exactSin = Math.Sin(x);
            double inaccuracy = Math.Abs(exactSin - approximateSin);

            textBoxTaylorValue.Text = approximateSin.ToString("F3");
            textBoxAccurateValue.Text = exactSin.ToString("F3");
            textBoxInaccuracy.Text = inaccuracy.ToString("F3");
        }

        private void textBox_keyDown(object sender, KeyEventArgs e)
        {
            Global.HandleKeyCode_OnlyNumber(sender, e);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Global.OpenForm(this, new Task3());
        }
    }
}
