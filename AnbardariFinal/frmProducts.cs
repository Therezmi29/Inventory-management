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
    public partial class frmProducts : Form
    {
        IProductRepository repository;
        int Code;
        public frmProducts()
        {
            InitializeComponent();
            repository = new ProductRepository();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                bool isSuccess;
                isSuccess = repository.Insert(int.Parse(txtCode.Text), txtProductName.Text, cmbProductGroup.Text, int.Parse(txtProductSerial.Text), txtUnit.Text, txtNote.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Text = txtProductName.Text = cmbProductGroup.Text = txtProductSerial.Text = txtUnit.Text = txtNote.Text = null;
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
                MessageBox.Show("لطفا کد کالا را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtProductName.Text == "")
            {
                MessageBox.Show("لطفا نام کالا را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbProductGroup.Text == "")
            {
                MessageBox.Show("لطفا گروه کالا را انتخاب کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtProductSerial.Text == "")
            {
                MessageBox.Show("لطفا کد اموال کالا را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtUnit.Text == "")
            {
                MessageBox.Show("لطفا واحد کالا را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return false;
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
                isSuccess = repository.Update(int.Parse(txtCode.Text), txtProductName.Text, cmbProductGroup.Text, int.Parse(txtProductSerial.Text), txtUnit.Text, txtNote.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Text = txtProductName.Text = cmbProductGroup.Text = txtProductSerial.Text = txtUnit.Text = txtNote.Text = null;
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            Code = int.Parse(txtCode.Text);
            DataTable data = repository.ReadData(Code);
            txtProductName.Text = data.Rows[0][1].ToString();
            cmbProductGroup.Text = data.Rows[0][2].ToString();
            txtProductSerial.Text = data.Rows[0][3].ToString();
            txtUnit.Text = data.Rows[0][4].ToString();
            txtNote.Text = data.Rows[0][5].ToString();
        }

    }
}
