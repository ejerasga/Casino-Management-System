using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace CasinoManagementSystem
{
    public partial class ManagePlayerForm : Form
    {
        PlayerClass player = new PlayerClass();
        public ManagePlayerForm()
        {
            InitializeComponent();
        }

        private void ManagePlayerForm_Load(object sender, EventArgs e)
        {
            showtTable();   
        }
        //To show player list in DatagridView
        public void showtTable()
        {
            DataGridView_player.DataSource = player.getPlayerlist(new MySqlCommand("SELECT * FROM `player`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_player.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView_player.DataSource = player.searchPlayer(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_player.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        // Display student data from student to textbox
        private void DataGridView_player_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_player.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = DataGridView_player.CurrentRow.Cells[1].Value.ToString();
            textBox__Lname.Text = DataGridView_player.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker1.Value = (DateTime)DataGridView_player.CurrentRow.Cells[3].Value;
            if (DataGridView_player.CurrentRow.Cells[4].Value.ToString() == "Male" )
                radioButton_male.Checked = true;

            textBox_phone.Text = DataGridView_player.CurrentRow.Cells[5].Value.ToString();
            textBox_address.Text = DataGridView_player.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])DataGridView_player.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);    
            pictureBox_player.Image = Image.FromStream(ms);
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Fname.Clear();
            textBox__Lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_player.Image = null;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            // Browse photo from computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif;)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_player.Image = Image.FromFile(opf.FileName);
        }

        // Create a function to verify
        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox__Lname.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == "") ||
                (pictureBox_player.Image == null))
            {
                return false;
            }
            else
                return true;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            // update player record
            int id = Convert.ToInt32(textBox_id.Text);
            string fname = textBox_Fname.Text;
            string lname = textBox__Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";



            // We need to check student age between 10 and 100

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The player age must be bwetween 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    // To get photo from picture box
                    MemoryStream ms = new MemoryStream();
                    pictureBox_player.Image.Save(ms, pictureBox_player.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (player.updatePlayer(id, fname, lname, bdate, gender, phone, address, img))
                    {
                        showtTable();
                        MessageBox.Show("Player data updated", "Update Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Player", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Remove the selected player
            int id = Convert.ToInt32(textBox_id.Text);
            // Show confirmation message before delete the player
            if(MessageBox.Show("Are you sure you want to removed this player", "Removed Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (player.deletePlayer(id))
                {
                    showtTable();
                    MessageBox.Show("Player Removed", "Remove player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
            }
        }
    }
}
