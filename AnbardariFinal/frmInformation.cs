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

    public partial class frmInformation : Form
    {
        IStockRepository Repository;
        public frmInformation()
        {
            InitializeComponent();
            Repository = new StockRepository();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validationInput())

            {
                bool isSuccess;
                isSuccess = Repository.Insert(int.Parse(txtCode.Text), txtCompanyName.Text, TxtOwnerName.Text, txtPhone.Text, txtFax.Text, txtAddress.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Text = TxtOwnerName.Text = txtCompanyName.Text = txtPhone.Text = txtFax.Text = txtAddress.Text = null;
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        bool validationInput()
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("لطفا کد اقتصادی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCompanyName.Text == "")
            {
                MessageBox.Show("لطفا نام شرکت را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("لطفا شماره تلفن را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                bool isSuccess;
                isSuccess = Repository.Update(int.Parse(txtCode.Text), txtCompanyName.Text, TxtOwnerName.Text, txtPhone.Text, txtFax.Text, txtAddress.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Text = TxtOwnerName.Text = txtCompanyName.Text = txtPhone.Text = txtFax.Text = txtAddress.Text = null;
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void frmInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
