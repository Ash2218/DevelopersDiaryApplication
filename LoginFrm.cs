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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                {
                    string query = @"SELECT userID, userName, userEmail 
                         FROM Users 
                         WHERE userName = @userName AND userPassword = @userPassword";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", username);
                        cmd.Parameters.AddWithValue("@userPassword", password);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Store logged-in user info in the CurrentUser session class
                                Session.UserID = reader.GetInt32(reader.GetOrdinal("userID"));
                                Session.UserName = reader.GetString(reader.GetOrdinal("userName"));
                                Session.UserEmail = reader.GetString(reader.GetOrdinal("userEmail"));

                                MessageBox.Show("Login successful!", "Login",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MessageBox.Show("Welcome back "+ Session.UserName + "!"
                                    , "Login",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide();
                                Form1 main = new Form1();
                                main.FormClosed += (s, args) => this.Close();
                                main.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPassword.Clear();
                                txtPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
