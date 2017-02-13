using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Week6
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public SqlConnection Connect()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Week6CS"].ConnectionString);
        }

        public SqlCommand CreateSqlCommand(string qry, SqlConnection conn)
        {
            return new SqlCommand(qry, conn);
        }

        public DataTable RunQuery(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            gvDisplay.DataSource = RunQuery(CreateSqlCommand("SELECT * FROM Employees", Connect()));
            gvDisplay.DataBind();

            SqlConnection conn = Connect();

            
            SqlCommand cmd = CreateSqlCommand("SELECT * FROM Employees", conn);
            
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                if (rdr["Department"].ToString().Equals("Accounting"))
                {
                    Response.Write(rdr["LastName"].ToString() + ", " + rdr["FirstName"] + "<br/>");
                }
            }
            conn.Close();
        }

        pub
    }
}