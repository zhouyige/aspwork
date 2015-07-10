<%@ Page Language="C#" AutoEventWireup="true" CodeFile="booksearch.aspx.cs" Inherits="booksearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>图书馆借阅管理系统</title>
    <link href="css/style.css" type="text/css" rel="stylesheet" />
    <link href="css/select.css" type="text/css" rel="stylesheet" />
    <link href="css/net.css" type="text/css" rel="stylesheet" />
    <script src="js/Controls.js"></script>
    <style type="text/css">
        .pppppp2 {
            margin-left: 17%;
            z-index:4;
        }
        .pppppp1 {
            margin-left: 30%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="logoBG">
            <div style="margin-left: 28%; height: auto; left: auto;" onclick="window.location.href= 'index.aspx';return false">
                <asp:Image ID="Image1" runat="server" Height="105px" style="margin-left: 0px; " ImageUrl="~/images/logo.png" />
            </div>
        </div>
    <div style="height: 712px">
        <div class="pppppp1">
            <br />
            <br />
            <asp:Label ID="Label" runat="server" CssClass="Label" Text="检索到"></asp:Label>
            <asp:Label ID="Label2" runat="server" CssClass="Label2" Width="25px" ForeColor="Red"></asp:Label>
            <asp:Label ID="Label3" runat="server" CssClass="Label3" Text="条"></asp:Label>
            <asp:Label ID="Label4" runat="server" CssClass="Label4" Width="40px" ForeColor="Red"></asp:Label>
            <asp:Label ID="Label5" runat="server" CssClass="Label5" Text="的结果"></asp:Label>
            <br />
            <br />
        </div>
        <div class="pppppp2">
            <asp:DropDownList ID="SearchingSelected" runat="server" Width="110px" AutoPostBack="True" Height="16px">
                <asp:ListItem Selected="True">书名</asp:ListItem>
                <asp:ListItem>作者</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="SearchName" runat="server" Width="420px" CssClass="SearchName"></asp:TextBox>
            <asp:Button ID="SearchingButton" runat="server" BackColor="#3333FF" 
            BorderColor="#666666" ForeColor="White" Text="搜索" onclick="SearchingButton_Click" CssClass="SearchingButton" Width="80px" />
            <br />
            <br />
            <br />
        </div>
        <div class="bookdetail">

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="300px" S="GridView1_RowCommand" OnRowCreated="GridView1_RowCreated" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="" Text='<%# Eval("TestData") %>'></asp:LinkButton>
                            <asp:Button ID="Button1" runat="server" BackColor="#33CCFF" BorderColor="#3399FF" BorderStyle="None" CssClass="bottondiyue" Font-Names="微软雅黑" OnClick="Button1_Click1" Text="预定" />
                        </ItemTemplate>
                        <HeaderStyle BackColor="Gray" BorderColor="Gray" />
                        <ItemStyle BackColor="Gray" BorderColor="Silver" Font-Names="微软雅黑" Width="300px" Wrap="True" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </div>

    </form>
    </body>
</html>
