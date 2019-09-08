using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QL_Duan
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        public static string Vitual_Username;
        protected override void Dispose(bool disposing)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi hệ thống không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void LoginEvent()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frm_Login log = new frm_Login();
            if (log.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //xử lí sự kiện đăng nhập thành công
                    //nutmenu_true();
                    //if (Quyen == "Administrator")
                    //{
                    //    Menu_adminstrator_true();
                    //}
                    //else
                    //{
                    //    if (Quyen == "Nhân viên")
                    //    {
                    //        Menu_NHANVIEN_true();
                    //    }
                    //    else
                    //    {
                    //        Menu_admin_true();
                    //    }
                    //}
                    barHeaderItem2.Caption = Vitual_Username;
                    menulogin(true);
                    bar_Dangnhap.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi thao tác với CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void menulogin(bool thuoctinh)
        {
            ribbonPage2.Visible = thuoctinh;
            ribbonPage3.Visible = thuoctinh;
            ribbonPage4.Visible = thuoctinh;
            ribbonPage5.Visible = thuoctinh;
            ribbonPageGroup3.Visible = thuoctinh;
            ribbonPageGroup4.Visible = thuoctinh;
            bar_Nguoidung.Enabled = thuoctinh;
            barButtonItem2.Enabled = thuoctinh;
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            menulogin(false);
            LoginEvent();
        }

        private void bar_Dangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            menulogin(false);
            LoginEvent();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_donvi));
            if (frm == null)
            {
                frm_donvi forms = new frm_donvi();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            menulogin(false);
            LoginEvent();
        }

        private void bar_Nguoidung_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_thongtincanhan));
            if (frm == null)
            {
                frm_thongtincanhan forms = new frm_thongtincanhan();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void bar_qlkhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_Qlkhachhang));
            if (frm == null)
            {
                frm_Qlkhachhang forms = new frm_Qlkhachhang();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}