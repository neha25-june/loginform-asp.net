<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LoginFormtest.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registration Panel</h1><br />
            <asp:Label runat="server" ID="lblErrorMsg"></asp:Label><br />
            <asp:Label ID="lblfirstname" runat="server">First Name</asp:Label>
            <br />
            <asp:TextBox ID="txtname" runat="server" Placeholder="Enter your firstname"></asp:TextBox> 
            <br />
            <asp:Label ID="lblLastname" runat="server">Last Name</asp:Label>
            <br />
            <asp:TextBox ID="txtlastname" runat="server" Placeholder="Enter your lastname"></asp:TextBox>
            <br />
            <asp:label ID="lblemail" runat="server">Email ID</asp:label>
            <br />
            <asp:textbox ID="txtemail" runat="server" Placeholder="Enter your email"></asp:textbox>
            <br />
            <asp:Label ID="lblpassword" runat="server">Password</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtpassword" Placeholder="Enter your password" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button runat="server" Text="Submit" ID="btnsubmit" OnClick="btnsubmit_Click"/>
        </div>
    </form>
</body>
</html>
