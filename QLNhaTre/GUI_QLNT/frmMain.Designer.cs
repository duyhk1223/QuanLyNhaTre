namespace GUI_QLNT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnHethong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGiaovien = new System.Windows.Forms.Button();
            this.btnHocsinh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pnlSide);
            this.panel1.Controls.Add(this.btnHethong);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnGiaovien);
            this.panel1.Controls.Add(this.btnHocsinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 560);
            this.panel1.TabIndex = 0;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSide.Location = new System.Drawing.Point(0, 19);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(7, 70);
            this.pnlSide.TabIndex = 1;
            // 
            // btnHethong
            // 
            this.btnHethong.BackColor = System.Drawing.Color.Transparent;
            this.btnHethong.FlatAppearance.BorderSize = 0;
            this.btnHethong.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHethong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHethong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHethong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHethong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHethong.ForeColor = System.Drawing.Color.White;
            this.btnHethong.Location = new System.Drawing.Point(0, 229);
            this.btnHethong.Margin = new System.Windows.Forms.Padding(0);
            this.btnHethong.Name = "btnHethong";
            this.btnHethong.Size = new System.Drawing.Size(135, 70);
            this.btnHethong.TabIndex = 3;
            this.btnHethong.Text = "Hệ thống";
            this.btnHethong.UseVisualStyleBackColor = false;
            this.btnHethong.Click += new System.EventHandler(this.btnHethong_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 159);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Học sinh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGiaovien
            // 
            this.btnGiaovien.BackColor = System.Drawing.Color.Transparent;
            this.btnGiaovien.FlatAppearance.BorderSize = 0;
            this.btnGiaovien.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGiaovien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGiaovien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGiaovien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaovien.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaovien.ForeColor = System.Drawing.Color.White;
            this.btnGiaovien.Location = new System.Drawing.Point(0, 89);
            this.btnGiaovien.Margin = new System.Windows.Forms.Padding(0);
            this.btnGiaovien.Name = "btnGiaovien";
            this.btnGiaovien.Size = new System.Drawing.Size(135, 70);
            this.btnGiaovien.TabIndex = 1;
            this.btnGiaovien.Text = "Giáo viên";
            this.btnGiaovien.UseVisualStyleBackColor = false;
            this.btnGiaovien.Click += new System.EventHandler(this.btnGiaovien_Click);
            // 
            // btnHocsinh
            // 
            this.btnHocsinh.BackColor = System.Drawing.Color.Transparent;
            this.btnHocsinh.FlatAppearance.BorderSize = 0;
            this.btnHocsinh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHocsinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHocsinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHocsinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocsinh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHocsinh.ForeColor = System.Drawing.Color.White;
            this.btnHocsinh.Location = new System.Drawing.Point(0, 19);
            this.btnHocsinh.Margin = new System.Windows.Forms.Padding(0);
            this.btnHocsinh.Name = "btnHocsinh";
            this.btnHocsinh.Size = new System.Drawing.Size(135, 70);
            this.btnHocsinh.TabIndex = 0;
            this.btnHocsinh.Text = "Học sinh";
            this.btnHocsinh.UseVisualStyleBackColor = false;
            this.btnHocsinh.Click += new System.EventHandler(this.btnHocsinh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(155, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 15);
            this.panel2.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(155, 75);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(905, 545);
            this.pnlControl.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "QUẢN LÝ NHÀ TRẺ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnHocsinh;
        private System.Windows.Forms.Button btnHethong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGiaovien;
    }
}