using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    /// <summary>
    /// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    /// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
    /// в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
    /// Вся логика игры должна быть реализована в классе с удвоителем.
    /// </summary>
    public partial class Form1 : Form
    {
        int counter;
        int number;
        int minTurns;

        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblCounterText.Text = "Кол-во комманд:";
            lblCounter.Text = counter.ToString();
            playButton.Text = "Играть";
            this.Text = "Удвоитель";
        }

        /// <summary>
        /// Обработчик события клика на кнопку +1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            countCommnads();
        }

        /// <summary>
        /// Обработчик события клика на кнопку *1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            countCommnads();

        }

        /// <summary>
        /// Обработчик события клика на кнопку Сброс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            resetCounter();
        }

        /// <summary>
        /// Метод подсчёта количества комманд
        /// </summary>
        private void countCommnads()
        {
            counter++;
            lblCounter.Text = counter.ToString();
        }

        /// <summary>
        /// Метод сброса счётчика
        /// </summary>
        private void resetCounter()
        {
            lblCounter.Text = "0";
            counter = 0;
            lblGetNumber.Visible = false;
            lblMinTurns.Text = "";
        }

        /// <summary>
        /// Обработчик события клика на кнопку Играть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            this.number = number.Next(1, 31);
            lblGetNumber.Text = $"Получи число {this.number} за минимальное количество ходов";
            lblNumber.Text = "0";
            resetCounter();
            lblGetNumber.Visible = true;
            calcMinTurns();
            lblMinTurns.Text = minTurns.ToString();
        }

        /// <summary>
        /// Метод подсчитывает минимальное количество шагов
        /// </summary>
        private void calcMinTurns()
        {
            int c = 1;
            minTurns = 0;
            while (c * 2 < number)
            {
                c = c * 2;
                minTurns++;
            }

            if (number == 1)
                minTurns = 1;
            else minTurns = minTurns + number - c + 1;
           
        }


    }
}
