using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient; // need dll
using System.Data;
namespace Week8
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("servver = csmadison.dhcp.bsu.edu; uid = vjtanksale; pwd=changeme; database=cs320;");
            string qry = "SELECT * FROM STUDENTS";
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                Response.Write(rdr["LastName"].ToString() + "<br/>");
            }
            rdr.Close();
            conn.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

        }
    }
}

//csmadison.dhcp.bsu.edu:3306
//vjtanksale
//changeme
//cs320 dbname
//get bsu vpn on rig bsu.edu/vpn