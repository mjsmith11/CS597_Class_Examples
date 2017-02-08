using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;


namespace Week5
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string plainTextPassword = tbxPassword.Text;
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainTextPassword));
            sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainTextPassword));
            byte[] result = sha1.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i<result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2")); //x2 is for 2 hex because we are sending in a byte at a time
            }
            Response.Write(strBuilder.ToString());
        }
    }
}