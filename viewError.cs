using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DevelopersDiaryApplication
{
    public partial class viewError : Form
    {
        //global variables
        int errorID = -1;
        public viewError(int errorID)
        {
            InitializeComponent();
            this.errorID = errorID;
        }

        private void viewError_Load(object sender, EventArgs e)
        {
         cbAI.Checked = true;
         cbPersonal.Checked = true;

            this.errorJoinExplanationJoinSolutionTableAdapter1.Fill(developerDiaryDS1.ErrorJoinExplanationJoinSolution,errorID);
            if (developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows.Count == 0)
            {
                MessageBox.Show("No rows");
                this.Close();
                return;
            }
            

            if (developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows[0]["explanation"]!=null) {
                int rowIndex = 0;
                while (rowIndex < developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows.Count)
                { //check if explanation exists
                    if (developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows[rowIndex]["explanation"].ToString() == "")
                    {
                        rtbExplanationAI.Text = "No explanation available";
                        rtbExplanationPersonal.Text = "No explanation available";
                    }
                    else if (developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows[rowIndex]["type"].ToString() == "AI")
                    {
                        rtbExplanationAI.Text = developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows[rowIndex]["explanation"].ToString();
                    }
                    else if (developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows[rowIndex]["type"].ToString() == "Personal")
                    {
                        rtbExplanationPersonal.Text = developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows[rowIndex]["explanation"].ToString();

                    }


                    rowIndex++;
                }//while

            }
            else
            {
                rtbExplanationPersonal.Text = "No explanation yet";
                rtbExplanationAI.Text = "No explanation yet";
            }

            DataRow row = developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows[0];

            SetText(tbErrorTitle, row, "errorTitle");
            SetText(rtbErrorMessage, row, "errorMessage");
            SetText(rtbErrorContext, row, "context", "No context available");
            SetText(rtbSolution, row, "solution", "No solution available");
            SetText(rtbNotes, row, "notes", "No notes available");







        }


        private void cbAI_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAI.Checked)
            {
                rtbExplanationAI.Visible = true;

            }
            else
            {
                rtbExplanationAI.Visible = false;
            }

            if (!cbPersonal.Checked)
            {
                rtbExplanationAI.Width = 1500;
            }
            else
            {
                rtbExplanationAI.Width = 700;
            }
        }

        private void cbPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPersonal.Checked)
            {
                rtbExplanationPersonal.Visible = true;
                rtbExplanationAI.Width = 700;
            }
            else
            {
                rtbExplanationPersonal.Visible = false;
                rtbExplanationAI.Width = 1500;
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
