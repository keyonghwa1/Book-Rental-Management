using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using 도서대여프로그램;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace 도서대여관리
{
    public partial class memberform : Form
    {
        public memberform()
        {
            InitializeComponent();
            member_grade();
        }

        private void fn_dbConnection(ref bool bwork) // db연결
        {
            bwork = true; // db 연결

            string connection_str = @"Server=192.168.219.106; uid=system; pwd=hr2; database=master";
            
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
        

        //OracleConnection sql_connection2;

       /* private void Ofn_dbConnection(ref bool bwork) // db연결
        {
            bwork = true; // db 연결

            string connection_str = "data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = 10.211.55.3)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = xe)));USER ID=system;PASSWORD=hr2;";
            
            sql_connection2 = new OracleConnection(connection_str);
                        
            try
            {
                sql_connection2.Open();
                Console.WriteLine("bwork = true");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                bwork = false;
            }

        }*/

        private void member_grade()
        { //회원 등급
            cmb.Items.Add("일반");
            cmb.Items.Add("vip");
            
        }



        static SqlConnection sql_connection;
        //string usercode1; // return할 담을변수

        public object Int { get; private set; }

        private void button2_Click(object sender, EventArgs e) // 저장 insert
        {

            button5.Enabled = true;
            bool bwork1 = false;
            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sql_connection; // db와 연결

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "dbo.sp_member2";

                //cmd.Parameters.AddWithValue("@message", "member insert확인");


                // SELECT해서 MESSAGE값 출력    
                cmd.Parameters.AddWithValue("@p_div", "SC");
                cmd.Parameters.AddWithValue("@p_name", username.Text.ToString());
                cmd.Parameters.AddWithValue("@p_tel", tel.Text.ToString());

            // cmd.Parameters.AddWithValue("@member_no", usercode.Text.ToString());// textbox.text - 문자열이 아닐수 있음

            // 메시지 불러오기
                cmd.Parameters.Add("@p_message", SqlDbType.NVarChar, 2000);
                cmd.Parameters["@p_message"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery(); // div sc 실행 완료


                String p_message = cmd.Parameters["@p_message"].Value.ToString();

                //MessageBox.Show("message 회원번호=" + usercode.Text); // usercode.Text안에 들어갔음

                if (Int32.Parse(p_message) > 0)
                {
                    MessageBox.Show(username.Text.ToString() + "님은 등록 되어 있습니다.");
                    return;
                }
                else
                {
                    insertok(); // 입력 메소드
                    search1(); // grid에 보여주기
                }
                    


        }

        private void insertok()
        {


            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql_connection; // db와 연결

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "dbo.sp_member2";

            //cmd.Parameters.AddWithValue("@message", "member insert확인");

            cmd.Parameters.AddWithValue("@p_div", "I");

            cmd.Parameters.AddWithValue("@p_member_grade", cmb.Text.ToString()); // textbox.text.tostring - 사용하면 텍스트 상자에서 텍스트를 가져 와서 해당 텍스트 유형으로 변환합니다.
            //cmd.Parameters.AddWithValue("@p_member_no", usercode.Text.ToString());// textbox.text - 문자열이 아닐수 있음
            cmd.Parameters.AddWithValue("@p_name", username.Text.ToString());
            cmd.Parameters.AddWithValue("@p_tel", tel.Text.ToString());
            cmd.Parameters.AddWithValue("@p_borrow", borrow.Text.ToString());
            cmd.Parameters.AddWithValue("@p_reserve", reservation.Text.ToString());

            cmd.ExecuteNonQuery();
        }

        // Mssql
        private void search1() // 검색 메소드
        {

            bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql_connection; // db와 연결

            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "dbo.sp_member2";

            //sqlcmd.Parameters.AddWithValue("@message", "member select");

            sqlcmd.Parameters.AddWithValue("@p_div", "S"); //  cmd.Parameters.Add()를 사용한다면 데이터의 유형 및 길이를 지정하여 사용자 입력을 제한 받을수있다,
            //예) .Parameters.Add("@name",SqlDbType.VarChar,30).Value=varName;

            sqlcmd.Parameters.AddWithValue("@p_member_no", member_no.Text.ToString());
            sqlcmd.Parameters.AddWithValue("@p_name", name.Text.ToString());


            //MessageBox.Show("search MEMBER_NO= " + member_no.Text.ToString() + "search name = " + name.Text.ToString());


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
                username.ReadOnly = true; // 이름 수정 못하게 읽기만 가능 !


            //MessageBox.Show(icount.ToString());
        }


        // Oracle
       /* private void Osearch1() // 검색 메소드
        {

            bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!


            OracleCommand cmd = new OracleCommand("SP_MEMBER2", sql_connection2);


            cmd.CommandType = CommandType.StoredProcedure;
            // 매개변수 순서가 아닌 이름으로 바인딩
            cmd.BindByName = true;

            // 입력 매개변수 
            //cmd.Parameters.Add("p_member_no", OracleDbType.Int32).Value = member_no.Text.ToString();
            
            cmd.Parameters.Add("p_member_no", OracleDbType.Varchar2).Value = member_no.Text.ToString();
            cmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = name.Text.ToString();

            MessageBox.Show("search MEMBER_NO= " + member_no.Text.ToString() + "search name = " + name.Text.ToString());
             

            
            try
            {

                cmd.Parameters.Add("output_data", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd); 
                
                DataTable dt = new DataTable(); 
                dataAdapter.Fill(dt);
                gridControl1.DataSource = dt.DefaultView;
            
            
            }
            catch (SqlException ex)
            {
                string sreturnmessage = "데이터베이스 오류" + ex.Message.ToString();
                MessageBox.Show(sreturnmessage);
            }
            finally
            {
                sql_connection2.Close();
            }

            int icount = 0;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                icount++;
            }

            MessageBox.Show(icount.ToString());
        }

        */

        private void update_Click(object sender, EventArgs e) // 수정 버튼
        {

            // 이름 읽기만 가능
            username.ReadOnly = true;

            // 비활성화 풀어줌
            cmb.Enabled = true;
            tel.ReadOnly = false;
            borrow.ReadOnly = false;
            reservation.ReadOnly = false;

        }

 
        private void button1_Click(object sender, EventArgs e) // 삭제
        {
            if (gridView1.RowCount == 0)
                return;

            bool bwork1 = false;
            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql_connection; // db와 연결

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "dbo.sp_member2";

            //cmd.Parameters.AddWithValue("@message", "member delete확인");

            cmd.Parameters.AddWithValue("@p_div", "D");

            cmd.Parameters.AddWithValue("@p_member_no", usercode.Text.ToString());

            cmd.ExecuteNonQuery();

            //gridView1.DeleteSelectedRows();

            MessageBox.Show("삭제되었습니다");

            search1(); // 검색

            // 비활성화 풀어줌
            /*username.ReadOnly = false;
            usercode.ReadOnly = false;
            cmb.Enabled = true;
            tel.ReadOnly = false;
            borrow.ReadOnly = false;
            reservation.ReadOnly = false;*/

        }

        private void search_Click(object sender, EventArgs e) // 검색 check
        {
            search1();
        }

        private void Ucheck_Click(object sender, EventArgs e) // 업데이트 확인 버튼
        {
            bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!


            MessageBox.Show("update로 확인버튼으로 들어와");

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql_connection; // db와 연결

            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "dbo.sp_member2";

            //sqlcmd.Parameters.AddWithValue("@message", "member update");

            sqlcmd.Parameters.AddWithValue("@p_div", "U");

            sqlcmd.Parameters.AddWithValue("@p_member_no", usercode.Text.ToString());

            sqlcmd.Parameters.AddWithValue("@p_member_grade", cmb.Text.ToString()); // textbox.text.tostring - 사용하면 텍스트 상자에서 텍스트를 가져 와서 해당 텍스트 유형으로 변환합니다.
            sqlcmd.Parameters.AddWithValue("@p_tel", tel.Text.ToString());
            sqlcmd.Parameters.AddWithValue("@p_borrow", borrow.Text.ToString());
            sqlcmd.Parameters.AddWithValue("@p_reserve", reservation.Text.ToString());

            sqlcmd.Parameters.Add("@p_message", SqlDbType.NVarChar, 2000);
            sqlcmd.Parameters["@p_message"].Direction = ParameterDirection.Output;

            sqlcmd.ExecuteNonQuery();

            int updateCnt = Int32.Parse(sqlcmd.Parameters["@p_message"].Value.ToString());
            if (updateCnt > 0)
                MessageBox.Show("수정되었습니다.");

            search1(); // 검색

            // 비활성화 된 부분 풀기
            //username.ReadOnly = false;


        }

        private void gridView1_FocusedRowChanged_1(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0 && gridView1.FocusedRowHandle > -1) // gridView1.FocusedRowHandle -> 중요!!!!
                {
                    /*gridView1.SetFocusedRowCellValue(coluserName.ToString(), Int32.Parse(usercode1) - 1);
                    gridView1.SetFocusedRowCellValue(coluserCode.ToString(), Int32.Parse(usercode1) - 1);
                    gridView1.SetFocusedRowCellValue(colUsertel.ToString(), Int32.Parse(usercode1) - 1);
                    gridView1.SetFocusedRowCellValue(colUserBorrow.ToString(), Int32.Parse(usercode1) - 1);
                    gridView1.SetFocusedRowCellValue(colUserReserve.ToString(), Int32.Parse(usercode1) - 1);*/

                    username.Text = gridView1.GetFocusedRowCellValue(coluserName).ToString(); // gridview에서 설정한 colums -> name 으로 쓴다,
                    usercode.Text = gridView1.GetFocusedRowCellValue(coluserCode).ToString(); // 회원명
                    cmb.Text = gridView1.GetFocusedRowCellValue(colUsergrade).ToString(); // 회원등급
                    tel.Text = gridView1.GetFocusedRowCellValue(colUsertel).ToString();// 회원 전화번호
                    borrow.Text = gridView1.GetFocusedRowCellValue(colUserBorrow).ToString(); // 대출가능건수
                    reservation.Text = gridView1.GetFocusedRowCellValue(colUserReserve).ToString(); // 예약가능건수
                    
                }
                else{
                username.Text = "";
                    usercode.Text = "";
                    cmb.Text = "";
                    tel.Text = "";
                    borrow.Text = "";
                    reservation.Text = "";

                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            //button5.Enabled = false;
            username.ReadOnly = false;
        }

        private void button6_Click(object sender, EventArgs e) // 대여버튼
        {
            도서대여프로그램.Form1 newform1 = new 도서대여프로그램.Form1();
            newform1.Show(); //폼창열기
        }

 
    }



   }
  

