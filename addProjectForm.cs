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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DevelopersDiaryApplication
{
    public partial class addProjectForm : Form
    {
        public addProjectForm()
        {
            InitializeComponent();
        }
        //global variables
        int projectID = -1;

        private void addProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'developerDiaryDS1.ProgrammingLanguage' table. You can move, or remove it, as needed.
            this.programmingLanguageTableAdapter.Fill(this.developerDiaryDS1.ProgrammingLanguage);
           // MessageBox.Show(developerDiaryDS1.ProgrammingLanguage.Rows.Count.ToString());

            checkedListBox1.DataSource = developerDiaryDS1.ProgrammingLanguage;
            checkedListBox1.DisplayMember = "languageName";
            checkedListBox1.ValueMember = "languageID";
            tbDateCreated.Text = DateTime.Now.ToString("dd-MM-yyyy");

           /* try
            {
                
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    string query = @"SELECT * From ProgrammingLanguage";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string language = "non";
                           while (reader.Read())
                            {
                                
                                language = reader.GetString(reader.GetOrdinal("languageName"));
                                MessageBox.Show(language);


                            }
                            MessageBox.Show("No more");
                        }
                    }
                }
            }//try
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }//load event

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //ask for confirmation before saving
            DialogResult result = MessageBox.Show(
            "Are you sure you want to add this project?",
            "Confirm save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Did not add project",
                "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
               if (rtbProjectDescription.Text != null)
                {
                    projectID = Convert.ToInt32(
                        projectTableAdapter1.InsertQuery_Project(
                        tbProjectName.Text.Trim(),
                        rtbProjectDescription.Text.Trim(),
                        tbDateCreated.Text,
                        Session.UserID,
                        DateTime.Now));
                }
               else
                {
                    projectID = Convert.ToInt32(
                        projectTableAdapter1.InsertQuery_Project(
                        tbProjectName.Text.Trim(),
                        "No description.",
                        tbDateCreated.Text,
                        Session.UserID,
                        DateTime.Now));
                }







                foreach (DataRowView item in checkedListBox1.CheckedItems)
                {
                    int languageID = Convert.ToInt32(item["languageID"]);
                    projectLanguagesTableAdapter1.InsertQueryProjectLanguages(projectID, languageID);



                }

                MessageBox.Show("Succesfully added",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error while saving job request:\n" + sqlEx.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
