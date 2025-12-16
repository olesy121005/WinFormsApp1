using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormulaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double a))
            {
                MessageBox.Show("Введите корректное число a");
                return;
            }

            double z1 = 2 * Math.Pow(Math.Sin(3 * Math.PI - 2 * a), 2)
                        * Math.Pow(Math.Cos(5 * Math.PI + 2 * a), 2);

            double z2 = 0.25 - 0.25 * Math.Sin(5 * Math.PI / 2 - 8 * a);

            labelZ1.Text = $"z1 = {z1:F6}";
            labelZ2.Text = $"z2 = {z2:F6}";
        }
    }
}
