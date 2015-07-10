<%@ Page Language="C#" AutoEventWireup="true" CodeFile="readerreverse.aspx.cs" Inherits="readerreverse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
                <div class="leftplane1">
                    <div id="u9" class="ax_表格" style="position: absolute; top: 13px; left: 10px">
                        <div id="u10" class="ax_单元格" style="cursor: pointer; text-align: center;">
                            <img id="u10_img" class="img" src="images/u10.png" tabindex="0">
                            <div id="u11" onclick="window.location.href= 'readersearch.aspx';return false">
                            <p><span>图书检索</span></p>
                            </div>
                        </div>
                        <div id="u12" class="ax_单元格" style="cursor: pointer">
                            <img id="u12_img" class="img" src="images/u12.png">
                            <div id="u11" onclick="window.location.href= 'readerreverse.aspx';return false">
                            <p><span>图书预定</span></p>
                            </div>
                        </div>
                        <div id="u14" class="ax_单元格" style="cursor: pointer">
                            <img id="u14_img" class="img" src="images/u10.png">
                            <div id="u11" onclick="window.location.href= 'readerborrowInfo.aspx';return false">
                                <p><span>借阅信息</span></p>
                            </div>
                        </div>
                        <div id="u16" class="ax_单元格" style="cursor: pointer">
                            <img id="u16_img" class="img" src="images/u10.png">
                            <div id="u11" onclick="window.location.href= 'readerInfo.aspx';return false">
                                <p><span>个人信息</span></p>
                            </div>
                         </div>
                    </div>
                </div>
            </div>
            <div class="rightside" style=" height: 600px; right: 0px; position: relative; top: auto; bottom: auto; left: auto;">
                 <div class="rightplane">
                     <asp:GridView ID="ReaderBorrowInfo" runat="server" AutoGenerateColumns="False" CssClass="gridview1" HorizontalAlign="Center" OnRowCommand="ReaderBorrowInfo_RowCommand">
                         <Columns>
                             <asp:BoundField DataField="BookId" HeaderText="识别码">
                             <HeaderStyle Width="100px" Wrap="True" />
                             <ItemStyle Width="100px" Wrap="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                             </asp:BoundField>
                             <asp:BoundField DataField="bookName" HeaderText="书名/作者">
                             <ItemStyle Width="350px" Wrap="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                             </asp:BoundField>
                             <asp:BoundField DataField="ReserveDate" HeaderText="预订日期">
                             <ItemStyle Width="100px" Wrap="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                             </asp:BoundField>
                             <asp:BoundField DataField="ReturnDate" HeaderText="预订解除日期">
                             <ItemStyle Width="100px" Wrap="True" HorizontalAlign="Center" VerticalAlign="Middle" />
                             </asp:BoundField>
                             <asp:ButtonField HeaderText="解除预订" Text="解除" CommandName="解除预订">
                             <ItemStyle Width="100px" Wrap="True" ForeColor="#3399FF" HorizontalAlign="Center" VerticalAlign="Middle" />
                             </asp:ButtonField>
                         </Columns>
                         <HeaderStyle BackColor="Gray" Height="20px" />
                         <RowStyle BackColor="White" Height="20px" Wrap="False" />
                     </asp:GridView>
                 </div>
            </div>
        </div>
    </form>
    <asp:Image ID="Image2" runat="server" style="position:absolute; top:365px; right:2px; height: 177px; width: 340px;" ImageUrl="~/images/cloud-1.png" />
    <asp:Image ID="Image3" runat="server" style="position:absolute; top:300px;left:-200px; height: 298px; width: 619px; right: 806px;" ImageUrl="~/images/cloud-2.png" />
</body>
</html>
