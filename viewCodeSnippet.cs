using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopersDiaryApplication
{
    public partial class viewCodeSnippet : Form
    {
        //global variables
        int snippetID = -1;
        public viewCodeSnippet(int snippetID)
        {
            InitializeComponent();
            this.snippetID = snippetID;
        }

        private void viewCodeSnippet_Load(object sender, EventArgs e)
        {
            refresh();

           


        }

        private void cbShowNotes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowNotes.Checked==true)
            {
              rtbNotes.Visible = true;
            }
            else
            {
                rtbNotes.Visible = false;
            }
        }


        //helper method to set the text of a control based on a DataRow value, with a default text if the value is null
        private void SetText(Control control, DataRow row, string columnName, string defaultText = "")
        {
            if (row.IsNull(columnName))
                control.Text = defaultText;
            else
                control.Text = row[columnName].ToString();
        }

        private void cbEnableEditing_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableEditing.Checked)
            {
                pnlCode.Visible = false;
                pnlExplanation.Visible = false;


                rtbCode.Visible = true;
                rtbExplanation.Visible = true;


                rtbCode.Location = new Point(66, 250);
                rtbCode.Size = new Size(600, 300);

                rtbExplanation.Location = new Point(850, 250);
                rtbExplanation.Size = new Size(600, 300);


            }
            else
            {
                //hide editing boxes
                rtbCode.Visible = false;
                rtbExplanation.Visible = false;

                //make the panels visible again
                pnlCode.Visible = true;
                pnlExplanation.Visible = true;
                
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //ask for confirmation before saving
            DialogResult result = MessageBox.Show(
                "Are you sure you want to save changes to this code snippet?",
                "Confirm save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                codeSnippetTableAdapter1.UpdateQuery_CodeSnippet(rtbNotes.Text.Trim(), rtbExplanation.Text.Trim(), rtbCode.Text.Trim(), lblCodeTitle.Text, snippetID, snippetID);
                MessageBox.Show("Changes saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Changes not saved", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refresh();
        }

        private void refresh()
        {
            rtbNotes.Visible = false;
            rtbCode.Visible = false;
            rtbExplanation.Visible = false;
            cbEnableEditing.Checked = false;


            this.codeSnippetJoinTableAdapter1.Fill(developerDiaryDS1.CodeSnippetJoin, snippetID);
            if (developerDiaryDS1.CodeSnippetJoin.Rows.Count == 0)
            {
                MessageBox.Show("No rows");
                this.Close();
                return;
            }


            rtbNotes.Text = "No notes available";



            DataRow row = developerDiaryDS1.CodeSnippetJoin.Rows[0];
            lblCodeTitle.Text = row["title"].ToString();
            lblLanguage.Text = "Programming language: " + row["languageName"].ToString();
            lblCategory.Text = "Category: " + row["categoryName"].ToString();
            lblCode.Text = row["code"].ToString();
            lblexplanation.Text = row["explanation"].ToString();
            lblProjectName.Text = "Project name: " + row["projectName"].ToString();

            rtbExplanation.Text = row["explanation"].ToString();
            rtbCode.Text = row["code"].ToString();


            SetText(rtbNotes, row, "notes", "No notes available");
        }
    }
}
