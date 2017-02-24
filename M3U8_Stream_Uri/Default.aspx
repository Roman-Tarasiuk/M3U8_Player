<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Get stream m3u8/mp4</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="align1">
                <asp:Label ID="Label1" runat="server" Text="Channel address:"></asp:Label>
            </div>
            <div class="align2">
                <asp:TextBox ID="txtPath" runat="server" Width="550px" CssClass="textBox"></asp:TextBox>
            </div>
            <br />
            <div class="align1">
                <asp:Button ID="btnGetM3U8" runat="server" Text="Get M3U8" OnClick="btnGetM3U8_Click" />
            </div>
            <div class="align2">
                <asp:TextBox ID="txtM3uPath" runat="server" Width="550px" CssClass="textBox"></asp:TextBox>
            </div>
        </div>
    </form>
</body>
</html>
