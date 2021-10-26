using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                float magiamgia = float.Parse(txtGiamGia.Text);
                labTongTien.Text = (ThanhTien() - magiamgia).ToString();
                labTongTien.Text = string.Format("{0:0,0}", (ThanhTien() - magiamgia));
            }
            catch
            {
                MessageBox.Show("Không hợp lệ.\nVui lòng kiểm tra lại", "Thông Báo");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            System.GC.Collect(); // giải phóng dung lượng
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGrid_Product.Rows.Clear();
            //dataGrid_Product.Refresh;
            datatable.Rows.Clear();
        }
    }
}
