namespace 도서대여프로그램
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.borrow_date = new DevExpress.XtraEditors.DateEdit();
            this.select = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colborrowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbookCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreturnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colborrowDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colborrowOk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bookCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bookName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bookYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bookPublishing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.b_publ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_year = new System.Windows.Forms.TextBox();
            this.b_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mtel = new System.Windows.Forms.TextBox();
            this.Mname = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.userNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.borrownoo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnamee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.booknamee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bkpubll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.borrowdatee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.returndatee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.borrowokk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.handphonee = new System.Windows.Forms.TextBox();
            this.namee = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrow_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrow_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1116, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "대여";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.borrow_date);
            this.groupBox4.Controls.Add(this.select);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.gridControl2);
            this.groupBox4.Location = new System.Drawing.Point(10, 208);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(498, 240);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "대여/반납목록";
            // 
            // borrow_date
            // 
            this.borrow_date.EditValue = null;
            this.borrow_date.Location = new System.Drawing.Point(141, 15);
            this.borrow_date.Name = "borrow_date";
            this.borrow_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.borrow_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.borrow_date.Size = new System.Drawing.Size(100, 20);
            this.borrow_date.TabIndex = 5;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(346, 19);
            this.select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(66, 18);
            this.select.TabIndex = 4;
            this.select.Text = "검색\r\n";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "대여일자\r\n";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 18);
            this.button3.TabIndex = 1;
            this.button3.Text = "수정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl2.Location = new System.Drawing.Point(5, 42);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(487, 178);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colborrowNo,
            this.coluserNo1,
            this.colbookCode1,
            this.colreturnDate,
            this.colborrowDate,
            this.colborrowOk});
            this.gridView2.DetailHeight = 280;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 700;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colborrowNo
            // 
            this.colborrowNo.Caption = "대여코드";
            this.colborrowNo.FieldName = "borrowno";
            this.colborrowNo.MinWidth = 17;
            this.colborrowNo.Name = "colborrowNo";
            this.colborrowNo.Visible = true;
            this.colborrowNo.VisibleIndex = 0;
            this.colborrowNo.Width = 66;
            // 
            // coluserNo1
            // 
            this.coluserNo1.Caption = "회원코드";
            this.coluserNo1.FieldName = "userno";
            this.coluserNo1.MinWidth = 17;
            this.coluserNo1.Name = "coluserNo1";
            this.coluserNo1.Visible = true;
            this.coluserNo1.VisibleIndex = 1;
            this.coluserNo1.Width = 66;
            // 
            // colbookCode1
            // 
            this.colbookCode1.Caption = "도서코드";
            this.colbookCode1.FieldName = "isbn";
            this.colbookCode1.MinWidth = 17;
            this.colbookCode1.Name = "colbookCode1";
            this.colbookCode1.Visible = true;
            this.colbookCode1.VisibleIndex = 2;
            this.colbookCode1.Width = 66;
            // 
            // colreturnDate
            // 
            this.colreturnDate.Caption = "반납일자";
            this.colreturnDate.FieldName = "returndate";
            this.colreturnDate.MinWidth = 17;
            this.colreturnDate.Name = "colreturnDate";
            this.colreturnDate.Visible = true;
            this.colreturnDate.VisibleIndex = 3;
            this.colreturnDate.Width = 66;
            // 
            // colborrowDate
            // 
            this.colborrowDate.Caption = "대여일자";
            this.colborrowDate.FieldName = "borrowdate";
            this.colborrowDate.MinWidth = 17;
            this.colborrowDate.Name = "colborrowDate";
            this.colborrowDate.Visible = true;
            this.colborrowDate.VisibleIndex = 4;
            this.colborrowDate.Width = 66;
            // 
            // colborrowOk
            // 
            this.colborrowOk.Caption = "대여여부";
            this.colborrowOk.FieldName = "borrowok";
            this.colborrowOk.MinWidth = 17;
            this.colborrowOk.Name = "colborrowOk";
            this.colborrowOk.Visible = true;
            this.colborrowOk.VisibleIndex = 5;
            this.colborrowOk.Width = 66;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.gridControl3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.b_publ);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.b_year);
            this.groupBox3.Controls.Add(this.b_name);
            this.groupBox3.Location = new System.Drawing.Point(523, 208);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(610, 248);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서정보";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(462, 178);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 25);
            this.button6.TabIndex = 4;
            this.button6.Text = "대여하기";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // gridControl3
            // 
            this.gridControl3.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl3.Location = new System.Drawing.Point(20, 42);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(401, 178);
            this.gridControl3.TabIndex = 4;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bookCode,
            this.bookName,
            this.bookYear,
            this.bookPublishing});
            this.gridView3.DetailHeight = 280;
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsEditForm.PopupEditFormWidth = 700;
            this.gridView3.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView3_FocusedRowChanged);
            // 
            // bookCode
            // 
            this.bookCode.Caption = "도서코드";
            this.bookCode.FieldName = "isbn";
            this.bookCode.MinWidth = 17;
            this.bookCode.Name = "bookCode";
            this.bookCode.Visible = true;
            this.bookCode.VisibleIndex = 0;
            this.bookCode.Width = 66;
            // 
            // bookName
            // 
            this.bookName.Caption = "도서명";
            this.bookName.FieldName = "bk_name";
            this.bookName.MinWidth = 17;
            this.bookName.Name = "bookName";
            this.bookName.Visible = true;
            this.bookName.VisibleIndex = 1;
            this.bookName.Width = 66;
            // 
            // bookYear
            // 
            this.bookYear.Caption = "출판년도";
            this.bookYear.FieldName = "bk_year";
            this.bookYear.MinWidth = 17;
            this.bookYear.Name = "bookYear";
            this.bookYear.Visible = true;
            this.bookYear.VisibleIndex = 2;
            this.bookYear.Width = 66;
            // 
            // bookPublishing
            // 
            this.bookPublishing.Caption = "출판사";
            this.bookPublishing.FieldName = "bk_publ";
            this.bookPublishing.MinWidth = 17;
            this.bookPublishing.Name = "bookPublishing";
            this.bookPublishing.Visible = true;
            this.bookPublishing.VisibleIndex = 3;
            this.bookPublishing.Width = 66;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 148);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 25);
            this.button4.TabIndex = 2;
            this.button4.Text = "검색";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // b_publ
            // 
            this.b_publ.Location = new System.Drawing.Point(500, 114);
            this.b_publ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_publ.Name = "b_publ";
            this.b_publ.Size = new System.Drawing.Size(88, 21);
            this.b_publ.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "출판사";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "출판년도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "도서명";
            // 
            // b_year
            // 
            this.b_year.Location = new System.Drawing.Point(500, 78);
            this.b_year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_year.Name = "b_year";
            this.b_year.Size = new System.Drawing.Size(88, 21);
            this.b_year.TabIndex = 3;
            // 
            // b_name
            // 
            this.b_name.Location = new System.Drawing.Point(500, 42);
            this.b_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_name.Name = "b_name";
            this.b_name.Size = new System.Drawing.Size(88, 21);
            this.b_name.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Mtel);
            this.groupBox2.Controls.Add(this.Mname);
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1128, 197);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회원정보";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(924, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(972, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(908, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "휴대폰번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(956, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // Mtel
            // 
            this.Mtel.Location = new System.Drawing.Point(989, 92);
            this.Mtel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mtel.Name = "Mtel";
            this.Mtel.Size = new System.Drawing.Size(116, 21);
            this.Mtel.TabIndex = 2;
            // 
            // Mname
            // 
            this.Mname.Location = new System.Drawing.Point(989, 52);
            this.Mname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(116, 21);
            this.Mname.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(3, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(892, 166);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.userNo,
            this.userName,
            this.userPhone,
            this.userGrade});
            this.gridView1.DetailHeight = 280;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // userNo
            // 
            this.userNo.Caption = "회원코드";
            this.userNo.FieldName = "member_no";
            this.userNo.MinWidth = 17;
            this.userNo.Name = "userNo";
            this.userNo.Visible = true;
            this.userNo.VisibleIndex = 0;
            this.userNo.Width = 66;
            // 
            // userName
            // 
            this.userName.Caption = "이름";
            this.userName.FieldName = "name";
            this.userName.MinWidth = 17;
            this.userName.Name = "userName";
            this.userName.Visible = true;
            this.userName.VisibleIndex = 1;
            this.userName.Width = 66;
            // 
            // userPhone
            // 
            this.userPhone.Caption = "전화번호";
            this.userPhone.FieldName = "tel";
            this.userPhone.MinWidth = 17;
            this.userPhone.Name = "userPhone";
            this.userPhone.Visible = true;
            this.userPhone.VisibleIndex = 2;
            this.userPhone.Width = 66;
            // 
            // userGrade
            // 
            this.userGrade.Caption = "회원등급";
            this.userGrade.FieldName = "usergrade";
            this.userGrade.MinWidth = 17;
            this.userGrade.Name = "userGrade";
            this.userGrade.Visible = true;
            this.userGrade.VisibleIndex = 3;
            this.userGrade.Width = 66;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1116, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "반납";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.gridControl4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.handphonee);
            this.groupBox1.Controls.Add(this.namee);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1044, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원정보";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(290, 214);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(66, 18);
            this.save.TabIndex = 1;
            this.save.Text = "저장";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // gridControl4
            // 
            this.gridControl4.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl4.Location = new System.Drawing.Point(387, 12);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(627, 426);
            this.gridControl4.TabIndex = 1;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.borrownoo,
            this.colnamee,
            this.coltell,
            this.booknamee,
            this.bkpubll,
            this.borrowdatee,
            this.returndatee,
            this.borrowokk});
            this.gridView4.DetailHeight = 280;
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsEditForm.PopupEditFormWidth = 700;
            this.gridView4.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView4_FocusedRowChanged);
            // 
            // borrownoo
            // 
            this.borrownoo.Caption = "대여코드";
            this.borrownoo.FieldName = "borrowno";
            this.borrownoo.MinWidth = 17;
            this.borrownoo.Name = "borrownoo";
            this.borrownoo.Visible = true;
            this.borrownoo.VisibleIndex = 0;
            this.borrownoo.Width = 66;
            // 
            // colnamee
            // 
            this.colnamee.Caption = "이름";
            this.colnamee.FieldName = "name";
            this.colnamee.MinWidth = 17;
            this.colnamee.Name = "colnamee";
            this.colnamee.Visible = true;
            this.colnamee.VisibleIndex = 1;
            this.colnamee.Width = 66;
            // 
            // coltell
            // 
            this.coltell.Caption = "전화번호";
            this.coltell.FieldName = "tel";
            this.coltell.MinWidth = 17;
            this.coltell.Name = "coltell";
            this.coltell.Visible = true;
            this.coltell.VisibleIndex = 2;
            this.coltell.Width = 66;
            // 
            // booknamee
            // 
            this.booknamee.Caption = "책이름";
            this.booknamee.FieldName = "bk_name";
            this.booknamee.MinWidth = 17;
            this.booknamee.Name = "booknamee";
            this.booknamee.Visible = true;
            this.booknamee.VisibleIndex = 3;
            this.booknamee.Width = 66;
            // 
            // bkpubll
            // 
            this.bkpubll.Caption = "출판사";
            this.bkpubll.FieldName = "bk_publ";
            this.bkpubll.MinWidth = 17;
            this.bkpubll.Name = "bkpubll";
            this.bkpubll.Visible = true;
            this.bkpubll.VisibleIndex = 4;
            this.bkpubll.Width = 66;
            // 
            // borrowdatee
            // 
            this.borrowdatee.Caption = "대여일자";
            this.borrowdatee.FieldName = "borrowdate";
            this.borrowdatee.MinWidth = 17;
            this.borrowdatee.Name = "borrowdatee";
            this.borrowdatee.Visible = true;
            this.borrowdatee.VisibleIndex = 5;
            this.borrowdatee.Width = 66;
            // 
            // returndatee
            // 
            this.returndatee.Caption = "반납일자";
            this.returndatee.FieldName = "returndate";
            this.returndatee.MinWidth = 17;
            this.returndatee.Name = "returndatee";
            this.returndatee.Visible = true;
            this.returndatee.VisibleIndex = 6;
            this.returndatee.Width = 66;
            // 
            // borrowokk
            // 
            this.borrowokk.Caption = "대여여부";
            this.borrowokk.FieldName = "borrowok";
            this.borrowokk.MinWidth = 17;
            this.borrowokk.Name = "borrowokk";
            this.borrowokk.Visible = true;
            this.borrowokk.VisibleIndex = 7;
            this.borrowokk.Width = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "휴대폰번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "이름";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(290, 191);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 18);
            this.button5.TabIndex = 1;
            this.button5.Text = "검색";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // handphonee
            // 
            this.handphonee.Location = new System.Drawing.Point(122, 215);
            this.handphonee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.handphonee.Name = "handphonee";
            this.handphonee.Size = new System.Drawing.Size(118, 21);
            this.handphonee.TabIndex = 2;
            // 
            // namee
            // 
            this.namee.Location = new System.Drawing.Point(122, 182);
            this.namee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namee.Name = "namee";
            this.namee.Size = new System.Drawing.Size(118, 21);
            this.namee.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 486);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = " ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrow_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrow_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mtel;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox b_publ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox b_year;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox handphonee;
        private System.Windows.Forms.TextBox namee;
        private DevExpress.XtraGrid.Columns.GridColumn userNo;
        private DevExpress.XtraGrid.Columns.GridColumn userName;
        private DevExpress.XtraGrid.Columns.GridColumn userPhone;
        private DevExpress.XtraGrid.Columns.GridColumn userGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colborrowNo;
        private DevExpress.XtraGrid.Columns.GridColumn coluserNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colbookCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colreturnDate;
        private DevExpress.XtraGrid.Columns.GridColumn colborrowDate;
        private DevExpress.XtraGrid.Columns.GridColumn colborrowOk;
        private DevExpress.XtraGrid.Columns.GridColumn bookCode;
        private DevExpress.XtraGrid.Columns.GridColumn bookName;
        private DevExpress.XtraGrid.Columns.GridColumn bookYear;
        private DevExpress.XtraGrid.Columns.GridColumn bookPublishing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox b_name;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button select;
        private DevExpress.XtraGrid.Columns.GridColumn colnamee;
        private DevExpress.XtraGrid.Columns.GridColumn coltell;
        private DevExpress.XtraGrid.Columns.GridColumn booknamee;
        private DevExpress.XtraGrid.Columns.GridColumn bkpubll;
        private DevExpress.XtraGrid.Columns.GridColumn borrowdatee;
        private DevExpress.XtraGrid.Columns.GridColumn returndatee;
        private System.Windows.Forms.Button save;
        private DevExpress.XtraGrid.Columns.GridColumn borrowokk;
        private DevExpress.XtraGrid.Columns.GridColumn borrownoo;
        private DevExpress.XtraEditors.DateEdit borrow_date;
    }
}

