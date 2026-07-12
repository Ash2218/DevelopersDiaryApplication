using DevelopersDiaryApplication.developerDiaryDSTableAdapters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopersDiaryApplication
{
    public partial class addError : Form
    {
        //global variables
        int projectID = -1;
        int errorID = -1;
        //   private static readonly HttpClient client = new HttpClient();
        public addError(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
        }

        private void addError_Load(object sender, EventArgs e)
        {
            //hide solution group box
            gbSolution.Visible = false;
            btnAddSolution.Enabled = false;
            //Fill the combo box with all languages
            this.programmingLanguageTableAdapter1.Fill(developerDiaryDS1.ProgrammingLanguage);

            cmbLanguage.DataSource = developerDiaryDS1.ProgrammingLanguage;
            cmbLanguage.DisplayMember = "languageName";
            cmbLanguage.ValueMember = "languageID";

            //Fill the combo box with all error types
            this.errorTypeTableAdapter1.Fill(developerDiaryDS1.ErrorType);
            cmbErrorType.DataSource = developerDiaryDS1.ErrorType;
            cmbErrorType.DisplayMember = "errorTypeName";
            cmbErrorType.ValueMember = "errorTypeID";



        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.MdiParent;

            if (parent != null)
            {
                parent.FormSetup(new viewProject(projectID));
            }
        }
        private async Task<string> GetChatGPTResponse(string prompt)
        {

            string apiKey = ConfigurationManager.AppSettings["OpenRouterApiKey"];
            using (HttpClient client = new HttpClient())
            {

               
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
                client.DefaultRequestHeaders.Add("HTTP-Referer", "https://github.com/yourusername/DevelopersDiary");
                client.DefaultRequestHeaders.Add("X-Title", "Developers Diary");

                var requestBody = new
                {
                    model = "qwen/qwen3-coder",
                    messages = new[]
                   {
                        new
                             {
                               role = "system",
                               content = "You are an experienced software engineer. Explain programming errors to beginners in clear, simple English. Include what the error means, why it happens, and how to fix it. Avoid unnecessary jargon."
                              },
                        new
                        {
                           role = "user",
                             content = prompt
                        }
                    },
                    max_tokens = 500
                };

                var jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://openrouter.ai/api/v1/chat/completions", content);
                var responseString = await response.Content.ReadAsStringAsync();
               // MessageBox.Show(responseString);
                if (!response.IsSuccessStatusCode)
                {
                    return responseString;
                }

                var responseObject = JsonConvert.DeserializeObject<dynamic>(responseString);

                return responseObject?.choices[0]?.message?.content?.ToString();
            }
        }
        private async void btnGenerateExplanation_Click(object sender, EventArgs e)
        {
            string prompt = $@"
           Programming Language: {cmbLanguage.Text}

           Error Title:
           {tbErrorTitle.Text}

           Error Message:
           {rtbErrorMessage.Text}

           Context:
           {rtbErrorContext.Text}

           Explain this error in simple English.
           1. What it means.
           2. Why it happened.
           3. How to fix it.
           4. Type of error (e.g., compile error, runtime error, logic error, unsure.) and why you think that.
           ";

            if (!string.IsNullOrEmpty(prompt))
            {


                try
                {
                    btnGenerateExplanation.Enabled = false;
                    rtbExplanationAI.Text = "Generating explanation...";
                    Cursor = Cursors.WaitCursor;

                    string response = await GetChatGPTResponse(prompt);
                  //  MessageBox.Show(response);
                    rtbExplanationAI.Text = response;
                    Cursor = Cursors.Default;
                }
                finally
                {
                    btnGenerateExplanation.Enabled = true;
                }
            }
            else
            {

                MessageBox.Show("Please enter a prompt.");
            }
        }

        private void btnSaveError_Click(object sender, EventArgs e)
        {
            if (IsControlEmpty(tbErrorTitle) || IsControlEmpty(rtbErrorMessage) || IsControlEmpty(cmbErrorType) || IsControlEmpty(cmbLanguage) || IsControlEmpty(rtbExplanationAI))
            {
                MessageBox.Show("Please fill in all required fields (Error Title, Error Message, Error Type, Language,AI explanation).",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            //ask for confirmation before saving
            DialogResult result = MessageBox.Show(
            "Are you sure you want to save this error?",
            "Confirm save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Did not save error",
                "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                int errorTypeID = Convert.ToInt32(cmbErrorType.SelectedValue);
                int languageID = Convert.ToInt32(cmbLanguage.SelectedValue);


                errorID = Convert.ToInt32(
                        errorTableAdapter1.InsertQuery_Error(
                            projectID,
                        tbErrorTitle.Text.Trim(),
                        rtbErrorMessage.Text.Trim(),
                        rtbErrorContext.Text.Trim(),
                        Convert.ToString(DateTime.Now),
                        errorTypeID,
                        false,
                        languageID));

               
                explanationTableAdapter1.InsertQuery_Explanation(errorID, "AI", rtbExplanationAI.Text.Trim());
                explanationTableAdapter1.InsertQuery_Explanation(errorID, "Personal", rtbExplanationPersonal.Text.Trim());


                MessageBox.Show("Error saved successfully with ID: " + errorID,
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAddSolution.Enabled = true;
                lblErrorID.Text = "Error ID: " + errorID.ToString();



            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error while saving job request:\n" + sqlEx.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //method to check if control is empty
        private bool IsControlEmpty(Control control)
        {
            if (control is TextBox textBox)
            {
                return string.IsNullOrWhiteSpace(textBox.Text);
            }
            else if (control is RichTextBox richTextBox)
            {
                return string.IsNullOrWhiteSpace(richTextBox.Text);
            }
            else if (control is ComboBox comboBox)
            {
                return comboBox.SelectedIndex == -1;
            }
            // Add more control types as needed
            return false;
        }

        private void btnAddSolution_Click(object sender, EventArgs e)
        {
            gbSolution.Visible = true;
        }

        private void btnHideSolution_Click(object sender, EventArgs e)
        {
            gbSolution.Visible = false;
        }

        private void btnSaveSolution_Click(object sender, EventArgs e)
        {
           solutionTableAdapter1.InsertQuery_Solution(errorID, rtbSolution.Text.Trim(), rtbNotes.Text.Trim(),false);
            DialogResult result = MessageBox.Show(
             "Are you sure you want to save this solution?",
             "Confirm save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Did not save solution",
                "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Solution saved successfully",
                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
