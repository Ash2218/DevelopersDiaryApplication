namespace DevelopersDiaryApplication
{
    partial class dashboardFrm
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
            this.flpProjects = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flpProjects
            // 
            this.flpProjects.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flpProjects.Location = new System.Drawing.Point(12, 95);
            this.flpProjects.Name = "flpProjects";
            this.flpProjects.Size = new System.Drawing.Size(1900, 647);
            this.flpProjects.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1679, 38);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Search error/code";
            // 
            // dashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flpProjects);
            this.Name = "dashboardFrm";
            this.Text = "dashboardFrm";
            this.Load += new System.EventHandler(this.dashboardFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProjects;
        private System.Windows.Forms.TextBox textBox1;
    }
}