using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;

namespace QL_Duan
{
    public partial class frm_QlNhathauphu : DevExpress.XtraEditors.XtraForm
    {
        #region X? lý design grid1
        void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if ( !gridView1.IsGroupRow(e.RowHandle) ) //N?u không ph?i là Group
            {
                if ( e.Info.IsRowIndicator ) //N?u là dòng Indicator
                {
                    if ( e.RowHandle < 0 )
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hi?n th? hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString( ); //S? th? t? tang d?n
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //L?y kích thu?c c?a vùng hi?n th? Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); })); //Tang kích thu?c n?u Text vu?t quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 d? dánh l?i s? th? t? tang d?n
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
        public frm_QlNhathauphu( )
        {
            InitializeComponent( );
        }

        DataClasses1DataContext data = new DataClasses1DataContext( );

        // đổ dữ liệu vào table grid view
        public void loaddata( )
        {
            var dlg = new DevExpress.Utils.WaitDialogForm("Đang tải dữ liệu ...", "Thông báo");
            try
            {
                data.Dispose( );
                data = new DataClasses1DataContext( );
                data.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);

                var collection = from c in data.tbl_Nhathauphus
                                 select c;
                //grid1.DataBindings.Clear();
                grid1.DataSource = collection;
                gridView1.CustomDrawRowIndicator += gridView1_CustomDrawRowIndicator;

            }
            catch
            {
                MessageBox.Show("Đường truyền Internet bị ngắt kết nối\n Kiểm tra lại đường truyền Internet của bạn. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                dlg.Close( );
            }
        }

        private void grid1_Click(object sender, EventArgs e)
        {

        }

        // load dữ liệu vào grid view nhà thầu phụ
        private void frm_QlNhathauphu_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}