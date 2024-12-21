using DevExpress.XtraRichEdit.Layout;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 도서대여프로그램
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void fn_dbConnection(ref bool bwork) // db연결
        {
            bwork = true; // db 연결

            //string connection_str = @"Server=192.168.219.106; uid=system; pwd=hr2; database=master";

            string connection_str = @"Server=192.168.1.4; uid=system; pwd=hr2; database=master";

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

        static SqlConnection sql_connection;
 

        private void button1_Click(object sender, EventArgs e) // 도서 대여 회원 검색 
        {


            button5.Enabled = true;
            bool bwork1 = false;
            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql_connection; // db와 연결

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "dbo.sp_book_borrow";


            // SELECT해서 MESSAGE값 출력    
            //            cmd.Parameters.AddWithValue("@div", "sjm");

            //            cmd.Parameters.AddWithValue("@name", Mname.Text.ToString());// textbox.text - 문자열이 아닐수 있음
            //            cmd.Parameters.AddWithValue("@tel", Mtel.Text.ToString());// textbox.text - 문자열이 아닐수 있음

            //            // 메시지 불러오기
            //            cmd.Parameters.Add("@message", SqlDbType.NVarChar, 2000);
            //            cmd.Parameters["@message"].Direction = ParameterDirection.Output;

            //            cmd.ExecuteNonQuery(); // div sc 실행 완료

            //            member_no_output = cmd.Parameters["@message"].Value.ToString(); // 선택한 회원코드 출력

            //            MessageBox.Show("member_no / output = " + member_no_output); // 선택된 회원 뽑아냄
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            //            SqlCommand cmd1 = new SqlCommand();

            //            cmd1.Connection = sql_connection; // db와 연결

            //            cmd1.CommandType = CommandType.StoredProcedure;

            //            cmd1.CommandText = "dbo.sp_member2";

            //            cmd.Parameters.AddWithValue("@div", "sss");
            cmd.Parameters.AddWithValue("@p_div", "SS");
            //cmd.Parameters.AddWithValue("@message", "member select");

            cmd.Parameters.AddWithValue("@p_name", Mname.Text.ToString());// textbox.text - 문자열이 아닐수 있음
            cmd.Parameters.AddWithValue("@p_tel", Mtel.Text.ToString());// textbox.text - 문자열이 아닐수 있음

            try
            {
                DataSet nDataSet = new DataSet(); // 데이타 부서정보, 여러 정보들 하나의 객체 x 그룹으로 볼수있다는것!
                // 개념: 엑셀 시트 123 -> 데이타 셋
                // c#.net 데이타 호출 -> 데이타 셋 (넘겨받는건 무조건 set) -> 보이는건 table로 보인다 그러므로 불러오는건 set 
                SqlDataAdapter nSqlDataAdapter = new SqlDataAdapter(cmd); // adapter 통해 
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

        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        string grid1_userno; // userno 담을 객체
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0 && gridView1.FocusedRowHandle > -1) // gridView1.FocusedRowHandle -> 중요!!!!
                {
                  
                    Mname.Text = gridView1.GetFocusedRowCellValue(userName).ToString(); // gridview에서 설정한 colums -> name 으로 쓴다,
                    Mtel.Text = gridView1.GetFocusedRowCellValue(userPhone).ToString(); // 회원명
                    grid1_userno = gridView1.GetFocusedRowCellValue(userNo).ToString();
                    //gridView1.GetFocusedRowCellValue(userGrade).ToString();

                    
                }
                else
                {
                    Mname.Text = "";
                    Mtel.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
/// <summary>
/// ////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e) // 도서검색
        {


            button5.Enabled = true;
            bool bwork1 = false;
            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql_connection; // db와 연결

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "dbo.sp_book_borrow";

            cmd.Parameters.AddWithValue("@p_div", "BRS");

            //cmd.Parameters.AddWithValue("@message", "member select");

            cmd.Parameters.AddWithValue("@p_bk_name", b_name.Text.ToString());// textbox.text - 문자열이 아닐수 있음
            cmd.Parameters.AddWithValue("@p_bk_publ_date", b_year.Text.ToString());// textbox.text - 문자열이 아닐수 있음
            cmd.Parameters.AddWithValue("@p_bk_publ_nm", b_publ.Text.ToString());
           // MessageBox.Show("search name= " + Mname.Text.ToString() + "search tel = " + Mtel.Text.ToString());

            try
            {
                DataSet nDataSet = new DataSet(); // 데이타 부서정보, 여러 정보들 하나의 객체 x 그룹으로 볼수있다는것!
                // 개념: 엑셀 시트 123 -> 데이타 셋
                // c#.net 데이타 호출 -> 데이타 셋 (넘겨받는건 무조건 set) -> 보이는건 table로 보인다 그러므로 불러오는건 set 
                SqlDataAdapter nSqlDataAdapter = new SqlDataAdapter(cmd); // adapter 통해 
                nSqlDataAdapter.Fill(nDataSet);
                gridControl3.DataSource = nDataSet.Tables[0]; // gridcontrol

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

        }

        string grid3_bookcode; // grid3_bookcode 담을 객체

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) //도서정보 데이터
        {
            try
            {
                if (gridView3.RowCount > 0 && gridView3.FocusedRowHandle > -1) // gridView1.FocusedRowHandle -> 중요!!!!
                {

                    b_name.Text = gridView3.GetFocusedRowCellValue(bookName).ToString(); // gridview에서 설정한 colums -> name 으로 쓴다,
                    b_year.Text = gridView3.GetFocusedRowCellValue(bookYear).ToString(); // 회원명
                    b_publ.Text = gridView3.GetFocusedRowCellValue(bookPublishing).ToString();
                    grid3_bookcode = gridView3.GetFocusedRowCellValue(bookCode).ToString();


                }
                else
                {
                    Mname.Text = "";
                    Mtel.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            //MessageBox.Show("book_publishing = " + grid3_bookcode);
        }

        string borrow_no; // 대여pk 담을 객체

        private void button6_Click(object sender, EventArgs e) // 대여 반납 등록
        {

            //button5.Enabled = true;
            bool bwork1 = false;
            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql_connection; // db와 연결

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "dbo.sp_book_borrow";

            cmd.Parameters.AddWithValue("@p_div", "BRC");

            cmd.Parameters.Add("@p_message", SqlDbType.NVarChar, 2000);
            cmd.Parameters["@p_message"].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            String p_message = cmd.Parameters["@p_message"].Value.ToString();
          //  cmd.Parameters.AddWithValue("@bk_name", b_name.Text.ToString());// textbox.text - 문자열이 아닐수 있음

            insertBorrow(); // 대여 입력
            // 대여일자 확인
            BorrowSearch();           

        }

        private void BorrowSearch()
        {

            button5.Enabled = true;
            bool bwork1 = false;
            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql_connection; // db와 연결

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "dbo.sp_book_borrow";

            cmd.Parameters.AddWithValue("@p_div", "BS");
            
            cmd.Parameters.AddWithValue("@p_borrowdate", borrow_date.Text.ToString());
            
            //cmd.Parameters.AddWithValue("@userno", gridView1.GetFocusedRowCellValue(userNo).ToString());

            try
            {
                DataSet nDataSet = new DataSet(); // 데이타 부서정보, 여러 정보들 하나의 객체 x 그룹으로 볼수있다는것!
                // 개념: 엑셀 시트 123 -> 데이타 셋
                // c#.net 데이타 호출 -> 데이타 셋 (넘겨받는건 무조건 set) -> 보이는건 table로 보인다 그러므로 불러오는건 set 
                SqlDataAdapter nSqlDataAdapter = new SqlDataAdapter(cmd); // adapter 통해 
                nSqlDataAdapter.Fill(nDataSet);
                gridControl2.DataSource = nDataSet.Tables[0]; // gridcontrol

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
        }

        private void insertBorrow()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql_connection; // db와 연결

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "dbo.sp_book_borrow";

            //cmd.Parameters.AddWithValue("@message", "member insert확인");

            cmd.Parameters.AddWithValue("@p_div", "BRI");

            //cmd.Parameters.AddWithValue("@borrowno", borrow_no); // textbox.text.tostring - 사용하면 텍스트 상자에서 텍스트를 가져 와서 해당 텍스트 유형으로 변환합니다.
            cmd.Parameters.AddWithValue("@p_member_no", grid1_userno);// textbox.text - 문자열이 아닐수 있음
            cmd.Parameters.AddWithValue("@p_isbn", grid3_bookcode);// textbox.text - 문자열이 아닐수 있음
            cmd.Parameters.AddWithValue("@p_returndate", DateTime.Now.AddDays(7.0));
            cmd.Parameters.AddWithValue("@p_borrowdate", DateTime.Now.ToLocalTime().Date);
            cmd.Parameters.AddWithValue("@p_borrowok", "Y");

           int result  = cmd.ExecuteNonQuery();

           /*if (result > 0)
           {

               MessageBox.Show("성공");
           }
           else {

               MessageBox.Show("실패");
           }*/

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) //대여/반납목록 grid
        {
            try
            {
                if (gridView2.RowCount > 0 && gridView2.FocusedRowHandle > -1) // gridView1.FocusedRowHandle -> 중요!!!!
                {

                    gridView2.GetFocusedRowCellValue(colborrowNo).ToString(); // gridview에서 설정한 colums -> name 으로 쓴다,
                    gridView2.GetFocusedRowCellValue(coluserNo1).ToString(); // 회원명
                    gridView2.GetFocusedRowCellValue(colbookCode1).ToString(); // 회원명
                    gridView2.GetFocusedRowCellValue(colreturnDate).ToString();
                    gridView2.GetFocusedRowCellValue(colborrowDate).ToString();
                    gridView2.GetFocusedRowCellValue(colborrowOk).ToString();

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e) // 수정
        {
            bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!


            MessageBox.Show("update로 확인버튼으로 들어와");

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql_connection; // db와 연결

            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "dbo.sp_book_borrow";

            //sqlcmd.Parameters.AddWithValue("@message", " update");

            sqlcmd.Parameters.AddWithValue("@p_div", "RU");

            sqlcmd.Parameters.AddWithValue("@p_borrowdate", borrow_date.Text.ToString());
            sqlcmd.Parameters.AddWithValue("@p_borrow_no", gridView2.GetFocusedRowCellValue(colborrowNo).ToString());
            //sqlcmd.Parameters.AddWithValue("@userno", gridView2.GetFocusedRowCellValue(coluserNo1).ToString());

            sqlcmd.ExecuteNonQuery();


            string borrowDate= borrow_date.Text.ToString();

            //gridView2.SetRowCellValue(gridView2.FocusedRowHandle, colborrowDate, Convert.ToDateTime(borrowDate));

            borrowdate_Search("1800");
            
        }

        private void borrowdate_Search(String p_borrowdateB)
        {
            bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql_connection; // db와 연결

            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "dbo.sp_book_borrow";

            //sqlcmd.Parameters.AddWithValue("@message", "book_management select");

            sqlcmd.Parameters.AddWithValue("@p_div", "RS"); //  cmd.Parameters.Add()를 사용한다면 데이터의 유형 및 길이를 지정하여 사용자 입력을 제한 받을수있다,
                                                            //예) .Parameters.Add("@name",SqlDbType.VarChar,30).Value=varName;

            String p_borrowdate = "";

            if (p_borrowdateB.Equals("1800"))
                p_borrowdate = p_borrowdateB;
            else
                p_borrowdate = borrow_date.Text.ToString();

            sqlcmd.Parameters.AddWithValue("@p_borrowdate", p_borrowdate);

            try
            {
                DataSet nDataSet = new DataSet(); // 데이타 부서정보, 여러 정보들 하나의 객체 x 그룹으로 볼수있다는것!
                // 개념: 엑셀 시트 123 -> 데이타 셋
                // c#.net 데이타 호출 -> 데이타 셋 (넘겨받는건 무조건 set) -> 보이는건 table로 보인다 그러므로 불러오는건 set 
                SqlDataAdapter nSqlDataAdapter = new SqlDataAdapter(sqlcmd); // adapter 통해 
                nSqlDataAdapter.Fill(nDataSet);
                gridControl2.DataSource = nDataSet.Tables[0]; // gridcontrol

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
        }

      

        private void button5_Click(object sender, EventArgs e) // 반납
        {

            search2();
            
//            bool bwork1 = false;

//            fn_dbConnection(ref bwork1);
//            if (!bwork1)
//                return; // false이므로 db연결이 되지 않았다는 것!!

//            SqlCommand sqlcmd = new SqlCommand();

//            sqlcmd.Connection = sql_connection; // db와 연결

//            sqlcmd.CommandType = CommandType.StoredProcedure;

//            sqlcmd.CommandText = "dbo.sp_book_borrow";

            //sqlcmd.Parameters.AddWithValue("@message", "book_management select");

//            sqlcmd.Parameters.AddWithValue("@p_div", "RES"); // 먼저 조회(조인)

//            sqlcmd.Parameters.AddWithValue("@p_name", namee.Text.ToString());
//            sqlcmd.Parameters.AddWithValue("@p_tel", handphonee.Text.ToString());


//            try
//            {
//                DataSet nDataSet = new DataSet(); // 데이타 부서정보, 여러 정보들 하나의 객체 x 그룹으로 볼수있다는것!
                // 개념: 엑셀 시트 123 -> 데이타 셋
                // c#.net 데이타 호출 -> 데이타 셋 (넘겨받는건 무조건 set) -> 보이는건 table로 보인다 그러므로 불러오는건 set 
//                SqlDataAdapter nSqlDataAdapter = new SqlDataAdapter(sqlcmd); // adapter 통해 
//                nSqlDataAdapter.Fill(nDataSet);
//                gridControl4.DataSource = nDataSet.Tables[0]; // gridcontrol

//           }
//            catch (SqlException ex)
//            {
//                string sreturnmessage = "데이터베이스 오류" + ex.Message.ToString();
//                MessageBox.Show(sreturnmessage);
//            }
//            finally
//            {
//                sql_connection.Close();
//            }

            ///////////////////////////////////////////////////////////////

         //   updatereturn();

           
        }

        //private void updatereturn()
        //{
        //    bool bwork1 = false;

        //    fn_dbConnection(ref bwork1);
        //    if (!bwork1)
        //        return; // false이므로 db연결이 되지 않았다는 것!!

        //    SqlCommand sqlcmd = new SqlCommand();

        //    sqlcmd.Connection = sql_connection; // db와 연결

        //    sqlcmd.CommandType = CommandType.StoredProcedure;

        //    sqlcmd.CommandText = "dbo.sp_book_borrow_ykh";

        //    sqlcmd.Parameters.AddWithValue("@message", "book_management select");

  
        //    sqlcmd.Parameters.AddWithValue("@div", "Uuu"); //  cmd.Parameters.Add()를 사용한다면 데이터의 유형 및 길이를 지정하여 사용자 입력을 제한 받을수있다,
        //    //예) .Parameters.Add("@name",SqlDbType.VarChar,30).Value=varName;


        //    sqlcmd.Parameters.AddWithValue("@returndate", gridView4.GetFocusedRowCellValue(returndatee).ToString());
        //    // sqlcmd.Parameters.AddWithValue("@borrowno", gridView4.GetFocusedRowCellValue(returndatee).ToString());

        //    try
        //    {
        //        DataSet nDataSet = new DataSet(); // 데이타 부서정보, 여러 정보들 하나의 객체 x 그룹으로 볼수있다는것!
        //        // 개념: 엑셀 시트 123 -> 데이타 셋
        //        // c#.net 데이타 호출 -> 데이타 셋 (넘겨받는건 무조건 set) -> 보이는건 table로 보인다 그러므로 불러오는건 set 
        //        SqlDataAdapter nSqlDataAdapter = new SqlDataAdapter(sqlcmd); // adapter 통해 
        //        nSqlDataAdapter.Fill(nDataSet);
        //        gridControl4.DataSource = nDataSet.Tables[0]; // gridcontrol

        //    }
        //    catch (SqlException ex)
        //    {
        //        string sreturnmessage = "데이터베이스 오류" + ex.Message.ToString();
        //        MessageBox.Show(sreturnmessage);
        //    }
        //    finally
        //    {
        //        sql_connection.Close();
        //    }

        //}

        private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            try
            {
                if (gridView4.RowCount > 0 && gridView4.FocusedRowHandle > -1) // gridView1.FocusedRowHandle -> 중요!!!!
                {

                    gridView4.GetFocusedRowCellValue(colnamee).ToString(); // gridview에서 설정한 colums -> name 으로 쓴다,
                    gridView4.GetFocusedRowCellValue(coltell).ToString(); // 회원명
                    gridView4.GetFocusedRowCellValue(booknamee).ToString();
                    gridView4.GetFocusedRowCellValue(borrowdatee).ToString();
                     gridView4.GetFocusedRowCellValue(returndatee).ToString();
                  

                }
                else
                {
                    //Mname.Text = "";
                    //Mtel.Text = "";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }

        }

        private void save_Click(object sender, EventArgs e)
        {

            bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql_connection; // db와 연결

            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "dbo.sp_book_borrow";

            //sqlcmd.Parameters.AddWithValue("@message", "book_management select");


            sqlcmd.Parameters.AddWithValue("@p_div", "RESERVE"); //  cmd.Parameters.Add()를 사용한다면 데이터의 유형 및 길이를 지정하여 사용자 입력을 제한 받을수있다,
            //예) .Parameters.Add("@name",SqlDbType.VarChar,30).Value=varName;


            /*sqlcmd.Parameters.AddWithValue("@p_returndate", Convert.ToDateTime(gridView4.GetFocusedRowCellValue(returndatee).ToString()));
            // sqlcmd.Parameters.AddWithValue("@borrowno", gridView4.GetFocusedRowCellValue(returndatee).ToString());

            sqlcmd.Parameters.AddWithValue("@p_borrowok", "N");
            sqlcmd.Parameters.AddWithValue("@p_borrow_no", gridView4.GetFocusedRowCellValue(borrownoo).ToString());
            */
            int RowNum = gridView4.RowCount;
            String returndate = "";
            String borrowokk = "";

            for (int i = 0;i<RowNum ;i++)
            {
                returndate = (string)gridView4.GetRowCellValue(i, "returndatee");
                borrowokk = "N";

                sqlcmd.Parameters.AddWithValue("@p_returndate", returndate);
                sqlcmd.Parameters.AddWithValue("@p_borrowok", borrowokk);

                if (i == RowNum - 1)
                {
                    MessageBox.Show("수정되었습니다");
                    search2();
                }
                sqlcmd.ExecuteNonQuery();
            }

           /* if (sqlcmd.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("수정되었습니다");
                search2();

            }
            else
            {
                MessageBox.Show("수정되지 않았습니다.");
               
            }*/

        }

        private void search2()
        {

            bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql_connection; // db와 연결

            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "dbo.sp_book_borrow";

            //sqlcmd.Parameters.AddWithValue("@message", "book_management select");

            sqlcmd.Parameters.AddWithValue("@p_div", "RES"); // 먼저 조회(조인)

            sqlcmd.Parameters.AddWithValue("@p_name", namee.Text.ToString());
            sqlcmd.Parameters.AddWithValue("@p_tel", handphonee.Text.ToString());


            try
            {
                DataSet nDataSet = new DataSet(); // 데이타 부서정보, 여러 정보들 하나의 객체 x 그룹으로 볼수있다는것!
                // 개념: 엑셀 시트 123 -> 데이타 셋
                // c#.net 데이타 호출 -> 데이타 셋 (넘겨받는건 무조건 set) -> 보이는건 table로 보인다 그러므로 불러오는건 set 
                SqlDataAdapter nSqlDataAdapter = new SqlDataAdapter(sqlcmd); // adapter 통해 
                nSqlDataAdapter.Fill(nDataSet);
                gridControl4.DataSource = nDataSet.Tables[0]; // gridcontrol

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

        }

        private void select_Click(object sender, EventArgs e)
        {
            String p_borrowdate = borrow_date.Text.ToString();

            borrowdate_Search(p_borrowdate);

            /* bool bwork1 = false;

            fn_dbConnection(ref bwork1);
            if (!bwork1)
                return; // false이므로 db연결이 되지 않았다는 것!!

            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sql_connection; // db와 연결

            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.CommandText = "dbo.sp_book_borrow";

            //sqlcmd.Parameters.AddWithValue("@message", "book_management select");

            sqlcmd.Parameters.AddWithValue("@p_div", "RS"); //  cmd.Parameters.Add()를 사용한다면 데이터의 유형 및 길이를 지정하여 사용자 입력을 제한 받을수있다,
                                                            //예) .Parameters.Add("@name",SqlDbType.VarChar,30).Value=varName;

            String p_borrowdate = "";

            if (p_borrowdateB.Equals("1800"))
                p_borrowdate = p_borrowdateB;
            else
                p_borrowdate = borrow_date.Text.ToString();

            sqlcmd.Parameters.AddWithValue("@p_borrowdate", p_borrowdate);

            try
            {
                DataSet nDataSet = new DataSet(); // 데이타 부서정보, 여러 정보들 하나의 객체 x 그룹으로 볼수있다는것!
                // 개념: 엑셀 시트 123 -> 데이타 셋
                // c#.net 데이타 호출 -> 데이타 셋 (넘겨받는건 무조건 set) -> 보이는건 table로 보인다 그러므로 불러오는건 set 
                SqlDataAdapter nSqlDataAdapter = new SqlDataAdapter(sqlcmd); // adapter 통해 
                nSqlDataAdapter.Fill(nDataSet);
                gridControl2.DataSource = nDataSet.Tables[0]; // gridcontrol

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
           */
        }

    }
}
