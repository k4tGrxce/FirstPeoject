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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        class Time
        {
            private int Hours { get; } = 0;

            private int Minutes { get; } = 0;

            public Time(int hours, int minutes)
            {
                Hours = hours;
                Minutes = minutes;
            }

            public int minutes()
            {
                return Hours * 60 + Minutes;
            }
        }

        private void textBox_keyDown(object sender, KeyEventArgs e)
        {
            Global.HandleKeyCode_OnlyNumber(sender, e);
        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {
            int hours = Global.GetValidNumber(textBox_Hours.Text);
            int minutes = Global.GetValidNumber(textBox_Minutes.Text);
            
            Time time = new Time(hours, minutes);
            int allMinutes = time.minutes();

            textBox_AllMinutes.Text = allMinutes.ToString();
        }
    }
}
