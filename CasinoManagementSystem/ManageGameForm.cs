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

namespace CasinoManagementSystem
{
    public partial class ManageGameForm : Form
    {
        GameClass game = new GameClass();
        public ManageGameForm()
        {
            InitializeComponent();
        }

        private void ManageGameForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        // Show data of the game
        private void showData()
        {
            // Show game ist on Datagridview
            DataGridView_game.DataSource = game.getGame(new MySqlCommand("SELECT * FROM `game`"));
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_Gtype.Clear();
            textBox__Ghour.Clear();
            textBox_description.Clear();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_Gtype.Text == "" || textBox__Ghour.Text == "" || textBox_Id.Equals(""))
            {
                MessageBox.Show("Need Game data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_Id.Text);
                string gName = textBox_Gtype.Text;
                int ghr = Convert.ToInt32(textBox__Ghour.Text);
                string desc = textBox_description.Text;

                if (game.updateGame(id, gName, ghr, desc))
                {

                    button_clear.PerformClick();
                    MessageBox.Show("Game update successfully", "Update Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error-Game not Edited", "Update Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_Id.Equals(""))
            {
                MessageBox.Show("Need Game id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_Id.Text);
                    if (game.deleteGame(id))
                    {

                        button_clear.PerformClick();
                        MessageBox.Show("Game Deleted", "Removed Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Removed Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_game_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = DataGridView_game.CurrentRow.Cells[0].Value.ToString();
            textBox_Gtype.Text = DataGridView_game.CurrentRow.Cells[1].Value.ToString();
            textBox__Ghour.Text = DataGridView_game.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = DataGridView_game.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // Search game an d show on datagridview
            DataGridView_game.DataSource = game.getGame(new MySqlCommand("SELECT * FROM `game` WHERE CONCAT(`GameName`)LIKE '%"+textBox_search.Text+"%'"));
            textBox_search.Clear();
        }
    }
}
