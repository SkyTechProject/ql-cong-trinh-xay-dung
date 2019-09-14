namespace QL_Duan
{
    partial class frm_QlNhathauphu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QlNhathauphu));
            this.Dienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nguoidaidien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Chucvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Diachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Website = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Masothue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sotaikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dienthoai
            // 
            this.Dienthoai.Caption = "Số điện thoại";
            this.Dienthoai.FieldName = "Dienthoai";
            this.Dienthoai.MinWidth = 17;
            this.Dienthoai.Name = "Dienthoai";
            this.Dienthoai.OptionsColumn.AllowEdit = false;
            this.Dienthoai.OptionsColumn.AllowSize = false;
            this.Dienthoai.Visible = true;
            this.Dienthoai.VisibleIndex = 3;
            this.Dienthoai.Width = 123;
            // 
            // grid1
            // 
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.grid1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grid1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grid1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grid1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grid1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grid1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grid1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.MainView = this.gridView1;
            this.grid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(1167, 540);
            this.grid1.TabIndex = 16;
            this.grid1.UseEmbeddedNavigator = true;
            this.grid1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid1.Click += new System.EventHandler(this.grid1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNTP,
            this.TenNTP,
            this.Nguoidaidien,
            this.Chucvu,
            this.Diachi,
            this.Dienthoai,
            this.Email,
            this.Website,
            this.Masothue,
            this.Sotaikhoan,
            this.Nganhang,
            this.Ghichu});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.grid1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaNTP
            // 
            this.MaNTP.Caption = "Mã NTP";
            this.MaNTP.FieldName = "MaNTP";
            this.MaNTP.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaNTP.MaxWidth = 70;
            this.MaNTP.MinWidth = 17;
            this.MaNTP.Name = "MaNTP";
            this.MaNTP.OptionsColumn.AllowEdit = false;
            this.MaNTP.Visible = true;
            this.MaNTP.VisibleIndex = 0;
            this.MaNTP.Width = 70;
            // 
            // TenNTP
            // 
            this.TenNTP.Caption = "Tên NTP";
            this.TenNTP.FieldName = "TenNTP";
            this.TenNTP.MinWidth = 17;
            this.TenNTP.Name = "TenNTP";
            this.TenNTP.OptionsColumn.AllowEdit = false;
            this.TenNTP.Visible = true;
            this.TenNTP.VisibleIndex = 1;
            this.TenNTP.Width = 117;
            // 
            // Nguoidaidien
            // 
            this.Nguoidaidien.Caption = "Người đại diện";
            this.Nguoidaidien.FieldName = "Nguoidaidien";
            this.Nguoidaidien.MinWidth = 17;
            this.Nguoidaidien.Name = "Nguoidaidien";
            this.Nguoidaidien.OptionsColumn.AllowEdit = false;
            this.Nguoidaidien.Visible = true;
            this.Nguoidaidien.VisibleIndex = 2;
            this.Nguoidaidien.Width = 109;
            // 
            // Chucvu
            // 
            this.Chucvu.Caption = "Chức vụ";
            this.Chucvu.FieldName = "Chucvu";
            this.Chucvu.Name = "Chucvu";
            this.Chucvu.Visible = true;
            this.Chucvu.VisibleIndex = 11;
            this.Chucvu.Width = 124;
            // 
            // Diachi
            // 
            this.Diachi.Caption = "Địa chỉ";
            this.Diachi.FieldName = "Diachi";
            this.Diachi.MinWidth = 17;
            this.Diachi.Name = "Diachi";
            this.Diachi.OptionsColumn.AllowEdit = false;
            this.Diachi.OptionsColumn.AllowSize = false;
            this.Diachi.Visible = true;
            this.Diachi.VisibleIndex = 4;
            this.Diachi.Width = 116;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 17;
            this.Email.Name = "Email";
            this.Email.OptionsColumn.AllowEdit = false;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 5;
            this.Email.Width = 66;
            // 
            // Website
            // 
            this.Website.Caption = "Website";
            this.Website.FieldName = "Website";
            this.Website.MinWidth = 17;
            this.Website.Name = "Website";
            this.Website.OptionsColumn.AllowEdit = false;
            this.Website.Visible = true;
            this.Website.VisibleIndex = 6;
            this.Website.Width = 66;
            // 
            // Masothue
            // 
            this.Masothue.Caption = "Mã số thuế";
            this.Masothue.FieldName = "Masothue";
            this.Masothue.MinWidth = 17;
            this.Masothue.Name = "Masothue";
            this.Masothue.OptionsColumn.AllowEdit = false;
            this.Masothue.Visible = true;
            this.Masothue.VisibleIndex = 7;
            this.Masothue.Width = 86;
            // 
            // Sotaikhoan
            // 
            this.Sotaikhoan.Caption = "Số tài khoản";
            this.Sotaikhoan.FieldName = "Sotaikhoan";
            this.Sotaikhoan.MinWidth = 17;
            this.Sotaikhoan.Name = "Sotaikhoan";
            this.Sotaikhoan.OptionsColumn.AllowEdit = false;
            this.Sotaikhoan.Visible = true;
            this.Sotaikhoan.VisibleIndex = 8;
            this.Sotaikhoan.Width = 100;
            // 
            // Nganhang
            // 
            this.Nganhang.Caption = "Ngân hàng";
            this.Nganhang.FieldName = "Nganhang";
            this.Nganhang.MinWidth = 17;
            this.Nganhang.Name = "Nganhang";
            this.Nganhang.OptionsColumn.AllowEdit = false;
            this.Nganhang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tongtrongluong", "{0:#.##} Ly")});
            this.Nganhang.Visible = true;
            this.Nganhang.VisibleIndex = 9;
            this.Nganhang.Width = 85;
            // 
            // Ghichu
            // 
            this.Ghichu.Caption = "Ghi chú";
            this.Ghichu.FieldName = "Ghichu";
            this.Ghichu.MinWidth = 17;
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.OptionsColumn.AllowEdit = false;
            this.Ghichu.Visible = true;
            this.Ghichu.VisibleIndex = 10;
            this.Ghichu.Width = 85;
            // 
            // btn_New
            // 
            this.btn_New.Appearance.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_New.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_New.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_New.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_New.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_New.Appearance.Options.UseBackColor = true;
            this.btn_New.Appearance.Options.UseBorderColor = true;
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Appearance.Options.UseForeColor = true;
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_New.Location = new System.Drawing.Point(27, 12);
            this.btn_New.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_New.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btn_New.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_New.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btn_New.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(94, 26);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "&Thêm mới";
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.BackColor = System.Drawing.Color.Green;
            this.btn_Update.Appearance.BackColor2 = System.Drawing.SystemColors.MenuText;
            this.btn_Update.Appearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Update.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Update.Appearance.Options.UseBackColor = true;
            this.btn_Update.Appearance.Options.UseBorderColor = true;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Appearance.Options.UseForeColor = true;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Update.Location = new System.Drawing.Point(532, 11);
            this.btn_Update.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Update.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Update.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Update.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btn_Update.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 26);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "&Cập nhật";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_New);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Update);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Exit);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Del);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Edit);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Print);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grid1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1167, 600);
            this.splitContainerControl1.SplitterPosition = 55;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.btn_Exit.Appearance.BackColor2 = System.Drawing.SystemColors.MenuText;
            this.btn_Exit.Appearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Exit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Exit.Appearance.Options.UseBackColor = true;
            this.btn_Exit.Appearance.Options.UseBorderColor = true;
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Appearance.Options.UseForeColor = true;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Exit.Location = new System.Drawing.Point(656, 11);
            this.btn_Exit.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Exit.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Exit.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Exit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btn_Exit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(94, 26);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "&Đóng";
            // 
            // btn_Del
            // 
            this.btn_Del.Appearance.BackColor = System.Drawing.Color.Brown;
            this.btn_Del.Appearance.BackColor2 = System.Drawing.SystemColors.MenuText;
            this.btn_Del.Appearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_Del.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Del.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Del.Appearance.Options.UseBackColor = true;
            this.btn_Del.Appearance.Options.UseBorderColor = true;
            this.btn_Del.Appearance.Options.UseFont = true;
            this.btn_Del.Appearance.Options.UseForeColor = true;
            this.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Del.ImageOptions.Image")));
            this.btn_Del.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Del.Location = new System.Drawing.Point(275, 12);
            this.btn_Del.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Del.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Del.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Del.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btn_Del.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(94, 26);
            this.btn_Del.TabIndex = 3;
            this.btn_Del.Text = "&Xóa";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Edit.Appearance.BackColor2 = System.Drawing.SystemColors.MenuText;
            this.btn_Edit.Appearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Edit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Edit.Appearance.Options.UseBackColor = true;
            this.btn_Edit.Appearance.Options.UseBorderColor = true;
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Appearance.Options.UseForeColor = true;
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Edit.Location = new System.Drawing.Point(151, 11);
            this.btn_Edit.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Edit.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Edit.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Edit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btn_Edit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(94, 26);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "&Sửa";
            // 
            // btn_Print
            // 
            this.btn_Print.Appearance.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Print.Appearance.BackColor2 = System.Drawing.SystemColors.MenuText;
            this.btn_Print.Appearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_Print.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Print.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Print.Appearance.Options.UseBackColor = true;
            this.btn_Print.Appearance.Options.UseBorderColor = true;
            this.btn_Print.Appearance.Options.UseFont = true;
            this.btn_Print.Appearance.Options.UseForeColor = true;
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.Image")));
            this.btn_Print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Print.Location = new System.Drawing.Point(403, 12);
            this.btn_Print.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Print.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Print.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Print.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btn_Print.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(104, 26);
            this.btn_Print.TabIndex = 4;
            this.btn_Print.Text = "&In";
            // 
            // frm_QlNhathauphu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 600);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frm_QlNhathauphu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhà thầu phụ";
            this.Load += new System.EventHandler(this.frm_QlNhathauphu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Dienthoai;
        private DevExpress.XtraGrid.GridControl grid1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNTP;
        private DevExpress.XtraGrid.Columns.GridColumn TenNTP;
        private DevExpress.XtraGrid.Columns.GridColumn Nguoidaidien;
        private DevExpress.XtraGrid.Columns.GridColumn Chucvu;
        private DevExpress.XtraGrid.Columns.GridColumn Diachi;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Website;
        private DevExpress.XtraGrid.Columns.GridColumn Masothue;
        private DevExpress.XtraGrid.Columns.GridColumn Sotaikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn Nganhang;
        private DevExpress.XtraGrid.Columns.GridColumn Ghichu;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
    }
}