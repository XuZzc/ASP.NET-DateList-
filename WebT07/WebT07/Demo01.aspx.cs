using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace WebT07
{
    public partial class Demo01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DataList1.DataSource = ProductBLL.GetProductList();
                this.DataList1.DataBind();
                this.DropDownList1.DataSource = ProductBLL.GetProductListall();
                this.DropDownList1.DataTextField = "ClassName";
                this.DropDownList1.DataValueField = "ClassID";
                this.DropDownList1.DataBind();

            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //删除
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Del")
            {
                int pid = int.Parse(this.DataList1.DataKeys[e.Item.ItemIndex].ToString());

                if (ProductBLL.DeleteById(pid))
                {
                    Response.Redirect("/Demo01.aspx");
                }
                else
                {
                    Response.Write("<script>alert('删除失败！')</script>");
                }
            }

        }
        /// <summary>
        /// 联动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.DropDownList1.SelectedValue.ToString());
            this.DataList1.DataSource = ProductBLL.Select(id);
            this.DataList1.DataBind();



        }
    }
}