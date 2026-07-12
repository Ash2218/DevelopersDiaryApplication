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
            this.pnlExplanation = new System.Windows.Forms.Panel();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblCodeTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.cbShowNotes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCodeHeading
            // 
            this.lblCodeHeading.AutoSize = true;
            this.lblCodeHeading.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeHeading.Location = new System.Drawing.Point(403, 167);
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
            this.lblExplanationHeading.Location = new System.Drawing.Point(1345, 167);
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
            this.pnlCode.Location = new System.Drawing.Point(64, 226);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(857, 519);
            this.pnlCode.TabIndex = 3;
            // 
            // pnlExplanation
            // 
            this.pnlExplanation.AutoScroll = true;
            this.pnlExplanation.BackColor = System.Drawing.Color.Transparent;
            this.pnlExplanation.Location = new System.Drawing.Point(1015, 226);
            this.pnlExplanation.Name = "pnlExplanation";
            this.pnlExplanation.Size = new System.Drawing.Size(857, 519);
            this.pnlExplanation.TabIndex = 4;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Location = new System.Drawing.Point(59, 21);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(65, 28);
            this.lblProjectName.TabIndex = 5;
            this.lblProjectName.Text = "label1";
            // 
            // lblCodeTitle
            // 
            this.lblCodeTitle.AutoSize = true;
            this.lblCodeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeTitle.Location = new System.Drawing.Point(895, 85);
            this.lblCodeTitle.Name = "lblCodeTitle";
            this.lblCodeTitle.Size = new System.Drawing.Size(65, 28);
            this.lblCodeTitle.TabIndex = 6;
            this.lblCodeTitle.Text = "label2";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Location = new System.Drawing.Point(1351, 21);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 28);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "label3";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguage.Location = new System.Drawing.Point(1752, 21);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(65, 28);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "label4";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(50, 840);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(1833, 173);
            this.rtbNotes.TabIndex = 9;
            this.rtbNotes.Text = "";
            // 
            // cbShowNotes
            // 
            this.cbShowNotes.AutoSize = true;
            this.cbShowNotes.BackColor = System.Drawing.Color.Transparent;
            this.cbShowNotes.Location = new System.Drawing.Point(50, 792);
            this.cbShowNotes.Name = "cbShowNotes";
            this.cbShowNotes.Size = new System.Drawing.Size(135, 32);
            this.cbShowNotes.TabIndex = 10;
            this.cbShowNotes.Text = "Show notes";
            this.cbShowNotes.UseVisualStyleBackColor = false;
            this.cbShowNotes.CheckedChanged += new System.EventHandler(this.cbShowNotes_CheckedChanged);
            // 
            // viewCodeSnippet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DevelopersDiaryApplication.Properties.Resources.Screenshot_2026_07_12_153604;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.cbShowNotes);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCodeTitle);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.pnlExplanation);
            this.Controls.Add(this.pnlCode);
            this.Controls.Add(this.lblExplanationHeading);
            this.Controls.Add(this.lblCodeHeading);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "viewCodeSnippet";
            this.Text = "viewCodeSnippet";
            this.Load += new System.EventHandler(this.viewCodeSnippet_Load);
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
    }
}