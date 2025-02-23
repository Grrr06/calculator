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
        private string _operation = "";  // Операция (+, -, *, /)

        public Form1()
        {
            InitializeComponent();
        }
        // Обработчик нажатия на кнопки с цифрами
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _input += button.Text;  // Добавляем текст кнопки в строку ввода
            textBoxDisplay.Text = _input;  // Отображаем в TextBox
        }
        // Обработчик нажатия на операторы
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_input != "")  // Если есть введенное число
            {
                _firstNumber = double.Parse(_input);  // Преобразуем строку в число
                _operation = button.Text;  // Запоминаем операцию
                _input = "";  // Очищаем строку ввода для второго числа
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (_input != "" && _operation != "")  // Проверяем, что есть второе число и операция
            {
                _secondNumber = double.Parse(_input);  // Преобразуем строку во второе число
                double result = 0;

                // Выполняем операцию в зависимости от выбранного оператора
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
                }

                // Отображаем результат в TextBox
                textBoxDisplay.Text = result.ToString();
                _input = result.ToString();  // Запоминаем результат для дальнейших операций
                _operation = "";  // Очищаем операцию
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
    }
}

