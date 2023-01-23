namespace CasinoManagementSystem
{
    partial class ManageGameForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox__Ghour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView_game = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox_Gtype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_game)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(499, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manage Game";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(12, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 14);
            this.panel2.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 49);
            this.panel1.TabIndex = 50;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.button_delete.Location = new System.Drawing.Point(1029, 634);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 44);
            this.button_delete.TabIndex = 49;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Update.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Update.Location = new System.Drawing.Point(906, 634);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(100, 44);
            this.button_Update.TabIndex = 48;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_description.Location = new System.Drawing.Point(41, 609);
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
            this.label5.Location = new System.Drawing.Point(41, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Description :";
            // 
            // textBox__Ghour
            // 
            this.textBox__Ghour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox__Ghour.Location = new System.Drawing.Point(41, 545);
            this.textBox__Ghour.Name = "textBox__Ghour";
            this.textBox__Ghour.Size = new System.Drawing.Size(166, 29);
            this.textBox__Ghour.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(41, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Hour : ";
            // 
            // DataGridView_game
            // 
            this.DataGridView_game.AllowUserToAddRows = false;
            this.DataGridView_game.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_game.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_game.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_game.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_game.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_game.ColumnHeadersHeight = 24;
            this.DataGridView_game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_game.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_game.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_game.Location = new System.Drawing.Point(12, 89);
            this.DataGridView_game.Name = "DataGridView_game";
            this.DataGridView_game.RowHeadersVisible = false;
            this.DataGridView_game.RowTemplate.Height = 80;
            this.DataGridView_game.Size = new System.Drawing.Size(1126, 342);
            this.DataGridView_game.TabIndex = 43;
            this.DataGridView_game.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_game.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_game.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_game.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_game.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_game.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_game.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_game.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_game.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_game.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_game.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_game.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_game.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_game.ThemeStyle.ReadOnly = false;
            this.DataGridView_game.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_game.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_game.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_game.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_game.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_game.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_game.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_game.Click += new System.EventHandler(this.DataGridView_game_Click);
            // 
            // textBox_Gtype
            // 
            this.textBox_Gtype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Gtype.Location = new System.Drawing.Point(41, 478);
            this.textBox_Gtype.Name = "textBox_Gtype";
            this.textBox_Gtype.Size = new System.Drawing.Size(296, 29);
            this.textBox_Gtype.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(41, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Game Type : ";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Id.Location = new System.Drawing.Point(405, 545);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(152, 29);
            this.textBox_Id.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(405, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Game Id : ";
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_clear.Location = new System.Drawing.Point(783, 634);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(100, 44);
            this.button_clear.TabIndex = 54;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(852, 54);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(180, 29);
            this.textBox_search.TabIndex = 56;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_search.ForeColor = System.Drawing.SystemColors.Control;
            this.button_search.Location = new System.Drawing.Point(1038, 53);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 30);
            this.button_search.TabIndex = 55;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // ManageGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox__Ghour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridView_game);
            this.Controls.Add(this.textBox_Gtype);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageGameForm";
            this.Text = "ManageGameForm";
            this.Load += new System.EventHandler(this.ManageGameForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Panel panel2;
        private Panel panel1;
        private Button button_delete;
        private Button button_Update;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox__Ghour;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_game;
        private TextBox textBox_Gtype;
        private Label label1;
        private TextBox textBox_Id;
        private Label label3;
        private Button button_clear;
        private TextBox textBox_search;
        private Button button_search;
    }
}