namespace 도서대여관리
{
    partial class bookform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ISBN_1 = new System.Windows.Forms.TextBox();
            this.bk_size = new System.Windows.Forms.TextBox();
            this.bk_name = new System.Windows.Forms.TextBox();
            this.bk_location = new System.Windows.Forms.ComboBox();
            this.ISBN_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bk_year = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsbn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBkname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBkyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBkpubl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBkpage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBksize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBkprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBklocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBkcarryin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBkstate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bk_publ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bk_page = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bk_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bk_carryin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bk_state = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.regi_n = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.b_save = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "도서명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "소장위치";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "크기";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 14);
            this.label11.TabIndex = 10;
            this.label11.Text = "도서정보 ISBN 검색";
            // 
            // ISBN_1
            // 
            this.ISBN_1.Location = new System.Drawing.Point(87, 299);
            this.ISBN_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBN_1.Name = "ISBN_1";
            this.ISBN_1.ReadOnly = true;
            this.ISBN_1.Size = new System.Drawing.Size(88, 21);
            this.ISBN_1.TabIndex = 12;
            // 
            // bk_size
            // 
            this.bk_size.Location = new System.Drawing.Point(87, 370);
            this.bk_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bk_size.Name = "bk_size";
            this.bk_size.Size = new System.Drawing.Size(88, 21);
            this.bk_size.TabIndex = 13;
            // 
            // bk_name
            // 
            this.bk_name.Location = new System.Drawing.Point(266, 299);
            this.bk_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bk_name.Name = "bk_name";
            this.bk_name.Size = new System.Drawing.Size(293, 21);
            this.bk_name.TabIndex = 17;
            // 
            // bk_location
            // 
            this.bk_location.FormattingEnabled = true;
            this.bk_location.Location = new System.Drawing.Point(87, 402);
            this.bk_location.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bk_location.Name = "bk_location";
            this.bk_location.Size = new System.Drawing.Size(88, 20);
            this.bk_location.TabIndex = 18;
            
            // 
            // ISBN_2
            // 
            this.ISBN_2.Location = new System.Drawing.Point(134, 40);
            this.ISBN_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBN_2.Name = "ISBN_2";
            this.ISBN_2.Size = new System.Drawing.Size(88, 22);
            this.ISBN_2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 21);
            this.button1.TabIndex = 24;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "출판년도";
            // 
            // bk_year
            // 
            this.bk_year.Location = new System.Drawing.Point(87, 334);
            this.bk_year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bk_year.Name = "bk_year";
            this.bk_year.Size = new System.Drawing.Size(71, 21);
            this.bk_year.TabIndex = 31;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(21, 94);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(895, 183);
            this.gridControl1.TabIndex = 50;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsbn,
            this.colBkname,
            this.colBkyear,
            this.colBkpubl,
            this.colBkpage,
            this.colBksize,
            this.colBkprice,
            this.colBklocation,
            this.colBkcarryin,
            this.colBkstate});
            this.gridView1.DetailHeight = 280;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIsbn
            // 
            this.colIsbn.Caption = "ISBN";
            this.colIsbn.FieldName = "ISBN";
            this.colIsbn.MinWidth = 17;
            this.colIsbn.Name = "colIsbn";
            this.colIsbn.Visible = true;
            this.colIsbn.VisibleIndex = 0;
            this.colIsbn.Width = 66;
            // 
            // colBkname
            // 
            this.colBkname.Caption = "도서명";
            this.colBkname.FieldName = "bk_name";
            this.colBkname.MinWidth = 17;
            this.colBkname.Name = "colBkname";
            this.colBkname.Visible = true;
            this.colBkname.VisibleIndex = 1;
            this.colBkname.Width = 66;
            // 
            // colBkyear
            // 
            this.colBkyear.Caption = "출판년도";
            this.colBkyear.FieldName = "bk_publ_date";
            this.colBkyear.MinWidth = 17;
            this.colBkyear.Name = "colBkyear";
            this.colBkyear.Visible = true;
            this.colBkyear.VisibleIndex = 2;
            this.colBkyear.Width = 66;
            // 
            // colBkpubl
            // 
            this.colBkpubl.Caption = "출판사";
            this.colBkpubl.FieldName = "bk_publ_nm";
            this.colBkpubl.MinWidth = 17;
            this.colBkpubl.Name = "colBkpubl";
            this.colBkpubl.Visible = true;
            this.colBkpubl.VisibleIndex = 3;
            this.colBkpubl.Width = 66;
            // 
            // colBkpage
            // 
            this.colBkpage.Caption = "페이지";
            this.colBkpage.FieldName = "bk_page";
            this.colBkpage.MinWidth = 17;
            this.colBkpage.Name = "colBkpage";
            this.colBkpage.Visible = true;
            this.colBkpage.VisibleIndex = 4;
            this.colBkpage.Width = 66;
            // 
            // colBksize
            // 
            this.colBksize.Caption = "크기";
            this.colBksize.FieldName = "bk_size";
            this.colBksize.MinWidth = 17;
            this.colBksize.Name = "colBksize";
            this.colBksize.Visible = true;
            this.colBksize.VisibleIndex = 5;
            this.colBksize.Width = 66;
            // 
            // colBkprice
            // 
            this.colBkprice.Caption = "가격";
            this.colBkprice.FieldName = "bk_price";
            this.colBkprice.MinWidth = 17;
            this.colBkprice.Name = "colBkprice";
            this.colBkprice.Visible = true;
            this.colBkprice.VisibleIndex = 6;
            this.colBkprice.Width = 66;
            // 
            // colBklocation
            // 
            this.colBklocation.Caption = "소장위치";
            this.colBklocation.FieldName = "bk_location";
            this.colBklocation.MinWidth = 17;
            this.colBklocation.Name = "colBklocation";
            this.colBklocation.Visible = true;
            this.colBklocation.VisibleIndex = 7;
            this.colBklocation.Width = 66;
            // 
            // colBkcarryin
            // 
            this.colBkcarryin.Caption = "반입구분";
            this.colBkcarryin.FieldName = "bk_carryin";
            this.colBkcarryin.MinWidth = 17;
            this.colBkcarryin.Name = "colBkcarryin";
            this.colBkcarryin.Visible = true;
            this.colBkcarryin.VisibleIndex = 8;
            this.colBkcarryin.Width = 66;
            // 
            // colBkstate
            // 
            this.colBkstate.Caption = "도서상태";
            this.colBkstate.FieldName = "bk_state";
            this.colBkstate.MinWidth = 17;
            this.colBkstate.Name = "colBkstate";
            this.colBkstate.Visible = true;
            this.colBkstate.VisibleIndex = 9;
            this.colBkstate.Width = 66;
            // 
            // bk_publ
            // 
            this.bk_publ.Location = new System.Drawing.Point(266, 334);
            this.bk_publ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bk_publ.Name = "bk_publ";
            this.bk_publ.Size = new System.Drawing.Size(71, 21);
            this.bk_publ.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 51;
            this.label3.Text = "출판사";
            // 
            // bk_page
            // 
            this.bk_page.Location = new System.Drawing.Point(428, 334);
            this.bk_page.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bk_page.Name = "bk_page";
            this.bk_page.Size = new System.Drawing.Size(71, 21);
            this.bk_page.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 53;
            this.label4.Text = "페이지";
            // 
            // bk_price
            // 
            this.bk_price.Location = new System.Drawing.Point(290, 370);
            this.bk_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bk_price.Name = "bk_price";
            this.bk_price.Size = new System.Drawing.Size(88, 21);
            this.bk_price.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 55;
            this.label6.Text = "가격";
            // 
            // bk_carryin
            // 
            this.bk_carryin.FormattingEnabled = true;
            this.bk_carryin.Location = new System.Drawing.Point(290, 400);
            this.bk_carryin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bk_carryin.Name = "bk_carryin";
            this.bk_carryin.Size = new System.Drawing.Size(88, 20);
            this.bk_carryin.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 57;
            this.label7.Text = "반입구분";
            
            // 
            // bk_state
            // 
            this.bk_state.FormattingEnabled = true;
            this.bk_state.Location = new System.Drawing.Point(499, 400);
            this.bk_state.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bk_state.Name = "bk_state";
            this.bk_state.Size = new System.Drawing.Size(88, 20);
            this.bk_state.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 59;
            this.label10.Text = "도서상태";
            // 
            // regi_n
            // 
            this.regi_n.Location = new System.Drawing.Point(694, 400);
            this.regi_n.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regi_n.Name = "regi_n";
            this.regi_n.Size = new System.Drawing.Size(118, 21);
            this.regi_n.TabIndex = 65;
            this.regi_n.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(621, 402);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 64;
            this.label16.Text = "등록번호";
            this.label16.Visible = false;
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(693, 38);
            this.b_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(118, 21);
            this.b_save.TabIndex = 71;
            this.b_save.Text = "저장";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(818, 38);
            this.b_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(118, 21);
            this.b_delete.TabIndex = 72;
            this.b_delete.Text = "삭제";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button2);
            this.groupControl1.Controls.Add(this.button_2);
            this.groupControl1.Controls.Add(this.b_save);
            this.groupControl1.Controls.Add(this.b_delete);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.ISBN_2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(947, 77);
            this.groupControl1.TabIndex = 74;
            this.groupControl1.Text = "도서관리(조회,입력,수정,삭제)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 21);
            this.button2.TabIndex = 75;
            this.button2.Text = "초기화";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(569, 38);
            this.button_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(118, 21);
            this.button_2.TabIndex = 74;
            this.button_2.Text = "수정";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // bookform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.regi_n);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.bk_state);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bk_carryin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bk_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bk_page);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bk_publ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.bk_year);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bk_location);
            this.Controls.Add(this.bk_name);
            this.Controls.Add(this.bk_size);
            this.Controls.Add(this.ISBN_1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "bookform";
            this.Text = "book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ISBN_1;
        private System.Windows.Forms.TextBox bk_size;
        private System.Windows.Forms.TextBox bk_name;
        private System.Windows.Forms.ComboBox bk_location;
        private System.Windows.Forms.TextBox ISBN_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bk_year;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox bk_publ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bk_page;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bk_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox bk_carryin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bk_state;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox regi_n;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_delete;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsbn;
        private DevExpress.XtraGrid.Columns.GridColumn colBkname;
        private DevExpress.XtraGrid.Columns.GridColumn colBkyear;
        private DevExpress.XtraGrid.Columns.GridColumn colBkpubl;
        private DevExpress.XtraGrid.Columns.GridColumn colBkpage;
        private DevExpress.XtraGrid.Columns.GridColumn colBksize;
        private DevExpress.XtraGrid.Columns.GridColumn colBkprice;
        private DevExpress.XtraGrid.Columns.GridColumn colBklocation;
        private DevExpress.XtraGrid.Columns.GridColumn colBkcarryin;
        private DevExpress.XtraGrid.Columns.GridColumn colBkstate;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button2;
    }
}