namespace SurveyClient
{
	partial class MySlider
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// trackBar1
			// 
			this.trackBar1.AutoSize = false;
			this.trackBar1.LargeChange = 25;
			this.trackBar1.Location = new System.Drawing.Point(3, 46);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(321, 66);
			this.trackBar1.SmallChange = 10;
			this.trackBar1.TabIndex = 0;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// MySlider
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.trackBar1);
			this.Name = "MySlider";
			this.Size = new System.Drawing.Size(327, 150);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TrackBar trackBar1;
	}
}
