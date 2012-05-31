namespace GeppettosBench
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumberOfItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValuesTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TemplateTextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GenerateTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TokenTriggerSuffixTextbox = new System.Windows.Forms.TextBox();
            this.TokenTriggerPrefixTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SplitCharForValuesTestbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GenerateTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.NumberOfItems);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ValuesTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // NumberOfItems
            // 
            this.NumberOfItems.AutoSize = true;
            this.NumberOfItems.Location = new System.Drawing.Point(96, 208);
            this.NumberOfItems.Name = "NumberOfItems";
            this.NumberOfItems.Size = new System.Drawing.Size(13, 13);
            this.NumberOfItems.TabIndex = 3;
            this.NumberOfItems.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of items:";
            // 
            // ValuesTextbox
            // 
            this.ValuesTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ValuesTextbox.Location = new System.Drawing.Point(6, 19);
            this.ValuesTextbox.Multiline = true;
            this.ValuesTextbox.Name = "ValuesTextbox";
            this.ValuesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ValuesTextbox.Size = new System.Drawing.Size(294, 179);
            this.ValuesTextbox.TabIndex = 1;
            this.ValuesTextbox.Text = "John|Doe|484.232.5555\r\nJane|Smith|494.343.2222\r\nRobert|Duncan|620.232.6666";
            this.ValuesTextbox.TextChanged += new System.EventHandler(this.TokensTextbox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TemplateTextbox);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template";
            // 
            // TemplateTextbox
            // 
            this.TemplateTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateTextbox.Location = new System.Drawing.Point(6, 19);
            this.TemplateTextbox.Multiline = true;
            this.TemplateTextbox.Name = "TemplateTextbox";
            this.TemplateTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TemplateTextbox.Size = new System.Drawing.Size(337, 203);
            this.TemplateTextbox.TabIndex = 0;
            this.TemplateTextbox.Text = "<div>\r\n<span>Name:%%1%% %%2%%</span>\r\n<br/>\r\n<span>Phone:%%3%%</span>\r\n</div>";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.GenerateTabControl);
            this.groupBox3.Location = new System.Drawing.Point(12, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 247);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate";
            // 
            // GenerateTabControl
            // 
            this.GenerateTabControl.Controls.Add(this.tabPage1);
            this.GenerateTabControl.Controls.Add(this.tabPage2);
            this.GenerateTabControl.Location = new System.Drawing.Point(6, 19);
            this.GenerateTabControl.Name = "GenerateTabControl";
            this.GenerateTabControl.SelectedIndex = 0;
            this.GenerateTabControl.Size = new System.Drawing.Size(649, 228);
            this.GenerateTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GenerateButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TokenTriggerSuffixTextbox);
            this.tabPage1.Controls.Add(this.TokenTriggerPrefixTextbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SplitCharForValuesTestbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(560, 7);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "#";
            // 
            // TokenTriggerSuffixTextbox
            // 
            this.TokenTriggerSuffixTextbox.Location = new System.Drawing.Point(56, 67);
            this.TokenTriggerSuffixTextbox.MaxLength = 5;
            this.TokenTriggerSuffixTextbox.Name = "TokenTriggerSuffixTextbox";
            this.TokenTriggerSuffixTextbox.Size = new System.Drawing.Size(24, 20);
            this.TokenTriggerSuffixTextbox.TabIndex = 4;
            this.TokenTriggerSuffixTextbox.Text = "%%";
            // 
            // TokenTriggerPrefixTextbox
            // 
            this.TokenTriggerPrefixTextbox.Location = new System.Drawing.Point(9, 67);
            this.TokenTriggerPrefixTextbox.MaxLength = 5;
            this.TokenTriggerPrefixTextbox.Name = "TokenTriggerPrefixTextbox";
            this.TokenTriggerPrefixTextbox.Size = new System.Drawing.Size(24, 20);
            this.TokenTriggerPrefixTextbox.TabIndex = 3;
            this.TokenTriggerPrefixTextbox.Text = "%%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Token Trigger";
            // 
            // SplitCharForValuesTestbox
            // 
            this.SplitCharForValuesTestbox.Location = new System.Drawing.Point(9, 28);
            this.SplitCharForValuesTestbox.MaxLength = 1;
            this.SplitCharForValuesTestbox.Name = "SplitCharForValuesTestbox";
            this.SplitCharForValuesTestbox.Size = new System.Drawing.Size(24, 20);
            this.SplitCharForValuesTestbox.TabIndex = 1;
            this.SplitCharForValuesTestbox.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Split character for values";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OutputTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(3, 6);
            this.OutputTextbox.Multiline = true;
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextbox.Size = new System.Drawing.Size(629, 190);
            this.OutputTextbox.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 505);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Geppettos\'s Bench";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.GenerateTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label NumberOfItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValuesTextbox;
        private System.Windows.Forms.TextBox TemplateTextbox;
        private System.Windows.Forms.TabControl GenerateTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SplitCharForValuesTestbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TokenTriggerSuffixTextbox;
        private System.Windows.Forms.TextBox TokenTriggerPrefixTextbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox OutputTextbox;

    }
}

