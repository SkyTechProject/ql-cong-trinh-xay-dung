using System;
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
    public partial class frm_NewKhachHang : DevExpress.XtraEditors.XtraForm
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
       public static int checkNew;
       public static string vitualMaKH;
       protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
       {
          
           switch (keyData)
           {
               case (Keys.S | Keys.Control):
                   btn_Save.PerformClick();
                   break;
               case (Keys.Escape):
                   btn_Exit.PerformClick();
                   break;
               

           }
           // return true;
           return base.ProcessCmdKey(ref msg, keyData);
       }
        public frm_NewKhachHang( )
        {
            InitializeComponent( );
        }
        private void addsave()
        {
            if (txt_MaKH.Text == "")
            {
                MessageBox.Show("Không thể thêm dữ liệu này được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    tbl_Khachhang AddNew = new tbl_Khachhang() { MaKH = txt_MaKH.Text, TenKH = txt_TenKH.Text, Donvicongtac = txt_DonVi.Text, Diachi = txt_DiaChi.Text, Sodienthoai = txt_SDT.Text, Email = txt_Email.Text, Website = txt_Website.Text, Masothue = txt_MaSoThue.Text, Sotaikhoan = txt_SoTK.Text, Nganhang = txt_NganHang.Text };

                    data.tbl_Khachhangs.InsertOnSubmit(AddNew);
                    data.SubmitChanges();
                    Application.DoEvents();
                    MessageBox.Show("Đã thêm mới dữ liệu thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                catch
                {
                    MessageBox.Show("Không thể thêm dữ liệu này được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void loadEdit()
        {
            try
            {
                txt_MaKH.Enabled = false;
                var collection = from c in data.tbl_Khachhangs
                                 where c.MaKH == vitualMaKH
                                 select c;
                txt_MaKH.Text = collection.Single().MaKH;
                txt_TenKH.Text = collection.Single().TenKH;
                txt_DonVi.Text = collection.Single().Donvicongtac;
                txt_DiaChi.Text = collection.Single().Diachi;
                txt_SDT.Text = collection.Single().Sodienthoai;
                txt_Email.Text = collection.Single().Email;
                txt_Website.Text = collection.Single().Website;
                txt_MaSoThue.Text = collection.Single().Masothue;
                txt_SoTK.Text = collection.Single().Sotaikhoan;
                txt_NganHang.Text = collection.Single().Nganhang;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi thao tác với CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void editsave()
        {
            try
            {

                tbl_Khachhang update_KH = data.tbl_Khachhangs.Single(p => p.MaKH == txt_MaKH.Text);
               // update_KH.Makh = txt_Makh.Text;
                update_KH.TenKH = txt_TenKH.Text;
                update_KH.Donvicongtac = txt_DonVi.Text;
                update_KH.Diachi = txt_DiaChi.Text;
                update_KH.Sodienthoai = txt_SDT.Text;
                update_KH.Email = txt_Email.Text;
                update_KH.Website = txt_Website.Text;
                update_KH.Masothue = txt_MaSoThue.Text;
                update_KH.Sotaikhoan = txt_SoTK.Text;
                update_KH.Nganhang = txt_NganHang.Text;

                data.SubmitChanges();
                MessageBox.Show("Bạn đã Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch
            {
                MessageBox.Show("Lỗi không cho lưu dữ liệu. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void frm_NewKhachHang_Load(object sender, EventArgs e)
        {
            if (checkNew == 1)
            {
               // checkNew = 0;
                txt_MaKH.Enabled = false;
                loadEdit();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkNew == 0)
            {
                addsave();
            }
            else
            {
                editsave();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}