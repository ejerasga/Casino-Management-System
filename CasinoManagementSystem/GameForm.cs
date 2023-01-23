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

namespace CasinoManagementSystem
{
    public partial class GameForm : Form
    {
        GameClass game = new GameClass();
        public GameForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_Gtype.Text == "" || textBox__Ghour.Text == "")
            {
                MessageBox.Show("Need Game data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string gName = textBox_Gtype.Text;
                int ghr = Convert.ToInt32(textBox__Ghour.Text);
                string desc = textBox_description.Text;

                if (game.insertGame(gName, ghr, desc))
                {

                    button_clear.PerformClick();
                    MessageBox.Show("New game inserted", "Add Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Game not inserted", "Add Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Gtype.Clear();
            textBox__Ghour.Clear();
            textBox_description.Clear();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            // Show game ist on Datagridview
            DataGridView_game.DataSource = game.getGame(new MySqlCommand("SELECT * FROM `game`"));
        }
    }
}
