using DTO;
using GUI.Form_Giao_Dien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class viewSV : UserControl
    {
        private SinhVien_DTO sv;
        public event EventHandler ClickEvent;
        public viewSV(SinhVien_DTO sv)
        {
            InitializeComponent();
            lbMSSV.Text = sv.MaSinhVien;
            lbHoTen.Text = sv.HoVaTenSV;
            this.sv = sv;
        }

        public SinhVien_DTO GetSinhVien()
        {
            return sv;
        }

        private void viewSV_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện ClickEvent khi user control được click
            ClickEvent?.Invoke(this, e);
        }

    }
}
