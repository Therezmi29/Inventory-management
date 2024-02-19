using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnbardariFinal
{
    public partial class frmUsers : Form
    {
        IPersonRepository repository;
        public frmUsers()
        {
            InitializeComponent();
            repository = new PersonRepository();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dt.Columns.Count > 0);
            Form1 frm = new Form1();
            frm.lblUserName.Text = txtUser.Text;
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        bool validationInput()
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("لطفا نام کاربری را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("لطفا رمز عبور را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


    }
}
