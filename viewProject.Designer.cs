namespace DevelopersDiaryApplication
{
    partial class viewProject
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
            this.lblProjectNameTimes = new System.Windows.Forms.Label();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.gbErrors = new System.Windows.Forms.GroupBox();
            this.btnAddError = new System.Windows.Forms.Button();
            this.dgvErrors = new System.Windows.Forms.DataGridView();
            this.gbCodeSnippets = new System.Windows.Forms.GroupBox();
            this.btnAddCodeSnippet = new System.Windows.Forms.Button();
            this.dgvCodeSnippets = new System.Windows.Forms.DataGridView();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.cbErrorMessage = new System.Windows.Forms.CheckBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.cbCode = new System.Windows.Forms.CheckBox();
            this.cmbErrorType = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cbShowFilters = new System.Windows.Forms.CheckBox();
            this.cbErrorTitle = new System.Windows.Forms.CheckBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cbContext = new System.Windows.Forms.CheckBox();
            this.programmingLanguageTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter();
            this.developerDiaryDS1 = new DevelopersDiaryApplication.developerDiaryDS();
            this.categoryTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.CategoryTableAdapter();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblErrorType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.errorTypeTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ErrorTypeTableAdapter();
            this.gbErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            this.gbCodeSnippets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodeSnippets)).BeginInit();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectNameTimes
            // 
            this.lblProjectNameTimes.AutoSize = true;
            this.lblProjectNameTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectNameTimes.Location = new System.Drawing.Point(12, 9);
            this.lblProjectNameTimes.Name = "lblProjectNameTimes";
            this.lblProjectNameTimes.Size = new System.Drawing.Size(197, 32);
            this.lblProjectNameTimes.TabIndex = 0;
            this.lblProjectNameTimes.Text = "Project namee";
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTerm.Location = new System.Drawing.Point(13, 60);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(1110, 34);
            this.txtSearchTerm.TabIndex = 1;
            this.txtSearchTerm.TextChanged += new System.EventHandler(this.txtSearchTerm_TextChanged);
            // 
            // gbErrors
            // 
            this.gbErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbErrors.Controls.Add(this.btnAddError);
            this.gbErrors.Controls.Add(this.dgvErrors);
            this.gbErrors.Location = new System.Drawing.Point(18, 191);
            this.gbErrors.Name = "gbErrors";
            this.gbErrors.Size = new System.Drawing.Size(1635, 268);
            this.gbErrors.TabIndex = 2;
            this.gbErrors.TabStop = false;
            this.gbErrors.Text = "Errors";
            // 
            // btnAddError
            // 
            this.btnAddError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddError.Location = new System.Drawing.Point(51, 213);
            this.btnAddError.Name = "btnAddError";
            this.btnAddError.Size = new System.Drawing.Size(199, 37);
            this.btnAddError.TabIndex = 1;
            this.btnAddError.Text = "Record new error";
            this.btnAddError.UseVisualStyleBackColor = true;
            this.btnAddError.Click += new System.EventHandler(this.btnAddError_Click);
            // 
            // dgvErrors
            // 
            this.dgvErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrors.Location = new System.Drawing.Point(34, 46);
            this.dgvErrors.Name = "dgvErrors";
            this.dgvErrors.RowHeadersWidth = 51;
            this.dgvErrors.RowTemplate.Height = 24;
            this.dgvErrors.Size = new System.Drawing.Size(1580, 150);
            this.dgvErrors.TabIndex = 0;
            this.dgvErrors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvErrors_CellClick);
            // 
            // gbCodeSnippets
            // 
            this.gbCodeSnippets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCodeSnippets.Controls.Add(this.btnAddCodeSnippet);
            this.gbCodeSnippets.Controls.Add(this.dgvCodeSnippets);
            this.gbCodeSnippets.Location = new System.Drawing.Point(18, 531);
            this.gbCodeSnippets.Name = "gbCodeSnippets";
            this.gbCodeSnippets.Size = new System.Drawing.Size(1635, 291);
            this.gbCodeSnippets.TabIndex = 3;
            this.gbCodeSnippets.TabStop = false;
            this.gbCodeSnippets.Text = "Code snippets";
            // 
            // btnAddCodeSnippet
            // 
            this.btnAddCodeSnippet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCodeSnippet.Location = new System.Drawing.Point(51, 212);
            this.btnAddCodeSnippet.Name = "btnAddCodeSnippet";
            this.btnAddCodeSnippet.Size = new System.Drawing.Size(187, 36);
            this.btnAddCodeSnippet.TabIndex = 1;
            this.btnAddCodeSnippet.Text = "Add new code snippet";
            this.btnAddCodeSnippet.UseVisualStyleBackColor = true;
            this.btnAddCodeSnippet.Click += new System.EventHandler(this.btnAddCodeSnippet_Click);
            // 
            // dgvCodeSnippets
            // 
            this.dgvCodeSnippets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodeSnippets.Location = new System.Drawing.Point(34, 37);
            this.dgvCodeSnippets.Name = "dgvCodeSnippets";
            this.dgvCodeSnippets.RowHeadersWidth = 51;
            this.dgvCodeSnippets.RowTemplate.Height = 24;
            this.dgvCodeSnippets.Size = new System.Drawing.Size(1580, 150);
            this.dgvCodeSnippets.TabIndex = 0;
            this.dgvCodeSnippets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCodeSnippets_CellClick);
            // 
            // pnlFilters
            // 
            this.pnlFilters.AutoScroll = true;
            this.pnlFilters.Controls.Add(this.lblCategory);
            this.pnlFilters.Controls.Add(this.lblErrorType);
            this.pnlFilters.Controls.Add(this.lblLanguage);
            this.pnlFilters.Controls.Add(this.cbContext);
            this.pnlFilters.Controls.Add(this.dtpTo);
            this.pnlFilters.Controls.Add(this.dtpFrom);
            this.pnlFilters.Controls.Add(this.cbErrorTitle);
            this.pnlFilters.Controls.Add(this.cmbCategory);
            this.pnlFilters.Controls.Add(this.cmbErrorType);
            this.pnlFilters.Controls.Add(this.cbCode);
            this.pnlFilters.Controls.Add(this.cmbLanguage);
            this.pnlFilters.Controls.Add(this.cbErrorMessage);
            this.pnlFilters.Location = new System.Drawing.Point(34, 100);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1041, 85);
            this.pnlFilters.TabIndex = 6;
            // 
            // cbErrorMessage
            // 
            this.cbErrorMessage.AutoSize = true;
            this.cbErrorMessage.Location = new System.Drawing.Point(26, 8);
            this.cbErrorMessage.Name = "cbErrorMessage";
            this.cbErrorMessage.Size = new System.Drawing.Size(118, 20);
            this.cbErrorMessage.TabIndex = 0;
            this.cbErrorMessage.Text = "Error Message";
            this.cbErrorMessage.UseVisualStyleBackColor = true;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(430, 27);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 24);
            this.cmbLanguage.TabIndex = 1;
            // 
            // cbCode
            // 
            this.cbCode.AutoSize = true;
            this.cbCode.Location = new System.Drawing.Point(842, 14);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(62, 20);
            this.cbCode.TabIndex = 2;
            this.cbCode.Text = "Code";
            this.cbCode.UseVisualStyleBackColor = true;
            this.cbCode.CheckedChanged += new System.EventHandler(this.chkSearchCode_CheckedChanged);
            // 
            // cmbErrorType
            // 
            this.cmbErrorType.FormattingEnabled = true;
            this.cmbErrorType.Location = new System.Drawing.Point(286, 21);
            this.cmbErrorType.Name = "cmbErrorType";
            this.cmbErrorType.Size = new System.Drawing.Size(121, 24);
            this.cmbErrorType.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(671, 34);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbCategory.TabIndex = 4;
            // 
            // cbShowFilters
            // 
            this.cbShowFilters.AutoSize = true;
            this.cbShowFilters.Location = new System.Drawing.Point(1081, 101);
            this.cbShowFilters.Name = "cbShowFilters";
            this.cbShowFilters.Size = new System.Drawing.Size(96, 20);
            this.cbShowFilters.TabIndex = 7;
            this.cbShowFilters.Text = "Show filters";
            this.cbShowFilters.UseVisualStyleBackColor = true;
            this.cbShowFilters.CheckedChanged += new System.EventHandler(this.cbShowFilters_CheckedChanged);
            // 
            // cbErrorTitle
            // 
            this.cbErrorTitle.AutoSize = true;
            this.cbErrorTitle.Location = new System.Drawing.Point(26, 34);
            this.cbErrorTitle.Name = "cbErrorTitle";
            this.cbErrorTitle.Size = new System.Drawing.Size(55, 20);
            this.cbErrorTitle.TabIndex = 5;
            this.cbErrorTitle.Text = "Title";
            this.cbErrorTitle.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(295, 91);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 6;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(562, 91);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 7;
            // 
            // cbContext
            // 
            this.cbContext.AutoSize = true;
            this.cbContext.Location = new System.Drawing.Point(161, 8);
            this.cbContext.Name = "cbContext";
            this.cbContext.Size = new System.Drawing.Size(73, 20);
            this.cbContext.TabIndex = 10;
            this.cbContext.Text = "Context";
            this.cbContext.UseVisualStyleBackColor = true;
            // 
            // programmingLanguageTableAdapter1
            // 
            this.programmingLanguageTableAdapter1.ClearBeforeFill = true;
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
            // btnApplyFilters
            // 
            this.btnApplyFilters.Location = new System.Drawing.Point(1155, 58);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(150, 36);
            this.btnApplyFilters.TabIndex = 8;
            this.btnApplyFilters.Text = "applyFilters";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(427, 8);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(68, 16);
            this.lblLanguage.TabIndex = 11;
            this.lblLanguage.Text = "Language";
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.Location = new System.Drawing.Point(292, 5);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(71, 16);
            this.lblErrorType.TabIndex = 12;
            this.lblErrorType.Text = "Error Type";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(668, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category";
            // 
            // errorTypeTableAdapter1
            // 
            this.errorTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // viewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnApplyFilters);
            this.Controls.Add(this.cbShowFilters);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.gbCodeSnippets);
            this.Controls.Add(this.gbErrors);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.lblProjectNameTimes);
            this.Name = "viewProject";
            this.Text = "viewProject";
            this.Load += new System.EventHandler(this.viewProject_Load);
            this.gbErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).EndInit();
            this.gbCodeSnippets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodeSnippets)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectNameTimes;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.GroupBox gbErrors;
        private System.Windows.Forms.GroupBox gbCodeSnippets;
        private System.Windows.Forms.Button btnAddError;
        private System.Windows.Forms.DataGridView dgvErrors;
        private System.Windows.Forms.Button btnAddCodeSnippet;
        private System.Windows.Forms.DataGridView dgvCodeSnippets;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbErrorType;
        private System.Windows.Forms.CheckBox cbCode;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.CheckBox cbErrorMessage;
        private System.Windows.Forms.CheckBox cbShowFilters;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.CheckBox cbErrorTitle;
        private System.Windows.Forms.CheckBox cbContext;
        private developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter programmingLanguageTableAdapter1;
        private developerDiaryDS developerDiaryDS1;
        private developerDiaryDSTableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblErrorType;
        private System.Windows.Forms.Label lblLanguage;
        private developerDiaryDSTableAdapters.ErrorTypeTableAdapter errorTypeTableAdapter1;
    }
}