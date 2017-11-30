<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            margin-left: 0px;
        }
        .style3
        {
            text-align: center;
            margin-left: 80px;
        }
        .style4
        {
            text-align: center;
        }
        .style5
        {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="style1">
    <div class="style3">
    
        <strong><span class="style5">&nbsp; </span>
        <br class="style5" />
        <span class="style5">Welcome</span></strong><br />
        <br />
        <asp:Label ID="ID" runat="server" Text="ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="IDTextBox" runat="server" Width="128px"></asp:TextBox>
    
    </div>
    <div class="style4">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Pass" runat="server" Text="Password"></asp:Label>
&nbsp;
        <asp:TextBox ID="PassTextBox" runat="server"></asp:TextBox>
        <br class="style1" />
        <br class="style1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
    </div>
    </form>
</body>
</html>
