using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyGuide
{
    public partial class StudyForm : Form
    {
        public StudyForm()
        {
            InitializeComponent();

        }

        public string getConfig(string appKey)
        {
            string appKeyValue = null;
            int idx = 0;
            bool found = false;

            for (idx = 0; (idx < 3 && found == false); idx++)
            {
                switch (idx)
                {
                    case 0:

                        if (ConfigurationManager.ConnectionStrings[appKey] != null)
                        {
                            appKeyValue = ConfigurationManager.ConnectionStrings[appKey].ConnectionString;
                            found = true;
                        }

                        break;

                    case 1:

                        if (ConfigurationManager.AppSettings[appKey] != null)
                        {
                            appKeyValue = ConfigurationManager.AppSettings[appKey].ToString();
                            found = true;
                        }

                        break;

                    default:
                        throw new SystemException("[" + appKey + "] not defined in App.config");


                }
            }

            return (appKeyValue);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //folderBrowserDialog.SelectedPath = "C:\\Users\\mikeb\\Desktop";

            //DialogResult browseResult = folderBrowserDialog.ShowDialog();

            //string folderPath = null; 

            //switch(browseResult == DialogResult.OK)
            //{
            //    case true:
            //        break; 
            //}

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = getConfig("RootLocation");

            DialogResult fileResult = openFileDialog.ShowDialog();

            switch (fileResult)
            {
                case DialogResult.OK:
                    jsonFileTextBox.Text = openFileDialog.FileName;
                    break;
            }
        }

        private void jsonFileTextBox_TextChanged(object sender, EventArgs e)
        {

            Size textBoxSize = TextRenderer.MeasureText(this.jsonFileTextBox.Text, this.jsonFileTextBox.Font);
            this.jsonFileTextBox.Size = textBoxSize;

            this.jsonFileTextBox.Show();

            switch (String.IsNullOrEmpty(this.jsonFileTextBox.Text))
            {
                case true:
                    MessageBox.Show("Please select a file to read");
                    break;

                case false:
                    this.readFileButton.Show();
                    break;
            }
        }

        private void read_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Reading your file");

        }
    }
}
