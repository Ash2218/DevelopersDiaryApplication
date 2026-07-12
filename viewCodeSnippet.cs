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
            rtbNotes.Visible = false;

            this.codeSnippetJoinTableAdapter1.Fill(developerDiaryDS1.CodeSnippetJoin, snippetID);

            if (developerDiaryDS1.CodeSnippetJoin.Rows.Count == 0)
            {
                MessageBox.Show("No rows");
                this.Close();
                return;
            }


            rtbNotes.Text = "No notes available";
           


            DataRow row = developerDiaryDS1.CodeSnippetJoin.Rows[0];
            lblCodeTitle.Text =  row["title"].ToString();
            lblLanguage.Text = "Programming language: "+row["languageName"].ToString();
            lblCategory.Text = "Category: " + row["categoryName"].ToString();
            lblCode.Text = row["code"].ToString();
            lblexplanation.Text = row["explanation"].ToString();
            lblProjectName.Text = "Project name: " + row["projectName"].ToString();


            SetText(rtbNotes, row, "notes", "No notes available");


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
    }
}
