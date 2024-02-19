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
    public partial class frmStoreBalance : Form
    {
        IAddProductToStoreRepository repository;
        public frmStoreBalance()
        {
            InitializeComponent();
            repository = new AddProductToStoreRepository();
        }

        private void txtSearchStore_TextChanged(object sender, EventArgs e)
        {
            repository.Search_Product(int.Parse(txtSearchStore.Text));
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            repository.Search_Product(int.Parse(txtProductSearch.Text));
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgStoreBalance.AutoGenerateColumns = false;
            dgStoreBalance.DataSource = repository.SelectAll();
        }

        private void btnPrintStore_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load("Report/rptBalance.mrt");
            report.Compile();
            report.ShowWithRibbonGUI();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
