<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sysmanaLog.aspx.cs" Inherits="sysmanaLog" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>图书</title>
    <link href="css/style.css" type="text/css" rel="stylesheet" />
    <link href="css/select.css" type="text/css" rel="stylesheet" />
    <link href="css/net.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="logoBG">
            <div style="margin-left: 28%; height: auto; left: auto;" onclick="window.location.href= 'index.aspx';return false">
                <asp:Image ID="Image1" runat="server" Height="105px" style="margin-left: 0px; " ImageUrl="~/images/logo.png" />
            </div>
        </div>
        <div>
            
            <div class="leftside" style="width: 250px; height: 600px">
                <div class="leftplane">
                    <div id="u9" class="ax_表格" style="position: absolute; top: 13px; left: 10px">
                        <div id="u10" class="ax_单元格" style="cursor: pointer; text-align: center;">
                            <img id="u10_img" class="img" src="images/u10.png" tabindex="0">
                            <div id="u11" onclick="window.location.href= 'sysmanaAM.aspx';return false">
                            <p><span>账号管理</span></p>
                            </div>
                        </div>
                        <div id="u12" class="ax_单元格" style="cursor: pointer">
                            <img id="u12_img" class="img" src="images/u12.png">
                            <div id="u11" onclick="window.location.href= 'sysmanaLog.aspx';return false">
                            <p><span>日志管理</span></p>
                            </div>
                        </div>
                        <div id="u14" class="ax_单元格" style="cursor: pointer">
                            <img id="u14_img" class="img" src="images/u10.png">
                            <div id="u11" onclick="window.location.href= 'sysmanaDB.aspx';return false">
                                <p><span>数据库维护</span></p>
                            </div>
                        </div>
             
                    </div>
                </div>
            </div>
            <div class="rightside">
                 <div class="rightplane">
                     <asp:GridView ID="GridView1" runat="server" CssClass="pagetable1" AutoGenerateColumns="False">
                         <Columns>
                             <asp:BoundField DataField="Gid" HeaderText="日志编号">
                             <HeaderStyle Height="10px" Width="100px" Wrap="False" />
                             <ItemStyle Height="10px" Width="100px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="Userid" HeaderText="操作用户ID">
                             <HeaderStyle Height="20px" Width="80px" Wrap="False" />
                             <ItemStyle Width="80px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="OpTime" HeaderText="操作日期">
                             <HeaderStyle Width="120px" Wrap="False" />
                             <ItemStyle Width="120px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="OpDetail" HeaderText="操作内容">
                             <HeaderStyle Width="350px" Wrap="False" />
                             <ItemStyle Height="40px" Width="450px" Wrap="False" />
                             </asp:BoundField>
                         </Columns>
                         <HeaderStyle BackColor="Silver" Height="20px" />
                         <RowStyle BackColor="White" Height="20px" />
                     </asp:GridView>
                 </div>
            </div>
        </div>
    </form>
    <asp:Image ID="Image2" runat="server" style="position:absolute; top:365px; right:2px; height: 177px; width: 340px;" ImageUrl="~/images/cloud-1.png" />
    <asp:Image ID="Image3" runat="server" style="position:absolute; top:300px;left:-200px; height: 298px; width: 619px; right: 806px;" ImageUrl="~/images/cloud-2.png" />
</body>
</html>