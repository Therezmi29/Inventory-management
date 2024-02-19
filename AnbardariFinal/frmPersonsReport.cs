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
    public partial class frmPersonsReport : Form
    {
        IPersonRepository repository;
        public frmPersonsReport()
        {
            InitializeComponent();
            repository = new PersonRepository();
        }

        private void frmPersonsReport_Load(object sender, EventArgs e)
        {
            Bindgrid();
        }

        private void Bindgrid()
        {
            dgReport.AutoGenerateColumns = false;
            dgReport.DataSource = repository.SelectAll();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            dgReport.DataSource = repository.SearchByName(txtSearchName.Text);
        }

        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            dgReport.DataSource = repository.SearchByCode(txtSearchType.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {

                if (MessageBox.Show("آیا از حذف فیلد مورد نظر اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                string Code = dgReport.CurrentRow.Cells[0].Value.ToString();
                repository.Delete(Code);
                Bindgrid();
            }
            else
            {
                MessageBox.Show("لطفا یک فیلد را از لیست انتخاب کنید");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();
            Report.Load("Report/rptPersons.mrt");
            Report.Compile();
            Report.Show();
        }
    }
}
