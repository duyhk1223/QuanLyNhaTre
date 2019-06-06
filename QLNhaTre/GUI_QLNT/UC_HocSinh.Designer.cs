namespace GUI_QLNT
{
    partial class UC_HocSinh
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

        #region Component Designer generated code

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabctrlHocsinh = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDSHS = new System.Windows.Forms.TabPage();
            this.gridDSHS = new System.Windows.Forms.DataGridView();
            this.tabSK = new System.Windows.Forms.TabPage();
            this.gridSK = new System.Windows.Forms.DataGridView();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.cbThangdo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNamhoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabctrlHocsinh.SuspendLayout();
            this.tabDSHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHS)).BeginInit();
            this.tabSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSK)).BeginInit();
            this.pnlTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 452);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 5);
            this.panel2.TabIndex = 3;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabctrlHocsinh;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(5, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(892, 23);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "`";
            // 
            // tabctrlHocsinh
            // 
            this.tabctrlHocsinh.Controls.Add(this.tabDSHS);
            this.tabctrlHocsinh.Controls.Add(this.tabSK);
            this.tabctrlHocsinh.Depth = 0;
            this.tabctrlHocsinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlHocsinh.Location = new System.Drawing.Point(5, 68);
            this.tabctrlHocsinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabctrlHocsinh.Name = "tabctrlHocsinh";
            this.tabctrlHocsinh.SelectedIndex = 0;
            this.tabctrlHocsinh.Size = new System.Drawing.Size(892, 384);
            this.tabctrlHocsinh.TabIndex = 8;
            this.tabctrlHocsinh.SelectedIndexChanged += new System.EventHandler(this.tabctrlHocsinh_SelectedIndexChanged);
            // 
            // tabDSHS
            // 
            this.tabDSHS.Controls.Add(this.gridDSHS);
            this.tabDSHS.Location = new System.Drawing.Point(4, 22);
            this.tabDSHS.Name = "tabDSHS";
            this.tabDSHS.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSHS.Size = new System.Drawing.Size(884, 358);
            this.tabDSHS.TabIndex = 0;
            this.tabDSHS.Text = "Danh sách học sinh";
            this.tabDSHS.UseVisualStyleBackColor = true;
            // 
            // gridDSHS
            // 
            this.gridDSHS.AllowUserToAddRows = false;
            this.gridDSHS.AllowUserToDeleteRows = false;
            this.gridDSHS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.gridDSHS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDSHS.BackgroundColor = System.Drawing.Color.White;
            this.gridDSHS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDSHS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSHS.EnableHeadersVisualStyles = false;
            this.gridDSHS.Location = new System.Drawing.Point(3, 3);
            this.gridDSHS.Name = "gridDSHS";
            this.gridDSHS.ReadOnly = true;
            this.gridDSHS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDSHS.RowHeadersVisible = false;
            this.gridDSHS.RowHeadersWidth = 20;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridDSHS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDSHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDSHS.Size = new System.Drawing.Size(878, 352);
            this.gridDSHS.TabIndex = 0;
            // 
            // tabSK
            // 
            this.tabSK.Controls.Add(this.gridSK);
            this.tabSK.Location = new System.Drawing.Point(4, 22);
            this.tabSK.Name = "tabSK";
            this.tabSK.Padding = new System.Windows.Forms.Padding(3);
            this.tabSK.Size = new System.Drawing.Size(884, 358);
            this.tabSK.TabIndex = 1;
            this.tabSK.Text = "Theo dõi sức khỏe";
            this.tabSK.UseVisualStyleBackColor = true;
            // 
            // gridSK
            // 
            this.gridSK.AllowUserToAddRows = false;
            this.gridSK.AllowUserToDeleteRows = false;
            this.gridSK.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.gridSK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridSK.BackgroundColor = System.Drawing.Color.White;
            this.gridSK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSK.EnableHeadersVisualStyles = false;
            this.gridSK.Location = new System.Drawing.Point(3, 3);
            this.gridSK.Name = "gridSK";
            this.gridSK.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridSK.RowHeadersVisible = false;
            this.gridSK.RowHeadersWidth = 20;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridSK.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridSK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSK.Size = new System.Drawing.Size(878, 352);
            this.gridSK.TabIndex = 1;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTool.Controls.Add(this.cbThangdo);
            this.pnlTool.Controls.Add(this.label3);
            this.pnlTool.Controls.Add(this.cbNamhoc);
            this.pnlTool.Controls.Add(this.label2);
            this.pnlTool.Controls.Add(this.cbLop);
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Controls.Add(this.btnThem);
            this.pnlTool.Controls.Add(this.btnXoa);
            this.pnlTool.Controls.Add(this.btnLuu);
            this.pnlTool.Controls.Add(this.btnSua);
            this.pnlTool.Controls.Add(this.button1);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(5, 28);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(892, 40);
            this.pnlTool.TabIndex = 7;
            // 
            // cbThangdo
            // 
            this.cbThangdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThangdo.FormattingEnabled = true;
            this.cbThangdo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThangdo.Location = new System.Drawing.Point(406, 12);
            this.cbThangdo.Name = "cbThangdo";
            this.cbThangdo.Size = new System.Drawing.Size(40, 21);
            this.cbThangdo.TabIndex = 2;
            this.cbThangdo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(344, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tháng:";
            this.label3.Visible = false;
            // 
            // cbNamhoc
            // 
            this.cbNamhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamhoc.FormattingEnabled = true;
            this.cbNamhoc.Location = new System.Drawing.Point(231, 11);
            this.cbNamhoc.Name = "cbNamhoc";
            this.cbNamhoc.Size = new System.Drawing.Size(103, 21);
            this.cbNamhoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm học:";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(50, 11);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(96, 21);
            this.cbLop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(547, 1);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(778, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(778, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 40);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(661, 1);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 40);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(661, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xuất báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // UC_HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlHocsinh);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_HocSinh";
            this.Size = new System.Drawing.Size(897, 452);
            this.Load += new System.EventHandler(this.UC_HocSinh_Load);
            this.tabctrlHocsinh.ResumeLayout(false);
            this.tabDSHS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHS)).EndInit();
            this.tabSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSK)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabctrlHocsinh;
        private System.Windows.Forms.TabPage tabDSHS;
        private System.Windows.Forms.TabPage tabSK;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView gridDSHS;
        private System.Windows.Forms.ComboBox cbNamhoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbThangdo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridSK;
        private System.Windows.Forms.Button button1;
    }
}
