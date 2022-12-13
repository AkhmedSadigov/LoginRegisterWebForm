<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginRegisterWebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<link href="login.css" rel="stylesheet" />
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1><br /><br />
            <asp:Label ID="Label3" CssClass="label" runat="server" Text="User Name" ></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="text" placeholder="Username" runat="server" Height="45px"></asp:TextBox><br /><br />
            <asp:Label ID="Label1" runat="server" CssClass="label" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" CssClass="text" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" CssClass="button" runat="server" Text="Login" OnClick="Button1_Click" /><br /><br />
            <asp:Label ID="Label2" CssClass="labellink" runat="server" Text="Haven't you any Account?"></asp:Label>
            <asp:LinkButton ID="LinkButton1" CssClass="link" runat="server" OnClick="LinkButton1_Click">Register Now</asp:LinkButton>
        </div>
    </form>
</body>
</html>
