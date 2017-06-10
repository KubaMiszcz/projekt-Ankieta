namespace SurveyEditor
{
    partial class QuestionEditForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionEditForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rtbQuestionContent = new System.Windows.Forms.RichTextBox();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
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
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.gbQuestionKind = new System.Windows.Forms.GroupBox();
			this.rb1to100 = new System.Windows.Forms.RadioButton();
			this.rb1to3 = new System.Windows.Forms.RadioButton();
			this.rb1to10 = new System.Windows.Forms.RadioButton();
			this.rb1to5 = new System.Windows.Forms.RadioButton();
			this.rbNoYesDontkonw = new System.Windows.Forms.RadioButton();
			this.rbNoYes = new System.Windows.Forms.RadioButton();
			this.lbTotalQuestions = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbQuestionNumberDropDownList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnPrevQuestion = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbAuthor = new System.Windows.Forms.TextBox();
			this.rtbSubject = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.groupBox1.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			this.gbQuestionKind.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rtbQuestionContent);
			this.groupBox1.Location = new System.Drawing.Point(12, 254);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox1.Size = new System.Drawing.Size(514, 110);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Question Content";
			this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_Paint);
			// 
			// rtbQuestionContent
			// 
			this.rtbQuestionContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbQuestionContent.Location = new System.Drawing.Point(5, 18);
			this.rtbQuestionContent.Name = "rtbQuestionContent";
			this.rtbQuestionContent.Size = new System.Drawing.Size(504, 87);
			this.rtbQuestionContent.TabIndex = 0;
			this.rtbQuestionContent.Text = "";
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(542, 24);
			this.menuStrip2.TabIndex = 9;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewStripMenuItem2,
            this.toolStripSeparator4,
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
			// NewStripMenuItem2
			// 
			this.NewStripMenuItem2.Name = "NewStripMenuItem2";
			this.NewStripMenuItem2.Size = new System.Drawing.Size(190, 22);
			this.NewStripMenuItem2.Text = "New";
			this.NewStripMenuItem2.Click += new System.EventHandler(this.NewStripMenuItem2_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
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
			this.importFromtxtToolStripMenuItem.Click += new System.EventHandler(this.importFromtxtToolStripMenuItem_Click);
			// 
			// exporttxtToolStripMenuItem
			// 
			this.exporttxtToolStripMenuItem.Name = "exporttxtToolStripMenuItem";
			this.exporttxtToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.exporttxtToolStripMenuItem.Text = "Export to *.txt";
			this.exporttxtToolStripMenuItem.Click += new System.EventHandler(this.exporttxtToolStripMenuItem_Click);
			// 
			// importFromDatabaseToolStripMenuItem
			// 
			this.importFromDatabaseToolStripMenuItem.Name = "importFromDatabaseToolStripMenuItem";
			this.importFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.importFromDatabaseToolStripMenuItem.Text = "Import from Database";
			this.importFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importFromDatabaseToolStripMenuItem_Click);
			// 
			// exportToDatabaseToolStripMenuItem
			// 
			this.exportToDatabaseToolStripMenuItem.Name = "exportToDatabaseToolStripMenuItem";
			this.exportToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.exportToDatabaseToolStripMenuItem.Text = "Export to Database";
			this.exportToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.exportToDatabaseToolStripMenuItem_Click);
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// gbQuestionKind
			// 
			this.gbQuestionKind.Controls.Add(this.rb1to100);
			this.gbQuestionKind.Controls.Add(this.rb1to3);
			this.gbQuestionKind.Controls.Add(this.rb1to10);
			this.gbQuestionKind.Controls.Add(this.rb1to5);
			this.gbQuestionKind.Controls.Add(this.rbNoYesDontkonw);
			this.gbQuestionKind.Controls.Add(this.rbNoYes);
			this.gbQuestionKind.Location = new System.Drawing.Point(12, 177);
			this.gbQuestionKind.Name = "gbQuestionKind";
			this.gbQuestionKind.Size = new System.Drawing.Size(514, 71);
			this.gbQuestionKind.TabIndex = 10;
			this.gbQuestionKind.TabStop = false;
			this.gbQuestionKind.Text = "Kind";
			this.gbQuestionKind.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_Paint);
			// 
			// rb1to100
			// 
			this.rb1to100.AutoSize = true;
			this.rb1to100.Location = new System.Drawing.Point(396, 43);
			this.rb1to100.Name = "rb1to100";
			this.rb1to100.Size = new System.Drawing.Size(98, 17);
			this.rb1to100.TabIndex = 2;
			this.rb1to100.TabStop = true;
			this.rb1to100.Text = "Value 1 To 100";
			this.rb1to100.UseVisualStyleBackColor = true;
			this.rb1to100.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rb1to3
			// 
			this.rb1to3.AutoSize = true;
			this.rb1to3.Location = new System.Drawing.Point(206, 20);
			this.rb1to3.Name = "rb1to3";
			this.rb1to3.Size = new System.Drawing.Size(86, 17);
			this.rb1to3.TabIndex = 2;
			this.rb1to3.TabStop = true;
			this.rb1to3.Text = "Value 1 To 3";
			this.rb1to3.UseVisualStyleBackColor = true;
			this.rb1to3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rb1to10
			// 
			this.rb1to10.AutoSize = true;
			this.rb1to10.Location = new System.Drawing.Point(396, 20);
			this.rb1to10.Name = "rb1to10";
			this.rb1to10.Size = new System.Drawing.Size(92, 17);
			this.rb1to10.TabIndex = 1;
			this.rb1to10.TabStop = true;
			this.rb1to10.Text = "Value 1 To 10";
			this.rb1to10.UseVisualStyleBackColor = true;
			this.rb1to10.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rb1to5
			// 
			this.rb1to5.AutoSize = true;
			this.rb1to5.Location = new System.Drawing.Point(206, 43);
			this.rb1to5.Name = "rb1to5";
			this.rb1to5.Size = new System.Drawing.Size(86, 17);
			this.rb1to5.TabIndex = 0;
			this.rb1to5.TabStop = true;
			this.rb1to5.Text = "Value 1 To 5";
			this.rb1to5.UseVisualStyleBackColor = true;
			this.rb1to5.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rbNoYesDontkonw
			// 
			this.rbNoYesDontkonw.AutoSize = true;
			this.rbNoYesDontkonw.Location = new System.Drawing.Point(6, 43);
			this.rbNoYesDontkonw.Name = "rbNoYesDontkonw";
			this.rbNoYesDontkonw.Size = new System.Drawing.Size(107, 17);
			this.rbNoYesDontkonw.TabIndex = 1;
			this.rbNoYesDontkonw.TabStop = true;
			this.rbNoYesDontkonw.Text = "NoYesDontKnow";
			this.rbNoYesDontkonw.UseVisualStyleBackColor = true;
			this.rbNoYesDontkonw.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rbNoYes
			// 
			this.rbNoYes.AutoSize = true;
			this.rbNoYes.Location = new System.Drawing.Point(6, 20);
			this.rbNoYes.Name = "rbNoYes";
			this.rbNoYes.Size = new System.Drawing.Size(57, 17);
			this.rbNoYes.TabIndex = 0;
			this.rbNoYes.TabStop = true;
			this.rbNoYes.Text = "NoYes";
			this.rbNoYes.UseVisualStyleBackColor = true;
			this.rbNoYes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// lbTotalQuestions
			// 
			this.lbTotalQuestions.AutoSize = true;
			this.lbTotalQuestions.Location = new System.Drawing.Point(313, 119);
			this.lbTotalQuestions.Name = "lbTotalQuestions";
			this.lbTotalQuestions.Size = new System.Drawing.Size(35, 13);
			this.lbTotalQuestions.TabIndex = 14;
			this.lbTotalQuestions.Text = "label1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(232, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Total Questions:";
			// 
			// cbQuestionList
			// 
			this.cbQuestionNumberDropDownList.FormattingEnabled = true;
			this.cbQuestionNumberDropDownList.Items.AddRange(new object[] {
            "1"});
			this.cbQuestionNumberDropDownList.Location = new System.Drawing.Point(104, 116);
			this.cbQuestionNumberDropDownList.Name = "cbQuestionList";
			this.cbQuestionNumberDropDownList.Size = new System.Drawing.Size(78, 21);
			this.cbQuestionNumberDropDownList.TabIndex = 17;
			this.cbQuestionNumberDropDownList.Text = "1";
			this.cbQuestionNumberDropDownList.SelectedIndexChanged += new System.EventHandler(this.cbQuestionList_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Go To Question:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnPrevQuestion
			// 
			this.btnPrevQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevQuestion.BackgroundImage")));
			this.btnPrevQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPrevQuestion.Location = new System.Drawing.Point(14, 370);
			this.btnPrevQuestion.Name = "btnPrevQuestion";
			this.btnPrevQuestion.Size = new System.Drawing.Size(92, 56);
			this.btnPrevQuestion.TabIndex = 3;
			this.btnPrevQuestion.Text = "\r\n";
			this.btnPrevQuestion.UseVisualStyleBackColor = true;
			this.btnPrevQuestion.Click += new System.EventHandler(this.btnPrevQuestion_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
			this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUpdate.Location = new System.Drawing.Point(224, 371);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(92, 56);
			this.btnUpdate.TabIndex = 19;
			this.btnUpdate.Text = "\r\n";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
			this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAdd.Location = new System.Drawing.Point(119, 370);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(92, 56);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "\r\n";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
			this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRemove.Location = new System.Drawing.Point(329, 370);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(92, 56);
			this.btnRemove.TabIndex = 15;
			this.btnRemove.Text = "\r\n";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
			this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnNext.Location = new System.Drawing.Point(434, 370);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(92, 56);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "\r\n";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNextQuestion_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Author:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(245, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Subject:";
			// 
			// tbAuthor
			// 
			this.tbAuthor.Location = new System.Drawing.Point(51, 10);
			this.tbAuthor.Name = "tbAuthor";
			this.tbAuthor.Size = new System.Drawing.Size(146, 20);
			this.tbAuthor.TabIndex = 22;
			this.tbAuthor.Text = "Krasnal Hałabała";
			this.tbAuthor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// rtbSubject
			// 
			this.rtbSubject.Location = new System.Drawing.Point(297, 10);
			this.rtbSubject.Name = "rtbSubject";
			this.rtbSubject.Size = new System.Drawing.Size(211, 57);
			this.rtbSubject.TabIndex = 23;
			this.rtbSubject.Text = "hebebe\npo dwakroc";
			this.rtbSubject.TextChanged += new System.EventHandler(this.rtbSubject_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.rtbSubject);
			this.groupBox2.Controls.Add(this.tbAuthor);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(12, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(514, 73);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_Paint);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(12, 144);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(514, 45);
			this.trackBar1.TabIndex = 20;
			// 
			// QuestionEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 456);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbQuestionNumberDropDownList);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.lbTotalQuestions);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gbQuestionKind);
			this.Controls.Add(this.btnPrevQuestion);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.trackBar1);
			this.Name = "QuestionEditForm";
			this.Text = "Question Editor";
			this.Load += new System.EventHandler(this.QuestionEditForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.gbQuestionKind.ResumeLayout(false);
			this.gbQuestionKind.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevQuestion;
		private System.Windows.Forms.RichTextBox rtbQuestionContent;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.GroupBox gbQuestionKind;
		private System.Windows.Forms.RadioButton rb1to3;
		private System.Windows.Forms.RadioButton rbNoYesDontkonw;
		private System.Windows.Forms.RadioButton rbNoYes;
		private System.Windows.Forms.RadioButton rb1to100;
		private System.Windows.Forms.RadioButton rb1to10;
		private System.Windows.Forms.RadioButton rb1to5;
		private System.Windows.Forms.Label lbTotalQuestions;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbQuestionNumberDropDownList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox rtbSubject;
		private System.Windows.Forms.TextBox tbAuthor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripMenuItem NewStripMenuItem2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.ToolStripMenuItem exporttxtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToDatabaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem importFromtxtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importFromDatabaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem loginToDatabaseToolStripMenuItem;
	}
}

