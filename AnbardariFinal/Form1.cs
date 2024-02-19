using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AnbardariFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersianCalendar calendar = new PersianCalendar();
            lblDate.Text = calendar.GetYear(DateTime.Now).ToString() + "/" + calendar.GetMonth(DateTime.Now).ToString("0#") + "/" + calendar.GetDayOfMonth(DateTime.Now).ToString("0#");
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            PersianCalendar calendar = new PersianCalendar();
            lblTime.Text = calendar.GetHour(DateTime.Now).ToString("0#")+":"+calendar.GetMinute(DateTime.Now).ToString("0#")+":"+calendar.GetSecond(DateTime.Now).ToString("0#");

        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            frmInformation form = new frmInformation();
            form.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmPersons form = new frmPersons();
            form.ShowDialog();
        }

        private void btnCustomersReport_Click(object sender, EventArgs e)
        {
            frmPersonsReport form = new frmPersonsReport();
            form.ShowDialog();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnProductInfo_Click(object sender, EventArgs e)
        {
            frmProducts form = new frmProducts();
            form.ShowDialog();
        }

        private void btnProductReport_Click(object sender, EventArgs e)
        {
            frmProductReport form = new frmProductReport();
            form.ShowDialog();
        }

        private void btnStockInfo_Click(object sender, EventArgs e)
        {
            frmStore form = new frmStore();
            form.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProductToStore form = new frmAddProductToStore();
            form.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportAnd_Export form = new frmImportAnd_Export();
            form.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            frmImportAnd_Export form = new frmImportAnd_Export();
            form.Text = " خروج کالا از انبار";
            form.lblPerson.Text = "تحویل دهنده";
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnImportReport_Click(object sender, EventArgs e)
        {
            frmImportAnd_Export form = new frmImportAnd_Export();
            form.ShowDialog();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            frmImportAnd_Export form = new frmImportAnd_Export();
            form.Text = " خروج کالا از انبار";
            form.lblPerson.Text = "تحویل دهنده";
            form.ShowDialog();
        }

        private void btnBalanceReport_Click(object sender, EventArgs e)
        {
            frmStoreBalance form = new frmStoreBalance();
            form.ShowDialog();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
