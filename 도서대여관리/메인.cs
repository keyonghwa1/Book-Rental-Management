using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 도서대여관리
{
    public partial class 메인 : Form
    {
        public 메인()
        {
            InitializeComponent();
        }


        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             foreach(Form form in Application.OpenForms){
                
                 
                if(form.Name == "bookform" ){

                    form.Activate(); 

                    return;

                }
             }

            bookform bookForm1 = new bookform();

            bookForm1.MdiParent = this; // this -> 메인
            bookForm1.Show();
                                                 
        }

        private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {

                if (form.Name == "memberform")
                {
                    form.Activate();
                    return;

                }

            }
            memberform memberForm1 = new memberform();
            memberForm1.MdiParent = this; // this -> 메인
            memberForm1.Show();
        }




    }
}
