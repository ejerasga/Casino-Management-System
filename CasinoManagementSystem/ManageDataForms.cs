using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoManagementSystem
{
    public partial class ManageDataForms : Form
    {
        GameClass game = new GameClass();
        DataClass dataa = new DataClass();
        public ManageDataForms()
        {
            InitializeComponent();
        }

        private void ManageDataForms_Load(object sender, EventArgs e)
        {
            // Popualte the combobox with game types
            comboBox_game.DataSource = game.getGame(new MySqlCommand("SELECT * FROM `game`"));
            comboBox_game.DisplayMember = "GameName";
            comboBox_game.ValueMember = "GameName";
            // To show data on data gridview
            showData();
        }
        
        public void showData()
        {
            DataGridView_data.DataSource = dataa.getList(new MySqlCommand("SELECT * FROM `data`"));
        }

        private void button_Update_Click(object sender, EventArgs e)
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
               

                    if (dataa.updateData(plyId, gName, data, desc))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("Data Edited Complete", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data not Edited", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            
            if(textBox_PlyId.Text == "")
            {
                MessageBox.Show("Field Error- we need player id", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_PlyId.Text);
                if (MessageBox.Show("Are you sure you want to removed this data", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataa.deleteData(id))
                    {
                        showData();
                        MessageBox.Show("Data Removed", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_PlyId.Clear();
            textBox__data.Clear();
            textBox_description.Clear();
            textBox_search.Clear();
        }

        private void DataGridView_game_Click(object sender, EventArgs e)
        {
            textBox_PlyId.Text = DataGridView_data.CurrentRow.Cells[0].Value.ToString();
            comboBox_game.Text = DataGridView_data.CurrentRow.Cells[1].Value.ToString();
            textBox__data.Text = DataGridView_data.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = DataGridView_data.CurrentRow.Cells[3].Value.ToString();
        }

        private void DataGridView_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
