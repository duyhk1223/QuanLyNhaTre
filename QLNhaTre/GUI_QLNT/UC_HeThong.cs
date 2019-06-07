using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
