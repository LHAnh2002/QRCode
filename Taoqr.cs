using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace QRCode
{
    public partial class Taoqr : Form
    {   
        bool isGenerated = false;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HLLPPM6\SQLEXPRESS;Initial Catalog=QRCode;Integrated Security=True");
        bool trangthai;
        public Taoqr()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * From Thongtin", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            LvDT.DataSource = dt;
            conn.Close();
            //LvDT.Columns[0].Width = 150;
            //LvDT.Columns[0].HeaderText = "Tên Cán Bộ";
            //LvDT.Columns[1].Width = 110;
            //LvDT.Columns[1].HeaderText = "Ảnh";

        }
        private void thietlaptrangthai(bool AnHien)
        {
            btTaoMa.Enabled = AnHien;
            btThemAnh.Enabled = AnHien;
            btLuu.Enabled = !AnHien;
            btLamMoi.Enabled = AnHien;
            btXoaAnh.Enabled = AnHien;
        }

        private void TaoMa_Click(object sender, EventArgs e)
        {
            trangthai = true;
            thietlaptrangthai(true);
            if (txtID.Text.Trim().Length != 0)
            {
                isGenerated = true;
                QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
                var data = qr.CreateQrCode(txtID.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(data);
                anhqr.Image = code.GetGraphic(10);
            }
            else
            {
                MessageBox.Show("Chưa Điền Thông Tin!!!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Luu_Click(object sender, EventArgs e)
        {
            thietlaptrangthai(true);
            if (txtID.Text.Trim().Length != 0)
            {
                byte[] b = ImageToByteArray(HinhThongTin.Image);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Thongtin values (@ID,@Hinh)", conn);
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text;
                //cmd.Parameters.Add("@TenCanBo", SqlDbType.NVarChar).Value = txtThongTin.Text;
                cmd.Parameters.Add("@Hinh", SqlDbType.Image).Value = b;
                cmd.ExecuteNonQuery();
                conn.Close();
                loadData();
                if (isGenerated)
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AnhQR";
                    anhqr.Image.Save(path + "\\" + txtID.Text + ".png", ImageFormat.Png);

                }
                MessageBox.Show("Đã Lưu Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Chưa Điền Thông Tin!!!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //chuyển image sang byte[]
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        private void LamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtTimKiem.Clear();
        }

        private void HinhThongTin_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên Cán Bộ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThongTin.Focus();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE From Thongtin where ID= N'" + txtID.Text + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                loadData();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AnhQR";
                FileInfo filetodelete = new FileInfo(path + "\\" + txtID.Text + ".png");
                filetodelete.Delete();
                MessageBox.Show("Đã Xóa Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void LvDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = LvDT.CurrentCell.RowIndex;
            txtID.Text = LvDT.Rows[r].Cells[0].Value.ToString();
            byte[] b = (byte[])LvDT.Rows[r].Cells[1].Value;
            //HinhThongTin.Image = ByteArrayToImage(b);
            Image newImage = byteArrayToImage(b);
            HinhThongTin.Image = newImage;

        }
        //chuyển từ byte[] sang Image để gắn cho ảnh thông tin
        //Image ByteArrayToImage(byte[] b)
        //{
        //    MemoryStream m = new MemoryStream();
        //    return Image.FromStream(m);
        //}
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            thietlaptrangthai(false);
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                HinhThongTin.Image = Image.FromFile(op.FileName);
                this.Text = op.FileName;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Taoqr_Load(object sender, EventArgs e)
        {
            thietlaptrangthai(true);
            //conn.Open();
            //loadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            //if (txtTimKiem.Text == "")
            //{
            //    MessageBox.Show("Bạn hãy nhập dữ liệu");
            //}
            //else
            //{
            //    conn.Open();
            //    string Lenhsql = "select Hinh from Thongtin where ID = N'" + txtTimKiem.Text + "'";
            //    SqlCommand cmd = new SqlCommand(Lenhsql, conn);
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(dt);
            //    LvDT.DataSource = dt;
            //}
            string rowFilter = string.Format("{0} like '{1}'", "ID", "*" + txtTimKiem.Text + "*");
            (LvDT.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}

