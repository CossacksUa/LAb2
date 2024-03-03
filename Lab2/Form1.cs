using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private Class1 calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Class1();
            comBox.Items.AddRange(new object[] { "+", "-", "*", "/", "^", "Конвертувати в десяткову", "Конвертувати в Р-ічну" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;

            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b)
                || !double.TryParse(txtC.Text, out c) || !double.TryParse(txtD.Text, out d))
            {
                MessageBox.Show("Введено некоректні дані");
                return;
            }

            try
            {
                if (checkBox1.Checked)
                {
                    var resultA = calculator.Power(a, c, 10);
                    txtResult1a.Text = $"Десяткова: {resultA.decimalResult}";
                    txtResult1b.Text = $"Шістнадцяткова: {resultA.radixResult}";

                    var resultB = calculator.Power(b, d, 10);
                    txtResult2a.Text = $"Десяткова: {resultB.decimalResult}";
                    txtResult2b.Text = $"Шістнадцяткова: {resultB.radixResult}";

                    a = Math.Pow(a, c);
                    b = Math.Pow(b, d);
                }

                {
                    switch (comBox.Text)
                    {
                        case "+":
                            txtResult1.Text = calculator.Add(a, b).ToString();
                            break;
                        case "-":
                            txtResult1.Text = calculator.Subtract(a, b).ToString();
                            break;
                        case "*":
                            txtResult1.Text = calculator.Multiply(a, b).ToString();
                            break;
                        case "/":
                            txtResult1.Text = calculator.Divide(a, b).ToString();
                            break;
                        case "Конвертувати в десяткову":
                            // Ваш існуючий код для конвертації в десяткову
                            break;
                        case "Конвертувати в Р-ічну":
                            // Ваш існуючий код для конвертації в Р-ічну
                            break;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtV.Text = "";
            txtResult1.Text = "";
            txtResult1a.Text = "";
            txtResult1b.Text = "";
            txtResult2a.Text = "";
            txtResult2b.Text = "";
            comBox.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtV.Text, System.Globalization.NumberStyles.HexNumber, null, out int v))
            {
                MessageBox.Show("Введено некоректне число");
                return;
            }

            try
            {
                if (checkBox2.Checked)
                {
                    int radix = 16;
                    string V = txtV.Text;
                    int decimalV = calculator.ConvertToDecimal(V, radix);
                    txtResult1.Text = $"Десяткова: {decimalV}";
                }

                if (checkBox3.Checked)
                {
                    int radix = 16;
                    string hexV = calculator.ConvertFromDecimal(v, radix);
                    txtResult1.Text += Environment.NewLine + $" P-ічна: {hexV}";
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}

