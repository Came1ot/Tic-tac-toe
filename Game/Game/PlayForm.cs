using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Game
{
	/// <summary>
	/// Description of PlayForm.
	/// </summary>
	public partial class PlayForm : Form
	{
        private Game Game = null;
        private Label[][] labels = null;
		public PlayForm()
		{
            InitializeComponent();
            labels = new Label[][] { new Label[] {label1, label2, label3},
                new Label [] {label4, label5, label6},
                new Label [] {label7, label8, label9}};
            Game = new Game(labels);
            Game.reset();
		}

        public void prepareForPlayGame()
        {
            int i, j;
            for (i = 0; i < labels.Length; i++)
                for (j = 0; j < labels[i].Length; j++)
                    labels[i][j].Enabled = false;
            зановоToolStripMenuItem.Visible = false;
            играToolStripMenuItem.Visible = false;
            параметрыToolStripMenuItem1.Visible = false;
            проигратьToolStripMenuItem.Visible = true;
        }

        void cellClick(object sender, EventArgs e)
        {
            Label cell = (Label)sender;
            String tag = cell.Tag.ToString();
            char[] arr = tag.ToCharArray();
            int row = int.Parse(arr[0].ToString());
            int col = int.Parse(arr[1].ToString());
            Game.play(sender);
        }
        
        void gamePlayClick(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < labels.Length; i++)
                for (j = 0; j < labels[i].Length; j++)
                    labels[i][j].ResetText();
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            int gameNumber = (int.Parse(menuItem.Tag.ToString()));
            int number = (int)gameNumber;
            int[][] playSequence = Game.gameSequence(number);
            for (i = 0; i < playSequence.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("X");
                    labels[playSequence[i][0]][playSequence[i][1]].Text = "X";
                }
                else
                {
                    labels[playSequence[i][0]][playSequence[i][1]].Text = "O";
                    Console.WriteLine("O");

                }
                Thread.Sleep(150);
                this.Refresh();
            }
            
        }
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
        private void зановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.reset();
        }

        private void vsИгрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.VS = 0;
            Game.reset();
            vsКомпьютерToolStripMenuItem.Checked = false;
        }

        private void vsКомпьютерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.VS = 1;
            Game.reset();
            vsИгрокToolStripMenuItem.Checked = false;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Difficulty = 1;
            easyToolStripMenuItem.Checked = false;
            Game.reset();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Difficulty = 0;
            hardToolStripMenuItem.Checked = false;
            Game.reset();
        }

        private void крестикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ноликиToolStripMenuItem.Checked = false;
            Game.Turn = 0;
            Game.reset();
            
        }

        private void ноликиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            крестикиToolStripMenuItem.Checked = false;
            Game.Turn = 1;
            Game.reset();
        }
       
	}
}
