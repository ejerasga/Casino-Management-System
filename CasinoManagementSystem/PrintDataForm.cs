using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;
using System.Reflection;

namespace CasinoManagementSystem
{
    public partial class PrintDataForm : Form
    {
        DataClass dataa = new DataClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintDataForm()
        {
            InitializeComponent();
        }

        private void PrintDataForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        // TO show data list
        public void showData()
        {
            DataGridView_data.DataSource = dataa.getList(new MySqlCommand("SELECT * FROM `data`"));
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            // DGVprinter helper for print pdf file 
            printer.Title = "Casino Player Data List";
            printer.SubTitle = string.Format("Date: {0})", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Group 3";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_data);
        }
        

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_data.DataSource = dataa.getList(new MySqlCommand("SELECT * FROM `data` WHERE CONCAT(player.PlyFirstName,player.PlyLastName,data.GameName)LIKE '%" + textBox_search.Text + "%'"));
        }
    }
    
}
