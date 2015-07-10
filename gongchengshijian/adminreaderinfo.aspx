<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminreaderinfo.aspx.cs" Inherits="adminreaderinfo" %>

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
                <div class="leftplane2">
                    <div id="u9" class="ax_表格" style="position: absolute; top: 13px; left: 10px">
                        <div id="u10" class="ax_单元格" style="cursor: pointer; text-align: center;">
                            <img id="u10_img" class="img" src="images/u10.png" tabindex="0">
                            <div id="u11" onclick="window.location.href= 'adminloan.aspx';return false">
                            <p><span>图书借出</span></p>
                            </div>
                        </div>
                        <div id="u12" class="ax_单元格" style="cursor: pointer">
                            <img id="u12_img" class="img" src="images/u10.png">
                            <div id="u11" onclick="window.location.href= 'adminrenew.aspx';return false">
                            <p><span>图书续借</span></p>
                            </div>
                        </div>
                        <div id="u14" class="ax_单元格" style="cursor: pointer">
                            <img id="u14_img" class="img" src="images/u10.png">
                              <div id="u11" onclick="window.location.href= 'adminbookreturn.aspx';return false">
                                <p><span>图书归还</span></p>
                            </div>
                        </div>
                        <div id="u16" class="ax_单元格" style="cursor: pointer">
                            <img id="Img1" class="img" src="images/u12.png">
                            <div id="u11" onclick="window.location.href= 'adminreaderinfo.aspx';return false">
                                <p><span>读者借阅信息</span></p>
                            </div>
                        </div>
                        <div id="u18" class="ax_单元格" style="cursor: pointer">
                            <img id="Img2" class="img" src="images/u10.png">
                            <div id="u11" onclick="window.location.href= 'adminbookmana.aspx';return false">
                               <p><span>图书管理</span></p>
                            </div>
                        </div>
                        <div id="u20" class="ax_单元格" style="cursor: pointer">
                            <img id="Img3" class="img" src="images/u10.png">
                            <div id="u11" onclick="window.location.href= 'adminInfo.aspx';return false">
                                 <p><span>管理员信息</span></p>
                            </div>
                        </div>
             
                    </div>
                </div>
            </div>
            <div class="rightside" style=" height: 600px; right: 0px; position: relative; top: auto; bottom: auto; left: auto;">
                 <div class="rightplane">
                     <asp:Label ID="Label1" runat="server" CssClass="label1" Font-Names="微软雅黑" 
                         Font-Size="12pt" Text="读者借阅证号："></asp:Label>
                     <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox1"></asp:TextBox>
                     <asp:Button ID="Button1" runat="server" CssClass="botton1" 
                         Font-Names="微软雅黑" Font-Size="10pt" Text="确认" BorderStyle="None" BackColor="#0066FF" ForeColor="White" OnClick="Button1_Click" />
                     <asp:GridView ID="GridView1" runat="server" CssClass="pagetable1" 
                         Font-Names="微软雅黑" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                         <AlternatingRowStyle BackColor="White" />
                         <Columns>
                             <asp:BoundField DataField="BookId" HeaderText="图书编号" >
                             
                             <ItemStyle Width="100px" Wrap="False" />
                             </asp:BoundField>
                             
                             <asp:BoundField DataField="BookName" HeaderText="图书名称" >
                             
                             <ItemStyle Width="350px" Wrap="False" />
                             </asp:BoundField>
                             
                             <asp:BoundField DataField="BorrowDate" HeaderText="借书日期" >
                             <ItemStyle Width="100px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="ReturnDate" HeaderText="还书截止日期" >
                             <ItemStyle Width="100px" Wrap="False" />
                             </asp:BoundField>
                         </Columns>
                         <FooterStyle BackColor="#CCCC99" />
                         <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                         <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                         <RowStyle BackColor="#F7F7DE" />
                         <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                         <SortedAscendingCellStyle BackColor="#FBFBF2" />
                         <SortedAscendingHeaderStyle BackColor="#848384" />
                         <SortedDescendingCellStyle BackColor="#EAEAD3" />
                         <SortedDescendingHeaderStyle BackColor="#575357" />
                     </asp:GridView>
                 </div>
            </div>
        </div>
    </form>
    <asp:Image ID="Image2" runat="server" style="position:absolute; top:365px; right:2px; height: 177px; width: 340px;" ImageUrl="~/images/cloud-1.png" />
    <asp:Image ID="Image3" runat="server" style="position:absolute; top:300px;left:-200px; height: 298px; width: 619px; right: 806px;" ImageUrl="~/images/cloud-2.png" />
</body>
</html>