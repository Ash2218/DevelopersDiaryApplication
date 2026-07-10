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
using System.Windows.Forms.VisualStyles;

namespace DevelopersDiaryApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void FormSetup(Form myForm)
        {
            //if a childform exists, close it 
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //set the parent form of the child window 
            myForm.MdiParent = this;

            //maximize the child window 
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();  //display the child window
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            FormSetup(new dashboardFrm());
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lblCurrentUser.Text = $"Current User: {Session.UserName} ({Session.UserEmail})";
            //MessageBox.Show("Show");
        }
        

        private void addNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProjectForm addProject = new addProjectForm();
            FormSetup(addProject);


        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboardFrm df = new dashboardFrm();
            FormSetup(df);
        }
    }
}
