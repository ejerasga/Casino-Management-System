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
    public partial class RegisterForm : Form
    {
        PlayerClass player = new PlayerClass();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
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

        private void button_upload_Click(object sender, EventArgs e)
        {
            // Browse photo from computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif;)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_player.Image = Image.FromFile(opf.FileName);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Add new player
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
            else if(verify())
            {
                try
                {
                    // To get photo from picture box
                    MemoryStream ms = new MemoryStream();
                    pictureBox_player.Image.Save(ms, pictureBox_player.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (player.insertPlayer(fname, lname, bdate, gender, phone, address, img))
                    {
                        showtTable();
                        MessageBox.Show("New Player Added", "Add Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }catch(Exception ex)
                
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Player", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Create a function to verify
        bool verify ()
        {
            if((textBox_Fname.Text =="") || (textBox__Lname.Text=="") || 
                (textBox_phone.Text=="") || (textBox_address.Text== "") ||
                (pictureBox_player.Image==null))
            {
                return false;
            }
            else
                return true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox__Lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_player.Image = null;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
