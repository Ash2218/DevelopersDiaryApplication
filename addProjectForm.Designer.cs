namespace DevelopersDiaryApplication
{
    partial class addProjectForm
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
            this.components = new System.ComponentModel.Container();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.tbDateCreated = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblAddProject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.programmingLanguageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerDiaryDS1 = new DevelopersDiaryApplication.developerDiaryDS();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbProjectDescription = new System.Windows.Forms.RichTextBox();
            this.programmingLanguageTableAdapter = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter();
            this.projectTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ProjectTableAdapter();
            this.projectLanguagesTableAdapter1 = new DevelopersDiaryApplication.developerDiaryDSTableAdapters.ProjectLanguagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.programmingLanguageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(770, 205);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(718, 43);
            this.tbProjectName.TabIndex = 0;
            // 
            // tbDateCreated
            // 
            this.tbDateCreated.Location = new System.Drawing.Point(770, 783);
            this.tbDateCreated.Name = "tbDateCreated";
            this.tbDateCreated.ReadOnly = true;
            this.tbDateCreated.Size = new System.Drawing.Size(397, 43);
            this.tbDateCreated.TabIndex = 2;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(426, 200);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(185, 38);
            this.lblProjectName.TabIndex = 3;
            this.lblProjectName.Text = "Project Name";
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Location = new System.Drawing.Point(426, 286);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Size = new System.Drawing.Size(252, 38);
            this.lblProjectDescription.TabIndex = 4;
            this.lblProjectDescription.Text = "Project Description";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(426, 783);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(179, 38);
            this.lblDateCreated.TabIndex = 5;
            this.lblDateCreated.Text = "Date Created";
            // 
            // lblAddProject
            // 
            this.lblAddProject.AutoSize = true;
            this.lblAddProject.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProject.Location = new System.Drawing.Point(841, 34);
            this.lblAddProject.Name = "lblAddProject";
            this.lblAddProject.Size = new System.Drawing.Size(232, 54);
            this.lblAddProject.TabIndex = 6;
            this.lblAddProject.Text = "Add project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Programming Languages";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.programmingLanguageBindingSource, "languageName", true));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(770, 511);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(397, 232);
            this.checkedListBox1.TabIndex = 8;
            // 
            // programmingLanguageBindingSource
            // 
            this.programmingLanguageBindingSource.DataMember = "ProgrammingLanguage";
            this.programmingLanguageBindingSource.DataSource = this.developerDiaryDS1;
            // 
            // developerDiaryDS1
            // 
            this.developerDiaryDS1.DataSetName = "developerDiaryDS";
            this.developerDiaryDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DevelopersDiaryApplication.Properties.Resources.saveButton;
            this.pictureBox3.Location = new System.Drawing.Point(822, 876);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(345, 134);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox2.Location = new System.Drawing.Point(1182, 511);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DevelopersDiaryApplication.Properties.Resources.asterisk;
            this.pictureBox1.Location = new System.Drawing.Point(1511, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // rtbProjectDescription
            // 
            this.rtbProjectDescription.Location = new System.Drawing.Point(770, 302);
            this.rtbProjectDescription.Name = "rtbProjectDescription";
            this.rtbProjectDescription.Size = new System.Drawing.Size(718, 180);
            this.rtbProjectDescription.TabIndex = 12;
            this.rtbProjectDescription.Text = "";
            // 
            // programmingLanguageTableAdapter
            // 
            this.programmingLanguageTableAdapter.ClearBeforeFill = true;
            // 
            // projectTableAdapter1
            // 
            this.projectTableAdapter1.ClearBeforeFill = true;
            // 
            // projectLanguagesTableAdapter1
            // 
            this.projectLanguagesTableAdapter1.ClearBeforeFill = true;
            // 
            // addProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.rtbProjectDescription);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddProject);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblProjectDescription);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.tbDateCreated);
            this.Controls.Add(this.tbProjectName);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programmingLanguageBindingSource, "languageName", true));
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "addProjectForm";
            this.Text = "addProjectForm";
            this.Load += new System.EventHandler(this.addProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programmingLanguageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerDiaryDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbDateCreated;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblAddProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private developerDiaryDS developerDiaryDS1;
        private System.Windows.Forms.BindingSource programmingLanguageBindingSource;
        private developerDiaryDSTableAdapters.ProgrammingLanguageTableAdapter programmingLanguageTableAdapter;
        private System.Windows.Forms.RichTextBox rtbProjectDescription;
        private developerDiaryDSTableAdapters.ProjectTableAdapter projectTableAdapter1;
        private developerDiaryDSTableAdapters.ProjectLanguagesTableAdapter projectLanguagesTableAdapter1;
    }
}