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
         setEnabled(false);
            //Fill the combo box with all languages
            this.programmingLanguageTableAdapter1.Fill(developerDiaryDS1.ProgrammingLanguage);

            cmbLanguage.DataSource = developerDiaryDS1.ProgrammingLanguage;
            cmbLanguage.DisplayMember = "languageName";
            cmbLanguage.ValueMember = "languageID";

            

            this.errorJoinExplanationJoinSolutionTableAdapter1.Fill(developerDiaryDS1.ErrorJoinExplanationJoinSolution,errorID);
            if (developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows.Count == 0)
            {
                MessageBox.Show("No rows");
                this.Close();
                return;
            }


            rtbExplanationAI.Text = "No explanation available";
            rtbExplanationPersonal.Text = "No explanation available";

            foreach (DataRow r in developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows)
            {
                if (r.IsNull("explanation"))
                    continue;

                if (r["type"].ToString() == "AI")
                    rtbExplanationAI.Text = r["explanation"].ToString();

                if (r["type"].ToString() == "Personal")
                    rtbExplanationPersonal.Text = r["explanation"].ToString();
            }

            DataRow row = developerDiaryDS1.ErrorJoinExplanationJoinSolution.Rows[0];
            cmbLanguage.Text = row["languageName"].ToString();
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

            if (cbPersonal.Checked==false)
            {
                rtbExplanationAI.Size = new Size(1200, 233);
            }
            else
            {
                rtbExplanationAI.Size = new Size(856, 233);
            }
        }

        private void cbPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPersonal.Checked)
            {
                rtbExplanationPersonal.Visible = true;
                rtbExplanationAI.Size = new Size(856, 233);
            }
            else
            {
                rtbExplanationPersonal.Visible = false;
                rtbExplanationAI.Size = new Size(1200, 233);
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


        private void setEnabled(bool State)
        {
            tbErrorTitle.Enabled = State;
            rtbErrorMessage.Enabled = State;
            rtbErrorContext.Enabled = State;
            rtbSolution.Enabled = State;
            rtbExplanationAI.Enabled = State;
            rtbExplanationPersonal.Enabled = State;
            rtbNotes.Enabled = State;
            cmbLanguage.Enabled = State;

        }

        

        private void cbEnableEditing_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableEditing.Checked)
            {
                setEnabled(true);
            }
            else
            {
                setEnabled(false);
            }
        }
    }
}
