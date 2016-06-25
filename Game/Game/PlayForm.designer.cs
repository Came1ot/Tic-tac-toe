namespace Game
{
	partial class PlayForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsИгрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsКомпьютерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.компьютерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крестикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ноликиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проигратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.партия1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.партия2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.партия3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.параметрыToolStripMenuItem1,
            this.зановоToolStripMenuItem,
            this.проигратьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vsИгрокToolStripMenuItem,
            this.vsКомпьютерToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // vsИгрокToolStripMenuItem
            // 
            this.vsИгрокToolStripMenuItem.Checked = true;
            this.vsИгрокToolStripMenuItem.CheckOnClick = true;
            this.vsИгрокToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vsИгрокToolStripMenuItem.Name = "vsИгрокToolStripMenuItem";
            this.vsИгрокToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vsИгрокToolStripMenuItem.Text = "vs Игрок";
            this.vsИгрокToolStripMenuItem.Click += new System.EventHandler(this.vsИгрокToolStripMenuItem_Click);
            // 
            // vsКомпьютерToolStripMenuItem
            // 
            this.vsКомпьютерToolStripMenuItem.CheckOnClick = true;
            this.vsКомпьютерToolStripMenuItem.Name = "vsКомпьютерToolStripMenuItem";
            this.vsКомпьютерToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vsКомпьютерToolStripMenuItem.Text = "vs Компьютер";
            this.vsКомпьютерToolStripMenuItem.Click += new System.EventHandler(this.vsКомпьютерToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem1
            // 
            this.параметрыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компьютерToolStripMenuItem,
            this.игрокToolStripMenuItem});
            this.параметрыToolStripMenuItem1.Name = "параметрыToolStripMenuItem1";
            this.параметрыToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem1.Text = "Параметры";
            // 
            // компьютерToolStripMenuItem
            // 
            this.компьютерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.компьютерToolStripMenuItem.Name = "компьютерToolStripMenuItem";
            this.компьютерToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.компьютерToolStripMenuItem.Text = "Компьютер";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Checked = true;
            this.easyToolStripMenuItem.CheckOnClick = true;
            this.easyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.CheckOnClick = true;
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // игрокToolStripMenuItem
            // 
            this.игрокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.крестикиToolStripMenuItem,
            this.ноликиToolStripMenuItem});
            this.игрокToolStripMenuItem.Name = "игрокToolStripMenuItem";
            this.игрокToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.игрокToolStripMenuItem.Text = "Игрок";
            // 
            // крестикиToolStripMenuItem
            // 
            this.крестикиToolStripMenuItem.Checked = true;
            this.крестикиToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.крестикиToolStripMenuItem.Name = "крестикиToolStripMenuItem";
            this.крестикиToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.крестикиToolStripMenuItem.Text = "Крестики";
            this.крестикиToolStripMenuItem.Click += new System.EventHandler(this.крестикиToolStripMenuItem_Click);
            // 
            // ноликиToolStripMenuItem
            // 
            this.ноликиToolStripMenuItem.CheckOnClick = true;
            this.ноликиToolStripMenuItem.Name = "ноликиToolStripMenuItem";
            this.ноликиToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ноликиToolStripMenuItem.Text = "Нолики";
            this.ноликиToolStripMenuItem.Click += new System.EventHandler(this.ноликиToolStripMenuItem_Click);
            // 
            // зановоToolStripMenuItem
            // 
            this.зановоToolStripMenuItem.Name = "зановоToolStripMenuItem";
            this.зановоToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.зановоToolStripMenuItem.Text = "Заново";
            this.зановоToolStripMenuItem.Click += new System.EventHandler(this.зановоToolStripMenuItem_Click);
            // 
            // проигратьToolStripMenuItem
            // 
            this.проигратьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.партия1ToolStripMenuItem,
            this.партия2ToolStripMenuItem,
            this.партия3ToolStripMenuItem});
            this.проигратьToolStripMenuItem.Name = "проигратьToolStripMenuItem";
            this.проигратьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.проигратьToolStripMenuItem.Text = "Проиграть";
            this.проигратьToolStripMenuItem.Visible = false;
            // 
            // партия1ToolStripMenuItem
            // 
            this.партия1ToolStripMenuItem.Name = "партия1ToolStripMenuItem";
            this.партия1ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.партия1ToolStripMenuItem.Tag = "1";
            this.партия1ToolStripMenuItem.Text = "Партия #1";
            this.партия1ToolStripMenuItem.Click += new System.EventHandler(this.gamePlayClick);
            // 
            // партия2ToolStripMenuItem
            // 
            this.партия2ToolStripMenuItem.Name = "партия2ToolStripMenuItem";
            this.партия2ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.партия2ToolStripMenuItem.Tag = "2";
            this.партия2ToolStripMenuItem.Text = "Партия #2";
            this.партия2ToolStripMenuItem.Click += new System.EventHandler(this.gamePlayClick);
            // 
            // партия3ToolStripMenuItem
            // 
            this.партия3ToolStripMenuItem.Name = "партия3ToolStripMenuItem";
            this.партия3ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.партия3ToolStripMenuItem.Tag = "3";
            this.партия3ToolStripMenuItem.Text = "Партия #3";
            this.партия3ToolStripMenuItem.Click += new System.EventHandler(this.gamePlayClick);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.label10.Location = new System.Drawing.Point(-6, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(346, 20);
            this.label10.TabIndex = 10;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 5);
            this.label14.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(171, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 68);
            this.label9.TabIndex = 7;
            this.label9.Tag = "22";
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.UseCompatibleTextRendering = true;
            this.label9.Click += new System.EventHandler(this.cellClick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(92, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 68);
            this.label8.TabIndex = 8;
            this.label8.Tag = "21";
            this.label8.Text = "X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.UseCompatibleTextRendering = true;
            this.label8.Click += new System.EventHandler(this.cellClick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 68);
            this.label7.TabIndex = 9;
            this.label7.Tag = "20";
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.UseCompatibleTextRendering = true;
            this.label7.Click += new System.EventHandler(this.cellClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 68);
            this.label4.TabIndex = 6;
            this.label4.Tag = "10";
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseCompatibleTextRendering = true;
            this.label4.Click += new System.EventHandler(this.cellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 68);
            this.label1.TabIndex = 1;
            this.label1.Tag = "00";
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.cellClick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(92, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 68);
            this.label5.TabIndex = 5;
            this.label5.Tag = "11";
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseCompatibleTextRendering = true;
            this.label5.Click += new System.EventHandler(this.cellClick);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 5);
            this.label13.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(171, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 68);
            this.label6.TabIndex = 4;
            this.label6.Tag = "12";
            this.label6.Text = "X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseCompatibleTextRendering = true;
            this.label6.Click += new System.EventHandler(this.cellClick);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(162, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(6, 231);
            this.label12.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 68);
            this.label3.TabIndex = 3;
            this.label3.Tag = "02";
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Click += new System.EventHandler(this.cellClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 68);
            this.label2.TabIndex = 2;
            this.label2.Tag = "01";
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.cellClick);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(83, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(6, 231);
            this.label11.TabIndex = 11;
            // 
            // PlayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(261, 295);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 324);
            this.MinimumSize = new System.Drawing.Size(267, 324);
            this.Name = "PlayForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Х-О\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem зановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проигратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem партия1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem партия2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem партия3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vsИгрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vsКомпьютерToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem компьютерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem игрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крестикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ноликиToolStripMenuItem;
	}
}
