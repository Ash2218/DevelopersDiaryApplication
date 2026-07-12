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
            this.rtbErrorMessage = new System.Windows.Forms.RichTextBox();
            this.rtbErrorContext = new System.Windows.Forms.RichTextBox();
            this.rtbExplanationAI = new System.Windows.Forms.RichTextBox();
            this.rtbSolution = new System.Windows.Forms.RichTextBox();
            this.cbAI = new System.Windows.Forms.CheckBox();
            this.cbPersonal = new System.Windows.Forms.CheckBox();
            this.rtbExplanationPersonal = new System.Windows.Forms.RichTextBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbEnableEditing = new System.Windows.Forms.CheckBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.developerDiaryDS1 = new DevelopersDiaryApplication.developerDiaryDS();
            this.errorJoinExplanationJoinSolutionTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ErrorJoinExplanationJoinSolutionTableAdapter();
            this.explanationTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ExplanationTableAdapter();
            this.programmingLanguageTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter();
            this.errorTypeTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ErrorTypeTableAdapter();
            this.cmbErrorType = new System.Windows.Forms.ComboBox();
            this.lblErrorType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTitle.Location = new System.Drawing.Point(24, 37);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(113, 31);
            this.lblErrorTitle.TabIndex = 0;
            this.lblErrorTitle.Text = "Error Title";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(28, 113);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(160, 31);
            this.lblErrorMessage.TabIndex = 1;
            this.lblErrorMessage.Text = "Error Message";
            // 
            // lblErrorContext
            // 
            this.lblErrorContext.AutoSize = true;
            this.lblErrorContext.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorContext.Location = new System.Drawing.Point(957, 113);
            this.lblErrorContext.Name = "lblErrorContext";
            this.lblErrorContext.Size = new System.Drawing.Size(93, 31);
            this.lblErrorContext.TabIndex = 2;
            this.lblErrorContext.Text = "Context";
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(28, 358);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(134, 31);
            this.lblExplanation.TabIndex = 5;
            this.lblExplanation.Text = "Explanation";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolution.Location = new System.Drawing.Point(28, 669);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(98, 31);
            this.lblSolution.TabIndex = 6;
            this.lblSolution.Text = "Solution";
            // 
            // tbErrorTitle
            // 
            this.tbErrorTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbErrorTitle.Location = new System.Drawing.Point(184, 37);
            this.tbErrorTitle.Name = "tbErrorTitle";
            this.tbErrorTitle.Size = new System.Drawing.Size(408, 38);
            this.tbErrorTitle.TabIndex = 8;
            // 
            // rtbErrorMessage
            // 
            this.rtbErrorMessage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbErrorMessage.Location = new System.Drawing.Point(30, 152);
            this.rtbErrorMessage.Name = "rtbErrorMessage";
            this.rtbErrorMessage.Size = new System.Drawing.Size(856, 174);
            this.rtbErrorMessage.TabIndex = 9;
            this.rtbErrorMessage.Text = "";
            // 
            // rtbErrorContext
            // 
            this.rtbErrorContext.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbErrorContext.Location = new System.Drawing.Point(953, 152);
            this.rtbErrorContext.Name = "rtbErrorContext";
            this.rtbErrorContext.Size = new System.Drawing.Size(856, 174);
            this.rtbErrorContext.TabIndex = 10;
            this.rtbErrorContext.Text = "";
            // 
            // rtbExplanationAI
            // 
            this.rtbExplanationAI.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExplanationAI.Location = new System.Drawing.Point(30, 399);
            this.rtbExplanationAI.Name = "rtbExplanationAI";
            this.rtbExplanationAI.Size = new System.Drawing.Size(856, 233);
            this.rtbExplanationAI.TabIndex = 11;
            this.rtbExplanationAI.Text = "";
            // 
            // rtbSolution
            // 
            this.rtbSolution.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSolution.Location = new System.Drawing.Point(34, 718);
            this.rtbSolution.Name = "rtbSolution";
            this.rtbSolution.Size = new System.Drawing.Size(852, 228);
            this.rtbSolution.TabIndex = 12;
            this.rtbSolution.Text = "";
            // 
            // cbAI
            // 
            this.cbAI.AutoSize = true;
            this.cbAI.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAI.Location = new System.Drawing.Point(232, 358);
            this.cbAI.Name = "cbAI";
            this.cbAI.Size = new System.Drawing.Size(57, 35);
            this.cbAI.TabIndex = 13;
            this.cbAI.Text = "AI";
            this.cbAI.UseVisualStyleBackColor = true;
            this.cbAI.CheckedChanged += new System.EventHandler(this.cbAI_CheckedChanged);
            // 
            // cbPersonal
            // 
            this.cbPersonal.AutoSize = true;
            this.cbPersonal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPersonal.Location = new System.Drawing.Point(353, 357);
            this.cbPersonal.Name = "cbPersonal";
            this.cbPersonal.Size = new System.Drawing.Size(122, 35);
            this.cbPersonal.TabIndex = 14;
            this.cbPersonal.Text = "Personal";
            this.cbPersonal.UseVisualStyleBackColor = true;
            this.cbPersonal.CheckedChanged += new System.EventHandler(this.cbPersonal_CheckedChanged);
            // 
            // rtbExplanationPersonal
            // 
            this.rtbExplanationPersonal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExplanationPersonal.Location = new System.Drawing.Point(953, 399);
            this.rtbExplanationPersonal.Name = "rtbExplanationPersonal";
            this.rtbExplanationPersonal.Size = new System.Drawing.Size(856, 233);
            this.rtbExplanationPersonal.TabIndex = 15;
            this.rtbExplanationPersonal.Text = "";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(949, 718);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(856, 228);
            this.rtbNotes.TabIndex = 17;
            this.rtbNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(943, 669);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(74, 31);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1538, 968);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 62);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbEnableEditing
            // 
            this.cbEnableEditing.AutoSize = true;
            this.cbEnableEditing.Location = new System.Drawing.Point(1684, 48);
            this.cbEnableEditing.Name = "cbEnableEditing";
            this.cbEnableEditing.Size = new System.Drawing.Size(115, 20);
            this.cbEnableEditing.TabIndex = 20;
            this.cbEnableEditing.Text = "Enable editing";
            this.cbEnableEditing.UseVisualStyleBackColor = true;
            this.cbEnableEditing.CheckedChanged += new System.EventHandler(this.cbEnableEditing_CheckedChanged);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(865, 41);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(252, 24);
            this.cmbLanguage.TabIndex = 22;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(681, 44);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(148, 16);
            this.lblLanguage.TabIndex = 23;
            this.lblLanguage.Text = "Programming language";
            // 
            // developerDiaryDS1
            // 
            this.developerDiaryDS1.DataSetName = "developerDiaryDS";
            this.developerDiaryDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorJoinExplanationJoinSolutionTableAdapter1
            // 
            this.errorJoinExplanationJoinSolutionTableAdapter1.ClearBeforeFill = true;
            // 
            // explanationTableAdapter1
            // 
            this.explanationTableAdapter1.ClearBeforeFill = true;
            // 
            // programmingLanguageTableAdapter1
            // 
            this.programmingLanguageTableAdapter1.ClearBeforeFill = true;
            // 
            // errorTypeTableAdapter1
            // 
            this.errorTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbErrorType
            // 
            this.cmbErrorType.FormattingEnabled = true;
            this.cmbErrorType.Location = new System.Drawing.Point(1338, 41);
            this.cmbErrorType.Name = "cmbErrorType";
            this.cmbErrorType.Size = new System.Drawing.Size(257, 24);
            this.cmbErrorType.TabIndex = 24;
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.Location = new System.Drawing.Point(1160, 44);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(71, 16);
            this.lblErrorType.TabIndex = 25;
            this.lblErrorType.Text = "Error Type";
            // 
            // viewError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lblErrorType);
            this.Controls.Add(this.cmbErrorType);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.cbEnableEditing);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtbNotes);
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
        private System.Windows.Forms.RichTextBox rtbNotes;
        private developerDiaryDSTableAdapters.ErrorJoinExplanationJoinSolutionTableAdapter errorJoinExplanationJoinSolutionTableAdapter1;
        private developerDiaryDS developerDiaryDS1;
        private developerDiaryDSTableAdapters.ExplanationTableAdapter explanationTableAdapter1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbEnableEditing;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter programmingLanguageTableAdapter1;
        private developerDiaryDSTableAdapters.ErrorTypeTableAdapter errorTypeTableAdapter1;
        private System.Windows.Forms.ComboBox cmbErrorType;
        private System.Windows.Forms.Label lblErrorType;
    }
}