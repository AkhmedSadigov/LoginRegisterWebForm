<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LoginRegisterWebForm.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="register.css" rel="stylesheet" />
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register</h1><br />
            <asp:Label ID="Label1" CssClass="label" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="text" placeholder="First Name" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" CssClass="label2" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="TextBox2" CssClass="text2" placeholder="Last Name" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label3" CssClass="label3" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="TextBox3" CssClass="text3" placeholder="Username" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox><br /><br />
            <asp:Label ID="Label4" CssClass="label4" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox4" CssClass="text4" placeholder="Email" runat="server" TextMode="Email"></asp:TextBox><br /><br />
            <asp:Label ID="Label5" CssClass="label5" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox5" CssClass="text5" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox><br /><br />
            <asp:Label ID="Label6" CssClass="label6" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="TextBox6" CssClass="text6" placeholder="Re Enter Password" runat="server" TextMode="Password"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" CssClass="button" runat="server" Text="Register" OnClick="Button1_Click" />
            <asp:Label ID="Label7" CssClass="labellink" runat="server" Text="You have already an Account!"></asp:Label>
            <asp:LinkButton ID="LinkButton1" CssClass="link" runat="server" OnClick="LinkButton1_Click">Back to Login </asp:LinkButton>
        </div>
    </form>
</body>
</html>
