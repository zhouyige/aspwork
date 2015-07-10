<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录</title>
    <link href="css/style.css" type="text/css" rel="stylesheet" />
    <script src="js/Controls.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 33px;
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
        <div style="height: 366px">
            <TABLE class="tbl" id="Table2" align="center" bgColor="#FFFFFF" style="margin-top: 10%; margin-left: 35%;">
							<TR>
								<TD align="left" style="background-color: #858585;">
                                  <h2 style="height: 20px; color: #FFFFFF; margin-top: 0px; margin-bottom: 0px;">用户登录</h2> </TD>
							</TR>
                            <TR>
                                <TD align="left">&nbsp;用户名</TD>
                            </TR>
							<TR>
								<TD align="center"><asp:textbox id="txtName" runat="server" 
                                        maxLength="12" Width="274px" Height="24px"></asp:textbox></TD>
							</TR>
                            <TR>
                                <TD align="left">&nbsp;密码</TD>
                            </TR>
							<TR>
								
								<TD align="center"><asp:textbox id="txtPwd" runat="server" 
                                        maxLength="12" Width="272px" TextMode="Password" Height="24px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD align="center">
									<asp:button id="Button1" runat="server" CssClass="loginbutton" Text="登陆" BorderStyle="None" OnClick="Button1_Click"></asp:button>
								</TD>
							</TR>
						</TABLE>
            </div>
    </form>
</body>
</html>
