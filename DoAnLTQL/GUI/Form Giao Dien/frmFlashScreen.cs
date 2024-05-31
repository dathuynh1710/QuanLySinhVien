using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_Giao_Dien
{
    public partial class frmFlashScreen : Form
    {
        public frmFlashScreen()
        {
            InitializeComponent();
        }

        private void timeFlashScreen_Tick(object sender, EventArgs e)
        {
            panel2.Width += 20;
            if (panel2.Width >= panel1.Width)
            {
                timeFlashScreen.Stop();
                foreach (Form form in Application.OpenForms)
                {
                    // Kiểm tra xem form có phải là frmMain không
                    if (form is frmMain)
                    {
                        // Nếu là frmMain, thực hiện phương thức OpenChildForm
                        ((frmMain)form).OpenChildForm(new frmSinhVien());
                        break; // Thoát khỏi vòng lặp sau khi thực hiện xong
                    }
                }
            }
        }


    }
}
