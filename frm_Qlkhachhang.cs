using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;


namespace QL_Duan
{
    public partial class frm_Qlkhachhang : DevExpress.XtraEditors.XtraForm
    {
        #region Xử lý design grid1
        void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); }));
            }

        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }
        #endregion
        DataClasses1DataContext data = new DataClasses1DataContext();
        
        public frm_Qlkhachhang()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if (keyData == (Keys.N))
            //{
            //    btn_New.PerformClick();
            //    return true;
            //}
            switch (keyData)
            {
                case (Keys.N | Keys.Control):
                    btn_New.PerformClick();
                    break;
                case (Keys.E | Keys.Control):
                    btn_Edit.PerformClick();
                    break;
                case (Keys.Delete | Keys.Control):
                    btn_Del.PerformClick();
                    break;
                case (Keys.R | Keys.Control):
                    btn_Update.PerformClick();
                    break;
                case (Keys.F8 | Keys.Control):
                    btn_Import.PerformClick();
                    break;
                case (Keys.F9 | Keys.Control):
                    btn_Export.PerformClick();
                    break;
                case (Keys.P | Keys.Control):
                    btn_Print.PerformClick();
                    break;
                case (Keys.Escape):
                    btn_Exit.PerformClick();
                    break;
               
            }
           // return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void loaddata()
        {
            var dlg = new DevExpress.Utils.WaitDialogForm("Đang tải dữ liệu ...","Thông báo");
            try
            {
                data.Dispose();
                data = new DataClasses1DataContext();
                data.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                var collection = from c in data.tbl_Khachhangs
                                 select c;
               // grid1.DataBindings.Clear();
                grid1.DataSource = collection;
                gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dlg.Close();
            }
        }
        
        private void NewsEvent()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            frm_NewKhachHang log = new frm_NewKhachHang();
            if (log.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //xử lí sự kiện sau khi thêm mới

                    loaddata();

                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi thao tác với CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
     
        private void bnt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_Qlkhachhang_Load(object sender, EventArgs e)
        {

            loaddata();
            
        }
       
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frm_NewKhachHang.checkNew = 1;
            frm_NewKhachHang.vitualMaKH = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, gridView1.Columns["MaKH"]);
            NewsEvent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_NewKhachHang.checkNew = 0;
            NewsEvent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {

                var query = from p in data.tbl_Khachhangs
                            where p.MaKH == gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, gridView1.Columns["MaKH"])
                            select p;

                data.tbl_Khachhangs.DeleteAllOnSubmit(query);
                data.SubmitChanges();
                loaddata();
                MessageBox.Show("Đã xóa thành công 1 dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhap");
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuat");
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In");
        }

       
    }
}