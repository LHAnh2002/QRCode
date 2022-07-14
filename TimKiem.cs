using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QRCode
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
            timer1.Start();
            
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HLLPPM6\SQLEXPRESS;Initial Catalog=QRCode;Integrated Security=True");
        public void funData(TextBox txtForm1)
        {
            txtID.Text = txtForm1.Text;
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Lenhsql = "select Hinh from Thongtin where ID = N'" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(Lenhsql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    byte[] images = (byte[])(dataReader[0]);

                    if (images == null)
                    {
                        HinhThongTin.Image = null;
                    }

                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(images);
                        HinhThongTin.Image = Image.FromStream(memoryStream);
                    }
                }
                else
                {
                    MessageBox.Show("Không có ảnh của thông tin này!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void HinhThongTin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
