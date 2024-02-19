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
    public partial class frmAddProductToStore : Form
    {
        IAddProductToStoreRepository repository;
        int id;
        public frmAddProductToStore()
        {
            InitializeComponent();
            repository = new AddProductToStoreRepository();
        }

        private void btnSearchCode_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtCode.Text);
            DataTable data = repository.Search_Code(id);
            txtCodeStore.Text = data.Rows[0][1].ToString();
            txtStoreName.Text = data.Rows[0][2].ToString();
            txtCodeProduct.Text = data.Rows[0][3].ToString();
            txtProductName.Text = data.Rows[0][4].ToString();
            txtProductSerial.Text = data.Rows[0][5].ToString();
            txtProductPlace.Text = data.Rows[0][6].ToString();
            txtFirstBalance.Text = data.Rows[0][7].ToString();
            txtCurrentBalance.Text = data.Rows[0][8].ToString();
        }

        private void btnSearchStore_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtCodeStore.Text);
            DataTable data = repository.Search_Store(id);
            txtStoreName.Text = data.Rows[0][1].ToString();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtCodeProduct.Text);
            DataTable data = repository.Search_Product(id);
            txtProductName.Text = data.Rows[0][1].ToString();
            txtProductSerial.Text = data.Rows[0][3].ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                bool isSuccess;
                isSuccess = repository.Insert(int.Parse(txtCode.Text), int.Parse(txtCodeStore.Text), txtStoreName.Text, int.Parse(txtCodeProduct.Text), txtProductName.Text, int.Parse(txtProductSerial.Text), txtProductPlace.Text, int.Parse(txtFirstBalance.Text), int.Parse(txtCurrentBalance.Text));
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Text = txtCodeStore.Text = txtStoreName.Text = txtCodeProduct.Text = txtProductName.Text = txtProductSerial.Text = txtProductPlace.Text = txtFirstBalance.Text = txtCurrentBalance.Text = null;
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




        bool validationInput()
        {
            if (txtCodeStore.Text == "")
            {
                MessageBox.Show("لطفا کد انبار را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCodeProduct.Text == "")
            {
                MessageBox.Show("لطفا کد کالا را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtProductPlace.Text == "")
            {
                MessageBox.Show("لطفا مکان کالا را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtFirstBalance.Text == "")
            {
                MessageBox.Show("لطفا موجودی اولیه را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return false;
        }

        private void frmAddProductToStore_Load(object sender, EventArgs e)
        {
           
        }
    }
}
