namespace SurveyClient
{
	partial class QuestionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbQuestion = new System.Windows.Forms.GroupBox();
			this.panelQuestion = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.importFromtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exporttxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.qYesNo1 = new SurveyClient.QYesNo();
			this.gbQuestion.SuspendLayout();
			this.panelQuestion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbQuestion
			// 
			this.gbQuestion.Controls.Add(this.panelQuestion);
			this.gbQuestion.Controls.Add(this.label3);
			this.gbQuestion.Controls.Add(this.label2);
			this.gbQuestion.Controls.Add(this.label1);
			this.gbQuestion.Controls.Add(this.trackBar1);
			this.gbQuestion.Controls.Add(this.richTextBox1);
			this.gbQuestion.Location = new System.Drawing.Point(11, 64);
			this.gbQuestion.Name = "gbQuestion";
			this.gbQuestion.Size = new System.Drawing.Size(566, 256);
			this.gbQuestion.TabIndex = 2;
			this.gbQuestion.TabStop = false;
			this.gbQuestion.Text = "groupBox1";
			// 
			// panelQuestion
			// 
			this.panelQuestion.Controls.Add(this.qYesNo1);
			this.panelQuestion.Location = new System.Drawing.Point(3, 114);
			this.panelQuestion.Margin = new System.Windows.Forms.Padding(0);
			this.panelQuestion.Name = "panelQuestion";
			this.panelQuestion.Size = new System.Drawing.Size(561, 56);
			this.panelQuestion.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(226, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "label1";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(500, 222);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "label1";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(6, 222);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(7, 181);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(553, 45);
			this.trackBar1.TabIndex = 4;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(6, 19);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(554, 92);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Current Question:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(542, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "n/a";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(97, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "n/a";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(461, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Total Questions:";
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(585, 24);
			this.menuStrip2.TabIndex = 10;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.importFromtxtToolStripMenuItem,
            this.exporttxtToolStripMenuItem,
            this.importFromDatabaseToolStripMenuItem,
            this.exportToDatabaseToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
			// 
			// importFromtxtToolStripMenuItem
			// 
			this.importFromtxtToolStripMenuItem.Name = "importFromtxtToolStripMenuItem";
			this.importFromtxtToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.importFromtxtToolStripMenuItem.Text = "Import from *.txt";
			// 
			// exporttxtToolStripMenuItem
			// 
			this.exporttxtToolStripMenuItem.Name = "exporttxtToolStripMenuItem";
			this.exporttxtToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.exporttxtToolStripMenuItem.Text = "Export to *.txt";
			// 
			// importFromDatabaseToolStripMenuItem
			// 
			this.importFromDatabaseToolStripMenuItem.Name = "importFromDatabaseToolStripMenuItem";
			this.importFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.importFromDatabaseToolStripMenuItem.Text = "Import from Database";
			// 
			// exportToDatabaseToolStripMenuItem
			// 
			this.exportToDatabaseToolStripMenuItem.Name = "exportToDatabaseToolStripMenuItem";
			this.exportToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.exportToDatabaseToolStripMenuItem.Text = "Export to Database";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToDatabaseToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// loginToDatabaseToolStripMenuItem
			// 
			this.loginToDatabaseToolStripMenuItem.Name = "loginToDatabaseToolStripMenuItem";
			this.loginToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.loginToDatabaseToolStripMenuItem.Text = "Login to Database";
			// 
			// button4
			// 
			this.button4.BackgroundImage = global::AnkietaKlient.Properties.Resources.Button_Next_icon;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button4.Location = new System.Drawing.Point(428, 326);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(149, 71);
			this.button4.TabIndex = 0;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::AnkietaKlient.Properties.Resources.Button_Previous_icon;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button3.Location = new System.Drawing.Point(11, 326);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(149, 71);
			this.button3.TabIndex = 0;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// qYesNo1
			// 
			this.qYesNo1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.qYesNo1.Location = new System.Drawing.Point(0, 0);
			this.qYesNo1.Name = "qYesNo1";
			this.qYesNo1.Size = new System.Drawing.Size(561, 56);
			this.qYesNo1.TabIndex = 0;
			// 
			// QuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 404);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.gbQuestion);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Name = "QuestionForm";
			this.Text = "QuestionForm";
			this.Load += new System.EventHandler(this.QuestionForm_Load);
			this.gbQuestion.ResumeLayout(false);
			this.gbQuestion.PerformLayout();
			this.panelQuestion.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox gbQuestion;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem importFromtxtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exporttxtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importFromDatabaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToDatabaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loginToDatabaseToolStripMenuItem;
		private System.Windows.Forms.Panel panelQuestion;
		private QYesNo qYesNo1;
	}
}