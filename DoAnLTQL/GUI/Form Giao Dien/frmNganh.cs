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
    public partial class frmNganh : Form
    {
        public frmNganh()
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

        private void frmNganh_Load(object sender, EventArgs e)
        {
            loadDataGridViewNganh();
            loadComboBoxKhoa();
        }

        private void loadDataGridViewNganh()
        {
            List<Nganh_DTO> lstnganh = Nganh_BUS.LayListNganh();
            if(lstnganh!=null && lstnganh.Count > 0){
                dgvNganh.DataSource = lstnganh;
                dgvNganh.Columns[0].Width = 100;
                dgvNganh.Columns["Id"].HeaderText = "ID";
                dgvNganh.Columns["Id"].Width = 140;
                dgvNganh.Columns["MaNganh"].HeaderText = "Mã Ngành";
                dgvNganh.Columns["MaNganh"].Width = 180;
                dgvNganh.Columns["TenNganh"].HeaderText = "Tên Ngành";
                dgvNganh.Columns["TenNganh"].Width = 250;
                dgvNganh.Columns["MaKhoa"].HeaderText = "Mã Khoa";
                dgvNganh.Columns["MaKhoa"].Width = 180;
                dgvNganh.Columns["TrangThai"].HeaderText = "Hoạt Động";
                dgvNganh.Columns["TrangThai"].Width = 180;
                /*dgvNganh.Columns["TrangThai"].Visible = false;*/
                dgvNganh.Columns["Id"].Visible = false;
            }
        }

        private void loadComboBoxKhoa()
        {
            List<Khoa_DTO> lstkhoa = Khoa_BUS.LayListKhoa();
            if(lstkhoa!=null && lstkhoa.Count > 0)
            {
                foreach(Khoa_DTO khoa in lstkhoa)
                {
                    cboTenKhoa.Items.Add(khoa.TenKhoa);
                }
            }
        }

        private void btnThemNganh_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.TextString.Trim().Equals("") || txtTenNganh.TextString.Trim().Equals("") || cboTenKhoa.Texts.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                string maNganh = txtMaNganh.TextString.Trim();

                if (Nganh_BUS.KiemTraNganh(maNganh) == false)
                {
                    Khoa_DTO khoa = Khoa_BUS.TimKhoaCuaNganhTheoTenKhoa(cboTenKhoa.Texts);
                    if (khoa!=null)
                    {
                        Nganh_DTO nganh = new Nganh_DTO();

                        nganh.MaNganh = txtMaNganh.TextString.Trim();
                        nganh.TenNganh = txtTenNganh.TextString;
                        nganh.MaKhoa = khoa.MaKhoa;

                        bool ketQua = Nganh_BUS.ThemNganh(nganh);

                        if (ketQua)
                        {
                            MessageBox.Show("Thêm Ngành thành công", "Thông báo");
                            loadDataGridViewNganh();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Ngành không thành công", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không lấy khoa thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Ngành đã tồn tại", "Thông báo");
                }
            }
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maKhoa;
            if (e.RowIndex >= 0 && e.ColumnIndex >= -1)
            {
                DataGridViewRow row = dgvNganh.Rows[e.RowIndex];

                txtMaNganh.TextString = row.Cells[1].Value.ToString().Trim();
                txtTenNganh.TextString = row.Cells[2].Value.ToString();
                maKhoa = row.Cells[3].Value.ToString();
                Khoa_DTO khoa = Khoa_BUS.TimKhoaCuaSV(maKhoa);
                cboTenKhoa.Texts = khoa.TenKhoa;
            }
        }

        private void btnCapNhatNganh_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.TextString.Trim().Equals("") || txtTenNganh.TextString.Trim().Equals("") || cboTenKhoa.Texts.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                string maNganh = txtMaNganh.TextString.Trim();

                if (Nganh_BUS.KiemTraNganh(maNganh) == true)
                {
                    Khoa_DTO khoa = Khoa_BUS.TimKhoaCuaNganhTheoTenKhoa(cboTenKhoa.Texts);
                    if (khoa != null)
                    {
                        Nganh_DTO nganh = Nganh_BUS.TimNganhCuaSV(maNganh);
                        nganh.MaNganh = txtMaNganh.TextString;
                        nganh.TenNganh= txtTenNganh.TextString;
                        nganh.MaKhoa = khoa.MaKhoa;


                        bool ketQua = Nganh_BUS.CapNhatNganh(nganh);

                        if (ketQua)
                        {
                            MessageBox.Show("Cập nhật Ngành thành công", "Thông báo");
                            loadDataGridViewNganh();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Ngành không thành công", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không lấy khoa thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Ngành không tồn tại", "Thông báo");
                }
            }
        }

        private void btnXoaNganh_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.TextString.Trim().Equals("") || txtTenNganh.TextString.Trim().Equals("") || cboTenKhoa.Texts.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                string maNganh = txtMaNganh.TextString.Trim();

                if (Nganh_BUS.KiemTraNganh(maNganh) == true)
                {
                    Nganh_DTO nganh = Nganh_BUS.TimNganhCuaSV(maNganh);

                    bool ketQua = Nganh_BUS.XoaNganh(nganh);

                    if (ketQua)
                    {
                        MessageBox.Show("Xóa Ngành thành công", "Thông báo");
                        loadDataGridViewNganh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Ngành không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Ngành không tồn tại", "Thông báo");
                }
            }
        }
    }
}
