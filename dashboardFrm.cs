using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopersDiaryApplication
{
    public partial class dashboardFrm : Form
    {
        public dashboardFrm()
        {
            InitializeComponent();
        }
        //global variables
        int projectID = -1;
        private void dashboardFrm_Load(object sender, EventArgs e)
        {
            LoadUserProjects();
        }
        private void LoadUserProjects()
        {
            flpProjects.Controls.Clear(); // clear existing cards before reloading

            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    string query = @"SELECT projectName, description ,projectID
                             FROM Project 
                             WHERE userID = @userID
                             ORDER BY dateCreated DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", Session.UserID);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string projectName = reader.GetString(reader.GetOrdinal("projectName"));
                                string description = reader.GetString(reader.GetOrdinal("description"));
                                int projectID = reader.GetInt32(reader.GetOrdinal("projectID")); // Assuming you have a projectID column in your Project table
                                CreateProjectCard(projectName, description, projectID);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading projects: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateProjectCard(string projectName, string description, int projectID)
        {
            Panel panel = new Panel();
            panel.Width = 300;
            panel.Height = 100;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.White;
            panel.Cursor = Cursors.Hand; // shows a hand cursor on hover, hinting it's clickable
            panel.Tag = projectID;       // store the project's ID on the panel itself

            PictureBox pic = new PictureBox();
            pic.Width = 48;
            pic.Height = 48;
            pic.Location = new Point(10, 20);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = Properties.Resources.folderIconBgRemoved;

            Label lblName = new Label();
            lblName.Text = projectName;
            lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblName.Location = new Point(70, 15);
            lblName.AutoSize = true;

            Label lblDescription = new Label();
            lblDescription.Text = description;
            lblDescription.Location = new Point(70, 45);
            lblDescription.AutoSize = true;

            panel.Controls.Add(pic);
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblDescription);
            flpProjects.Controls.Add(panel);

            // Wire up click event on the panel AND every child control inside it
            panel.Click += ProjectCard_Click;
            pic.Click += ProjectCard_Click;
            lblName.Click += ProjectCard_Click;
            lblDescription.Click += ProjectCard_Click;
        }
        private void ProjectCard_Click(object sender, EventArgs e)
        {
            Control clicked = sender as Control;

            // Walk up to find the parent Panel, in case a child control (label/picture) was clicked
            while (clicked != null && !(clicked is Panel))
            {
                clicked = clicked.Parent;
            }

            if (clicked != null)
            {
                projectID = (int)clicked.Tag;

                // Example: open a project details form
                MessageBox.Show($"Project ID: {projectID} clicked!", "Project Clicked",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 parent = (Form1)this.MdiParent;

                if (parent != null)
                {
                    parent.FormSetup(new viewProject(projectID));
                }
            }
        }
    }
}
