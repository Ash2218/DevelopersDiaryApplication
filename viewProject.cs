using System;
using System.Collections;
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
            pnlFilters.Visible = false;
            cbErrorTitle.Checked = true;
            cbErrorMessage.Checked = true;



            this.programmingLanguageTableAdapter1.Fill(developerDiaryDS1.ProgrammingLanguage);
            cmbLanguage.DataSource = developerDiaryDS1.ProgrammingLanguage;
            cmbLanguage.DisplayMember = "languageName";
            cmbLanguage.ValueMember = "languageID";
            cmbLanguage.SelectedIndex = -1;

            this.categoryTableAdapter1.Fill(developerDiaryDS1.Category);
            cmbCategory.DataSource = developerDiaryDS1.Category;
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryID";
            cmbCategory.SelectedIndex = -1;

            this.errorTypeTableAdapter1.Fill(developerDiaryDS1.ErrorType);
            cmbErrorType.DataSource = developerDiaryDS1.ErrorType;
            cmbErrorType.DisplayMember = "errorTypeName";
            cmbErrorType.ValueMember = "errorTypeID";
            cmbErrorType.SelectedIndex = -1;

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

            /*Form1 parent = (Form1)this.MdiParent;

            if (parent != null)
            {
                parent.FormSetup(new addError(projectID));
            }*/
            addError frm = new addError(projectID);
            frm.FormClosed += (s, args) =>
            {
                RefreshData();
            };

            frm.ShowDialog();
            
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
            /*Form1 parent = (Form1)this.MdiParent;

            if (parent != null)
            {
                parent.FormSetup(new AddCodeSnippet(projectID));
            }*/
            AddCodeSnippet frm = new AddCodeSnippet(projectID);

            frm.FormClosed += (s, args) =>
            {
                RefreshData();
            };

            frm.ShowDialog();
           
           
        }

        private void btnShowFilters_Click(object sender, EventArgs e)
        {

        }

        private void cbShowFilters_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowFilters.Checked)
            {
                pnlFilters.Visible = true;
            }
            else
            {
                pnlFilters.Visible = false;
            }
        }

        private void chkSearchCode_CheckedChanged(object sender, EventArgs e)
        {

        }

       
        

        private void txtSearchTerm_TextChanged(object sender, EventArgs e)
        {

            searchErrorsQuery(txtSearchTerm.Text.Trim());
            searchCodeSnippet(txtSearchTerm.Text.Trim());

        }
        public void searchErrorsQuery(string searchTerm)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                string sql = @"
        SELECT errorTitle,errorMessage,context,languageName,errorTypeName
        FROM Error
        INNER JOIN ProgrammingLanguage
            ON Error.languageID = ProgrammingLanguage.languageID
        INNER JOIN ErrorType
            ON Error.errorTypeID = ErrorType.errorTypeID
        WHERE Error.projectID = @ID
        AND Error.isArchived = 0";

                List<string> conditions = new List<string>();
                if (cbErrorMessage.Checked)
                {
                    conditions.Add("errorMessage LIKE @searchText");
                }
                if (cbErrorTitle.Checked)
                {
                    conditions.Add("errorTitle LIKE @searchText");
                }
                if (cbContext.Checked)
                {
                    conditions.Add("context LIKE @searchText");
                }
                if (conditions.Count > 0)
                {
                    sql += " AND (";
                    sql += string.Join(" OR ", conditions);
                    sql += ")";
                }
                if (cmbLanguage.SelectedIndex != -1)
                {
                    sql += " AND Error.languageID=@LanguageID";
                   
                }
                if (cmbErrorType.SelectedIndex != -1)
                {
                    sql += " AND Error.errorTypeID=@ErrorTypeID";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", projectID);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchTerm + "%");

                if (cmbLanguage.SelectedIndex != -1)
                cmd.Parameters.AddWithValue("@LanguageID",cmbLanguage.SelectedValue);

                if (cmbErrorType.SelectedIndex != -1)
                    cmd.Parameters.AddWithValue("@ErrorTypeID", cmbErrorType.SelectedValue);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvErrors.DataSource = dt;
                //MessageBox.Show(sql.ToString());
            }
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            searchErrorsQuery(txtSearchTerm.Text.Trim());
            searchCodeSnippet(txtSearchTerm.Text.Trim());
        }

        public void searchCodeSnippet(string searchTerm)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                string sql = @"
       SELECT title, code, explanation, notes, languageName, categoryName
FROM CodeSnippet
INNER JOIN ProgrammingLanguage
    ON CodeSnippet.languageID = ProgrammingLanguage.languageID
INNER JOIN Category
    ON CodeSnippet.categoryID = Category.categoryID
WHERE CodeSnippet.projectID = @ID
AND CodeSnippet.isArchived = 0";

                List<string> conditions = new List<string>();
                if (cbCode.Checked)
                {
                    conditions.Add("code LIKE @searchText");
                }
                if (cbErrorTitle.Checked)
                {
                    conditions.Add("title LIKE @searchText");
                }
                
                if (conditions.Count > 0)
                {
                    sql += " AND (";
                    sql += string.Join(" OR ", conditions);
                    sql += ")";
                }
                if (cmbLanguage.SelectedIndex != -1)
                {
                    sql += " AND CodeSnippet.languageID=@LanguageID";

                }
                if (cmbCategory.SelectedIndex != -1)
                {
                    sql += " AND CodeSnippet.categoryID=@CategoryID";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", projectID);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchTerm + "%");

                if (cmbLanguage.SelectedIndex != -1)
                    cmd.Parameters.AddWithValue("@LanguageID", cmbLanguage.SelectedValue);

                if (cmbCategory.SelectedIndex != -1)
                    cmd.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvCodeSnippets.DataSource = dt;
               // MessageBox.Show(sql.ToString());
            }
        }

        private void RefreshData()
        {
            displayErrorsQuery();
            displayCodeSnippetsQuery();
        }
    }
}
