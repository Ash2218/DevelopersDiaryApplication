namespace DevelopersDiaryApplication
{
    partial class AddCodeSnippet
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
            this.tbCodeTitle = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblCodeTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.rtbExplanation = new System.Windows.Forms.RichTextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.pbGenerateExplanation = new System.Windows.Forms.PictureBox();
            this.cbAddNotes = new System.Windows.Forms.CheckBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnSaveCodeSnippet = new System.Windows.Forms.Button();
            this.developerDiaryDS1 = new DevelopersDiaryApplication.developerDiaryDS();
            this.categoryTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.CategoryTableAdapter();
            this.programmingLanguageTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.rbLineByLine = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.codeSnippetTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.CodeSnippetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerateExplanation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodeTitle
            // 
            this.tbCodeTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodeTitle.Location = new System.Drawing.Point(84, 82);
            this.tbCodeTitle.Name = "tbCodeTitle";
            this.tbCodeTitle.Size = new System.Drawing.Size(475, 43);
            this.tbCodeTitle.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(647, 80);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(471, 45);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.Text = "Select a category";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(1172, 80);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(456, 45);
            this.cmbLanguage.TabIndex = 2;
            this.cmbLanguage.Text = "Select a programming language";
            // 
            // lblCodeTitle
            // 
            this.lblCodeTitle.AutoSize = true;
            this.lblCodeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeTitle.Location = new System.Drawing.Point(77, 28);
            this.lblCodeTitle.Name = "lblCodeTitle";
            this.lblCodeTitle.Size = new System.Drawing.Size(71, 38);
            this.lblCodeTitle.TabIndex = 3;
            this.lblCodeTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1174, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Programming language";
            // 
            // rtbCode
            // 
            this.rtbCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCode.Location = new System.Drawing.Point(84, 188);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.Size = new System.Drawing.Size(1544, 309);
            this.rtbCode.TabIndex = 6;
            this.rtbCode.Text = "";
            // 
            // rtbExplanation
            // 
            this.rtbExplanation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExplanation.Location = new System.Drawing.Point(84, 547);
            this.rtbExplanation.Name = "rtbExplanation";
            this.rtbExplanation.Size = new System.Drawing.Size(1327, 249);
            this.rtbExplanation.TabIndex = 7;
            this.rtbExplanation.Text = "";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(86, 147);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(83, 38);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Code";
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.BackColor = System.Drawing.Color.Transparent;
            this.lblExplanation.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(86, 500);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(166, 38);
            this.lblExplanation.TabIndex = 9;
            this.lblExplanation.Text = "Explanation";
            // 
            // pbGenerateExplanation
            // 
            this.pbGenerateExplanation.BackColor = System.Drawing.Color.Transparent;
            this.pbGenerateExplanation.Image = global::DevelopersDiaryApplication.Properties.Resources.btnGenerate;
            this.pbGenerateExplanation.Location = new System.Drawing.Point(1417, 646);
            this.pbGenerateExplanation.Name = "pbGenerateExplanation";
            this.pbGenerateExplanation.Size = new System.Drawing.Size(219, 130);
            this.pbGenerateExplanation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGenerateExplanation.TabIndex = 10;
            this.pbGenerateExplanation.TabStop = false;
            this.pbGenerateExplanation.Click += new System.EventHandler(this.pbGenerateExplanation_Click);
            // 
            // cbAddNotes
            // 
            this.cbAddNotes.AutoSize = true;
            this.cbAddNotes.BackColor = System.Drawing.Color.Transparent;
            this.cbAddNotes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddNotes.Location = new System.Drawing.Point(84, 802);
            this.cbAddNotes.Name = "cbAddNotes";
            this.cbAddNotes.Size = new System.Drawing.Size(141, 35);
            this.cbAddNotes.TabIndex = 12;
            this.cbAddNotes.Text = "Add notes";
            this.cbAddNotes.UseVisualStyleBackColor = false;
            this.cbAddNotes.CheckedChanged += new System.EventHandler(this.cbAddNotes_CheckedChanged);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(84, 843);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(1327, 127);
            this.rtbNotes.TabIndex = 13;
            this.rtbNotes.Text = "";
            // 
            // btnSaveCodeSnippet
            // 
            this.btnSaveCodeSnippet.Location = new System.Drawing.Point(1474, 894);
            this.btnSaveCodeSnippet.Name = "btnSaveCodeSnippet";
            this.btnSaveCodeSnippet.Size = new System.Drawing.Size(154, 76);
            this.btnSaveCodeSnippet.TabIndex = 14;
            this.btnSaveCodeSnippet.Text = "Save";
            this.btnSaveCodeSnippet.UseVisualStyleBackColor = true;
            this.btnSaveCodeSnippet.Click += new System.EventHandler(this.btnSaveCodeSnippet_Click);
            // 
            // developerDiaryDS1
            // 
            this.developerDiaryDS1.DataSetName = "developerDiaryDS";
            this.developerDiaryDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // programmingLanguageTableAdapter1
            // 
            this.programmingLanguageTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox1.Location = new System.Drawing.Point(565, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox2.Location = new System.Drawing.Point(1124, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox3.Location = new System.Drawing.Point(1634, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox4.Location = new System.Drawing.Point(1634, 188);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox5.Location = new System.Drawing.Point(1442, 547);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 49;
            this.pictureBox5.TabStop = false;
            // 
            // rbLineByLine
            // 
            this.rbLineByLine.AutoSize = true;
            this.rbLineByLine.BackColor = System.Drawing.Color.Transparent;
            this.rbLineByLine.Location = new System.Drawing.Point(1433, 599);
            this.rbLineByLine.Name = "rbLineByLine";
            this.rbLineByLine.Size = new System.Drawing.Size(94, 21);
            this.rbLineByLine.TabIndex = 50;
            this.rbLineByLine.TabStop = true;
            this.rbLineByLine.Text = "Line by line";
            this.rbLineByLine.UseVisualStyleBackColor = false;
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.BackColor = System.Drawing.Color.Transparent;
            this.rbGeneral.Location = new System.Drawing.Point(1554, 599);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(74, 21);
            this.rbGeneral.TabIndex = 51;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "General";
            this.rbGeneral.UseVisualStyleBackColor = false;
            // 
            // codeSnippetTableAdapter1
            // 
            this.codeSnippetTableAdapter1.ClearBeforeFill = true;
            // 
            // AddCodeSnippet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DevelopersDiaryApplication.Properties.Resources.blue_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1684, 1055);
            this.Controls.Add(this.rbGeneral);
            this.Controls.Add(this.rbLineByLine);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSaveCodeSnippet);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.cbAddNotes);
            this.Controls.Add(this.pbGenerateExplanation);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.rtbExplanation);
            this.Controls.Add(this.rtbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodeTitle);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.tbCodeTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddCodeSnippet";
            this.Text = "AddCodeSnippet";
            this.Load += new System.EventHandler(this.AddCodeSnippet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerateExplanation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodeTitle;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblCodeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.RichTextBox rtbExplanation;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.PictureBox pbGenerateExplanation;
        private System.Windows.Forms.CheckBox cbAddNotes;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnSaveCodeSnippet;
        private developerDiaryDS developerDiaryDS1;
        private developerDiaryDSTableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter programmingLanguageTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton rbLineByLine;
        private System.Windows.Forms.RadioButton rbGeneral;
        private developerDiaryDSTableAdapters.CodeSnippetTableAdapter codeSnippetTableAdapter1;
    }
}