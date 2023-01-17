<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoginFormtest.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Thank you visit our website :)</h1>
            <p>Pervious user's data</p>
            firstname : <%HttpContext.Current.Session["first_name"] %> <br />
            email : <%HttpContext.Current.Session["email"] %>
            <asp:HyperLink runat="server" ID="hyperlink1" NavigateUrl="~/Login.aspx">Logout</asp:HyperLink>
        </div>
    </form>
</body>
</html>
