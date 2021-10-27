using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienQuanCafe
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }
        DataTable datatable;



        private void FrmMain_Load(object sender, EventArgs e)
        {
            datatable = new DataTable();
            datatable.Columns.Add("Thức uống");
            datatable.Columns.Add("Số lượng");
            datatable.Columns.Add("Thành tiền");
            dataGrid_Product.DataSource = datatable;

            txtGiamGia.Text = "0";
            txtTenKhachHang.Text = "Khách Hàng A";


        }
        #region Viết sự kiện cho các button Menu
        private void btnCafeden_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Cafe Đen")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Cafe Đen", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Cafe Đen";
                row[1] = 1;
                row[2] = "10000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }
        private void btnCafeSua_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Cafe Sữa")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Cafe Sữa", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Cafe Sữa";
                row[1] = 1;
                row[2] = "12000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Diêm")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Diêm", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Diêm";
                row[1] = 1;
                row[2] = "2000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnBacXiu_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Bạc Xỉu")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Bạc Xỉu", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Bạc Xỉu";
                row[1] = 1;
                row[2] = "15000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnMiloDam_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Milo Dầm")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Milo Dầm", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Milo Dầm";
                row[1] = 1;
                row[2] = "35000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnTraChanh_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Trà Chanh")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Trà Chanh", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Trà Chanh";
                row[1] = 1;
                row[2] = "15000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btbTraSua_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Trà Sữa")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Trà Sữa", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Trà Sữa";
                row[1] = 1;
                row[2] = "25000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnTraSen_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Trà Sen")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Trà Sen", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Trà Sen";
                row[1] = 1;
                row[2] = "10000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnNuocSuoi_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Nước Suối")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Nước Suối", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Nước Suối";
                row[1] = 1;
                row[2] = "5000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnNuocNgot_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Nước Ngọt")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Nước Ngọt", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Nước Ngọt";
                row[1] = 1;
                row[2] = "10000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnKhoGa_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Khô Gà")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Khô Gà", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Khô Gà";
                row[1] = 1;
                row[2] = "25000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnHuongDuong_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Hướng Dương")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Hướng Dương", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Hướng Dương";
                row[1] = 1;
                row[2] = "9000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnHatDua_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Hạt Dưa")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Hạt Dưa", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Hạt Dưa";
                row[1] = 1;
                row[2] = "8000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnThuocLa555_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Thuốc Lá 555")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Thuốc Lá 555", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Thuốc Lá 555";
                row[1] = 1;
                row[2] = "55000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        private void btnThuocLaSaiGon_Click(object sender, EventArgs e)
        {
            Boolean kiemtra = true;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                // Đã tồn tại
                if (item[0].ToString() == "Thuốc Lá SaiGon")
                {
                    kiemtra = false;
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    item[2] = ThanhTien("Thuốc Lá SaiGon", int.Parse(item[1].ToString()));
                    break;
                }
            }
            // Chưa tồn tại
            if (kiemtra == true)
            {
                row[0] = "Thuốc Lá SaiGon";
                row[1] = 1;
                row[2] = "20000";
                datatable.Rows.Add(row);
            }
            // lable sum số lượng
            labSoLuong.Text = TongSoLuong().ToString();
            labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
        }

        #endregion
        #region Hàm tính toán
        private float ThanhTien(string name, int sl)
        {
            float ketqua = 0;
            switch (name)
            {
                case "Cafe Đen":
                    ketqua = sl * 10000;
                    break;
                case "Cafe Sữa":
                    ketqua = sl * 12000;
                    break;
                case "Bạc Xỉu":
                    ketqua = sl * 15000;
                    break;
                case "Trà Sữa":
                    ketqua = sl * 25000;
                    break;
                case "Trà Chanh":
                    ketqua = sl * 15000;
                    break;
                case "Milo Dầm":
                    ketqua = sl * 35000;
                    break;
                case "Trà Sen":
                    ketqua = sl * 10000;
                    break;
                case "Nước Suối":
                    ketqua = sl * 5000;
                    break;
                case "Nước Ngọt":
                    ketqua = sl * 10000;
                    break;
                case "Hạt Dưa":
                    ketqua = sl * 8000;
                    break;
                case "Hướng Dương":
                    ketqua = sl * 9000;
                    break;
                case "Khô Gà":
                    ketqua = sl * 25000;
                    break;
                case "Thuốc Lá 555":
                    ketqua = sl * 55000;
                    break;
                case "Thuốc Lá SaiGon":
                    ketqua = sl * 20000;
                    break;
                case "Diêm":
                    ketqua = sl * 2000;
                    break;
                default:
                    MessageBox.Show("Không hợp lệ", "Thông báo");
                    break;
            }
            return ketqua;
        }
        // Tổng số lượng
        private int TongSoLuong()
        {
            int SUM = 0;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                SUM = SUM + int.Parse(item[1].ToString());
            }
            return SUM;
        }
        // Thành tiền
        private float ThanhTien()
        {
            float THANHTIEN = 0;
            DataRow row;
            row = datatable.NewRow();
            // cộng dồn số lượng
            foreach (DataRow item in datatable.Rows)
            {
                THANHTIEN = THANHTIEN + float.Parse(item[2].ToString());
            }
            return THANHTIEN;
        }
        #endregion

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (labSoLuong.Text != "0")
                {
                    if (txtTenKhachHang.Text != "")
                    {
                        float magiamgia = float.Parse(txtGiamGia.Text);
                        labTongTien.Text = (ThanhTien() - magiamgia).ToString();
                        labTongTien.Text = string.Format("{0:0,0}", (ThanhTien() - magiamgia));


                    }
                    else
                        MessageBox.Show("Tên khách hàng trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Khách chưa order ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Không hợp lệ.\nVui lòng kiểm tra lại !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            System.GC.Collect(); // giải phóng dung lượng
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (labSoLuong.Text != "0")
            {
                int rowIndex = dataGrid_Product.CurrentCell.RowIndex;
                dataGrid_Product.Rows.RemoveAt(rowIndex);
                labSoLuong.Text = TongSoLuong().ToString();
                labThanhTien.Text = string.Format("{0:0,0}", (ThanhTien()));
            }
            else
                MessageBox.Show("Khách chưa order", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                StreamWriter streamwriter;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog.FileName;
                }
                else
                {
                    filename = @"D:\XuatHoaDon.txt";
                }
                if (!File.Exists(filename))
                {
                    streamwriter = new StreamWriter(filename);
                    streamwriter.WriteLine(string.Format("{0,-30}", dataGrid_Product.Columns[0].HeaderText) +
                                           string.Format("{0,-10}", dataGrid_Product.Columns[1].HeaderText) +
                                           string.Format("{0,-10}", dataGrid_Product.Columns[2].HeaderText)
                                          );
                    streamwriter.WriteLine("\n---------------------------------------------------");
                    streamwriter.WriteLine(txtTenKhachHang.Text + " Time(" + DateTime.Now + ") ");
                    for (int i = 0; i < dataGrid_Product.Rows.Count; i++)
                    {
                        streamwriter.WriteLine(string.Format("{0,-30}", dataGrid_Product.Rows[i].Cells[0].Value) +
                                               string.Format("{0,-10}", dataGrid_Product.Rows[i].Cells[1].Value) +
                                               string.Format("{0,-10}", dataGrid_Product.Rows[i].Cells[2].Value)
                                              );
                    }
                    streamwriter.WriteLine(string.Format("{0,-30}", "Tổng") +
                                           string.Format("{0,-10}", labSoLuong.Text) +
                                           string.Format("{0,-10}", labThanhTien.Text) + "  => $: " + labTongTien.Text
                                           );
                }
                else
                {
                    streamwriter = File.AppendText(filename);
                    streamwriter.WriteLine("\n---------------------------------------------------");
                    streamwriter.WriteLine(txtTenKhachHang.Text + " Time(" + DateTime.Now + ") ");
                    for (int i = 0; i < dataGrid_Product.Rows.Count; i++)
                    {
                        streamwriter.WriteLine(string.Format("{0,-30}", dataGrid_Product.Rows[i].Cells[0].Value) +
                                               string.Format("{0,-10}", dataGrid_Product.Rows[i].Cells[1].Value) +
                                               string.Format("{0,-10}", dataGrid_Product.Rows[i].Cells[2].Value)
                                              );
                    }
                    streamwriter.WriteLine(string.Format("{0,-30}", "Tổng") +
                                           string.Format("{0,-10}", labSoLuong.Text) +
                                           string.Format("{0,-10}", labThanhTien.Text) + "  => $: " + labTongTien.Text
                                          );
                }
                streamwriter.Close();
                MessageBox.Show("In thành công", "Thông Báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("In thất bại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (labSoLuong.Text != "0")
            {
                if (txtTenKhachHang.Text != "")
                {
                    DialogResult thongbao = MessageBox.Show("Số tiền cần trả là: " + labTongTien.Text + " vnđ\n\nXác nhận đã thanh toán nhấn YES", "Khách hàng: " + txtTenKhachHang.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (thongbao == DialogResult.Yes)
                    {
                        datatable.Rows.Clear();
                        labSoLuong.Text = "0";
                        labThanhTien.Text = "0";
                        labTongTien.Text = "0";
                        txtGiamGia.Text = "0";
                    }
                }
                else
                    MessageBox.Show("Tên khách hàng trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thực đơn đang trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
