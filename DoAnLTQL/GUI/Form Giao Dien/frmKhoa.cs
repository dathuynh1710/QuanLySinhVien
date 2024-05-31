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
using System.Windows.Markup;

namespace GUI.Form_Giao_Dien
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
            CenterControl(panelGroup);
        }
        private void CenterControl(Control control)
        {
            control.Anchor = AnchorStyles.None; // Bỏ anchor để không bị lệch khi form thay đổi kích thước
            int x = (this.ClientSize.Width - control.Width) / 2;
            int y = (this.ClientSize.Height - control.Height) / 2;
            control.Location = new Point(x, y);
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            loadDataGridViewKhoa();

        }

        private void loadDataGridViewKhoa()
        {
            List<Khoa_DTO> lstKhoa = Khoa_BUS.LayListKhoa();
            if (lstKhoa != null && lstKhoa.Count > 0)
            {
                dgvKhoa.DataSource = lstKhoa;
                dgvKhoa.Columns["Id"].HeaderText = "ID";
                dgvKhoa.Columns["Id"].Width = 100;
                dgvKhoa.Columns["MaKhoa"].HeaderText = "Mã Khoa";
                dgvKhoa.Columns["MaKhoa"].Width = 180;
                dgvKhoa.Columns["TenKhoa"].HeaderText = "Tên Khoa";
                dgvKhoa.Columns["TenKhoa"].Width = 250;
                dgvKhoa.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvKhoa.Columns["TrangThai"].Width = 150;

            }
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextString.Trim().Equals("") || txtTenKhoa.TextString.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                string maKhoa = txtMaKhoa.TextString.Trim();

                if (Khoa_BUS.KiemTraKhoa(maKhoa) == false)
                {
                    Khoa_DTO khoa = new Khoa_DTO();
                    khoa.MaKhoa = maKhoa;
                    khoa.TenKhoa = txtTenKhoa.TextString.Trim();

                    bool ketQua = Khoa_BUS.ThemKhoa(khoa);

                    if (ketQua)
                    {
                        MessageBox.Show("Thêm Khoa thành công", "Thông báo");
                        loadDataGridViewKhoa();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Khoa không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mã Khoa đã tồn tại", "Thông báo");
                }
            }
        }




        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= -1)
            {
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];

                txtMaKhoa.TextString = row.Cells[1].Value.ToString().Trim();
                txtTenKhoa.TextString = row.Cells[2].Value.ToString();
            }
        }

        private void btnCapNhatKhoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextString.Trim().Equals("") || txtTenKhoa.TextString.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                string maKhoa = txtMaKhoa.TextString.Trim();

                if (Khoa_BUS.KiemTraKhoa(maKhoa) == true)
                {
                    Khoa_DTO khoa = Khoa_BUS.TimKhoaCuaSV(txtMaKhoa.TextString.Trim());
                    khoa.MaKhoa = maKhoa;
                    khoa.TenKhoa = txtTenKhoa.TextString.Trim();

                    bool ketQua = Khoa_BUS.CapNhatKhoa(khoa);

                    if (ketQua)
                    {
                        MessageBox.Show("Cập nhật Khoa thành công", "Thông báo");
                        loadDataGridViewKhoa();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật Khoa không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Khoa chưa tồn tại", "Thông báo");
                }
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextString.Trim().Equals("") || txtTenKhoa.TextString.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                string maKhoa = txtMaKhoa.TextString.Trim();

                if (Khoa_BUS.KiemTraKhoa(maKhoa) == true)
                {
                    Khoa_DTO khoa = Khoa_BUS.TimKhoaCuaSV(txtMaKhoa.TextString.Trim());
                    khoa.MaKhoa = maKhoa;
                    khoa.TenKhoa = txtTenKhoa.TextString.Trim();

                    bool ketQua = Khoa_BUS.XoaKhoa(khoa);

                    if (ketQua)
                    {
                        MessageBox.Show("Xóa Khoa thành công", "Thông báo");
                        loadDataGridViewKhoa();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Khoa không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Khoa không tồn tại", "Thông báo");
                }
            }
        }
    }
}
