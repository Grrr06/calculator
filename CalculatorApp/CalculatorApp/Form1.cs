using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1: Form
    {
        private string _input = "";  // Для хранения вводимой строки
        private double _firstNumber = 0;  // Первое число
        private double _secondNumber = 0;  // Второе число
        private string _operation = "";

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _input += button.Text;
            textBoxDisplay.Text = _input;
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_input != "")
            {
                _firstNumber = double.Parse(_input);
                _operation = button.Text;
                _input = "";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
           if (_input != "" && _operation != "")
            {
                _secondNumber = double.Parse(_input);
                double result = 0;

                switch (_operation)
                {
                    case "+":
                        result = _firstNumber + _secondNumber;
                        break;
                    case "-":
                        result = _firstNumber - _secondNumber;
                        break;
                    case "*":
                        result = _firstNumber * _secondNumber;
                        break;
                    case "/":
                        if (_secondNumber != 0)
                            result = _firstNumber / _secondNumber;
                        else
                            MessageBox.Show("Ошибка: Деление на 0!");
                        break;
                    case "^":
                        result = Math.Pow(_firstNumber, _secondNumber);
                        break;
                }

                textBoxDisplay.Text = result.ToString();
                _input = result.ToString();
                _operation = "";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            _input = "";
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = "";
            textBoxDisplay.Clear();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void power_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            if (_input != "")
            {
                double number = double.Parse(_input);
                if (number >= 0)
                {
                    double result = Math.Sqrt(number);
                    textBoxDisplay.Text = result.ToString();
                    _input = result.ToString();
                }
                else
                {
                    MessageBox.Show("Ошибка: Квадратный корень из отрицательного числа!");
                }
            }
        }
        private void squareRoot_Click(object sender, EventArgs e)
        {
            sqrt_Click(sender, e);
        }
    }
}

