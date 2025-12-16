namespace FormulaWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelZ1;
        private System.Windows.Forms.Label labelZ2;

        private void InitializeComponent()
        {
            labelA = new System.Windows.Forms.Label();
            textBoxA = new System.Windows.Forms.TextBox();
            buttonCalc = new System.Windows.Forms.Button();
            labelZ1 = new System.Windows.Forms.Label();
            labelZ2 = new System.Windows.Forms.Label();

            SuspendLayout();

            labelA.AutoSize = true;
            labelA.Location = new System.Drawing.Point(20, 20);
            labelA.Text = "Введите a:";

            textBoxA.Location = new System.Drawing.Point(120, 18);

            buttonCalc.Location = new System.Drawing.Point(20, 60);
            buttonCalc.Text = "Рассчитать";
            buttonCalc.Click += buttonCalc_Click;

            labelZ1.Location = new System.Drawing.Point(20, 110);
            labelZ1.Text = "z1 =";

            labelZ2.Location = new System.Drawing.Point(20, 140);
            labelZ2.Text = "z2 =";

            Controls.Add(labelA);
            Controls.Add(textBoxA);
            Controls.Add(buttonCalc);
            Controls.Add(labelZ1);
            Controls.Add(labelZ2);

            Text = "Расчет по формулам";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
