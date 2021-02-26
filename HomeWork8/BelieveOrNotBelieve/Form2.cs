#region Автор
// Щеглов Григорий
#endregion

#region Описание задачи
/*
    2. Используя полученные знания и класс TrueFalse, разработать игру «Верю — не верю».
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

namespace BelieveOrNotBelieve
{
    public partial class Form2 : Form
    {
        private TrueFalse _dataBase;
        private int _points;
        private bool _yesNo;
        private Stack<int> _randomNumbers = new Stack<int>();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnQuestionEditor_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_dataBase == null)
            {
                MessageBox.Show("Загрузите список вопросов", "Сообщение");
                return;
            }
            btnQuestionEditor.Enabled = false;
            btnOpenQuestionList.Enabled = false;
            btnNo.Enabled = true;
            btnYes.Enabled = true;
            GenerateRandomNumbers();
            textBox.Text = _dataBase[_randomNumbers.Peek()].Text;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            _yesNo = true;
            Game();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            _yesNo = false;
            Game();
        }
        
        private void btnOpenQuestionList_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                _dataBase = new TrueFalse(open.FileName);
                _dataBase.Load();
            }
        }

        private void Game()
        {
            if (_yesNo == _dataBase[_randomNumbers.Pop()].TrueFalse)
                _points++;

            if(_randomNumbers.Count == 0)
            {
                MessageBox.Show($"Ваш результат: {_points}", "Результат");
                textBox.Text = "";
                btnNo.Enabled = false;
                btnYes.Enabled = false;
                btnQuestionEditor.Enabled = true;
                btnOpenQuestionList.Enabled = true;
                return;
            }

            textBox.Text = _dataBase[_randomNumbers.Peek()].Text;
        }

        private void GenerateRandomNumbers()
        {
            Random random = new Random();
            int number;
            _points = 0;
            _randomNumbers.Clear();
            while (_randomNumbers.Count < 5)
            {
                number = random.Next(0, _dataBase.Count - 1);
                if (!_randomNumbers.Contains(number))
                {
                    _randomNumbers.Push(number);
                }

            }
        }

    }
}
