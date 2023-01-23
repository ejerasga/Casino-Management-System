namespace CasinoManagementSystem
{
    partial class PrintDataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button_upload = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.DataGridView_data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(12, 576);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 14);
            this.panel2.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 49);
            this.panel1.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(499, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "CMS Player Data List";
            // 
            // button_upload
            // 
            this.button_upload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_upload.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_upload.ForeColor = System.Drawing.SystemColors.Control;
            this.button_upload.Location = new System.Drawing.Point(897, 638);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(112, 44);
            this.button_upload.TabIndex = 85;
            this.button_upload.Text = "Print";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(844, 77);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(188, 29);
            this.textBox_search.TabIndex = 84;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_search.ForeColor = System.Drawing.SystemColors.Control;
            this.button_search.Location = new System.Drawing.Point(1038, 73);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 37);
            this.button_search.TabIndex = 83;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // DataGridView_data
            // 
            this.DataGridView_data.AllowUserToAddRows = false;
            this.DataGridView_data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.DataGridView_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_data.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridView_data.ColumnHeadersHeight = 24;
            this.DataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_data.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_data.Location = new System.Drawing.Point(12, 118);
            this.DataGridView_data.Name = "DataGridView_data";
            this.DataGridView_data.RowHeadersVisible = false;
            this.DataGridView_data.RowTemplate.Height = 80;
            this.DataGridView_data.Size = new System.Drawing.Size(1126, 456);
            this.DataGridView_data.TabIndex = 80;
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
            // PrintDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.DataGridView_data);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrintDataForm";
            this.Text = "PrintDataForm";
            this.Load += new System.EventHandler(this.PrintDataForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private Button button_upload;
        private TextBox textBox_search;
        private Button button_search;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_data;
    }
}