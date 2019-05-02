using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Sql;

namespace TropicalServer.UI
{
    /// <summary>
    /// Summary description for LoginGenericHandler
    /// </summary>
    public class LoginGenericHandler : IHttpHandler
    {
        SqlConnection zywConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["zywconstring"].ConnectionString);
        public void ProcessRequest(HttpContext context1)
        {
            context1.Response.ContentType = "text/plain";
            DataLoad(context1);
        }
        private void DataLoad(HttpContext context2)
        {
            // connect to the database and retrieve the data
            string sql = "select * from tblUserLogin";
            zywConnection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, zywConnection);
            adapter.Fill(ds, "tab1");
            DataRow[] drs = ds.Tables["tab1"].Select("UserID='admin'");
            // close it as soon as possible, take too much source
            zywConnection.Close();
            //-------------------------------------------------------------------
            string adminReceive = drs[0]["UserID"].ToString();
            string passwdReceive = drs[0]["Password"].ToString();

            // get the admin & pwd from the client using Request
            string name = context2.Request.Form["LoginID"];
            string pwd = context2.Request.Form["Password"];

            string _vs = context2.Request.Form["viewstate"];
            bool ispostback = ! string.IsNullOrEmpty(_vs);

            // check if it is the first time to load the page
            if (ispostback)
            {
                if ((name == adminReceive) && (pwd == passwdReceive))
                {
                     context2.Response.Redirect("Products.aspx");
                }
               else
               {
                    context2.Response.Redirect("LoginPageNew.aspx");
               }
            }
            else
            {
                context2.Response.Redirect("LoginPageNew.aspx");
            }

        
            // redirect to the Products.aspx page
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}