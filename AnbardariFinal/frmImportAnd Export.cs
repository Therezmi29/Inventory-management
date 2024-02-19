using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace AnbardariFinal
{
    public partial class frmImportAnd_Export : Form
    {
        IExportAndImportRepository repository;
        int id;
        public frmImportAnd_Export()
        {
            InitializeComponent();
            repository = new ExportAndImportRepository();
        }

        private void btnSearchCodeProduct_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtCodeProduct.Text);
            DataTable data = repository.SearchProduct(id);
            txtProductName.Text = data.Rows[0][1].ToString();
            txtProductSerial.Text = data.Rows[0][3].ToString();

        }

        private void btnSearchCodeStore_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtCodeStore.Text);
            DataTable data = repository.SearchStore(id);
            txtStoreName.Text = data.Rows[0][1].ToString();
        }

        private void btnAddProductToStore_Click(object sender, EventArgs e)
        {
            frmAddProductToStore form = new frmAddProductToStore();
            form.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProducts form = new frmProducts();
            form.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                bool isSuccess;
                isSuccess = repository.Insert(int.Parse(txtCodeProduct.Text), txtProductName.Text, int.Parse(txtProductSerial.Text), int.Parse(txtCodeStore.Text), txtStoreName.Text, int.Parse(txtNumber.Text), txtPerson.Text, cmbType.Text, mtbCalendar.Text, txtNote.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);                }
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

        private void frmImportAnd_Export_Load(object sender, EventArgs e)
        {
            dgExportImport.AutoGenerateColumns = false;
        }



        bool validationInput()
        {
            if (txtCodeProduct.Text == "")
            {
                MessageBox.Show("لطفا کد کالا را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCodeStore.Text == "")
            {
                MessageBox.Show("لطفا کد انبار را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNumber.Text == "")
            {
                MessageBox.Show("لطفا تعداد را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPerson.Text == "")
            {
                MessageBox.Show("لطفا شخص را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbType.Text == "")
            {
                MessageBox.Show("لطفا نوع کاربری شخص را مشخص کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (mtbCalendar.Text == "")
            {
                MessageBox.Show("لطفا تاریخ را وارد کنید", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();
            Report.Load("Report/rptExportImport.mrt");
            Report.Compile();
            Report.ShowWithRibbonGUI();

            
        }
    }
}
