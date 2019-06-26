using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;

namespace GUI_QLNT
{
    public partial class UC_HeThong : UserControl
    {
        public UC_HeThong()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmThemND fthemND = new frmThemND();
            fthemND.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSuaND fsuaND = new frmSuaND();
            fsuaND.ShowDialog();
        }

        private void LoadNamHocToDGV()
        {
            dgvNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();

            dgvNamHoc.Columns[1].Visible = false;
            dgvNamHoc.Columns[4].Visible = false;
            dgvNamHoc.Columns[2].HeaderText = "Năm bắt đầu";
            dgvNamHoc.Columns[3].HeaderText = "Năm kết thúc";
            dgvNamHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dgvNamHoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvNamHoc.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void UC_HeThong_Load(object sender, EventArgs e)
        {
            LoadNamHocToDGV();
        }
    }
}
