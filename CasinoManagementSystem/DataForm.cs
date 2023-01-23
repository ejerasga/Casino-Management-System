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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CasinoManagementSystem
{
    public partial class DataForm : Form
    {
        GameClass game = new GameClass();
        PlayerClass player = new PlayerClass();
        DataClass dataa = new DataClass();
        public DataForm()
        {
            InitializeComponent();
        }
        // Function to show data on datagridview data
        private void showData()
        {
            DataGridView_data.DataSource = dataa.getList(new MySqlCommand("SELECT * FROM `data`"));
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            // Popualte the combobox with game types
            comboBox_game.DataSource = game.getGame(new MySqlCommand("SELECT * FROM `game`"));
            comboBox_game.DisplayMember = "GameName";
            comboBox_game.ValueMember = "GameName";
            // To show data on datagridview 
            showData();
            // To Display player list on Datagridview
            DataGridView_player.DataSource = player.getList(new MySqlCommand("SELECT `PlyId`,`PlyFirstName`,`PlyLastName` FROM `player`"));

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_PlyId.Text == "" || textBox__data.Text == "")
            {
                MessageBox.Show("Need data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int plyId = Convert.ToInt32(textBox_PlyId.Text);
                string gName = comboBox_game.Text;
                double data = Convert.ToInt32(textBox__data.Text);
                string desc = textBox_description.Text;
                if (!dataa.checkData(plyId, gName))
                {

                    if (dataa.insertData(plyId, gName, data, desc))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("New data added", "Add Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data not added", "Add Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The data for this game are already exists","Add Data",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_PlyId.Clear();
            textBox__data.Clear();
            comboBox_game.SelectedIndex = 0;
            textBox_description.Clear(); 
        }

        private void DataGridView_player_Click(object sender, EventArgs e)
        {
            textBox_PlyId.Text = DataGridView_player.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
