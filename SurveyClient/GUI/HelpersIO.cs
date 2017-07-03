using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SurveyEditor;




namespace SurveyClient
{
	public partial class QuestionForm : Form
	{
		private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "Survey files (*.srv)|*.srv";
			saveFileDialog1.FilterIndex = 1;
			saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\MyAnsweredSurveys"; //zrob podkatalog jakis
			if (!Directory.Exists(saveFileDialog1.InitialDirectory))
			{
				Directory.CreateDirectory(saveFileDialog1.InitialDirectory);
			}
			saveFileDialog1.RestoreDirectory = true;
			saveFileDialog1.DefaultExt = ".srv";
			saveFileDialog1.FileName = "Survey1"; //dodaj date albo jakis ciag
			Stream myStream;

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				_currentSavedPath = Path.GetDirectoryName(saveFileDialog1.FileName);
				_currentSavedFileName = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
				if ((myStream = saveFileDialog1.OpenFile()) != null)
				{
					ZapiszDoPliku(myStream);
				}
			}
		}

		private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_currentSavedFileName == null)
			{
				zapiszJakoToolStripMenuItem_Click(sender, e);
			}
			else
			{
				FileStream myStream = new FileStream(_currentSavedFileName + ".srv", FileMode.Create);
				ZapiszDoPliku(myStream);
			}
		}

		private void ZapiszDoPliku(Stream myStream)
		{
			//zapisywanie pliku .srv
			using (StreamWriter writer = new StreamWriter(myStream, System.Text.Encoding.UTF8))
			{
				String json = JsonConvert.SerializeObject(MySurvey, Formatting.Indented);
				writer.WriteLine(json);
			}
			myStream.Close();
			//if (File.Exists(_currentSavedFileName + ".srv"))
			//{
			//	File.Copy(_currentSavedFileName + ".srvpr", _currentSavedFileName + "\\" + _currentSavedFileName + ".npr", true);
			//	File.Delete(_currentSavedFileName + ".npr");
			//}


			this.Text = _title + " - " + _currentSavedFileName;
		}
		private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Stream myStream = null;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			//openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "Survey files (*.srv)|*.srv";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((myStream = openFileDialog1.OpenFile()) != null)
					{
						using (StreamReader reader = new StreamReader(myStream, System.Text.Encoding.UTF8))
						{
							// Insert code to read the stream here.
							while (!reader.EndOfStream)
							{
								String json = reader.ReadToEnd();
								SurveyClass importedSurvey = JsonConvert.DeserializeObject<SurveyClass>(json);
								MySurvey = importedSurvey;
								_curQuestionList = MySurvey.QuestionList;
							}
							myStream.Close();

							curIdx = 0;
							//int i = 1;
							//cbQuestionNumberDropDownList.Items.Clear();
							//foreach (var q in _curQuestionList)
							//{
							//	cbQuestionNumberDropDownList.Items.Add(i);
							//	i++;
							//}
							//UpdateForm();

							_currentSavedPath = Path.GetDirectoryName(openFileDialog1.FileName);
							_currentSavedFileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
							this.Text = _title + " - " + _currentSavedFileName;
							UpdateForm();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message + ex.StackTrace);
				}
			}
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
