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
    }
}
