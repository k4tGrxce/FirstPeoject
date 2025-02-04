using System;
using System.Windows.Forms;

namespace ОАИП_Лаба_1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private int GetValidCoordinate(string text, string coordName)
        {
            if (int.TryParse(text, out int result))
                return result;

            MessageBox.Show($"Координата {coordName} была пуста - ей присвоено значение 0!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return 0;
        }

        private bool HasTriangle(int x, int y, int z)
        {
            return (x > 0 && y > 0 && z > 0) && (x + y >= z && x + z >= y && z + y >= x);
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int x = GetValidCoordinate(textBox_X.Text, "X");
            int y = GetValidCoordinate(textBox_Y.Text, "Y");
            int z = GetValidCoordinate(textBox_Z.Text, "Z");

            bool hasTriangle = HasTriangle(x, y, z);
            finalLabel.Text = hasTriangle ? "Существует!" : "Не существует...";
        }

        private void textBox_keyDown(object sender, KeyEventArgs e) =>
            Global.HandleKeyCode_OnlyNumber(sender, e);

        private void nextButton_Click(object sender, EventArgs e) =>
            Global.OpenForm(this, new Task2());
    }
}
