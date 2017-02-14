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
            if (!IsPostBack)
            {
                SqlConnection conn = Connect();
                SqlCommand cmd = CreateSqlCommand("SELECT EmployeeId,LastName,FirstName FROM Employees", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(rdr["LastName"].ToString() + ", " + rdr["FirstName"].ToString(), rdr["EmployeeId"].ToString()));
                }
                rdr.Close();
                conn.Close();
            }
            DataTable results = RunQuery(CreateSqlCommand("SELECT * FROM Employees", Connect()));
            DataTable copyResults = results.Clone(); // copies only structure no data
            foreach(DataRow dr in results.Rows)
            {
                if(dr["Department"].ToString().Equals("Accounting"))
                {
                    copyResults.ImportRow(dr);
                }
            }
            gvDisplay.DataSource = copyResults;
            gvDisplay.DataBind();

            //SqlConnection conn = Connect();

            
            //SqlCommand cmd = CreateSqlCommand("SELECT * FROM Employees", conn);
            
            //SqlDataReader rdr = cmd.ExecuteReader();
            //while(rdr.Read())
            //{
            //    if (rdr["Department"].ToString().Equals("Accounting"))
            //    {
            //        Response.Write(rdr["LastName"].ToString() + ", " + rdr["FirstName"] + "<br/>");
            //    }
            //}
            //rdr.Close();
            //conn.Close();
        }

        public int UpdateSalary(int employeeId, float newSalary)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = CreateSqlCommand("Update Employees set Salary=@s where EmployeeId=@e", conn);
            cmd.Parameters.AddWithValue("@s",newSalary);
            cmd.Parameters.AddWithValue("@e", employeeId);
            conn.Open();
            int retVal = cmd.ExecuteNonQuery();
            conn.Close();
            return retVal;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!TextBox1.Text.Equals(""))
                UpdateSalary(Int32.Parse(DropDownList1.SelectedValue), float.Parse(TextBox1.Text));
            }
            catch(Exception ex)
            {
                //
            }
        }
    }
}