using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QL_Duan
{
    public partial class frm_nguoidung : DevExpress.XtraEditors.XtraForm
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public frm_nguoidung()
        {
            InitializeComponent();
            // Cài đặt thuộc tính OFD
            xtraOpenFileDialog1.Title = "Select Picture";
            xtraOpenFileDialog1.Filter = "Windows Bitmap|*.bmp|JPEG Image|*.jpg|All Files|*.*";
        }
        //ảnh -> byte[]
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //byte[] -> ảnh
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_nguoidung_Load(object sender, EventArgs e)
        {
            //try
            //{
                //var collection = from c in data.Nhanviens
                //                 where c.Tendangnhap == frm_Main.Vitual_Username
                //                 select c;
           
                //txt_Manv.Text = collection.Single().Manv;
                //txt_Tennv.Text = collection.Single().Tendangnhap;
                //txt_Matkhau.Text = collection.Single().Matkhau;
                //txt_Hoten.Text = collection.Single().Hoten;
                //cmb_Chucvu.Text = collection.Single().Chucvu;
                //txt_Diachi.Text = collection.Single().Hokhau;
                //txt_Sodienthoai.Text = collection.Single().Sodienthoai;
                //txt_Email.Text = collection.Single().Email;
              // cmb_Quyen.Text=collection.Single().IDNhomquyen
               // check_Trangthai.Checked = Convert.ToBoolean(collection.Single().Tinhtrang);
              //  pic_Logo.Image = byteArrayToImage(collection.Single().Hinhanh.ToArray());


            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi load dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            try
            {

                Nhanvien update_thongtin = data.Nhanviens.Single(p => p.Manv == txt_Manv.Text);
                update_thongtin.Tendangnhap = txt_Tennv.Text;
                update_thongtin.Hoten = txt_Hoten.Text;
                update_thongtin.Matkhau = txt_Matkhau.Text;
                update_thongtin.Chucvu = cmb_Chucvu.Text;
                update_thongtin.Ngaysinh = txt_ngaysinh.Text;
                update_thongtin.Hokhau = txt_Diachi.Text;
                update_thongtin.Sodienthoai = txt_Sodienthoai.Text;
                update_thongtin.Email = txt_Email.Text;
                update_thongtin.Tinhtrang = check_Trangthai.Checked;

                update_thongtin.Hinhanh = imageToByteArray(pic_Logo.Image);
                data.SubmitChanges();
                MessageBox.Show("Bạn đã Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch
            {
                MessageBox.Show("Đường truyền Internet bị ngắt kết nối\n Kiểm tra lại đường truyền Internet của bạn. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } 
        }

        private void but_hinhanh_Click(object sender, EventArgs e)
        {

        }
    }
}