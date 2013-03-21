<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label>Server:</label>
        <br />
        <asp:TextBox ID="server" runat="server" />
        <br />
        <label>Shared secret:</label>
        <br />
        <asp:TextBox ID="secret" runat="server" />
        <br />
        <br />
        <label>Login:</label>
        <br />
        <asp:TextBox ID="login" runat="server" />
        <br />
        <label>Passcode:</label>
        <br />
        <asp:TextBox ID="password" runat="server" />
        <br />
        <asp:Button ID="send" runat="server" Text="Login" />
        <asp:Label ID="info" runat="server" />
    </div>
    </form>
</body>
</html>
