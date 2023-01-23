using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace CasinoManagementSystem
{
    public partial class PrintGameForm : Form
    {
        GameClass game = new GameClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintGameForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // Search game an d show on datagridview
            DataGridView_player.DataSource = game.getGame(new MySqlCommand("SELECT * FROM `game` WHERE CONCAT(`GameName`)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            // DGVprinter helper for print pdf file 
            printer.Title = "Casino Game List";
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

        private void PrintGameForm_Load(object sender, EventArgs e)
        {
            DataGridView_player.DataSource = game.getGame(new MySqlCommand("SELECT * FROM `game`"));
        }
    }
}
