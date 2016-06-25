using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            InitializeComponent();
        }

        public void setLabelTextInfo()
        {

            label.Text = @"Курсовая работа по дисциплине ООП
Выполнила студентка группы ИУС-10б
Козлова С.О.";
        }

        public void setLabelTextRules()
        {
            label.Text = @"Игроки по очереди ставят на свободные клетки поля 3х3 знаки (один всегда крестики, другой всегда нолики). Первый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или диагонали, выигрывает. Первый ход делает игрок, ставящий крестики.";
        }

        private void ShowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
