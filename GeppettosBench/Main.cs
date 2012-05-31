using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeppettosBench
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void TokensTextbox_TextChanged(object sender, EventArgs e)
        {
            this.NumberOfItems.Text = ValuesTextbox.Text.Split(new char[] { '\n' }).Length.ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (this.SplitCharForValuesTestbox.Text.Length == 0){
                MessageBox.Show("No split character defined for values.");
                return;
            }

            OutputTextbox.Text = "";

            foreach(string line in ValuesTextbox.Text.Split(new char[] { '\n' })){
                var values = line.Split(this.SplitCharForValuesTestbox.Text[0]);
                var template = this.TemplateTextbox.Text;
                if (line != "")
                {
                    for (var i = 1; i <= values.Length; i++)
                    {
                        template = template.Replace(this.TokenTriggerPrefixTextbox.Text + i + this.TokenTriggerSuffixTextbox.Text,
                                                    values[i - 1]);
                    }
                    OutputTextbox.Text += template + "\n";
                }
            }

            this.GenerateTabControl.SelectedIndex = 1;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            TokensTextbox_TextChanged(null, null);
        }

        private void LoadTemplateFromFileButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            var selected = openFileDialog.ShowDialog();

            if (selected != System.Windows.Forms.DialogResult.Cancel)
            {
                TemplateTextbox.Text = "";
                var fileStream = openFileDialog.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    // Read the first line from the file and write it the textbox.
                    TemplateTextbox.Text += reader.ReadToEnd();
                }
                fileStream.Close();

            }
        }
    }
}
