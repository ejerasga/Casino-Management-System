namespace CasinoManagementSystem
{
    partial class GameForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox__Ghour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView_game = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox_Gtype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Game";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(12, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 14);
            this.panel2.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 49);
            this.panel1.TabIndex = 39;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.SystemColors.Control;
            this.button_add.Location = new System.Drawing.Point(1029, 624);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 44);
            this.button_add.TabIndex = 38;
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
            this.button_clear.Location = new System.Drawing.Point(871, 624);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(100, 44);
            this.button_clear.TabIndex = 37;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_description.Location = new System.Drawing.Point(41, 599);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(516, 81);
            this.textBox_description.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(41, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Description :";
            // 
            // textBox__Ghour
            // 
            this.textBox__Ghour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox__Ghour.Location = new System.Drawing.Point(41, 519);
            this.textBox__Ghour.Name = "textBox__Ghour";
            this.textBox__Ghour.Size = new System.Drawing.Size(156, 29);
            this.textBox__Ghour.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(41, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hour : ";
            // 
            // DataGridView_game
            // 
            this.DataGridView_game.AllowUserToAddRows = false;
            this.DataGridView_game.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_game.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_game.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_game.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_game.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_game.ColumnHeadersHeight = 24;
            this.DataGridView_game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_game.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_game.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_game.Location = new System.Drawing.Point(12, 42);
            this.DataGridView_game.Name = "DataGridView_game";
            this.DataGridView_game.RowHeadersVisible = false;
            this.DataGridView_game.RowTemplate.Height = 80;
            this.DataGridView_game.Size = new System.Drawing.Size(1126, 340);
            this.DataGridView_game.TabIndex = 23;
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
            // 
            // textBox_Gtype
            // 
            this.textBox_Gtype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Gtype.Location = new System.Drawing.Point(41, 438);
            this.textBox_Gtype.Name = "textBox_Gtype";
            this.textBox_Gtype.Size = new System.Drawing.Size(264, 29);
            this.textBox_Gtype.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(41, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Game Type : ";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox__Ghour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridView_game);
            this.Controls.Add(this.textBox_Gtype);
            this.Controls.Add(this.label1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
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
        private Button button_add;
        private Button button_clear;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox__Ghour;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_game;
        private TextBox textBox_Gtype;
        private Label label1;
    }
}