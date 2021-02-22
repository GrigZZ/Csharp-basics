#region Автор
// Щеглов Григорий
#endregion

#region Описание задачи
/*
    2.  Используя Windows Forms, разработать игру «Угадай число».
        Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
        Для ввода данных от человека используется элемент TextBox.
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        private int _userNumber;
        private int _number;
        private int _attempts;
        private Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // Чтобы не срабатывал звук при нажатии Enter
                    _userNumber = int.Parse(txtUserAnswer.Text);
                    _attempts--;
                    txtUserAnswer.Clear();
                    if (_userNumber > _number)
                    {
                        lblAttempts.Text = $"Попыток: {_attempts}";
                        lblMoreLess.Text = "Слишком большое число";
                    }
                    else if (_userNumber < _number)
                    {
                        lblAttempts.Text = $"Попыток: {_attempts}";
                        lblMoreLess.Text = "Слишком маленькое число";
                    }
                    else
                    {
                        lblMoreLess.Text = "";
                        var result = MessageBox.Show("Продолжить?", "Правильно!!!", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                            Close();
                        txtUserAnswer.Enabled = false;
                        lblMoreLess.Visible = false;
                    }
                    if(_attempts == 0)
                    {
                        lblMoreLess.Text = "";
                        var result = MessageBox.Show("Попыток больше нет.\nПродолжить?", "Game Over", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                            Close();
                        txtUserAnswer.Enabled = false;
                        lblMoreLess.Visible = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            LaunchGame(7);
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            LaunchGame(5);
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            LaunchGame(3);
        }

        private void LaunchGame(int attempts)
        {
            lblGameRules.Visible = true;
            lblMoreLess.Visible = true;
            txtUserAnswer.Enabled = true;
            _number = rnd.Next(1, 100);
            _attempts = attempts;
            lblAttempts.Text = $"Попыток: {attempts}";
        }
    }
}
