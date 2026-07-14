namespace DevelopersDiaryApplication
{
    partial class viewCodeSnippet
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
            this.lblCodeHeading = new System.Windows.Forms.Label();
            this.lblExplanationHeading = new System.Windows.Forms.Label();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.pnlExplanation = new System.Windows.Forms.Panel();
            this.lblexplanation = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblCodeTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.cbShowNotes = new System.Windows.Forms.CheckBox();
            this.codeSnippetJoinTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.CodeSnippetJoinTableAdapter();
            this.developerDiaryDS1 = new DevelopersDiaryApplication.developerDiaryDS();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.cbEnableEditing = new System.Windows.Forms.CheckBox();
            this.rtbExplanation = new System.Windows.Forms.RichTextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.codeSnippetTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.CodeSnippetTableAdapter();
            this.pnlCode.SuspendLayout();
            this.pnlExplanation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeHeading
            // 
            this.lblCodeHeading.AutoSize = true;
            this.lblCodeHeading.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeHeading.Location = new System.Drawing.Point(391, 223);
            this.lblCodeHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeHeading.Name = "lblCodeHeading";
            this.lblCodeHeading.Size = new System.Drawing.Size(68, 31);
            this.lblCodeHeading.TabIndex = 1;
            this.lblCodeHeading.Text = "Code";
            // 
            // lblExplanationHeading
            // 
            this.lblExplanationHeading.AutoSize = true;
            this.lblExplanationHeading.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanationHeading.Location = new System.Drawing.Point(1443, 223);
            this.lblExplanationHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExplanationHeading.Name = "lblExplanationHeading";
            this.lblExplanationHeading.Size = new System.Drawing.Size(142, 31);
            this.lblExplanationHeading.TabIndex = 2;
            this.lblExplanationHeading.Text = "Explanation";
            // 
            // pnlCode
            // 
            this.pnlCode.AutoScroll = true;
            this.pnlCode.BackColor = System.Drawing.Color.Transparent;
            this.pnlCode.Controls.Add(this.lblCode);
            this.pnlCode.Location = new System.Drawing.Point(66, 308);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(823, 349);
            this.pnlCode.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(3, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(65, 28);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "label1";
            // 
            // pnlExplanation
            // 
            this.pnlExplanation.AutoScroll = true;
            this.pnlExplanation.BackColor = System.Drawing.Color.Transparent;
            this.pnlExplanation.Controls.Add(this.lblexplanation);
            this.pnlExplanation.Location = new System.Drawing.Point(1017, 308);
            this.pnlExplanation.Name = "pnlExplanation";
            this.pnlExplanation.Size = new System.Drawing.Size(805, 349);
            this.pnlExplanation.TabIndex = 4;
            // 
            // lblexplanation
            // 
            this.lblexplanation.AutoSize = true;
            this.lblexplanation.Location = new System.Drawing.Point(3, 0);
            this.lblexplanation.Name = "lblexplanation";
            this.lblexplanation.Size = new System.Drawing.Size(65, 28);
            this.lblexplanation.TabIndex = 0;
            this.lblexplanation.Text = "label1";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(59, 21);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(100, 38);
            this.lblProjectName.TabIndex = 5;
            this.lblProjectName.Text = "label1";
            // 
            // lblCodeTitle
            // 
            this.lblCodeTitle.AutoSize = true;
            this.lblCodeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeTitle.Location = new System.Drawing.Point(819, 133);
            this.lblCodeTitle.Name = "lblCodeTitle";
            this.lblCodeTitle.Size = new System.Drawing.Size(113, 45);
            this.lblCodeTitle.TabIndex = 6;
            this.lblCodeTitle.Text = "label2";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(856, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 38);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "label3";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(1422, 9);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(100, 38);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "label4";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(50, 880);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(1833, 94);
            this.rtbNotes.TabIndex = 9;
            this.rtbNotes.Text = "";
            // 
            // cbShowNotes
            // 
            this.cbShowNotes.AutoSize = true;
            this.cbShowNotes.BackColor = System.Drawing.Color.Transparent;
            this.cbShowNotes.Location = new System.Drawing.Point(50, 842);
            this.cbShowNotes.Name = "cbShowNotes";
            this.cbShowNotes.Size = new System.Drawing.Size(135, 32);
            this.cbShowNotes.TabIndex = 10;
            this.cbShowNotes.Text = "Show notes";
            this.cbShowNotes.UseVisualStyleBackColor = false;
            this.cbShowNotes.CheckedChanged += new System.EventHandler(this.cbShowNotes_CheckedChanged);
            // 
            // codeSnippetJoinTableAdapter1
            // 
            this.codeSnippetJoinTableAdapter1.ClearBeforeFill = true;
            // 
            // developerDiaryDS1
            // 
            this.developerDiaryDS1.DataSetName = "developerDiaryDS";
            this.developerDiaryDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtbCode
            // 
            this.rtbCode.Location = new System.Drawing.Point(66, 691);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.Size = new System.Drawing.Size(823, 96);
            this.rtbCode.TabIndex = 11;
            this.rtbCode.Text = "";
            // 
            // cbEnableEditing
            // 
            this.cbEnableEditing.AutoSize = true;
            this.cbEnableEditing.Location = new System.Drawing.Point(1426, 105);
            this.cbEnableEditing.Name = "cbEnableEditing";
            this.cbEnableEditing.Size = new System.Drawing.Size(159, 32);
            this.cbEnableEditing.TabIndex = 12;
            this.cbEnableEditing.Text = "Enable Editing";
            this.cbEnableEditing.UseVisualStyleBackColor = true;
            this.cbEnableEditing.CheckedChanged += new System.EventHandler(this.cbEnableEditing_CheckedChanged);
            // 
            // rtbExplanation
            // 
            this.rtbExplanation.Location = new System.Drawing.Point(1038, 691);
            this.rtbExplanation.Name = "rtbExplanation";
            this.rtbExplanation.Size = new System.Drawing.Size(823, 96);
            this.rtbExplanation.TabIndex = 13;
            this.rtbExplanation.Text = "";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(1175, 105);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(173, 37);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // codeSnippetTableAdapter1
            // 
            this.codeSnippetTableAdapter1.ClearBeforeFill = true;
            // 
            // viewCodeSnippet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DevelopersDiaryApplication.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.rtbExplanation);
            this.Controls.Add(this.cbEnableEditing);
            this.Controls.Add(this.rtbCode);
            this.Controls.Add(this.cbShowNotes);
            this.Controls.Add(this.lblExplanationHeading);
            this.Controls.Add(this.lblCodeHeading);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCodeTitle);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.pnlExplanation);
            this.Controls.Add(this.pnlCode);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "viewCodeSnippet";
            this.Text = "viewCodeSnippet";
            this.Load += new System.EventHandler(this.viewCodeSnippet_Load);
            this.pnlCode.ResumeLayout(false);
            this.pnlCode.PerformLayout();
            this.pnlExplanation.ResumeLayout(false);
            this.pnlExplanation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodeHeading;
        private System.Windows.Forms.Label lblExplanationHeading;
        private System.Windows.Forms.Panel pnlCode;
        private System.Windows.Forms.Panel pnlExplanation;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblCodeTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.CheckBox cbShowNotes;
        private developerDiaryDSTableAdapters.CodeSnippetJoinTableAdapter codeSnippetJoinTableAdapter1;
        private developerDiaryDS developerDiaryDS1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblexplanation;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.CheckBox cbEnableEditing;
        private System.Windows.Forms.RichTextBox rtbExplanation;
        private System.Windows.Forms.Button btnSaveChanges;
        private developerDiaryDSTableAdapters.CodeSnippetTableAdapter codeSnippetTableAdapter1;
    }
}