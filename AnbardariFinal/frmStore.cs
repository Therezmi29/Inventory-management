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
    public partial class frmStore : Form
    {
        IStoreRepository repository;
        public frmStore()
        {
            InitializeComponent();
            repository = new StoreRepository();
        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgStore.AutoGenerateColumns = false;
            dgStore.DataSource = repository.SelectAll();
        }

        private void txtStoreName_TextChanged(object sender, EventArgs e)
        {
            dgStore.DataSource = repository.SearchByName(txtStoreName.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                bool isSuccess;
                isSuccess = repository.Insert(int.Parse(txtCode.Text), txtStoreName.Text, txtStorePhone.Text, txtStoreAddress.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Text = txtStoreName.Text = txtStorePhone.Text = txtStoreAddress.Text = null;
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                bool isSuccess;
                isSuccess = repository.Update(int.Parse(txtCode.Text), txtStoreName.Text, txtStorePhone.Text, txtStoreAddress.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Text = txtStoreName.Text = txtStorePhone.Text = txtStoreAddress.Text = null;
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق بود", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف فیلد مورد نظر اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                int Code = int.Parse(dgStore.CurrentRow.Cells[0].Value.ToString());
                repository.Delete(Code);
                BindGrid();
            }
        }


        bool validationInput()
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("لطفا کد انبار را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtStoreName.Text == "")
            {
                MessageBox.Show("لطفا نام انبار را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtStorePhone.Text == "")
            {
                MessageBox.Show("لطفا تلفن انبار را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
