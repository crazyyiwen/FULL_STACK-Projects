using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TropicalServer.UI
{
    public partial class Products : System.Web.UI.Page
    {
        // configure the pzywConnection
        SqlConnection pzywConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["zywconstring"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            string caribbeanline = "select ItemID, ItemNumber, ItemDescription, ItemType from tblItem";
            BindData(caribbeanline);
            // name the button
            List<string> myList = new List<string>();
            myList.Add("Caribbean Line");
            myList.Add("mexican line");
            myList.Add("central american line");
            myList.Add("paisano line");
            myList.Add("domestic items");
            myList.Add("meats");
            myList.Add("deserts");
            myList.Add("others");
            myList.Add("drinkable yogurts");
            myList.Add("arepas");
            myList.Add("per pound items");
            Repeater1.DataSource = myList;
            Repeater1.DataBind();

        }
        // button event

        protected void BindData(string sqlOperation)
        {
            try
            {
                // use par replace in case the dangers
                SqlCommand cmd = new SqlCommand(sqlOperation, pzywConnection);
                cmd.CommandType = CommandType.Text;
                pzywConnection.Open();
                // get the data from database
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "tbl");
                GridView1.DataSource = ds.Tables["tbl"];
                GridView1.DataBind();
                pzywConnection.Close();
            }
            catch
            {

            }
        }

        protected void GridView1_SelectedIndexChanged2(object sender, EventArgs e)
        {

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string col = e.CommandName.ToString();
            
            switch (col)
            {
                case "Caribbean Line":
                    // Do some stuff when the Edit button is clicked.
                    ArrayList caribbeanline = new ArrayList();
                    //caribbeanline.Add("IF OBJECT_ID('Caribbean_Line','P') IS NOT NULL DROP PROCEDURE Caribbean_Line go");
                    //caribbeanline.Add("CREATE PROCEDURE Caribbean_Line AS begin select ItemType as ITEM#, ItemDescription as ITEMDESCRIPTION, PrePrice as PRE_PRICE from (select * from tblItem left join tblItemType on tblItem.ItemType = tblItemType.ItemTypeNumber) A end; go");
                    //caribbeanline.Add("EXEC Caribbean_Line");
                    //string caribbeanline = "select UserID from tblUserLogin";
                    //BindData("IF OBJECT_ID('Caribbean_Line','P') IS NOT NULL DROP PROCEDURE Caribbean_Line go\n" +
                    //    "CREATE PROCEDURE Caribbean_Line AS begin select ItemType as ITEM#, ItemDescription as ITEMDESCRIPTION, PrePrice as PRE_PRICE from (select * from tblItem left join tblItemType on tblItem.ItemType = tblItemType.ItemTypeNumber) A end; go\n" +
                    //    "EXEC Caribbean_Line");
                    //foreach (var item in caribbeanline)
                    //{
                    //BindData(caribbeanline.ToString());
                    //}
                    BindData("select ItemType as ITEM#, ItemDescription as ITEMDESCRIPTION, PrePrice as PRE_PRICE from (select * from tblItem left join tblItemType on tblItem.ItemType = tblItemType.ItemTypeNumber) A where ItemTypeDescription='CARIBBEAN LINE' ");
                    break;
                case "mexican line":
                    // Do some stuff when the Edit button is clicked.

                    break;
                case "central american line":
                    // Do some stuff when the Edit button is clicked.
                    

                    break;
                case "paisano line":
                    // Do some stuff when the Edit button is clicked.

                    break;
                case "domestic items":
                    // Do some stuff when the Edit button is clicked.

                    break;
                case "meats":
                    // Do some stuff when the Edit button is clicked.

                    break;
                case "deserts":
                    // Do some stuff when the Edit button is clicked.

                    break;
                case "others":
                    // Do some stuff when the Edit button is clicked.

                    break;
                case "drinkable yogurts":
                    // Do some stuff when the Edit button is clicked.

                    break;
                case "arepas":
                    // Do some stuff when the Edit button is clicked.

                    break;
                case "per pound items":
                    // Do some stuff when the Edit button is clicked.

                    break;
                default:
                    break;
            }
        }
    }
}