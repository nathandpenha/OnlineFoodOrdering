<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="WebApplication1.order" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;ItemID&nbsp;
        <asp:Label ID="itemidLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        Item&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="fooditemLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
       cost&nbsp;&nbsp;&nbsp;
        <asp:Label ID="priceLabel" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Quantity&nbsp;
        <asp:TextBox ID="quantityText" runat="server" AutoPostBack="True" 
            ontextchanged="quantityText_TextChanged">1</asp:TextBox>
        <br />
        <br />
        <br />
        TOTAL&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="totalLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="orderButton" runat="server" onclick="orderButton_Click" 
            Text="Order" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="notAvailLabel" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
