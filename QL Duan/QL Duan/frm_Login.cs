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
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
       // int CountLogin = 3;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = from c in data.Nhanviens

                                 select c;

                if (collection.Single().Tendangnhap.ToString() == txt_Tendangnhap.Text && collection.Single().Matkhau == txt_Matkhau.Text)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Main.Vitual_Username = collection.Single().Tendangnhap;
                    // Form1.Quyen = collection.Single().Quyentruycap;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}