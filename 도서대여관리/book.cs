using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 도서대여관리
{
    public partial class bookform : Form
    {
        public bookform()
        {
            InitializeComponent();
            book_locate(); // 책 소장 위치
            book_state(); // 도서 상태
            book_carryin(); // 반입구분
        }

        static SqlConnection sql_connection;

        private void fn_dbConnection(ref bool bwork) // db연결
        {
            bwork = true; // db 연결

            //string connection_str = @"Server=121.170.218.149; uid=gmpit; pwd=gmpit)9)5; database=GMPIT";

            // 스터디 카페 ip
            string connection_str = @"Server=192.168.1.19; uid=system; pwd=hr2; database=master";
            // 집 ip
            //string connection_str = @"Server=192.168.219.103; uid=system; pwd=hr2; database=master";

            //string connection_str = @"Server=172.30.1.74; uid=system; pwd=hr2; database=master";
            

            sql_connection = new SqlConnection(connection_str);
            try
            {
                sql_connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                bwork = false;
            }

        }

        private void bookform_Load(object sender, EventArgs e)
        {


        }

        private void memberStatue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void book_locate() // 소장 위치(책)
        { 
            bk_location.Items.Add("자료실1");
            bk_location.Items.Add("자료실2");
            bk_location.Items.Add("자료실3");
         }

        private void book_state() // 도서상태
        {
            bk_state.Items.Add("심함");
            bk_state.Items.Add("깨끗");
            bk_state.Items.Add("중간");

        }

        private void book_carryin()
        {
            // 반입구분

            bk_carryin.Items.Add("중고");
            bk_carryin.Items.Add("새책");

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        string regi_n1; // output 해 놓은거 담을 변수

        private void b_save_Click(object sender, EventArgs e) // 저장 , 입력
        {

            // 활성화
            //ISBN_1.ReadOnly = false;
            bk_name.ReadOnly = false;
            bk_size.ReadOnly = false;
            bk_carryin.Enabled = true;
            bk_state.Enabled = true;
            //regi_n.ReadOnly = false;

            bool bwork1 = false;
            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand cmd = new SqlCommand();
            //MessageBox.Show("INSERT 이쪽으로 넘어옴");
            try
            {            
                cmd.Connection = sql_connection; // db와 연결

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "dbo.sp_book_management";

                cmd.Parameters.AddWithValue("@p_div", "BSC");

                
                cmd.Parameters.AddWithValue("@p_bk_name", bk_name.Text.ToString());
                cmd.Parameters.AddWithValue("@p_bk_publ_date",bk_year.Text.ToString());
                cmd.Parameters.AddWithValue("@p_bk_publ_nm", bk_publ.Text.ToString());
                

                // cmd.Parameters.AddWithValue("@member_no", usercode.Text.ToString());// textbox.text - 문자열이 아닐수 있음

                // 메시지 불러오기

                cmd.Parameters.Add("@p_message", SqlDbType.NVarChar, 2000);
                cmd.Parameters["@p_message"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery(); // div sc 실행 완료

                String p_message = cmd.Parameters["@p_message"].Value.ToString();
                

                //MessageBox.Show("등록자동 넘버= " + regi_n1);

                if (p_message.Equals("OK"))
                {
                    insertok(); // 입력 메소드
                    search();
                }          
                else
                    MessageBox.Show("등록 되어 있습니다.\n(새로운 책을 등록해주세요)");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }


        private void insertok() {

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql_connection; // db와 연결

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "dbo.sp_book_management";

            //cmd.Parameters.AddWithValue("@message", "book insert확인");

            cmd.Parameters.AddWithValue("@p_div", "BI");
            
            //cmd.Parameters.AddWithValue("@regi_n", regi_n1);

            //cmd.Parameters.AddWithValue("@p_isbn", ISBN_1.Text.ToString()); // textbox.text.tostring - 사용하면 텍스트 상자에서 텍스트를 가져 와서 해당 텍스트 유형으로 변환합니다.
            cmd.Parameters.AddWithValue("@p_bk_name", bk_name.Text.ToString()); // 도서명
            cmd.Parameters.AddWithValue("@p_bk_publ_date", bk_year.Text.ToString()); // 출판년도
            cmd.Parameters.AddWithValue("@p_bk_publ_nm", bk_publ.Text.ToString()); // 출판사
            cmd.Parameters.AddWithValue("@p_bk_page", bk_page.Text.ToString()); // 페이지
            cmd.Parameters.AddWithValue("@p_bk_size", bk_size.Text.ToString()); // 크기
            cmd.Parameters.AddWithValue("@p_bk_price", bk_price.Text.ToString()); // 가격
            cmd.Parameters.AddWithValue("@p_bk_location", bk_location.Text.ToString()); //소장위치
            cmd.Parameters.AddWithValue("@p_bk_carryin", bk_carryin.Text.ToString()); //반입구분
            cmd.Parameters.AddWithValue("@p_bk_state", bk_state.Text.ToString()); // 도서상태
           

            // 메시지 불러오기

            cmd.Parameters.Add("@p_message", SqlDbType.NVarChar, 2000);
            cmd.Parameters["@p_message"].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery(); // div sc 실행 완료

            String p_message = cmd.Parameters["@p_message"].Value.ToString();

            if(Int32.Parse(p_message) >0 )
                MessageBox.Show("등록되었습니다.");

        }

        private void b_delete_Click(object sender, EventArgs e) // 삭제
        {


            bool bwork1 = false;
            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql_connection; // db와 연결

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "dbo.sp_book_management";

            //cmd.Parameters.AddWithValue("@message", "member delete확인");

            cmd.Parameters.AddWithValue("@p_div", "BD");

            cmd.Parameters.AddWithValue("@p_isbn", ISBN_1.Text.ToString());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return;
            }
            sql_connection.Close();

            if(gridView1.RowCount > 0)
                search(); // 검색

           
        }
///////////////////////////////////////////////////////////////////////////

        private void search() // 검색 메소드
        {

            bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql_connection; // db와 연결

            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "dbo.sp_book_management";

            //sqlcmd.Parameters.AddWithValue("@message", "book_management select");

            sqlcmd.Parameters.AddWithValue("@p_div", "BS"); //  cmd.Parameters.Add()를 사용한다면 데이터의 유형 및 길이를 지정하여 사용자 입력을 제한 받을수있다,
            //예) .Parameters.Add("@name",SqlDbType.VarChar,30).Value=varName;

            sqlcmd.Parameters.AddWithValue("@p_isbn", ISBN_2.Text.ToString());
          

            try
            {
                DataSet nDataSet = new DataSet(); // 데이타 부서정보, 여러 정보들 하나의 객체 x 그룹으로 볼수있다는것!
                // 개념: 엑셀 시트 123 -> 데이타 셋
                // c#.net 데이타 호출 -> 데이타 셋 (넘겨받는건 무조건 set) -> 보이는건 table로 보인다 그러므로 불러오는건 set 
                SqlDataAdapter nSqlDataAdapter = new SqlDataAdapter(sqlcmd); // adapter 통해 
                nSqlDataAdapter.Fill(nDataSet);
                gridControl1.DataSource = nDataSet.Tables[0]; // gridcontrol

            }
            catch (SqlException ex)
            {
                string sreturnmessage = "데이터베이스 오류" + ex.Message.ToString();
                MessageBox.Show(sreturnmessage);
            }
            finally
            {
                sql_connection.Close();
            }


            int icount = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                icount++;
            }


            if(gridView1.RowCount > 0)
            {
                // 비활성화
                ISBN_1.ReadOnly = true;
                bk_name.ReadOnly = true;
                bk_size.ReadOnly = true;
                bk_carryin.Enabled = false;
                bk_state.Enabled = false;
                regi_n.ReadOnly = true;

                //MessageBox.Show(icount.ToString());
            }

        }

///////////////////////////////////////////업데이트///////////////////////////////////////////////////

        private void update_enable(ref bool uden)
        {

            uden = true;

            // 비활성화
            ISBN_1.ReadOnly = true;
            bk_name.ReadOnly = true;
            bk_size.ReadOnly = true;
            bk_carryin.Enabled = false;
            bk_state.Enabled = false;
            regi_n.ReadOnly = true;

        }

        private void b_update_Click(object sender, EventArgs e) // 업데이트
        {
            bool enable = false;

            update_enable(ref enable);

            if (!enable)
                return;

        }

 
        private void button_2_Click(object sender, EventArgs e) // 업데이트 확인
        {
            bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            //MessageBox.Show("update로 확인버튼으로 들어와");

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql_connection; // db와 연결

            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "dbo.sp_book_management";

            //sqlcmd.Parameters.AddWithValue("@message", "book_management update");

            sqlcmd.Parameters.AddWithValue("@p_div", "BU"); //  cmd.Parameters.Add()를 사용한다면 데이터의 유형 및 길이를 지정하여 사용자 입력을 제한 받을수있다,
            //예) .Parameters.Add("@name",SqlDbType.VarChar,30).Value=varName;

            sqlcmd.Parameters.AddWithValue("@p_isbn", ISBN_1.Text.ToString());
            sqlcmd.Parameters.AddWithValue("@p_bk_publ_date", bk_year.Text.ToString()); // textbox.text.tostring - 사용하면 텍스트 상자에서 텍스트를 가져 와서 해당 텍스트 유형으로 변환합니다.
            sqlcmd.Parameters.AddWithValue("@p_bk_publ_nm", bk_publ.Text.ToString());
            sqlcmd.Parameters.AddWithValue("@p_bk_page", bk_page.Text.ToString());
            sqlcmd.Parameters.AddWithValue("@p_bk_price", bk_price.Text.ToString());
            sqlcmd.Parameters.AddWithValue("@p_bk_location", bk_location.Text.ToString());
            //sqlcmd.Parameters.AddWithValue("@regi_n", regi_n.Text.ToString());

            // 메시지 불러오기

            sqlcmd.Parameters.Add("@p_message", SqlDbType.NVarChar, 2000);
            sqlcmd.Parameters["@p_message"].Direction = ParameterDirection.Output;

            sqlcmd.ExecuteNonQuery(); // div sc 실행 완료

            String p_message= sqlcmd.Parameters["@p_message"].Value.ToString();

            int result = Int32.Parse(p_message);

             if (result >= 1)
             { MessageBox.Show("수정되었습니다."); }
             else { MessageBox.Show("실패"); }


            search(); // 검색

            // 활성화
         /*  
            ISBN_1.ReadOnly = false;
            bk_name.ReadOnly = false;
            bk_size.ReadOnly = false;
            bk_carryin.Enabled = true;
            bk_state.Enabled = true;
            regi_n.ReadOnly = false;
         */
       
        }

//////////////////////////////////////검색///////////////////////////////
        private void button1_Click(object sender, EventArgs e) //검색
        {
            search();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            try
            {
                if (gridView1.RowCount > 0 && gridView1.FocusedRowHandle > -1) 
                {
                    //regi_n.Text = gridView1.GetFocusedRowCellValue(colRegin).ToString();
                    ISBN_1.Text = gridView1.GetFocusedRowCellValue(colIsbn).ToString();
                    bk_name.Text = gridView1.GetFocusedRowCellValue(colBkname).ToString();
                    bk_year.Text = gridView1.GetFocusedRowCellValue(colBkyear).ToString();
                    bk_publ.Text = gridView1.GetFocusedRowCellValue(colBkpubl).ToString();

                    bk_page.Text = gridView1.GetFocusedRowCellValue(colBkpage).ToString();
                    bk_size.Text = gridView1.GetFocusedRowCellValue(colBksize).ToString();
                    bk_price.Text = gridView1.GetFocusedRowCellValue(colBkprice).ToString();

                    bk_location.Text = gridView1.GetFocusedRowCellValue(colBklocation).ToString();
                    bk_carryin.Text = gridView1.GetFocusedRowCellValue(colBkcarryin).ToString();
                    bk_state.Text = gridView1.GetFocusedRowCellValue(colBkstate).ToString();
                }

                else
                {
                    regi_n.Text = "";
                    ISBN_1.Text = "";
                    bk_name.Text = "";
                    bk_year.Text = "";
                    bk_publ.Text = "";

                    bk_page.Text = "";
                    bk_size.Text = "";
                    bk_price.Text = "";

                    bk_location.Text = "";
                    bk_carryin.Text = "";
                    bk_state.Text = "";
                    

                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 활성화
            ISBN_1.ReadOnly = true;
            bk_name.ReadOnly = false;
            bk_size.ReadOnly = false;
            bk_carryin.Enabled = true;
            bk_state.Enabled = true;
            regi_n.ReadOnly = false;

            gridView1.AddNewRow(); 
        }

 
    }
}
