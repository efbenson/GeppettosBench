namespace GeppettosBench
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>The main.</summary>
    public partial class Main : Form
    {
        /// <summary>Initializes a new instance of the <see cref="Main"/> class.</summary>
        public Main()
        {
            this.InitializeComponent();
        }

        /// <summary>The tokens textbox text changed.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void TokensTextboxTextChanged(object sender, EventArgs e)
        {
            this.NumberOfItems.Text = this.ValuesTextbox.Text.Split(new char[] { '\n' }).Length.ToString();
        }

        /// <summary>The generate button click.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void GenerateButtonClick(object sender, EventArgs e)
        {
            var output = new StringBuilder();
            this.OutputTextbox.Text = string.Empty;

            if (this.SplitCharForValuesTestbox.Text.Length == 0)
            {
                MessageBox.Show("No split character defined for values.");
                return;
            }

            if (this.TemplateTextbox.Text.Contains(LoopSectionTokenPrefixTextBox.Text))
            {
                var inSection = false;
                var loopText = new StringBuilder();
                var sectionSuffix = this.LoopSectionTokenSuffixTextbox.Text;
                var sectionPrefix = this.LoopSectionTokenPrefixTextBox.Text;

                foreach (var line in this.TemplateTextbox.Text.Split(new char[] { '\n' }))
                {
                    if (line.Contains(sectionSuffix))
                    {
                        if (!inSection)
                        {
                            MessageBox.Show("Section end found without a section start.");
                            return;
                        }
                        else
                        {
                            inSection = false;
                            output.Append(this.ReplaceTokens(loopText.ToString()));
                        }
                    }
                    else if (line.Contains(sectionPrefix))
                    {
                        if (inSection)
                        {
                            MessageBox.Show("New section found without a section end.");
                            return;
                        }
                        else
                        {
                            inSection = true;
                            loopText.Clear();
                        }
                    }
                    else
                    {
                        if (inSection)
                        {
                            loopText.Append(line + "\n");
                        }
                        else
                        {
                            output.Append(line + "\n");
                        }
                    }
                }
            }
            else
            {
                output.Append(this.ReplaceTokens(this.TemplateTextbox.Text));
            }

            this.OutputTextbox.Text = output.ToString();

            this.GenerateTabControl.SelectedIndex = 1;
        }

        /// <summary>The replace tokens.</summary>
        /// <param name="baseTemplate">The template.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private string ReplaceTokens(string baseTemplate)
        {
            var retVal = new StringBuilder();
            var id = 0d;
            var idIncrement = 0d;
            double.TryParse(this.IdTokenStartTextBox.Text, out id);
            double.TryParse(this.IdTokenIncrementTextBox.Text, out idIncrement);

            foreach (var line in this.ValuesTextbox.Text.Split(new char[] { '\n' }))
            {
                var template = baseTemplate;
                var values = line.Split(this.SplitCharForValuesTestbox.Text[0]);

                if (line == string.Empty)
                {
                    continue;
                }

                for (var i = 1; i <= values.Length; i++)
                {
                    template =
                        template.Replace(
                            this.TokenTriggerPrefixTextbox.Text + i + this.TokenTriggerSuffixTextbox.Text,
                            values[i - 1]);
                }

                template =
                    template.Replace(
                        this.TokenTriggerPrefixTextbox.Text + "id" + this.TokenTriggerSuffixTextbox.Text, id.ToString());

                retVal.Append(template + "\n");
                id += idIncrement;
            }

            return retVal.ToString();
        }

        /// <summary>The main load.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void MainLoad(object sender, EventArgs e)
        {
            this.TokensTextboxTextChanged(null, null);
        }

        /// <summary>The load template from file button click.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void LoadTemplateFromFileButtonClick(object sender, EventArgs e)
        {

            var openFileDialog = new OpenFileDialog();

            var selected = openFileDialog.ShowDialog();

            if (selected == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            this.TemplateTextbox.Text = string.Empty;
            var fileStream = openFileDialog.OpenFile();

            using (var reader = new System.IO.StreamReader(fileStream))
            {
                this.TemplateTextbox.Text += reader.ReadToEnd();
            }
            fileStream.Close();
        }

        /// <summary>The Load data from file click.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void LoadDataFromFileClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            var selected = openFileDialog.ShowDialog();

            if (selected == DialogResult.Cancel)
            {
                return;
            }

            this.ValuesTextbox.Text = string.Empty;
            var fileStream = openFileDialog.OpenFile();

            using (var reader = new System.IO.StreamReader(fileStream))
            {
                this.ValuesTextbox.Text += reader.ReadToEnd();
            }
            fileStream.Close();
        }
    }
}
