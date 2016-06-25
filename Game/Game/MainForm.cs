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
    public partial class MainForm : Form
    {
        private PlayForm play;

        public MainForm()
        {
            InitializeComponent();
        }

        private void последниеПартииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            play = new PlayForm();
            play.prepareForPlayGame();
            play.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            play = new PlayForm();
            play.ShowDialog();
        }

        private void общийСчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game t = new Game();
            String []arr = t.getScores();
            MessageBox.Show(arr[0] + "\n" + arr[1] + "\n" + arr[2] + "\n");
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm showForm = new ShowForm();
            showForm.setLabelTextInfo();            
            showForm.ShowDialog();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm showForm = new ShowForm();
            showForm.setLabelTextRules();
            showForm.ShowDialog();
        }
    }
}
