<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication11.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="texta" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:TextBox ID="textb" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="btnSub_Click" Text="+" />
        <asp:Button ID="Button2" runat="server" onclick="btnAdd_Click" Text="-" />
        <asp:Button ID="Button3" runat="server" onclick="btnMult_Click" Text="*" />
        <asp:Button ID="Button4" runat="server" onclick="btnDivide_Click" Text="/" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
    
    </div>
    </form>
</body>
</html>
