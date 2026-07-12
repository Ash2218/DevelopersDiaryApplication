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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbErrors = new System.Windows.Forms.GroupBox();
            this.btnAddError = new System.Windows.Forms.Button();
            this.dgvErrors = new System.Windows.Forms.DataGridView();
            this.gbCodeSnippets = new System.Windows.Forms.GroupBox();
            this.btnAddCodeSnippet = new System.Windows.Forms.Button();
            this.dgvCodeSnippets = new System.Windows.Forms.DataGridView();
            this.gbErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            this.gbCodeSnippets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodeSnippets)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1626, 34);
            this.textBox1.TabIndex = 1;
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
            // viewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.gbCodeSnippets);
            this.Controls.Add(this.gbErrors);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProjectNameTimes);
            this.Name = "viewProject";
            this.Text = "viewProject";
            this.Load += new System.EventHandler(this.viewProject_Load);
            this.gbErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).EndInit();
            this.gbCodeSnippets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodeSnippets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectNameTimes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbErrors;
        private System.Windows.Forms.GroupBox gbCodeSnippets;
        private System.Windows.Forms.Button btnAddError;
        private System.Windows.Forms.DataGridView dgvErrors;
        private System.Windows.Forms.Button btnAddCodeSnippet;
        private System.Windows.Forms.DataGridView dgvCodeSnippets;
    }
}