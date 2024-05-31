using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_Giao_Dien
{
    public partial class frmLop : Form
    {
        public frmLop()
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

        private void frmLop_Load(object sender, EventArgs e)
        {
            loadComboBoxNganh();
            loadComboBoxCVHT();
            loadDataGridView();
        }

        private void loadComboBoxNganh()
        {
            List<Nganh_DTO> lstNganh = Nganh_BUS.LayListNganh();
            foreach(Nganh_DTO nganh in  lstNganh)
            {
                cboNganh.Items.Add(nganh.TenNganh);
            }
        }

        private void loadComboBoxCVHT()
        {
            List<CVHT_DTO> lstcvht = CVHT_BUS.LayListCVHT();
            foreach (CVHT_DTO cvht in lstcvht)
            {
                cboCVHT.Items.Add(cvht.TenCVHT);
            }
        }

        private void loadDataGridView()
        {
            List<Lop_DTO> lstlop = Lop_BUS.LayListLop();
            if(lstlop != null && lstlop.Count > 0)
            {
                dgvLop.DataSource = lstlop;
                dgvLop.Columns["Id"].HeaderText = "ID";
                dgvLop.Columns["Id"].Width = 140;
                dgvLop.Columns["MaLop"].HeaderText = "Mã Lớp";
                dgvLop.Columns["MaLop"].Width = 180;
                dgvLop.Columns["TenLop"].HeaderText = "Tên Lớp";
                dgvLop.Columns["TenLop"].Width = 250;
                dgvLop.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvLop.Columns["SoLuong"].Width = 180;
                dgvLop.Columns["MaCVHT"].HeaderText = "Mã CVHT";
                dgvLop.Columns["MaCVHT"].Width = 180;
                dgvLop.Columns["MaNganh"].HeaderText = "Mã Ngành";
                dgvLop.Columns["MaNganh"].Width = 180;
                dgvLop.Columns["TrangThai"].HeaderText = "Hoạt Động";
                dgvLop.Columns["TrangThai"].Width = 180;
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= -1)
            {
                DataGridViewRow row = dgvLop.Rows[e.RowIndex];
                txtMaLop.TextString = row.Cells[1].Value.ToString().Trim();
                txtTenLop.TextString = row.Cells[2].Value.ToString().Trim();
                txtSoLuong.TextString = row.Cells[3].Value.ToString().Trim();
                CVHT_DTO cvht = CVHT_BUS.TimCVHTCuaSV(row.Cells[4].Value.ToString().Trim());
                Nganh_DTO nganh = Nganh_BUS.TimNganhCuaSV(row.Cells[5].Value.ToString().Trim());
                cboCVHT.Texts = cvht.TenCVHT;
                cboNganh.Texts = nganh.TenNganh;
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextString.Equals("") || txtTenLop.TextString.Equals("")
               || txtSoLuong.TextString.Equals("") || cboCVHT.Texts.Equals("") ||
               cboNganh.Texts.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Lớp!", "Thông báo");
            }
            else if (!IsNumeric(txtSoLuong.TextString))
            {
                MessageBox.Show("Số lượng phải nhập là số!", "Thông báo");
            }
            else
            {
                Lop_DTO ktlop = Lop_BUS.TimLopTheoMaLop(txtMaLop.TextString.Trim());
                if (ktlop==null)
                {
                    Lop_DTO lop = new Lop_DTO();
                    lop.MaLop = txtMaLop.TextString.Trim();
                    lop.TenLop = txtTenLop.TextString.Trim();
                    lop.SoLuong = int.Parse(txtSoLuong.TextString);
                    CVHT_DTO cvht = CVHT_BUS.TimCVHTTheoTenCVHT(cboCVHT.Texts);
                    lop.MaCVHT = cvht.MaCVHT;
                    Nganh_DTO nganh = Nganh_BUS.TimNganhTheoTenNganh(cboNganh.Texts);
                    lop.MaNganh = nganh.MaNganh;
                    bool ketQua = Lop_BUS.ThemLop(lop);

                    if (ketQua)
                    {
                        MessageBox.Show("Thêm Lớp thành công", "Thông báo");
                        loadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Lớp không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Lớp đã tồn tại", "Thông báo");
                }
            }
        }

        public bool IsNumeric(string input)
        {
            // Biểu thức chính quy kiểm tra chuỗi chỉ chứa các ký tự số từ 0 đến 9
            Regex regex = new Regex(@"^\d+$");

            // So sánh chuỗi với biểu thức chính quy
            return regex.IsMatch(input);
        }

        private void btnCapNhatLop_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextString.Equals("") || txtTenLop.TextString.Equals("")
               || txtSoLuong.TextString.Equals("") || cboCVHT.Texts.Equals("") ||
               cboNganh.Texts.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Lớp!", "Thông báo");
            }
            else if (!IsNumeric(txtSoLuong.TextString))
            {
                MessageBox.Show("Số lượng phải nhập là số!", "Thông báo");
            }
            else
            {
                Lop_DTO lop = Lop_BUS.TimLopTheoMaLop(txtMaLop.TextString.Trim());
                if (lop != null)
                {
                    lop.MaLop = txtMaLop.TextString.Trim();
                    lop.TenLop = txtTenLop.TextString.Trim();
                    lop.SoLuong = int.Parse(txtSoLuong.TextString);
                    CVHT_DTO cvht = CVHT_BUS.TimCVHTTheoTenCVHT(cboCVHT.Texts);
                    lop.MaCVHT = cvht.MaCVHT;
                    Nganh_DTO nganh = Nganh_BUS.TimNganhTheoTenNganh(cboNganh.Texts);
                    lop.MaNganh = nganh.MaNganh;
                    bool ketQua = Lop_BUS.SuaLop(lop);

                    if (ketQua)
                    {
                        MessageBox.Show("Cập nhật Lớp thành công", "Thông báo");
                        loadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật Lớp không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Lớp chưa tồn tại", "Thông báo");
                }
            }
        }
    }
}
