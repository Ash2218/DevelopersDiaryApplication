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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopersDiaryApplication
{
    public partial class AddCodeSnippet : Form
    {
        //global variables
        int projectID = -1;
        public AddCodeSnippet(int projectID)
        {

            InitializeComponent();
            this.projectID = projectID;
        }

       

        private void AddCodeSnippet_Load(object sender, EventArgs e)
        {
            rtbNotes.Visible = false;

            //add language options to the combo box
            this.programmingLanguageTableAdapter1.Fill(developerDiaryDS1.ProgrammingLanguage);
            cmbLanguage.DataSource = developerDiaryDS1.ProgrammingLanguage;
            cmbLanguage.DisplayMember = "languageName";
            cmbLanguage.ValueMember = "languageID";
            cmbLanguage.SelectedIndex = -1;

            //add category options to the combo box
            this.categoryTableAdapter1.Fill(developerDiaryDS1.Category);
            cmbCategory.DataSource = developerDiaryDS1.Category;
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryID";
            cmbCategory.SelectedIndex = -1;

        }

        private void cbAddNotes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddNotes.Checked == true)
            {
                rtbNotes.Visible = true;
            }
            else
            {
                rtbNotes.Visible = false;
            }
        }

        private async Task<string> GetChatGPTResponse(string code, string language, bool lineByLine)
        {

            string apiKey = ConfigurationManager.AppSettings["OpenRouterApiKey"];
            using (HttpClient client = new HttpClient())
            {


                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
                client.DefaultRequestHeaders.Add("HTTP-Referer", "https://github.com/Ash2218/DevelopersDiary");
                client.DefaultRequestHeaders.Add("X-Title", "Developers Diary");
                string prompt;

                if (lineByLine)
                {
                    prompt = $@"
                    Programming Language: {language}

                    Code:
                    {code}

                    Explain this code line by line.

                    For each line or block of code:
                    - Repeat the line of code.
                    - Explain what it does.
                    - Explain why it is used.
                    - Keep the explanation beginner friendly.
                    - Group related lines together where appropriate.
                    ";
                }
                else
                {
                    prompt = $@"
                    Programming Language: {language}

                    Code:
                    {code}

                    Give a general explanation of this code.

                    Include:
                    1. what it does.
                    2. How it works overall.
                    3. Important concepts used.
                    4. Keep the explanation beginner friendly.
                    ";
                }
                var requestBody = new
                {
                    model = "qwen/qwen3-coder",
                    messages = new[]
                   {
                        new
                             {
                               role = "system",
                               content = "You are an experienced software engineer and programming tutor. Explain source code to beginners in clear, simple English. Adapt your explanation based on the user's request. If they request a general explanation, summarize how the code works. If they request a line-by-line explanation, explain each significant line or block. Avoid unnecessary jargon and use beginner-friendly language."
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

        private async void pbGenerateExplanation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbCode.Text))
            {
                MessageBox.Show("Please enter some code first.");
                return;
            }
            if (!rbGeneral.Checked && !rbLineByLine.Checked)
            {
                MessageBox.Show("Please select an explanation type.");
                return;
            }

            

           
            try
            {
                // Disable UI
                pbGenerateExplanation.Enabled = false;
                Cursor = Cursors.WaitCursor;
                rtbExplanation.Text = "Generating explanation...";

                bool lineByLine = rbLineByLine.Checked;

                string response = await GetChatGPTResponse(
                    rtbCode.Text,
                    cmbLanguage.Text,
                    lineByLine);

                rtbExplanation.Text = response;
                FormatExplanation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message);
            }
            finally
            {
                // Re-enable UI
                pbGenerateExplanation.Enabled = true;
                Cursor = Cursors.Default;
            }


        }

        private void FormatExplanation()
        {
            string[] headings =
            {
                "What the code does","Why it's used","What it does","Important concepts used","What it does",
                "How it works overall",
                "Important concepts",
                "Line"
            };

            foreach (string heading in headings)
            {
                int startFor = 0;

                while ((startFor = rtbExplanation.Text.IndexOf(heading, startFor)) != -1)
                {
                    rtbExplanation.SelectionStart = startFor;
                    rtbExplanation.SelectionLength = heading.Length;
                    rtbExplanation.SelectionColor = Color.DarkBlue;
                    rtbExplanation.SelectionFont = new Font(
                        rtbExplanation.Font,
                        FontStyle.Bold);

                    // Continue searching after this occurrence
                    startFor += heading.Length;
                }
            }

            int start = 0;

            while ((start = rtbExplanation.Text.IndexOf("##", start)) != -1)
            {
                int end = rtbExplanation.Text.IndexOf('\n', start);

                if (end == -1)
                {
                    end = rtbExplanation.Text.Length;
                }
                rtbExplanation.SelectionStart = start;
                rtbExplanation.SelectionLength = end - start;
                rtbExplanation.SelectionColor = Color.DarkGreen;
                rtbExplanation.SelectionFont = new Font(
                    rtbExplanation.Font,
                    FontStyle.Bold);
                start = end;
            }
            rtbExplanation.SelectionStart = 0;
            rtbExplanation.SelectionLength = 0;
            rtbExplanation.SelectionColor = Color.Black;
        }

        private void btnSaveCodeSnippet_Click(object sender, EventArgs e)
        {
            if (IsControlEmpty(tbCodeTitle) || IsControlEmpty(rtbCode) || IsControlEmpty(rtbExplanation) || IsControlEmpty(cmbLanguage) || IsControlEmpty(cmbCategory))
            {
                MessageBox.Show("Please fill in all required fields ( Title, Code, Category, Language,Explanation).",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            //ask for confirmation before saving
            DialogResult result = MessageBox.Show(
            "Are you sure you want to save this code?",
            "Confirm save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Did not save code",
                "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                int categoryID = Convert.ToInt32(cmbCategory.SelectedValue);
                int languageID = Convert.ToInt32(cmbLanguage.SelectedValue);


                codeSnippetTableAdapter1.InsertQuery_CodeSnippet(Convert.ToInt32(projectID),languageID,categoryID,rtbNotes.Text,rtbExplanation.Text,rtbCode.Text,tbCodeTitle.Text, Convert.ToString(DateTime.Now), false);


               

                MessageBox.Show("Code saved successfully",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               //reload formm called viewProject 
                this.Close();
                




            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error while saving code:\n" + sqlEx.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
    }
}
