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
    public partial class frmPersons : Form
    {
        IPersonRepository repository;
        public string Code = "";
        public frmPersons()
        {
            InitializeComponent();
            repository = new PersonRepository();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                bool isSuccess;
                isSuccess = repository.Insert(txtCodePerson.Text, txtPersonName.Text, cmbType.Text, txtPhone.Text, txtMobile.Text, txtPassword.Text, txtAddress.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodePerson.Text = txtPersonName.Text = cmbType.Text = txtPhone.Text = txtMobile.Text = txtPassword.Text = txtAddress.Text = null;
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        bool validationInput()
        {
            if (txtCodePerson.Text == "")
            {
                MessageBox.Show("لطفا کد ملی شخص را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPersonName.Text == "")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbType.SelectedIndex == 0)
            {
                MessageBox.Show("لطفا نوع کاربری شخص را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("لطفا موبایل را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("لطفا رمز عبور را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                bool isSuccess;
                isSuccess = repository.Update(txtCodePerson.Text, txtPersonName.Text, cmbType.Text, txtPhone.Text, txtMobile.Text, txtPassword.Text, txtAddress.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPersonName.Text = cmbType.Text = txtPhone.Text = txtMobile.Text = txtAddress.Text = txtPassword.Text = null;
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            DataTable data = repository.ReadData(Code);
            txtPersonName.Text = data.Rows[0]["Name"].ToString();
            cmbType.Text = data.Rows[0]["Type"].ToString();
            txtPhone.Text = data.Rows[0]["Phone"].ToString();
            txtMobile.Text = data.Rows[0]["Mobile"].ToString();
            txtMobile.Text = data.Rows[0]["Password"].ToString();
            txtAddress.Text = data.Rows[0]["Address"].ToString();


        }

    }
}
