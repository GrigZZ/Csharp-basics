#region Автор
// Щеглов Григорий
#endregion

#region Описание задачи
/*
    1.  а) Добавить в программу «Удвоитель» подсчет количества отданных команд.

        б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
        Игрок должен постараться получить это число за минимальное количество ходов.
        
        в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
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

namespace Doubler
{
    public partial class Form1 : Form
    {
        private int winNumber;
        private Stack<int> stack = new Stack<int>();
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            stack.Push(int.Parse(lblNumber.Text) + 1);
            lblNumber.Text = stack.Peek().ToString();
            lblCommands.Text = (int.Parse(lblCommands.Text) + 1).ToString();          
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            stack.Push(int.Parse(lblNumber.Text) * 2);
            lblNumber.Text = stack.Peek().ToString();
            lblCommands.Text = (int.Parse(lblCommands.Text) + 1).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stack.Clear();
            lblNumber.Text = "1";
            lblCommands.Text = "0";
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGameToolStripMenuItem.Enabled = true;
            playToolStripMenuItem.Enabled = false;
            winNumber = rnd.Next(100, 999);
            lblNumberMessage.Text = $"Наберите {winNumber} за минимальное число ходов";
            lblNumberMessage.Visible = true;
            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
            btnReset.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stack.Clear();
            lblNumber.Text = "1";
            lblCommands.Text = "0";
            winNumber = rnd.Next(100, 999);
            lblNumberMessage.Text = $"Наберите {winNumber} за минимальное число ходов";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(stack.Count != 0)
            {
                stack.Pop();
                if(stack.Count > 0)
                {
                    lblNumber.Text = stack.Peek().ToString();
                    lblCommands.Text = (int.Parse(lblCommands.Text) - 1).ToString();
                }
                else
                {
                    lblNumber.Text = "1";
                    lblCommands.Text = "0";
                }
            }
        }
    }
}
