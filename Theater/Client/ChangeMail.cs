using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater.Client
{
    public partial class ChangeMail : Form
    {
        public string Email { get; set; }
        public ChangeMail()
        {
            InitializeComponent();
        }

        public ChangeMail(string email)
        {
            Email = email;
            InitializeComponent();
        }
        private void tbxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                btnApply_Click(this, new EventArgs());
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Email = tbxEmail.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ChangeMail_Load(object sender, EventArgs e)
        {
            tbxEmail.Text = Email;
        }
    }
}
