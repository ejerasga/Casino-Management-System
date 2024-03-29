﻿using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        PlayerClass player = new PlayerClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please input Username and Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string uname = textBox_username.Text;
                string pass = textBox_password.Text;
                DataTable table = player.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + uname + "' AND `password`='" + pass + "'"));
                if (table.Rows.Count > 0)
                {

                    Form1 main = new Form1();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Username and Password are incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
        }
    }
}
