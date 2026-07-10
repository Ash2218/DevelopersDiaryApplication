namespace DevelopersDiaryApplication
{
    partial class viewError
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
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblErrorContext = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.tbErrorTitle = new System.Windows.Forms.TextBox();
            this.developerDiaryDS1 = new DevelopersDiaryApplication.developerDiaryDS();
            this.rtbErrorMessage = new System.Windows.Forms.RichTextBox();
            this.rtbErrorContext = new System.Windows.Forms.RichTextBox();
            this.rtbExplanationAI = new System.Windows.Forms.RichTextBox();
            this.rtbSolution = new System.Windows.Forms.RichTextBox();
            this.cbAI = new System.Windows.Forms.CheckBox();
            this.cbPersonal = new System.Windows.Forms.CheckBox();
            this.rtbExplanationPersonal = new System.Windows.Forms.RichTextBox();
            this.rbEnableEditing = new System.Windows.Forms.RadioButton();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.errorJoinExplanationJoinSolutionTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ErrorJoinExplanationJoinSolutionTableAdapter();
            this.explanationTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ExplanationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Location = new System.Drawing.Point(24, 40);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(65, 16);
            this.lblErrorTitle.TabIndex = 0;
            this.lblErrorTitle.Text = "Error Title";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(24, 82);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(96, 16);
            this.lblErrorMessage.TabIndex = 1;
            this.lblErrorMessage.Text = "Error Message";
            // 
            // lblErrorContext
            // 
            this.lblErrorContext.AutoSize = true;
            this.lblErrorContext.Location = new System.Drawing.Point(38, 331);
            this.lblErrorContext.Name = "lblErrorContext";
            this.lblErrorContext.Size = new System.Drawing.Size(51, 16);
            this.lblErrorContext.TabIndex = 2;
            this.lblErrorContext.Text = "Context";
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Location = new System.Drawing.Point(35, 553);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(77, 16);
            this.lblExplanation.TabIndex = 5;
            this.lblExplanation.Text = "Explanation";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(38, 782);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(55, 16);
            this.lblSolution.TabIndex = 6;
            this.lblSolution.Text = "Solution";
            // 
            // tbErrorTitle
            // 
            this.tbErrorTitle.Location = new System.Drawing.Point(184, 37);
            this.tbErrorTitle.Name = "tbErrorTitle";
            this.tbErrorTitle.Size = new System.Drawing.Size(408, 22);
            this.tbErrorTitle.TabIndex = 8;
            // 
            // developerDiaryDS1
            // 
            this.developerDiaryDS1.DataSetName = "developerDiaryDS";
            this.developerDiaryDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtbErrorMessage
            // 
            this.rtbErrorMessage.Location = new System.Drawing.Point(175, 82);
            this.rtbErrorMessage.Name = "rtbErrorMessage";
            this.rtbErrorMessage.Size = new System.Drawing.Size(864, 174);
            this.rtbErrorMessage.TabIndex = 9;
            this.rtbErrorMessage.Text = "";
            // 
            // rtbErrorContext
            // 
            this.rtbErrorContext.Location = new System.Drawing.Point(165, 328);
            this.rtbErrorContext.Name = "rtbErrorContext";
            this.rtbErrorContext.Size = new System.Drawing.Size(874, 154);
            this.rtbErrorContext.TabIndex = 10;
            this.rtbErrorContext.Text = "";
            // 
            // rtbExplanationAI
            // 
            this.rtbExplanationAI.Location = new System.Drawing.Point(34, 593);
            this.rtbExplanationAI.Name = "rtbExplanationAI";
            this.rtbExplanationAI.Size = new System.Drawing.Size(767, 141);
            this.rtbExplanationAI.TabIndex = 11;
            this.rtbExplanationAI.Text = "";
            // 
            // rtbSolution
            // 
            this.rtbSolution.Location = new System.Drawing.Point(38, 801);
            this.rtbSolution.Name = "rtbSolution";
            this.rtbSolution.Size = new System.Drawing.Size(1137, 164);
            this.rtbSolution.TabIndex = 12;
            this.rtbSolution.Text = "";
            // 
            // cbAI
            // 
            this.cbAI.AutoSize = true;
            this.cbAI.Location = new System.Drawing.Point(247, 548);
            this.cbAI.Name = "cbAI";
            this.cbAI.Size = new System.Drawing.Size(41, 20);
            this.cbAI.TabIndex = 13;
            this.cbAI.Text = "AI";
            this.cbAI.UseVisualStyleBackColor = true;
            this.cbAI.CheckedChanged += new System.EventHandler(this.cbAI_CheckedChanged);
            // 
            // cbPersonal
            // 
            this.cbPersonal.AutoSize = true;
            this.cbPersonal.Location = new System.Drawing.Point(335, 548);
            this.cbPersonal.Name = "cbPersonal";
            this.cbPersonal.Size = new System.Drawing.Size(83, 20);
            this.cbPersonal.TabIndex = 14;
            this.cbPersonal.Text = "Personal";
            this.cbPersonal.UseVisualStyleBackColor = true;
            this.cbPersonal.CheckedChanged += new System.EventHandler(this.cbPersonal_CheckedChanged);
            // 
            // rtbExplanationPersonal
            // 
            this.rtbExplanationPersonal.Location = new System.Drawing.Point(1018, 593);
            this.rtbExplanationPersonal.Name = "rtbExplanationPersonal";
            this.rtbExplanationPersonal.Size = new System.Drawing.Size(675, 141);
            this.rtbExplanationPersonal.TabIndex = 15;
            this.rtbExplanationPersonal.Text = "";
            // 
            // rbEnableEditing
            // 
            this.rbEnableEditing.AutoSize = true;
            this.rbEnableEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnableEditing.Location = new System.Drawing.Point(1336, 20);
            this.rbEnableEditing.Name = "rbEnableEditing";
            this.rbEnableEditing.Size = new System.Drawing.Size(218, 36);
            this.rbEnableEditing.TabIndex = 16;
            this.rbEnableEditing.TabStop = true;
            this.rbEnableEditing.Text = "Enable editing";
            this.rbEnableEditing.UseVisualStyleBackColor = true;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(1084, 293);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(320, 96);
            this.rtbNotes.TabIndex = 17;
            this.rtbNotes.Text = "";
            // 
            // errorJoinExplanationJoinSolutionTableAdapter1
            // 
            this.errorJoinExplanationJoinSolutionTableAdapter1.ClearBeforeFill = true;
            // 
            // explanationTableAdapter1
            // 
            this.explanationTableAdapter1.ClearBeforeFill = true;
            // 
            // viewError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.rbEnableEditing);
            this.Controls.Add(this.rtbExplanationPersonal);
            this.Controls.Add(this.cbPersonal);
            this.Controls.Add(this.cbAI);
            this.Controls.Add(this.rtbSolution);
            this.Controls.Add(this.rtbExplanationAI);
            this.Controls.Add(this.rtbErrorContext);
            this.Controls.Add(this.rtbErrorMessage);
            this.Controls.Add(this.tbErrorTitle);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.lblErrorContext);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblErrorTitle);
            this.Name = "viewError";
            this.Text = "viewError";
            this.Load += new System.EventHandler(this.viewError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblErrorContext;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.TextBox tbErrorTitle;
        private System.Windows.Forms.RichTextBox rtbErrorMessage;
        private System.Windows.Forms.RichTextBox rtbErrorContext;
        private System.Windows.Forms.RichTextBox rtbExplanationAI;
        private System.Windows.Forms.RichTextBox rtbSolution;
        private System.Windows.Forms.CheckBox cbAI;
        private System.Windows.Forms.CheckBox cbPersonal;
        private System.Windows.Forms.RichTextBox rtbExplanationPersonal;
        private System.Windows.Forms.RadioButton rbEnableEditing;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private developerDiaryDSTableAdapters.ErrorJoinExplanationJoinSolutionTableAdapter errorJoinExplanationJoinSolutionTableAdapter1;
        private developerDiaryDS developerDiaryDS1;
        private developerDiaryDSTableAdapters.ExplanationTableAdapter explanationTableAdapter1;
    }
}