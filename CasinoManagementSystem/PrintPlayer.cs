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

namespace CasinoManagementSystem
{
    public partial class PrintPlayer : Form
    {
        PlayerClass player = new PlayerClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintPlayer()
        {
            InitializeComponent();
        }

        private void PrintPlayer_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `player`"));
        }

        // Function to show player list in datagridview
        public void showData(MySqlCommand command)
        {
            DataGridView_player.ReadOnly = true;
            DataGridView_player.Columns.Clear();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_player.DataSource = player.getList(command);

            // Column 7 is the image column index
            imageColumn = (DataGridViewImageColumn)DataGridView_player.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // Check the radio button
            string selectQuery;
            if(radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM `player`";
            }
            else if(radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM `player` WHERE `Gender`= 'Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM `player` WHERE `Gender`= 'Female'";
            }
            showData(new MySqlCommand(selectQuery));
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            /*
            // DGVprinter helper for print pdf file 
            printer.Title = "Casino Player List";
            printer.SubTitle = string.Format("Date: {0})", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Group 3";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_player);
            */
        }

        private void button_upload_Click_1(object sender, EventArgs e)
        {
            // DGVprinter helper for print pdf file 
            printer.Title = "Casino Player List";
            printer.SubTitle = string.Format("Date: {0})", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Group 3";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_player);
        }
    }
}
