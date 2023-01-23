namespace CasinoManagementSystem
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox__data = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView_player = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox_PlyId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_game = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridView_data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(217, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Player List";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(12, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 14);
            this.panel2.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 49);
            this.panel1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(819, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Add Data";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.SystemColors.Control;
            this.button_add.Location = new System.Drawing.Point(1029, 637);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 44);
            this.button_add.TabIndex = 49;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_clear.Location = new System.Drawing.Point(871, 637);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(100, 44);
            this.button_clear.TabIndex = 48;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_description.Location = new System.Drawing.Point(134, 602);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(516, 81);
            this.textBox_description.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(26, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Description :";
            // 
            // textBox__data
            // 
            this.textBox__data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox__data.Location = new System.Drawing.Point(134, 550);
            this.textBox__data.Name = "textBox__data";
            this.textBox__data.Size = new System.Drawing.Size(156, 29);
            this.textBox__data.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(58, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Bet ($) : ";
            // 
            // DataGridView_player
            // 
            this.DataGridView_player.AllowUserToAddRows = false;
            this.DataGridView_player.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_player.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_player.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_player.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_player.ColumnHeadersHeight = 24;
            this.DataGridView_player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_player.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_player.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_player.Location = new System.Drawing.Point(9, 53);
            this.DataGridView_player.Name = "DataGridView_player";
            this.DataGridView_player.RowHeadersVisible = false;
            this.DataGridView_player.RowTemplate.Height = 80;
            this.DataGridView_player.Size = new System.Drawing.Size(533, 349);
            this.DataGridView_player.TabIndex = 43;
            this.DataGridView_player.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_player.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_player.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_player.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_player.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_player.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_player.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_player.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_player.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_player.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_player.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_player.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_player.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_player.ThemeStyle.ReadOnly = false;
            this.DataGridView_player.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_player.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_player.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_player.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_player.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_player.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_player.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_player.Click += new System.EventHandler(this.DataGridView_player_Click);
            // 
            // textBox_PlyId
            // 
            this.textBox_PlyId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PlyId.Location = new System.Drawing.Point(134, 434);
            this.textBox_PlyId.Name = "textBox_PlyId";
            this.textBox_PlyId.Size = new System.Drawing.Size(156, 29);
            this.textBox_PlyId.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(43, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Player Id : ";
            // 
            // comboBox_game
            // 
            this.comboBox_game.FormattingEnabled = true;
            this.comboBox_game.Location = new System.Drawing.Point(134, 490);
            this.comboBox_game.Name = "comboBox_game";
            this.comboBox_game.Size = new System.Drawing.Size(516, 29);
            this.comboBox_game.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(15, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Select Game : ";
            // 
            // DataGridView_data
            // 
            this.DataGridView_data.AllowUserToAddRows = false;
            this.DataGridView_data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_data.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_data.ColumnHeadersHeight = 24;
            this.DataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_data.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_data.Location = new System.Drawing.Point(593, 53);
            this.DataGridView_data.Name = "DataGridView_data";
            this.DataGridView_data.RowHeadersVisible = false;
            this.DataGridView_data.RowTemplate.Height = 80;
            this.DataGridView_data.Size = new System.Drawing.Size(536, 349);
            this.DataGridView_data.TabIndex = 54;
            this.DataGridView_data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_data.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_data.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_data.ThemeStyle.ReadOnly = false;
            this.DataGridView_data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_data.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(562, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 363);
            this.panel3.TabIndex = 55;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DataGridView_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_game);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox__data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridView_player);
            this.Controls.Add(this.textBox_PlyId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Panel panel2;
        private Panel panel1;
        private Button button_add;
        private Button button_clear;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox__data;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_player;
        private TextBox textBox_PlyId;
        private Label label1;
        private ComboBox comboBox_game;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_data;
        private Panel panel3;
    }
}