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
    public partial class frmProductReport : Form
    {
        IProductRepository repository;
        public frmProductReport()
        {
            InitializeComponent();
            repository = new ProductRepository();
        }

        private void frmProductReport_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void BindGrid()
        {
            dgProduct.AutoGenerateColumns = false;
            dgProduct.DataSource = repository.SelectAll();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            repository.SearchByName(txtSearchName.Text);
        }

        private void cmbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            repository.SearchByName(cmbProductGroup.Text);
        }

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            repository.SearchByCode(int.Parse(txtSearchCode.ToString()));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف فیلد مورد نظر اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            {
                int Code = int.Parse(dgProduct.CurrentRow.Cells[0].Value.ToString());
                repository.Delete(Code);
                BindGrid();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();
            Report.Load("Report/rptProduct.mrt");
            Report.Compile();
            Report.ShowWithRibbonGUI();
        }
    }
}
