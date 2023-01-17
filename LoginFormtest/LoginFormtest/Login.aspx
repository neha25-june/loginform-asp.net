<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginFormtest.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:label runat="server" ID="lblErrorMsg"></asp:label>
            <asp:Label runat="server" Text="Email ID" ID="lblEmail"></asp:Label>
            <asp:Textbox runat="server" Placeholder="Enter your email id" ID="txtEmail"></asp:Textbox>
            <asp:Label runat="server" Text="Password" ID="lblPassword"></asp:Label>
            <asp:TextBox runat="server" Placeholder="Enter your password" TextMode="Password" ID="txtPassword"></asp:TextBox>
            <asp:Button runat="server" Text="Login" OnClick="Login_Click"/>
        </div>
    </form>
</body>
</html>
