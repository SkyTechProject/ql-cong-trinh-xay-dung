namespace QL_Duan
{
    partial class frm_QLNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLNCC));
            this.Diachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Donvicongtac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sodienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sotaikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Website = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Masothue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bnt_New = new DevExpress.XtraEditors.SimpleButton();
            this.gridView_NCC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nganhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid1 = new DevExpress.XtraGrid.GridControl();
            this.bnt_Update = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bnt_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.bnt_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.bnt_Edit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Diachi
            // 
            this.Diachi.Caption = "Địa chỉ";
            this.Diachi.FieldName = "Diachi";
            this.Diachi.Name = "Diachi";
            this.Diachi.OptionsColumn.AllowEdit = false;
            this.Diachi.OptionsColumn.FixedWidth = true;
            this.Diachi.Visible = true;
            this.Diachi.VisibleIndex = 2;
            this.Diachi.Width = 200;
            // 
            // Donvicongtac
            // 
            this.Donvicongtac.Caption = "Ghi chú";
            this.Donvicongtac.FieldName = "Ghichu";
            this.Donvicongtac.Name = "Donvicongtac";
            this.Donvicongtac.OptionsColumn.AllowEdit = false;
            this.Donvicongtac.OptionsColumn.FixedWidth = true;
            this.Donvicongtac.Visible = true;
            this.Donvicongtac.VisibleIndex = 9;
            this.Donvicongtac.Width = 164;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.Caption = "Số điện thoại";
            this.Sodienthoai.FieldName = "Sodienthoai";
            this.Sodienthoai.Name = "Sodienthoai";
            this.Sodienthoai.OptionsColumn.AllowEdit = false;
            this.Sodienthoai.OptionsColumn.FixedWidth = true;
            this.Sodienthoai.Visible = true;
            this.Sodienthoai.VisibleIndex = 3;
            this.Sodienthoai.Width = 177;
            // 
            // TenNCC
            // 
            this.TenNCC.Caption = "Tên NCC";
            this.TenNCC.FieldName = "TenNCC";
            this.TenNCC.MaxWidth = 100;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.OptionsColumn.AllowEdit = false;
            this.TenNCC.OptionsColumn.FixedWidth = true;
            this.TenNCC.Visible = true;
            this.TenNCC.VisibleIndex = 1;
            this.TenNCC.Width = 100;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.OptionsColumn.AllowEdit = false;
            this.Email.OptionsColumn.FixedWidth = true;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            this.Email.Width = 119;
            // 
            // Sotaikhoan
            // 
            this.Sotaikhoan.Caption = "Số tài khoản";
            this.Sotaikhoan.FieldName = "Sotaikhoan";
            this.Sotaikhoan.Name = "Sotaikhoan";
            this.Sotaikhoan.OptionsColumn.AllowEdit = false;
            this.Sotaikhoan.OptionsColumn.FixedWidth = true;
            this.Sotaikhoan.Visible = true;
            this.Sotaikhoan.VisibleIndex = 7;
            this.Sotaikhoan.Width = 150;
            // 
            // Website
            // 
            this.Website.Caption = "Website";
            this.Website.FieldName = "Website";
            this.Website.Name = "Website";
            this.Website.OptionsColumn.AllowEdit = false;
            this.Website.OptionsColumn.FixedWidth = true;
            this.Website.Visible = true;
            this.Website.VisibleIndex = 5;
            this.Website.Width = 200;
            // 
            // MaNCC
            // 
            this.MaNCC.Caption = "Mã NCC";
            this.MaNCC.FieldName = "MaNCC";
            this.MaNCC.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaNCC.MaxWidth = 100;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.OptionsColumn.AllowEdit = false;
            this.MaNCC.OptionsColumn.FixedWidth = true;
            this.MaNCC.Visible = true;
            this.MaNCC.VisibleIndex = 0;
            this.MaNCC.Width = 100;
            // 
            // Masothue
            // 
            this.Masothue.Caption = "Mã số thuế";
            this.Masothue.FieldName = "Masothue";
            this.Masothue.MaxWidth = 100;
            this.Masothue.MinWidth = 40;
            this.Masothue.Name = "Masothue";
            this.Masothue.OptionsColumn.AllowEdit = false;
            this.Masothue.OptionsColumn.FixedWidth = true;
            this.Masothue.Visible = true;
            this.Masothue.VisibleIndex = 6;
            this.Masothue.Width = 100;
            // 
            // bnt_New
            // 
            this.bnt_New.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnt_New.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnt_New.Appearance.BorderColor = System.Drawing.Color.Green;
            this.bnt_New.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.bnt_New.Appearance.ForeColor = System.Drawing.Color.White;
            this.bnt_New.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.bnt_New.Appearance.Options.UseBackColor = true;
            this.bnt_New.Appearance.Options.UseBorderColor = true;
            this.bnt_New.Appearance.Options.UseFont = true;
            this.bnt_New.Appearance.Options.UseForeColor = true;
            this.bnt_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_New.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bnt_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_New.ImageOptions.Image")));
            this.bnt_New.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.bnt_New.Location = new System.Drawing.Point(25, 11);
            this.bnt_New.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnt_New.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bnt_New.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.bnt_New.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.bnt_New.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bnt_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnt_New.Name = "bnt_New";
            this.bnt_New.Size = new System.Drawing.Size(94, 26);
            this.bnt_New.TabIndex = 20;
            this.bnt_New.Text = "Thêm mới";
            // 
            // gridView_NCC
            // 
            this.gridView_NCC.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView_NCC.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView_NCC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_NCC.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_NCC.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_NCC.Appearance.Row.Options.UseFont = true;
            this.gridView_NCC.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridView_NCC.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView_NCC.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_NCC.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView_NCC.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView_NCC.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridView_NCC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.Diachi,
            this.Sodienthoai,
            this.Email,
            this.Website,
            this.Masothue,
            this.Sotaikhoan,
            this.Nganhang,
            this.Donvicongtac});
            this.gridView_NCC.GridControl = this.grid1;
            this.gridView_NCC.Name = "gridView_NCC";
            this.gridView_NCC.OptionsView.ShowAutoFilterRow = true;
            this.gridView_NCC.OptionsView.ShowFooter = true;
            this.gridView_NCC.OptionsView.ShowGroupPanel = false;
            // 
            // Nganhang
            // 
            this.Nganhang.Caption = "Ngân hàng";
            this.Nganhang.FieldName = "Nganhang";
            this.Nganhang.Name = "Nganhang";
            this.Nganhang.OptionsColumn.AllowEdit = false;
            this.Nganhang.OptionsColumn.FixedWidth = true;
            this.Nganhang.Visible = true;
            this.Nganhang.VisibleIndex = 8;
            this.Nganhang.Width = 200;
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
            this.grid1.MainView = this.gridView_NCC;
            this.grid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(1167, 536);
            this.grid1.TabIndex = 16;
            this.grid1.UseEmbeddedNavigator = true;
            this.grid1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_NCC});
            // 
            // bnt_Update
            // 
            this.bnt_Update.Appearance.BackColor = System.Drawing.Color.Green;
            this.bnt_Update.Appearance.BackColor2 = System.Drawing.SystemColors.MenuText;
            this.bnt_Update.Appearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bnt_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.bnt_Update.Appearance.ForeColor = System.Drawing.Color.White;
            this.bnt_Update.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.bnt_Update.Appearance.Options.UseBackColor = true;
            this.bnt_Update.Appearance.Options.UseBorderColor = true;
            this.bnt_Update.Appearance.Options.UseFont = true;
            this.bnt_Update.Appearance.Options.UseForeColor = true;
            this.bnt_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Update.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bnt_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Update.ImageOptions.Image")));
            this.bnt_Update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.bnt_Update.Location = new System.Drawing.Point(367, 11);
            this.bnt_Update.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_Update.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_Update.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.bnt_Update.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.bnt_Update.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bnt_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnt_Update.Name = "bnt_Update";
            this.bnt_Update.Size = new System.Drawing.Size(94, 26);
            this.bnt_Update.TabIndex = 19;
            this.bnt_Update.Text = "Cập nhật";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.bnt_New);
            this.splitContainerControl1.Panel1.Controls.Add(this.bnt_Update);
            this.splitContainerControl1.Panel1.Controls.Add(this.bnt_Exit);
            this.splitContainerControl1.Panel1.Controls.Add(this.bnt_Delete);
            this.splitContainerControl1.Panel1.Controls.Add(this.bnt_Edit);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grid1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1167, 598);
            this.splitContainerControl1.SplitterPosition = 57;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bnt_Exit
            // 
            this.bnt_Exit.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.bnt_Exit.Appearance.BackColor2 = System.Drawing.SystemColors.MenuText;
            this.bnt_Exit.Appearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bnt_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.bnt_Exit.Appearance.ForeColor = System.Drawing.Color.White;
            this.bnt_Exit.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.bnt_Exit.Appearance.Options.UseBackColor = true;
            this.bnt_Exit.Appearance.Options.UseBorderColor = true;
            this.bnt_Exit.Appearance.Options.UseFont = true;
            this.bnt_Exit.Appearance.Options.UseForeColor = true;
            this.bnt_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Exit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bnt_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Exit.ImageOptions.Image")));
            this.bnt_Exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.bnt_Exit.Location = new System.Drawing.Point(483, 11);
            this.bnt_Exit.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_Exit.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_Exit.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.bnt_Exit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.bnt_Exit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bnt_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnt_Exit.Name = "bnt_Exit";
            this.bnt_Exit.Size = new System.Drawing.Size(94, 26);
            this.bnt_Exit.TabIndex = 18;
            this.bnt_Exit.Text = "Đóng";
            // 
            // bnt_Delete
            // 
            this.bnt_Delete.Appearance.BackColor = System.Drawing.Color.Brown;
            this.bnt_Delete.Appearance.BackColor2 = System.Drawing.SystemColors.MenuText;
            this.bnt_Delete.Appearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bnt_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.bnt_Delete.Appearance.ForeColor = System.Drawing.Color.White;
            this.bnt_Delete.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.bnt_Delete.Appearance.Options.UseBackColor = true;
            this.bnt_Delete.Appearance.Options.UseBorderColor = true;
            this.bnt_Delete.Appearance.Options.UseFont = true;
            this.bnt_Delete.Appearance.Options.UseForeColor = true;
            this.bnt_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Delete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bnt_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Delete.ImageOptions.Image")));
            this.bnt_Delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.bnt_Delete.Location = new System.Drawing.Point(253, 11);
            this.bnt_Delete.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_Delete.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_Delete.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.bnt_Delete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.bnt_Delete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bnt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnt_Delete.Name = "bnt_Delete";
            this.bnt_Delete.Size = new System.Drawing.Size(94, 26);
            this.bnt_Delete.TabIndex = 17;
            this.bnt_Delete.Text = "Xóa";
            // 
            // bnt_Edit
            // 
            this.bnt_Edit.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.bnt_Edit.Appearance.BackColor2 = System.Drawing.Color.DarkSlateGray;
            this.bnt_Edit.Appearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bnt_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.bnt_Edit.Appearance.ForeColor = System.Drawing.Color.White;
            this.bnt_Edit.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.bnt_Edit.Appearance.Options.UseBackColor = true;
            this.bnt_Edit.Appearance.Options.UseBorderColor = true;
            this.bnt_Edit.Appearance.Options.UseFont = true;
            this.bnt_Edit.Appearance.Options.UseForeColor = true;
            this.bnt_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Edit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bnt_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Edit.ImageOptions.Image")));
            this.bnt_Edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.bnt_Edit.Location = new System.Drawing.Point(142, 11);
            this.bnt_Edit.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_Edit.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_Edit.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.bnt_Edit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.bnt_Edit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bnt_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnt_Edit.Name = "bnt_Edit";
            this.bnt_Edit.Size = new System.Drawing.Size(94, 26);
            this.bnt_Edit.TabIndex = 16;
            this.bnt_Edit.Text = "Sửa";
            // 
            // frm_QLNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 598);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frm_QLNCC";
            this.Text = "Quản lý Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Diachi;
        private DevExpress.XtraGrid.Columns.GridColumn Donvicongtac;
        private DevExpress.XtraGrid.Columns.GridColumn Sodienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn TenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Sotaikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn Website;
        private DevExpress.XtraGrid.Columns.GridColumn MaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn Masothue;
        private DevExpress.XtraEditors.SimpleButton bnt_New;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_NCC;
        private DevExpress.XtraGrid.Columns.GridColumn Nganhang;
        private DevExpress.XtraGrid.GridControl grid1;
        private DevExpress.XtraEditors.SimpleButton bnt_Update;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton bnt_Exit;
        private DevExpress.XtraEditors.SimpleButton bnt_Delete;
        private DevExpress.XtraEditors.SimpleButton bnt_Edit;
    }
}