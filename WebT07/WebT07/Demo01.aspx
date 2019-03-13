<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo01.aspx.cs" Inherits="WebT07.Demo01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" RepeatColumns="4" DataKeyField="ProductID" OnItemCommand="DataList1_ItemCommand">
              <HeaderTemplate>
                  <table>
                
            </HeaderTemplate>
           
             <ItemTemplate>
              <dl>
                  <dt> <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/ProductPic/"+ Eval("ProductPic") %>' /> </dt>
                  <dd><%# Eval("ProductName") %></dd>
                  <dd>￥<%# Eval("ProductPrice") %></dd> 
                 <dd><asp:Button ID="Button1" runat="server" Text="删除" OnClientClick='return  confirm("你确认删除吗？")' CommandName="Del" /></dd>
                 
              </dl>
            </ItemTemplate>
           <FooterTemplate>
               </table>
            </FooterTemplate>
           
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
