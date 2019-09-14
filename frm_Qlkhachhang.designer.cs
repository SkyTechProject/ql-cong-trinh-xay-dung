namespace QL_Duan
{
    partial class frm_Qlkhachhang
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Qlkhachhang));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btn_Export = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Import = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.grid1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Diachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sodienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Website = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Masothue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sotaikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nganhang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Export);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Import);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_New);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Update);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Exit);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Del);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Edit);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Print);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grid1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1183, 699);
            this.splitContainerControl1.SplitterPosition = 48;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btn_Export
            // 
            this.btn_Export.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Export.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Export.Appearance.Options.UseFont = true;
            this.btn_Export.Appearance.Options.UseForeColor = true;
            this.btn_Export.AppearanceHovered.BackColor = System.Drawing.Color.Cyan;
            this.btn_Export.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Export.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Export.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Export.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_Export.AppearanceHovered.Options.UseFont = true;
            this.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Export.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Export.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export.ImageOptions.Image")));
            this.btn_Export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Export.Location = new System.Drawing.Point(593, 10);
            this.btn_Export.LookAndFeel.SkinMaskColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Export.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Export.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Export.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(104, 26);
            this.btn_Export.TabIndex = 6;
            this.btn_Export.Text = "Xuất";
            this.btn_Export.ToolTip = "Ctrl + F9";
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Import.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Import.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Import.Appearance.Options.UseFont = true;
            this.btn_Import.Appearance.Options.UseForeColor = true;
            this.btn_Import.AppearanceHovered.BackColor = System.Drawing.Color.Cyan;
            this.btn_Import.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Import.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Import.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Import.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_Import.AppearanceHovered.Options.UseFont = true;
            this.btn_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Import.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Import.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Import.ImageOptions.Image")));
            this.btn_Import.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Import.Location = new System.Drawing.Point(474, 10);
            this.btn_Import.LookAndFeel.SkinMaskColor = System.Drawing.Color.Teal;
            this.btn_Import.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Import.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Import.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(104, 26);
            this.btn_Import.TabIndex = 5;
            this.btn_Import.Text = "Nhập";
            this.btn_Import.ToolTip = "Ctrl + F8";
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_New
            // 
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_New.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_New.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Appearance.Options.UseForeColor = true;
            this.btn_New.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_New.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_New.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_New.AppearanceHovered.Options.UseBackColor = true;
            this.btn_New.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_New.AppearanceHovered.Options.UseFont = true;
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_New.Location = new System.Drawing.Point(35, 11);
            this.btn_New.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_New.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_New.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_New.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(94, 26);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "Thêm mới";
            this.btn_New.ToolTip = "Ctrl + N";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Update.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Appearance.Options.UseForeColor = true;
            this.btn_Update.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Update.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Update.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Update.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Update.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_Update.AppearanceHovered.Options.UseFont = true;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Update.Location = new System.Drawing.Point(364, 10);
            this.btn_Update.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Update.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Update.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Update.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 26);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Làm tươi";
            this.btn_Update.ToolTip = "Ctrl + R";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Exit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Appearance.Options.UseForeColor = true;
            this.btn_Exit.AppearanceHovered.BackColor = System.Drawing.Color.Silver;
            this.btn_Exit.AppearanceHovered.BorderColor = System.Drawing.Color.Silver;
            this.btn_Exit.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Exit.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_Exit.AppearanceHovered.Options.UseFont = true;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Exit.Location = new System.Drawing.Point(831, 10);
            this.btn_Exit.LookAndFeel.SkinMaskColor = System.Drawing.Color.Gray;
            this.btn_Exit.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Exit.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Exit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(94, 26);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Đóng";
            this.btn_Exit.ToolTip = "ESC";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Del.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Del.Appearance.Options.UseFont = true;
            this.btn_Del.Appearance.Options.UseForeColor = true;
            this.btn_Del.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Del.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Del.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Del.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Del.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_Del.AppearanceHovered.Options.UseFont = true;
            this.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Del.ImageOptions.Image")));
            this.btn_Del.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Del.Location = new System.Drawing.Point(254, 10);
            this.btn_Del.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Del.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Maroon;
            this.btn_Del.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Del.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(94, 26);
            this.btn_Del.TabIndex = 3;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.ToolTip = "Ctrl + Delete";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Edit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Appearance.Options.UseForeColor = true;
            this.btn_Edit.AppearanceHovered.BackColor = System.Drawing.Color.Cyan;
            this.btn_Edit.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Edit.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Edit.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_Edit.AppearanceHovered.Options.UseFont = true;
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Edit.Location = new System.Drawing.Point(145, 11);
            this.btn_Edit.LookAndFeel.SkinMaskColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Edit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btn_Edit.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Edit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(94, 26);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.ToolTip = "Ctrl + E";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_Print.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Print.Appearance.Options.UseFont = true;
            this.btn_Print.Appearance.Options.UseForeColor = true;
            this.btn_Print.AppearanceHovered.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Print.AppearanceHovered.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btn_Print.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Print.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Print.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_Print.AppearanceHovered.Options.UseFont = true;
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.ImageOptions.Image")));
            this.btn_Print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btn_Print.Location = new System.Drawing.Point(712, 10);
            this.btn_Print.LookAndFeel.SkinMaskColor = System.Drawing.Color.Olive;
            this.btn_Print.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Print.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btn_Print.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(104, 26);
            this.btn_Print.TabIndex = 7;
            this.btn_Print.Text = "In ấn";
            this.btn_Print.ToolTip = "Ctrl + P";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
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
            this.grid1.Size = new System.Drawing.Size(1183, 646);
            this.grid1.TabIndex = 7;
            this.grid1.UseEmbeddedNavigator = true;
            this.grid1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.MaKH,
            this.TenKH,
            this.Diachi,
            this.Sodienthoai,
            this.Email,
            this.Website,
            this.Masothue,
            this.Sotaikhoan,
            this.Nganhang});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.grid1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaKH
            // 
            this.MaKH.Caption = "MãKH";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaKH.MaxWidth = 86;
            this.MaKH.MinWidth = 17;
            this.MaKH.Name = "MaKH";
            this.MaKH.OptionsColumn.AllowEdit = false;
            this.MaKH.OptionsColumn.FixedWidth = true;
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 0;
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Tên Khách hàng";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.MinWidth = 17;
            this.TenKH.Name = "TenKH";
            this.TenKH.OptionsColumn.AllowEdit = false;
            this.TenKH.OptionsColumn.FixedWidth = true;
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 1;
            this.TenKH.Width = 150;
            // 
            // Diachi
            // 
            this.Diachi.Caption = "Địa chỉ";
            this.Diachi.FieldName = "Diachi";
            this.Diachi.MinWidth = 17;
            this.Diachi.Name = "Diachi";
            this.Diachi.OptionsColumn.AllowEdit = false;
            this.Diachi.Visible = true;
            this.Diachi.VisibleIndex = 2;
            this.Diachi.Width = 18;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.Caption = "Số điện thoại";
            this.Sodienthoai.FieldName = "Sodienthoai";
            this.Sodienthoai.MinWidth = 17;
            this.Sodienthoai.Name = "Sodienthoai";
            this.Sodienthoai.OptionsColumn.AllowEdit = false;
            this.Sodienthoai.OptionsColumn.AllowSize = false;
            this.Sodienthoai.OptionsColumn.FixedWidth = true;
            this.Sodienthoai.Visible = true;
            this.Sodienthoai.VisibleIndex = 4;
            this.Sodienthoai.Width = 120;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 17;
            this.Email.Name = "Email";
            this.Email.OptionsColumn.AllowEdit = false;
            this.Email.OptionsColumn.AllowSize = false;
            this.Email.OptionsColumn.FixedWidth = true;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            this.Email.Width = 150;
            // 
            // Website
            // 
            this.Website.Caption = "Website";
            this.Website.FieldName = "Website";
            this.Website.MinWidth = 17;
            this.Website.Name = "Website";
            this.Website.OptionsColumn.AllowEdit = false;
            this.Website.OptionsColumn.FixedWidth = true;
            this.Website.Visible = true;
            this.Website.VisibleIndex = 5;
            this.Website.Width = 150;
            // 
            // Masothue
            // 
            this.Masothue.Caption = "Mã số thuế";
            this.Masothue.FieldName = "Masothue";
            this.Masothue.MinWidth = 17;
            this.Masothue.Name = "Masothue";
            this.Masothue.OptionsColumn.AllowEdit = false;
            this.Masothue.OptionsColumn.FixedWidth = true;
            this.Masothue.Visible = true;
            this.Masothue.VisibleIndex = 6;
            this.Masothue.Width = 150;
            // 
            // Sotaikhoan
            // 
            this.Sotaikhoan.Caption = "Số tài khoản";
            this.Sotaikhoan.FieldName = "Sotaikhoan";
            this.Sotaikhoan.MinWidth = 17;
            this.Sotaikhoan.Name = "Sotaikhoan";
            this.Sotaikhoan.OptionsColumn.AllowEdit = false;
            this.Sotaikhoan.OptionsColumn.FixedWidth = true;
            this.Sotaikhoan.Visible = true;
            this.Sotaikhoan.VisibleIndex = 7;
            this.Sotaikhoan.Width = 150;
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
            this.Nganhang.Width = 250;
            // 
            // frm_Qlkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 699);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Qlkhachhang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frm_Qlkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.SimpleButton btn_Export;
        private DevExpress.XtraEditors.SimpleButton btn_Import;
        private DevExpress.XtraGrid.GridControl grid1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn Diachi;
        private DevExpress.XtraGrid.Columns.GridColumn Sodienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Website;
        private DevExpress.XtraGrid.Columns.GridColumn Masothue;
        private DevExpress.XtraGrid.Columns.GridColumn Sotaikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn Nganhang;

    }
}