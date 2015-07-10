<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>图书馆借阅管理系统</title>
    <link href="css/style.css" type="text/css" rel="stylesheet" />
    <script src="js/Controls.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="logoBG">
            <div style="margin-left: 28%; height: auto; left: auto;" onclick="window.location.href= 'index.aspx';return false">
                <asp:Image ID="Image1" runat="server" Height="105px" style="margin-left: 0px; " ImageUrl="~/images/logo.png" />
            </div>
        </div>
        <div style="height:200px;">
            <div style="padding-top: 150px">
                <p style="margin: auto auto auto 29%">
                    <asp:TextBox ID="BookSearchTextBox" runat="server" OnTextChanged="BookSearchTextBox_TextChanged" style="margin-left: 0px" Height="30px" Width="373px"></asp:TextBox>
                    <asp:Button ID="BookSearchButton" runat="server" OnClick="BookSearchButton_Click" Text="图书检索" Height="36px" Width="100px" BackColor="#CCCCCC" BorderColor="#333333" BorderStyle="Ridge" Font-Names="华文琥珀" Font-Size="Large" />
                </p>
            </div>
        </div>
        <div style="height: 30px; margin-left: 45%;">
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server"  onmouseover="onmouseovered(this.id)" onmouseout="onmouseouted(this.id)" OnClick="LinkButton1_Click" ViewStateMode="Enabled" ForeColor="White">登录</asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" ViewStateMode="Enabled" ForeColor="Red">退出重登</asp:LinkButton>
        </div>
    </form>
    <asp:Image ID="Image2" runat="server" style="position:absolute; top:365px; right:2px; height: 177px; width: 340px;" ImageUrl="~/images/cloud-1.png" />
    <asp:Image ID="Image3" runat="server" style="position:absolute; top:300px;left:-200px; height: 298px; width: 619px;" ImageUrl="~/images/cloud-2.png" />
</body>
</html>
