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
    public partial class viewProject : Form
    {
        //global variables
        int projectID = -1;
        int selectedErrorID = -1;
        int selectedSnippetID = -1;
        public viewProject(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
        }
        public void displayErrorsQuery()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    string sql = @"
                       SELECT 
                       errorID,errorTitle ,errorMessage,context,dateRecorded, errorTypeName As ErrorType 
                       FROM Error,ErrorType
                       WHERE ErrorType.errorTypeID = Error.errorTypeID
                       AND  projectID= @ID
                       AND isArchived = 0;";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", projectID);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvErrors.DataSource = dt;
                        dgvErrors.Font = new Font("Segoe UI", 14);
                        // dgvErrors.Columns[0].Width = 150;
                        // dgvErrors.Columns[1].Width = 250;
                        dgvErrors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgvErrors.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        dgvErrors.Columns["errorTitle"].HeaderText = "Error Title";
                        dgvErrors.Columns["errorMessage"].HeaderText = "Error Message";
                        dgvErrors.Columns["context"].HeaderText = "Context";
                        dgvErrors.Columns["dateRecorded"].HeaderText = "Date Recorded";
                        dgvErrors.Columns["ErrorType"].HeaderText = "Error Type";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error while loading errors:\n" + sqlEx.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error while loading errors:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayCodeSnippetsQuery()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    string sql = @"
                       select snippetID,title ,languageName ,code,categoryName,dateRecorded from CodeSnippet,Category,ProgrammingLanguage
                       where CodeSnippet.categoryID = Category.categoryID
                       AND CodeSnippet.languageID = ProgrammingLanguage.languageID
                       AND projectID=@ID
                       AND isArchived = 0";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", projectID);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCodeSnippets.DataSource = dt;
                        dgvCodeSnippets.Font = new Font("Segoe UI", 14);
                        
                        dgvCodeSnippets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgvCodeSnippets.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        dgvCodeSnippets.Columns["title"].HeaderText = "Title";
                        dgvCodeSnippets.Columns["languageName"].HeaderText = "Programming Language";
                        dgvCodeSnippets.Columns["code"].HeaderText = "Code";
                        dgvCodeSnippets.Columns["categoryName"].HeaderText = "Category";
                        dgvCodeSnippets.Columns["dateRecorded"].HeaderText = "Date Recorded";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error while loading code snippets:\n" + sqlEx.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error while loading code snippets:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewProject_Load(object sender, EventArgs e)
        {
            displayErrorsQuery();
            displayCodeSnippetsQuery();

        }

        private void dgvErrors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                // Guard: filtered view may have fewer rows than clientTable
                DataView dv = (dgvErrors.DataSource as DataTable).DefaultView;
                if (e.RowIndex >= dv.Count) return;

                DataGridViewRow row = dgvErrors.Rows[e.RowIndex];

                selectedErrorID = Convert.ToInt32(dv[e.RowIndex]["errorID"]);
                MessageBox.Show("Selected Error ID: " + selectedErrorID);

                //Form1 parent = (Form1)this.MdiParent;

                //if (parent != null)
                //{
                //    parent.FormSetup(new viewError(selectedErrorID));
                //}
                viewError viewErrorForm = new viewError(selectedErrorID);
                viewErrorForm.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading selected client:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAddError_Click(object sender, EventArgs e)
        {

            Form1 parent = (Form1)this.MdiParent;

            if (parent != null)
            {
                parent.FormSetup(new addError(projectID));
            }

        }

        private void dgvCodeSnippets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                if (e.RowIndex < 0) return;

                // Guard: filtered view may have fewer rows than clientTable
                DataView dv = (dgvCodeSnippets.DataSource as DataTable).DefaultView;
                if (e.RowIndex >= dv.Count) return;

                DataGridViewRow row = dgvCodeSnippets.Rows[e.RowIndex];

                selectedSnippetID = Convert.ToInt32(dv[e.RowIndex]["snippetID"]);
                MessageBox.Show("Selected snippet ID: " + selectedSnippetID);

                //Form1 parent = (Form1)this.MdiParent;

                //if (parent != null)
                //{
                //    parent.FormSetup(new viewError(selectedErrorID));
                //}
                viewCodeSnippet viewCode = new viewCodeSnippet(selectedSnippetID);
                viewCode.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading selected code snippet:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCodeSnippet_Click(object sender, EventArgs e)
        {

        }
    }
}
