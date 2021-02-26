#region Автор
// Щеглов Григорий
#endregion

#region Описание задачи
/*
    1.  а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок
        (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).

        б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
        
        в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия,авторские права и др.).
        
        г) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
        
        д) Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
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
    public partial class Form1 : Form
    {
        private TrueFalse _dataBase;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if(_dataBase != null)
            {
                textBox.Text = _dataBase[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = _dataBase[(int)nudNumber.Value - 1].TrueFalse;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(_dataBase == null)
            {
                MessageBox.Show("Создайте или откройте базу данных", "Сообщение");
                return;
            }
            _dataBase.Add((_dataBase.Count + 1).ToString(), true);
            nudNumber.Maximum = _dataBase.Count;
            nudNumber.Value = _dataBase.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || _dataBase == null)
                return;
            var result = MessageBox.Show("Вы действительно хотите удалить вопрос?", "Предупреждение", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                _dataBase.Remove((int)nudNumber.Value);
                nudNumber.Maximum--;
                if (nudNumber.Value > 1)
                    nudNumber.Value = nudNumber.Value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_dataBase == null)
            {
                MessageBox.Show("Создайте или откройте базу данных", "Сообщение");
                return;
            }

            _dataBase[(int)nudNumber.Value - 1].Text = textBox.Text;
            _dataBase[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                _dataBase = new TrueFalse(save.FileName);
                _dataBase.Add("Собака - домашнее животное.", true);
                _dataBase.Save();

                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                _dataBase = new TrueFalse(open.FileName);
                _dataBase.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = _dataBase.Count;
                nudNumber.Value = 1;
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (_dataBase != null)
                _dataBase.Save();
            else
                MessageBox.Show("Ошибка создания базы данных");
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Questions Editor\nVersion 1.0\nGrigZZ in collaboration with\n© GeekBrains\n2021", "О программе");
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            if (_dataBase != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                    _dataBase.FileName = save.FileName;
                    _dataBase.Save();
            }
            else
                MessageBox.Show("Ошибка создания базы данных");
        }
    }
}
