using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            //ลูป while
            /*
           int i = 1;
            int i2 = 1;
            while (i==1)
            {
                Response.Write(txt_number.Text + "*"+ i2 + "=" + (int.Parse(txt_number.Text) * i2)+"<br>");
                if (i2 == 12)
                {
                    break;
                }
                i2++;
            }*/


            //ลูป 
            /*for (int i = 1; i <= 12; i++)
            {
                Response.Write(txt_number.Text + "*" + i + "=" + (int.Parse(txt_number.Text) * i)+"<br>");
            }
            */


            //ทดสอบตัวแปล
            /*int x5 = 10;
            int y = 15;
            Double z = 5.3;
            string a = "พีระพงศ์";
            Double c = (x5+0.00) / z;**/

            //ทดสอบlogin
            
            if (txt_name.Text == "เฟรม" )
            {
                if (txt_password.Text == "1234")
                {
                    Response.Write("สวัสดีเฟรม น่ารักนะเรา");
                }
                else
                {
                    Response.Write("เดาสิ่นะ...รหัสอ่ะ :P");
                }
            }
            else if (txt_name.Text == "ฟ้า")
            {
                if (txt_password.Text == "4321")
                {
                    Response.Write("หว่ายยยย เดาถูกหวะ !!!!!!!");
                }
                else
                {
                    Response.Write("มั่วแล้ววววววว");
                }
            }
            else
            {
                Response.Write("มึงมั่วหนักแล้ว");
            }
                
               
            
        }
    }
}

 
