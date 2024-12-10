namespace 도서대여관리
{
    partial class memberform
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.member_no = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.borrow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.reservation = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coluserCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsergrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsertel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserBorrow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserReserve = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button5 = new System.Windows.Forms.Button();
            this.Ucheck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.usercode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원등급";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "회원명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "회원번호";
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(668, 149);
            this.cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(71, 20);
            this.cmb.TabIndex = 4;
            // 
            // member_no
            // 
            this.member_no.Location = new System.Drawing.Point(248, 51);
            this.member_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.member_no.Name = "member_no";
            this.member_no.Size = new System.Drawing.Size(204, 22);
            this.member_no.TabIndex = 5;
            // 
            // name
            // 
            this.name.HideSelection = false;
            this.name.Location = new System.Drawing.Point(54, 47);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 22);
            this.name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "전화번호";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(838, 152);
            this.tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(193, 21);
            this.tel.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "대출/가능건수";
            // 
            // borrow
            // 
            this.borrow.Location = new System.Drawing.Point(678, 190);
            this.borrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(61, 21);
            this.borrow.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(772, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "예약/가능건수";
            // 
            // reservation
            // 
            this.reservation.Location = new System.Drawing.Point(867, 185);
            this.reservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(50, 21);
            this.reservation.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(746, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 22);
            this.button2.TabIndex = 20;
            this.button2.Text = "저장";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 40);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 24);
            this.button3.TabIndex = 21;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(574, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "회원검색";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(10, 111);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(542, 165);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluserCode,
            this.coluserName,
            this.colUsergrade,
            this.colUsertel,
            this.colUserBorrow,
            this.colUserReserve});
            this.gridView1.DetailHeight = 280;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // coluserCode
            // 
            this.coluserCode.Caption = "회원코드";
            this.coluserCode.FieldName = "member_no";
            this.coluserCode.MinWidth = 17;
            this.coluserCode.Name = "coluserCode";
            this.coluserCode.Visible = true;
            this.coluserCode.VisibleIndex = 0;
            this.coluserCode.Width = 66;
            // 
            // coluserName
            // 
            this.coluserName.Caption = "회원명";
            this.coluserName.FieldName = "name";
            this.coluserName.MinWidth = 17;
            this.coluserName.Name = "coluserName";
            this.coluserName.Visible = true;
            this.coluserName.VisibleIndex = 1;
            this.coluserName.Width = 66;
            // 
            // colUsergrade
            // 
            this.colUsergrade.Caption = "회원등급";
            this.colUsergrade.FieldName = "member_grade";
            this.colUsergrade.MinWidth = 17;
            this.colUsergrade.Name = "colUsergrade";
            this.colUsergrade.Visible = true;
            this.colUsergrade.VisibleIndex = 2;
            this.colUsergrade.Width = 66;
            // 
            // colUsertel
            // 
            this.colUsertel.Caption = "회원전화번호";
            this.colUsertel.FieldName = "tel";
            this.colUsertel.MinWidth = 17;
            this.colUsertel.Name = "colUsertel";
            this.colUsertel.Visible = true;
            this.colUsertel.VisibleIndex = 3;
            this.colUsertel.Width = 66;
            // 
            // colUserBorrow
            // 
            this.colUserBorrow.Caption = "대출/가능권수";
            this.colUserBorrow.FieldName = "borrow";
            this.colUserBorrow.MinWidth = 17;
            this.colUserBorrow.Name = "colUserBorrow";
            this.colUserBorrow.Visible = true;
            this.colUserBorrow.VisibleIndex = 4;
            this.colUserBorrow.Width = 66;
            // 
            // colUserReserve
            // 
            this.colUserReserve.Caption = "예약/가능권수";
            this.colUserReserve.FieldName = "reserve";
            this.colUserReserve.MinWidth = 17;
            this.colUserReserve.Name = "colUserReserve";
            this.colUserReserve.Visible = true;
            this.colUserReserve.VisibleIndex = 5;
            this.colUserReserve.Width = 66;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 21);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "회원번호";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "회원명";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(542, 50);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(96, 22);
            this.update.TabIndex = 23;
            this.update.Text = "수정";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(458, 53);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(63, 19);
            this.search.TabIndex = 24;
            this.search.Text = "검색";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button5);
            this.groupControl1.Controls.Add(this.button2);
            this.groupControl1.Controls.Add(this.Ucheck);
            this.groupControl1.Controls.Add(this.member_no);
            this.groupControl1.Controls.Add(this.search);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.name);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.update);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1052, 92);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "회원정보관리";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(950, 50);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 22);
            this.button5.TabIndex = 31;
            this.button5.Text = "초기화";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Ucheck
            // 
            this.Ucheck.Location = new System.Drawing.Point(644, 50);
            this.Ucheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ucheck.Name = "Ucheck";
            this.Ucheck.Size = new System.Drawing.Size(96, 22);
            this.Ucheck.TabIndex = 32;
            this.Ucheck.Text = "수정 확인";
            this.Ucheck.UseVisualStyleBackColor = true;
            this.Ucheck.Click += new System.EventHandler(this.Ucheck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 22);
            this.button1.TabIndex = 26;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usercode
            // 
            this.usercode.Location = new System.Drawing.Point(836, 112);
            this.usercode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usercode.Name = "usercode";
            this.usercode.ReadOnly = true;
            this.usercode.Size = new System.Drawing.Size(196, 21);
            this.usercode.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(772, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "회원번호";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(651, 111);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(88, 21);
            this.username.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "회원명";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(596, 258);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 26);
            this.button6.TabIndex = 31;
            this.button6.Text = "대여/버튼";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // memberform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 366);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.usercode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.reservation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "memberform";
            this.Text = "member";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.TextBox member_no;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox borrow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox reservation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
       
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button search;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usercode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Ucheck;
        private DevExpress.XtraGrid.Columns.GridColumn coluserCode;
        private DevExpress.XtraGrid.Columns.GridColumn coluserName;
        private DevExpress.XtraGrid.Columns.GridColumn colUsergrade;
        private DevExpress.XtraGrid.Columns.GridColumn colUsertel;
        private DevExpress.XtraGrid.Columns.GridColumn colUserBorrow;
        private DevExpress.XtraGrid.Columns.GridColumn colUserReserve;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}