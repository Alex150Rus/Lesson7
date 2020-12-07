using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointTwo
{
    /// <summary>
    /// Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
    /// а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
    /// a) Для ввода данных от человека используется элемент TextBox;
    /// б) ** Реализовать отдельную форму c TextBox для ввода числа.
    /// </summary>
    public partial class Form1 : Form
    {
        int compNumber;
        bool playing = false;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события клика на кнопку Играть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            SetCompNumber();
            lblTip.Text = "Подсказка:";
            userNumber.ReadOnly = false;
            userNumber.Text = "";
            playing = true;
            btnPlay.BackColor = Color.Green;           
        }

        /// <summary>
        /// Метод для обработки ввода пользователя после нажатия Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userNumber_Input(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int result;
                int.TryParse(userNumber.Text, out result);
                if (result > 0 && playing)
                {
                    string tip;
                    if (result < compNumber) tip = "Число компьютера больше";
                    else if (result > compNumber) tip = "Число компьютера меньше";
                    else
                    {
                        tip = "Вы угадали";
                        userNumber.ReadOnly = true;
                        playing = false;
                        btnPlay.BackColor = Color.Red;

                    }
                    lblTip.Text = tip;
                }
            }
        }

        /// <summary>
        /// Метод отвечает за загадывание номера
        /// </summary>
        private void SetCompNumber()
        {
            Random n = new Random();
            compNumber = n.Next(0, 100);
        }

    }
}
