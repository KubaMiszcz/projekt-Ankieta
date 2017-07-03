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
			this.qYesNo1 = new SurveyClient.QYesNo();
			this.rtbQuestionContent = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbTotalQuestions = new System.Windows.Forms.Label();
			this.lbCurrentQuestionNum = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
			this.btnNextQuestion = new System.Windows.Forms.Button();
			this.btnPrevQuestion = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.lbCurAnswer = new System.Windows.Forms.Label();
			this.gbQuestion.SuspendLayout();
			this.panelQuestion.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbQuestion
			// 
			this.gbQuestion.Controls.Add(this.panelQuestion);
			this.gbQuestion.Controls.Add(this.rtbQuestionContent);
			this.gbQuestion.Location = new System.Drawing.Point(11, 64);
			this.gbQuestion.Name = "gbQuestion";
			this.gbQuestion.Size = new System.Drawing.Size(566, 180);
			this.gbQuestion.TabIndex = 2;
			this.gbQuestion.TabStop = false;
			this.gbQuestion.Text = "Question Content";
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
			// qYesNo1
			// 
			this.qYesNo1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.qYesNo1.Location = new System.Drawing.Point(0, 0);
			this.qYesNo1.Name = "qYesNo1";
			this.qYesNo1.Size = new System.Drawing.Size(561, 56);
			this.qYesNo1.TabIndex = 0;
			this.qYesNo1.Load += new System.EventHandler(this.qYesNo1_Load);
			// 
			// rtbQuestionContent
			// 
			this.rtbQuestionContent.Location = new System.Drawing.Point(6, 19);
			this.rtbQuestionContent.Name = "rtbQuestionContent";
			this.rtbQuestionContent.ReadOnly = true;
			this.rtbQuestionContent.Size = new System.Drawing.Size(554, 92);
			this.rtbQuestionContent.TabIndex = 2;
			this.rtbQuestionContent.Text = "";
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
			// lbTotalQuestions
			// 
			this.lbTotalQuestions.AutoSize = true;
			this.lbTotalQuestions.Location = new System.Drawing.Point(542, 35);
			this.lbTotalQuestions.Name = "lbTotalQuestions";
			this.lbTotalQuestions.Size = new System.Drawing.Size(24, 13);
			this.lbTotalQuestions.TabIndex = 3;
			this.lbTotalQuestions.Text = "n/a";
			// 
			// lbCurrentQuestionNum
			// 
			this.lbCurrentQuestionNum.AutoSize = true;
			this.lbCurrentQuestionNum.Location = new System.Drawing.Point(97, 35);
			this.lbCurrentQuestionNum.Name = "lbCurrentQuestionNum";
			this.lbCurrentQuestionNum.Size = new System.Drawing.Size(24, 13);
			this.lbCurrentQuestionNum.TabIndex = 3;
			this.lbCurrentQuestionNum.Text = "n/a";
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
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(585, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip2";
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
			this.openToolStripMenuItem.Click += new System.EventHandler(this.otworzToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
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
			// btnNextQuestion
			// 
			this.btnNextQuestion.BackgroundImage = global::SurveyClient.Properties.Resources.Button_Next_icon;
			this.btnNextQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnNextQuestion.Location = new System.Drawing.Point(428, 250);
			this.btnNextQuestion.Name = "btnNextQuestion";
			this.btnNextQuestion.Size = new System.Drawing.Size(149, 71);
			this.btnNextQuestion.TabIndex = 0;
			this.btnNextQuestion.UseVisualStyleBackColor = true;
			this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
			// 
			// btnPrevQuestion
			// 
			this.btnPrevQuestion.BackgroundImage = global::SurveyClient.Properties.Resources.Button_Previous_icon;
			this.btnPrevQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPrevQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnPrevQuestion.Location = new System.Drawing.Point(11, 250);
			this.btnPrevQuestion.Name = "btnPrevQuestion";
			this.btnPrevQuestion.Size = new System.Drawing.Size(149, 71);
			this.btnPrevQuestion.TabIndex = 0;
			this.btnPrevQuestion.UseVisualStyleBackColor = true;
			this.btnPrevQuestion.Click += new System.EventHandler(this.btnPrevQuestion_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(252, 250);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Current Answer:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbCurAnswer
			// 
			this.lbCurAnswer.AutoSize = true;
			this.lbCurAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbCurAnswer.Location = new System.Drawing.Point(258, 269);
			this.lbCurAnswer.Name = "lbCurAnswer";
			this.lbCurAnswer.Size = new System.Drawing.Size(66, 33);
			this.lbCurAnswer.TabIndex = 12;
			this.lbCurAnswer.Text = "N/A";
			this.lbCurAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbCurAnswer.TextChanged += new System.EventHandler(this.lbCurAnswer_TextChanged);
			// 
			// QuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 331);
			this.Controls.Add(this.lbCurAnswer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.lbTotalQuestions);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lbCurrentQuestionNum);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.gbQuestion);
			this.Controls.Add(this.btnNextQuestion);
			this.Controls.Add(this.btnPrevQuestion);
			this.Name = "QuestionForm";
			this.Text = "QuestionForm";
			this.Load += new System.EventHandler(this.QuestionForm_Load);
			this.gbQuestion.ResumeLayout(false);
			this.panelQuestion.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox gbQuestion;
		private System.Windows.Forms.Button btnPrevQuestion;
		private System.Windows.Forms.Button btnNextQuestion;
		private System.Windows.Forms.RichTextBox rtbQuestionContent;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbTotalQuestions;
		private System.Windows.Forms.Label lbCurrentQuestionNum;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MenuStrip menuStrip1;
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
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private QYesNo qYesNo1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbCurAnswer;
	}
}