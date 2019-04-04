using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        webservice.WebService1 cal = new webservice.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btnSub_Click(object sender, EventArgs e)
        {
           Label1.Text = cal.Add(Convert.ToInt16(texta.Text), Convert.ToInt16(textb.Text)).ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
           Label1.Text = cal.Subtract(Convert.ToInt16(texta.Text), Convert.ToInt16(textb.Text)).ToString();
            
        }

        protected void btnMult_Click(object sender, EventArgs e)
        {

            Label1.Text = cal.Multiply(Convert.ToInt16(texta.Text), Convert.ToInt16(textb.Text)).ToString();
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
          
            Label1.Text = cal.Divide(Convert.ToInt16(texta.Text), Convert.ToInt16(textb.Text)).ToString();
        }
    }
}