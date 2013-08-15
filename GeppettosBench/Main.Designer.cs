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
            this.LoadDataFromFile = new System.Windows.Forms.Button();
            this.NumberOfItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValuesTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LoadTemplateFromFileButton = new System.Windows.Forms.Button();
            this.TemplateTextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GenerateTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IdTokenIncrementTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IdTokenStartTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LoopSectionTokenSuffixTextbox = new System.Windows.Forms.TextBox();
            this.LoopSectionTokenPrefixTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TokenTriggerSuffixTextbox = new System.Windows.Forms.TextBox();
            this.TokenTriggerPrefixTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SplitCharForValuesTestbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SaveOutputButton = new System.Windows.Forms.Button();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LoadDataFromFile);
            this.groupBox1.Controls.Add(this.NumberOfItems);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ValuesTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // LoadDataFromFile
            // 
            this.LoadDataFromFile.Location = new System.Drawing.Point(7, 17);
            this.LoadDataFromFile.Name = "LoadDataFromFile";
            this.LoadDataFromFile.Size = new System.Drawing.Size(89, 23);
            this.LoadDataFromFile.TabIndex = 4;
            this.LoadDataFromFile.Text = "Load From File";
            this.LoadDataFromFile.UseVisualStyleBackColor = true;
            this.LoadDataFromFile.Click += new System.EventHandler(this.LoadDataFromFileClick);
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
            this.ValuesTextbox.Location = new System.Drawing.Point(6, 41);
            this.ValuesTextbox.Multiline = true;
            this.ValuesTextbox.Name = "ValuesTextbox";
            this.ValuesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ValuesTextbox.Size = new System.Drawing.Size(294, 164);
            this.ValuesTextbox.TabIndex = 1;
            this.ValuesTextbox.Text = "John|Doe|484.232.5555\r\nJane|Smith|494.343.2222\r\nRobert|Duncan|620.232.6666";
            this.ValuesTextbox.WordWrap = false;
            this.ValuesTextbox.TextChanged += new System.EventHandler(this.TokensTextboxTextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LoadTemplateFromFileButton);
            this.groupBox2.Controls.Add(this.TemplateTextbox);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template";
            // 
            // LoadTemplateFromFileButton
            // 
            this.LoadTemplateFromFileButton.Location = new System.Drawing.Point(6, 17);
            this.LoadTemplateFromFileButton.Name = "LoadTemplateFromFileButton";
            this.LoadTemplateFromFileButton.Size = new System.Drawing.Size(89, 23);
            this.LoadTemplateFromFileButton.TabIndex = 1;
            this.LoadTemplateFromFileButton.Text = "Load From File";
            this.LoadTemplateFromFileButton.UseVisualStyleBackColor = true;
            this.LoadTemplateFromFileButton.Click += new System.EventHandler(this.LoadTemplateFromFileButtonClick);
            // 
            // TemplateTextbox
            // 
            this.TemplateTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateTextbox.Location = new System.Drawing.Point(6, 41);
            this.TemplateTextbox.Multiline = true;
            this.TemplateTextbox.Name = "TemplateTextbox";
            this.TemplateTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TemplateTextbox.Size = new System.Drawing.Size(337, 187);
            this.TemplateTextbox.TabIndex = 0;
            this.TemplateTextbox.Text = "<div>\r\n<<@\r\n<span> Employee #%%id%%</span>\r\n<span>Name:%%1%% %%2%%</span>\r\n<br/>\r" +
    "\n@>>\r\n<<@\r\n<span> Employee #%%id%%</span>\r\n<span>Phone:%%3%%</span>\r\n@>>\r\n</div>" +
    "";
            this.TemplateTextbox.WordWrap = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.GenerateTabControl);
            this.groupBox3.Controls.Add(this.GenerateButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate";
            // 
            // GenerateTabControl
            // 
            this.GenerateTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateTabControl.Controls.Add(this.tabPage1);
            this.GenerateTabControl.Controls.Add(this.tabPage2);
            this.GenerateTabControl.Location = new System.Drawing.Point(6, 48);
            this.GenerateTabControl.Name = "GenerateTabControl";
            this.GenerateTabControl.SelectedIndex = 0;
            this.GenerateTabControl.Size = new System.Drawing.Size(649, 218);
            this.GenerateTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.IdTokenIncrementTextBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.IdTokenStartTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.LoopSectionTokenSuffixTextbox);
            this.tabPage1.Controls.Add(this.LoopSectionTokenPrefixTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TokenTriggerSuffixTextbox);
            this.tabPage1.Controls.Add(this.TokenTriggerPrefixTextbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SplitCharForValuesTestbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IdTokenIncrementTextBox
            // 
            this.IdTokenIncrementTextBox.Location = new System.Drawing.Point(222, 152);
            this.IdTokenIncrementTextBox.MaxLength = 5;
            this.IdTokenIncrementTextBox.Name = "IdTokenIncrementTextBox";
            this.IdTokenIncrementTextBox.Size = new System.Drawing.Size(37, 20);
            this.IdTokenIncrementTextBox.TabIndex = 16;
            this.IdTokenIncrementTextBox.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Increments By";
            // 
            // IdTokenStartTextBox
            // 
            this.IdTokenStartTextBox.Location = new System.Drawing.Point(80, 155);
            this.IdTokenStartTextBox.MaxLength = 5;
            this.IdTokenStartTextBox.Name = "IdTokenStartTextBox";
            this.IdTokenStartTextBox.Size = new System.Drawing.Size(41, 20);
            this.IdTokenStartTextBox.TabIndex = 14;
            this.IdTokenStartTextBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Starts at";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Id Token";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "End Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Start Section";
            // 
            // LoopSectionTokenSuffixTextbox
            // 
            this.LoopSectionTokenSuffixTextbox.Location = new System.Drawing.Point(216, 116);
            this.LoopSectionTokenSuffixTextbox.MaxLength = 5;
            this.LoopSectionTokenSuffixTextbox.Name = "LoopSectionTokenSuffixTextbox";
            this.LoopSectionTokenSuffixTextbox.Size = new System.Drawing.Size(37, 20);
            this.LoopSectionTokenSuffixTextbox.TabIndex = 9;
            this.LoopSectionTokenSuffixTextbox.Text = "@>>";
            // 
            // LoopSectionTokenPrefixTextBox
            // 
            this.LoopSectionTokenPrefixTextBox.Location = new System.Drawing.Point(80, 116);
            this.LoopSectionTokenPrefixTextBox.MaxLength = 5;
            this.LoopSectionTokenPrefixTextBox.Name = "LoopSectionTokenPrefixTextBox";
            this.LoopSectionTokenPrefixTextBox.Size = new System.Drawing.Size(41, 20);
            this.LoopSectionTokenPrefixTextBox.TabIndex = 8;
            this.LoopSectionTokenPrefixTextBox.Text = "<<@";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loop Section";
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Split character for values";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SaveOutputButton);
            this.tabPage2.Controls.Add(this.OutputTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SaveOutputButton
            // 
            this.SaveOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveOutputButton.Location = new System.Drawing.Point(557, 163);
            this.SaveOutputButton.Name = "SaveOutputButton";
            this.SaveOutputButton.Size = new System.Drawing.Size(75, 23);
            this.SaveOutputButton.TabIndex = 7;
            this.SaveOutputButton.Text = "Save Output";
            this.SaveOutputButton.UseVisualStyleBackColor = true;
            this.SaveOutputButton.Click += new System.EventHandler(this.SaveOutputButtonClick);
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextbox.Location = new System.Drawing.Point(3, 6);
            this.OutputTextbox.Multiline = true;
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextbox.Size = new System.Drawing.Size(629, 153);
            this.OutputTextbox.TabIndex = 0;
            this.OutputTextbox.WordWrap = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(573, 19);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButtonClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 524);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Geppettos\'s Bench";
            this.Load += new System.EventHandler(this.MainLoad);
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
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox OutputTextbox;
        private System.Windows.Forms.Button LoadTemplateFromFileButton;
        private System.Windows.Forms.Button LoadDataFromFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoopSectionTokenSuffixTextbox;
        private System.Windows.Forms.TextBox LoopSectionTokenPrefixTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdTokenIncrementTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdTokenStartTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SaveOutputButton;

    }
}

