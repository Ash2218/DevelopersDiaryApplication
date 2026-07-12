namespace DevelopersDiaryApplication
{
    partial class addError
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
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.rtbExplanationPersonal = new System.Windows.Forms.RichTextBox();
            this.rtbExplanationAI = new System.Windows.Forms.RichTextBox();
            this.rtbErrorContext = new System.Windows.Forms.RichTextBox();
            this.rtbErrorMessage = new System.Windows.Forms.RichTextBox();
            this.tbErrorTitle = new System.Windows.Forms.TextBox();
            this.lblErrorContext = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblErrorType = new System.Windows.Forms.Label();
            this.cmbErrorType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAI = new System.Windows.Forms.Label();
            this.lblPersonalExplanation = new System.Windows.Forms.Label();
            this.btnGenerateExplanation = new System.Windows.Forms.Button();
            this.btnSaveError = new System.Windows.Forms.Button();
            this.gbSolution = new System.Windows.Forms.GroupBox();
            this.rtbSolution = new System.Windows.Forms.RichTextBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnSaveSolution = new System.Windows.Forms.Button();
            this.btnAddSolution = new System.Windows.Forms.Button();
            this.btnHideSolution = new System.Windows.Forms.Button();
            this.developerDiaryDS1 = new DevelopersDiaryApplication.developerDiaryDS();
            this.programmingLanguageTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter();
            this.errorTypeTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ErrorTypeTableAdapter();
            this.errorTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ErrorTableAdapter();
            this.explanationTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ExplanationTableAdapter();
            this.solutionTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.SolutionTableAdapter();
            this.lblErrorID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbSolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(788, 84);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(148, 16);
            this.lblLanguage.TabIndex = 40;
            this.lblLanguage.Text = "Programming language";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(980, 80);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(180, 24);
            this.cmbLanguage.TabIndex = 39;
            // 
            // rtbExplanationPersonal
            // 
            this.rtbExplanationPersonal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExplanationPersonal.Location = new System.Drawing.Point(1009, 418);
            this.rtbExplanationPersonal.Name = "rtbExplanationPersonal";
            this.rtbExplanationPersonal.Size = new System.Drawing.Size(558, 198);
            this.rtbExplanationPersonal.TabIndex = 36;
            this.rtbExplanationPersonal.Text = "";
            // 
            // rtbExplanationAI
            // 
            this.rtbExplanationAI.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExplanationAI.Location = new System.Drawing.Point(90, 396);
            this.rtbExplanationAI.Name = "rtbExplanationAI";
            this.rtbExplanationAI.Size = new System.Drawing.Size(735, 233);
            this.rtbExplanationAI.TabIndex = 32;
            this.rtbExplanationAI.Text = "";
            // 
            // rtbErrorContext
            // 
            this.rtbErrorContext.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbErrorContext.Location = new System.Drawing.Point(999, 188);
            this.rtbErrorContext.Name = "rtbErrorContext";
            this.rtbErrorContext.Size = new System.Drawing.Size(558, 150);
            this.rtbErrorContext.TabIndex = 31;
            this.rtbErrorContext.Text = "";
            // 
            // rtbErrorMessage
            // 
            this.rtbErrorMessage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbErrorMessage.Location = new System.Drawing.Point(76, 188);
            this.rtbErrorMessage.Name = "rtbErrorMessage";
            this.rtbErrorMessage.Size = new System.Drawing.Size(739, 150);
            this.rtbErrorMessage.TabIndex = 30;
            this.rtbErrorMessage.Text = "";
            // 
            // tbErrorTitle
            // 
            this.tbErrorTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbErrorTitle.Location = new System.Drawing.Point(230, 73);
            this.tbErrorTitle.Name = "tbErrorTitle";
            this.tbErrorTitle.Size = new System.Drawing.Size(408, 38);
            this.tbErrorTitle.TabIndex = 29;
            // 
            // lblErrorContext
            // 
            this.lblErrorContext.AutoSize = true;
            this.lblErrorContext.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorContext.Location = new System.Drawing.Point(1003, 149);
            this.lblErrorContext.Name = "lblErrorContext";
            this.lblErrorContext.Size = new System.Drawing.Size(161, 31);
            this.lblErrorContext.TabIndex = 26;
            this.lblErrorContext.Text = "Context/ Code";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(74, 149);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(160, 31);
            this.lblErrorMessage.TabIndex = 25;
            this.lblErrorMessage.Text = "Error Message";
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTitle.Location = new System.Drawing.Point(70, 73);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(113, 31);
            this.lblErrorTitle.TabIndex = 24;
            this.lblErrorTitle.Text = "Error Title";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(94, 998);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(107, 45);
            this.btnGoBack.TabIndex = 41;
            this.btnGoBack.Text = "go back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.Location = new System.Drawing.Point(1194, 83);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(71, 16);
            this.lblErrorType.TabIndex = 43;
            this.lblErrorType.Text = "Error Type";
            // 
            // cmbErrorType
            // 
            this.cmbErrorType.FormattingEnabled = true;
            this.cmbErrorType.Location = new System.Drawing.Point(1372, 80);
            this.cmbErrorType.Name = "cmbErrorType";
            this.cmbErrorType.Size = new System.Drawing.Size(257, 24);
            this.cmbErrorType.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox1.Location = new System.Drawing.Point(657, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox2.Location = new System.Drawing.Point(821, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox3.Location = new System.Drawing.Point(831, 396);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.Location = new System.Drawing.Point(91, 377);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(92, 16);
            this.lblAI.TabIndex = 47;
            this.lblAI.Text = "AI Explanation";
            // 
            // lblPersonalExplanation
            // 
            this.lblPersonalExplanation.AutoSize = true;
            this.lblPersonalExplanation.Location = new System.Drawing.Point(1006, 377);
            this.lblPersonalExplanation.Name = "lblPersonalExplanation";
            this.lblPersonalExplanation.Size = new System.Drawing.Size(134, 16);
            this.lblPersonalExplanation.TabIndex = 48;
            this.lblPersonalExplanation.Text = "Personal Explanation";
            // 
            // btnGenerateExplanation
            // 
            this.btnGenerateExplanation.Location = new System.Drawing.Point(655, 641);
            this.btnGenerateExplanation.Name = "btnGenerateExplanation";
            this.btnGenerateExplanation.Size = new System.Drawing.Size(170, 37);
            this.btnGenerateExplanation.TabIndex = 49;
            this.btnGenerateExplanation.Text = "Generate";
            this.btnGenerateExplanation.UseVisualStyleBackColor = true;
            this.btnGenerateExplanation.Click += new System.EventHandler(this.btnGenerateExplanation_Click);
            // 
            // btnSaveError
            // 
            this.btnSaveError.Location = new System.Drawing.Point(1197, 659);
            this.btnSaveError.Name = "btnSaveError";
            this.btnSaveError.Size = new System.Drawing.Size(192, 45);
            this.btnSaveError.TabIndex = 50;
            this.btnSaveError.Text = "Save error";
            this.btnSaveError.UseVisualStyleBackColor = true;
            this.btnSaveError.Click += new System.EventHandler(this.btnSaveError_Click);
            // 
            // gbSolution
            // 
            this.gbSolution.Controls.Add(this.btnSaveSolution);
            this.gbSolution.Controls.Add(this.rtbNotes);
            this.gbSolution.Controls.Add(this.rtbSolution);
            this.gbSolution.Location = new System.Drawing.Point(94, 729);
            this.gbSolution.Name = "gbSolution";
            this.gbSolution.Size = new System.Drawing.Size(1473, 237);
            this.gbSolution.TabIndex = 51;
            this.gbSolution.TabStop = false;
            this.gbSolution.Text = "Add Solution";
            // 
            // rtbSolution
            // 
            this.rtbSolution.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSolution.Location = new System.Drawing.Point(35, 35);
            this.rtbSolution.Name = "rtbSolution";
            this.rtbSolution.Size = new System.Drawing.Size(631, 142);
            this.rtbSolution.TabIndex = 33;
            this.rtbSolution.Text = "";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotes.Location = new System.Drawing.Point(727, 35);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(631, 142);
            this.rtbNotes.TabIndex = 34;
            this.rtbNotes.Text = "";
            // 
            // btnSaveSolution
            // 
            this.btnSaveSolution.Location = new System.Drawing.Point(497, 194);
            this.btnSaveSolution.Name = "btnSaveSolution";
            this.btnSaveSolution.Size = new System.Drawing.Size(169, 37);
            this.btnSaveSolution.TabIndex = 35;
            this.btnSaveSolution.Text = "Save Solution";
            this.btnSaveSolution.UseVisualStyleBackColor = true;
            this.btnSaveSolution.Click += new System.EventHandler(this.btnSaveSolution_Click);
            // 
            // btnAddSolution
            // 
            this.btnAddSolution.Location = new System.Drawing.Point(230, 675);
            this.btnAddSolution.Name = "btnAddSolution";
            this.btnAddSolution.Size = new System.Drawing.Size(119, 48);
            this.btnAddSolution.TabIndex = 52;
            this.btnAddSolution.Text = "Add Solution";
            this.btnAddSolution.UseVisualStyleBackColor = true;
            this.btnAddSolution.Click += new System.EventHandler(this.btnAddSolution_Click);
            // 
            // btnHideSolution
            // 
            this.btnHideSolution.Location = new System.Drawing.Point(378, 675);
            this.btnHideSolution.Name = "btnHideSolution";
            this.btnHideSolution.Size = new System.Drawing.Size(139, 46);
            this.btnHideSolution.TabIndex = 53;
            this.btnHideSolution.Text = "Hide solution";
            this.btnHideSolution.UseVisualStyleBackColor = true;
            this.btnHideSolution.Click += new System.EventHandler(this.btnHideSolution_Click);
            // 
            // developerDiaryDS1
            // 
            this.developerDiaryDS1.DataSetName = "developerDiaryDS";
            this.developerDiaryDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programmingLanguageTableAdapter1
            // 
            this.programmingLanguageTableAdapter1.ClearBeforeFill = true;
            // 
            // errorTypeTableAdapter1
            // 
            this.errorTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // errorTableAdapter1
            // 
            this.errorTableAdapter1.ClearBeforeFill = true;
            // 
            // explanationTableAdapter1
            // 
            this.explanationTableAdapter1.ClearBeforeFill = true;
            // 
            // solutionTableAdapter1
            // 
            this.solutionTableAdapter1.ClearBeforeFill = true;
            // 
            // lblErrorID
            // 
            this.lblErrorID.AutoSize = true;
            this.lblErrorID.Location = new System.Drawing.Point(574, 691);
            this.lblErrorID.Name = "lblErrorID";
            this.lblErrorID.Size = new System.Drawing.Size(44, 16);
            this.lblErrorID.TabIndex = 54;
            this.lblErrorID.Text = "label1";
            // 
            // addError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lblErrorID);
            this.Controls.Add(this.btnHideSolution);
            this.Controls.Add(this.btnAddSolution);
            this.Controls.Add(this.gbSolution);
            this.Controls.Add(this.btnSaveError);
            this.Controls.Add(this.btnGenerateExplanation);
            this.Controls.Add(this.lblPersonalExplanation);
            this.Controls.Add(this.lblAI);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblErrorType);
            this.Controls.Add(this.cmbErrorType);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.rtbExplanationPersonal);
            this.Controls.Add(this.rtbExplanationAI);
            this.Controls.Add(this.rtbErrorContext);
            this.Controls.Add(this.rtbErrorMessage);
            this.Controls.Add(this.tbErrorTitle);
            this.Controls.Add(this.lblErrorContext);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblErrorTitle);
            this.Name = "addError";
            this.Text = "addError";
            this.Load += new System.EventHandler(this.addError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbSolution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.RichTextBox rtbExplanationPersonal;
        private System.Windows.Forms.RichTextBox rtbExplanationAI;
        private System.Windows.Forms.RichTextBox rtbErrorContext;
        private System.Windows.Forms.RichTextBox rtbErrorMessage;
        private System.Windows.Forms.TextBox tbErrorTitle;
        private System.Windows.Forms.Label lblErrorContext;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblErrorTitle;
        private developerDiaryDS developerDiaryDS1;
        private developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter programmingLanguageTableAdapter1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblErrorType;
        private System.Windows.Forms.ComboBox cmbErrorType;
        private developerDiaryDSTableAdapters.ErrorTypeTableAdapter errorTypeTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAI;
        private System.Windows.Forms.Label lblPersonalExplanation;
        private System.Windows.Forms.Button btnGenerateExplanation;
        private System.Windows.Forms.Button btnSaveError;
        private developerDiaryDSTableAdapters.ErrorTableAdapter errorTableAdapter1;
        private System.Windows.Forms.GroupBox gbSolution;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.RichTextBox rtbSolution;
        private System.Windows.Forms.Button btnSaveSolution;
        private System.Windows.Forms.Button btnAddSolution;
        private System.Windows.Forms.Button btnHideSolution;
        private developerDiaryDSTableAdapters.ExplanationTableAdapter explanationTableAdapter1;
        private developerDiaryDSTableAdapters.SolutionTableAdapter solutionTableAdapter1;
        private System.Windows.Forms.Label lblErrorID;
    }
}