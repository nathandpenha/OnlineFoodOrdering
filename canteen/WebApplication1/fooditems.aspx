<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fooditems.aspx.cs" Inherits="WebApplication1.fooditems" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="MenuBar">
	<asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    AutoGenerateColumns="false" OnSelectedIndexChanged = "OnSelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="item_id" HeaderText="Id" ItemStyle-Width="150" />
        <asp:BoundField DataField="item_name" HeaderText="Item" ItemStyle-Width="150" />
        <asp:BoundField DataField="price" HeaderText="Price" ItemStyle-Width="150" />
        
            <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="150" />
    </Columns>
</asp:GridView>
    </div>
    </form>
</body>
</html>
