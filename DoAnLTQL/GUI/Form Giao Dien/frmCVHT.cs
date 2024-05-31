using BUS;
using DTO;
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
    public partial class frmCVHT : Form
    {
        public frmCVHT()
        {
            InitializeComponent();
            CenterControl(panelGroup);
        }
        private void CenterControl(Control control)
        {
            control.Anchor = AnchorStyles.None; 
            int x = (this.ClientSize.Width - control.Width) / 2;
            int y = (this.ClientSize.Height - control.Height) / 2;
            control.Location = new Point(x, y);
        }

        private void frmCVHT_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            List<CVHT_DTO> lstcvht = CVHT_BUS.LayListCVHT();
            if(lstcvht!=null && lstcvht.Count > 0 )
            {
                dgvCVHT.DataSource = lstcvht;
                dgvCVHT.Columns["Id"].HeaderText = "ID";
                dgvCVHT.Columns["Id"].Width = 140;
                dgvCVHT.Columns["MaCVHT"].HeaderText = "Mã CVHT";
                dgvCVHT.Columns["MaCVHT"].Width = 180;
                dgvCVHT.Columns["TenCVHT"].HeaderText = "Tên CVHT";
                dgvCVHT.Columns["TenCVHT"].Width = 250;
                dgvCVHT.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvCVHT.Columns["NgaySinh"].Width = 180;
                dgvCVHT.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvCVHT.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvCVHT.Columns["GioiTinh"].Width = 180;
                dgvCVHT.Columns["TrangThai"].HeaderText = "Hoạt Động";
                dgvCVHT.Columns["TrangThai"].Width = 180;
                /*dgvMonHoc.Columns["TrangThai"].Visible = false;*/
                dgvCVHT.Columns["Id"].Visible = false;
            }    
        }

        private void btnThemCVHT_Click(object sender, EventArgs e)
        {
            if (txtMaCVHT.TextString.Equals("") || txtTenCVHT.TextString.Equals("")
               || (rdoNam.Checked==false && rdoNu.Checked==false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Cố vấn học tập!", "Thông báo");
            }
            else
            {
                CVHT_DTO ktcvht = CVHT_BUS.TimCVHTTheoMaCVHT(txtMaCVHT.TextString);
                if (ktcvht == null)
                {
                    CVHT_DTO cvht = new CVHT_DTO();
                    cvht.MaCVHT = txtMaCVHT.TextString.Trim();
                    cvht.TenCVHT = txtTenCVHT.TextString.Trim();
                    cvht.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
                    if (rdoNam.Checked)
                    {
                        cvht.GioiTinh = "Nam";
                    }
                    else
                    {
                        cvht.GioiTinh = "Nữ";
                    }
                   
                    bool ketQua = CVHT_BUS.ThemCVHT(cvht);

                    if (ketQua)
                    {
                        MessageBox.Show("Thêm Cố vấn học tập thành công", "Thông báo");
                        loadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Cố vấn học tập không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Cố vấn học tập đã tồn tại", "Thông báo");
                }
            }
        }

        private void btnCapNhatCVHT_Click(object sender, EventArgs e)
        {
            if (txtMaCVHT.TextString.Equals("") || txtTenCVHT.TextString.Equals("")
              || (rdoNam.Checked == false && rdoNu.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Cố vấn học tập!", "Thông báo");
            }
            else
            {
                CVHT_DTO cvht = CVHT_BUS.TimCVHTTheoMaCVHT(txtMaCVHT.TextString);
                if (cvht != null)
                {
                    cvht.MaCVHT = txtMaCVHT.TextString.Trim();
                    cvht.TenCVHT = txtTenCVHT.TextString.Trim();
                    cvht.NgaySinh = Convert.ToDateTime(dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
                    if (rdoNam.Checked)
                    {
                        cvht.GioiTinh = "Nam";
                    }
                    else
                    {
                        cvht.GioiTinh = "Nữ";
                    }

                    bool ketQua = CVHT_BUS.CapNhatCVHT(cvht);

                    if (ketQua)
                    {
                        MessageBox.Show("Cập nhật Cố vấn học tập thành công", "Thông báo");
                        loadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật Cố vấn học tập không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Cố vấn học tập chưa tồn tại", "Thông báo");
                }
            }
        }

        private void btnXoaCVHT_Click(object sender, EventArgs e)
        {
            if (txtMaCVHT.TextString.Equals("") || txtTenCVHT.TextString.Equals("")
              || (rdoNam.Checked == false && rdoNu.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Cố vấn học tập!", "Thông báo");
            }
            else
            {
                CVHT_DTO cvht = CVHT_BUS.TimCVHTTheoMaCVHT(txtMaCVHT.TextString);
                if (cvht != null)
                {

                    bool ketQua = CVHT_BUS.XoaCVHT(cvht.MaCVHT);

                    if (ketQua)
                    {
                        MessageBox.Show("Xóa Cố vấn học tập thành công", "Thông báo");
                        loadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Cố vấn học tập không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Cố vấn học tập không tồn tại", "Thông báo");
                }
            }
        }

        private void dgvCVHT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= -1)
            {
                DataGridViewRow row = dgvCVHT.Rows[e.RowIndex];
                txtMaCVHT.TextString = row.Cells[1].Value.ToString();
                txtTenCVHT.TextString = row.Cells[2].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                if (row.Cells[4].Value.ToString().Equals("Nam"))
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
            }
        }
    }
}
