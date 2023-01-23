namespace CasinoManagementSystem
{
    public partial class Form1 : Form
    {
        PlayerClass player = new PlayerClass();
        public Form1()
        {
            InitializeComponent();
            customoziDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerCount();
        }
           // Functionto display player count
           private void playerCount()
        {
            // Display the values
            label_totalPly.Text = "Total Players : " + player.totalStudent();
            label_maleply.Text = "Male : " + player.maleStudent();
            label_femaleply.Text = "Female : " + player.femaleStudent();
        }
        
        private void customoziDesign()
        {
            panel_playersSubMenu.Visible = false;
            panel_gametypeSubMenu.Visible = false;
            panel_dataSubMenu.Visible = false;
        }
        
        private void hideSubmenu()
        {/*
            if (panel_playersSubMenu.Visible == true)
                panel_playersSubMenu = null;
            if (panel_gametypeSubMenu.Visible == true)
                panel_gametypeSubMenu = null;
            if (panel_dataSubMenu.Visible == true)
                panel_dataSubMenu = null;
            */
        }
        
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        
        
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_players_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            
            
        }

        private void button_managementPlayers_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button_playersPrint_Click(object sender, EventArgs e)
        {
            
           
        }
        
        private void button_gameType_Click(object sender, EventArgs e)
        {
           
        }
        
        private void butto_newGame_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button_manage_Game_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button_gametypePrint_Click(object sender, EventArgs e)
        {
            
            
        }
        
        private void button_data_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button_addData_Click(object sender, EventArgs e)
        {
           
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            
        }

        private void button_dataPrint_Click(object sender, EventArgs e)
        {
           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel_upperRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_top_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        // To show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        */

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button_registration_Click_1(object sender, EventArgs e)
        {

        }

        private void button_players_Click_1(object sender, EventArgs e)
        {

        }

        private void button_managementPlayers_Click_1(object sender, EventArgs e)
        {

        }

        private void button_player_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_playersSubMenu);
        }
        #region StdSubmenu
        private void button_gameType_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_gametypeSubMenu);
        }
        #region CourseSubmenu
        private void button_registration_Click_2(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            //...
            //...Your code
            //...
            hideSubmenu();
        }

        private void button_managePlayers_Click(object sender, EventArgs e)
        {
            openChildForm(new ManagePlayerForm());
            //...
            //...Your code
            //...
            hideSubmenu();
        }

        private void button_status_Click_1(object sender, EventArgs e)
        {
            //...
            //...Your code
            //...
            hideSubmenu();
        }

        private void button_playersPrint_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PrintPlayer());
            //...
            //...Your code
            //...
            hideSubmenu();
        }
        #endregion StdSubmenu
        private void button_newGame_Click(object sender, EventArgs e)
        {
            openChildForm(new GameForm());
            //...
            //...Your code
            //...
            hideSubmenu();
        }

        private void button_namageGame_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageGameForm());
            //...
            //...Your code
            //...
            hideSubmenu();
        }

        private void button_gametypePrint_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PrintGameForm());
            //...
            //...Your code
            //...
            hideSubmenu();
        }
        #endregion CourseSubmenu
        private void button_Data_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_dataSubMenu);
        }
        #region ScoreSubmenu
        private void button_addData_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DataForm());
            //...
            //...Your code
            //...
            hideSubmenu();
        }

        private void button_manage_Score_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageDataForms());
            //...
            //...Your code
            //...
            hideSubmenu();
        }

        private void button_dataPrint_Click_1(object sender, EventArgs e)
        {
            openChildForm(new PrintDataForm());
            //...
            //...Your code
            //...
            hideSubmenu();
        }
        #endregion ScoreSubmenu
        private void panel_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_top_Paint_2(object sender, PaintEventArgs e)
        {

        }

        // To show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {

        }

        private void panel_dataSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_gametypeSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_playersSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel_semiTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_role_Click(object sender, EventArgs e)
        {

        }

        private void label_user_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_main);
            playerCount();  
        }
    }
}