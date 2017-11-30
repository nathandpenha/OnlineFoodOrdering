<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addmoney.aspx.cs" Inherits="WebApplication1.addmoney" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <p>
        Enter The PRN:<asp:TextBox ID="prnText" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="checkBalance" runat="server" onclick="checkBalance_Click" 
            Text="Check Balance" />
    </p>
    <p style="margin-left: 120px">
        <asp:Label ID="balanceLabel" runat="server"></asp:Label>
    </p>
    <p>
        Enter The Amount:<asp:TextBox ID="amountText" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="refillButton" runat="server" onclick="refillButton_Click" 
            Text="Refill Account" />
    </p>
    </form>
</body>
</html>
