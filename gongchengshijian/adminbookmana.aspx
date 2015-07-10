<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminbookmana.aspx.cs" Inherits="adminbookmana" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>图书</title>
    <link href="css/style.css" type="text/css" rel="stylesheet" />
    <link href="css/select.css" type="text/css" rel="stylesheet" />
    <link href="css/net.css" type="text/css" rel="stylesheet" />
    <script src="js/jquery-1.6.3.min.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript">
        function ShowNo()                        //隐藏两个层 
        {
            document.getElementById("doing").style.display = "none";
            document.getElementById("divAdduser").style.display = "none";
        }
        function $(id) {
            return (document.getElementById) ? document.getElementById(id) : document.all[id];
        }
        function showFloat()                    //根据屏幕的大小显示两个层 
        {
            var range = getRange();
            $('doing').style.width = range.width + "px";
            $('doing').style.height = range.height + "px";
            $('doing').style.display = "block";
            document.getElementById("divAdduser").style.display = "";

            return false;
        }
        function getRange()                      //得到屏幕的大小 
        {
            var top = document.body.scrollTop;
            var left = document.body.scrollLeft;
            var height = document.body.clientHeight;
            var width = document.body.clientWidth;

            if (top == 0 && left == 0 && height == 0 && width == 0) {
                top = document.documentElement.scrollTop;
                left = document.documentElement.scrollLeft;
                height = document.documentElement.clientHeight;
                width = document.documentElement.clientWidth;
            }
            return { top: top, left: left, height: height, width: width };
        }
</script> 
    <style type="text/css"> 
          body{margin:0px;} 
    </style> 
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
                            <img id="Img1" class="img" src="images/u10.png">
                            <div id="u11" onclick="window.location.href= 'adminreaderinfo.aspx';return false">
                                <p><span>读者借阅信息</span></p>
                            </div>
                        </div>
                        <div id="u18" class="ax_单元格" style="cursor: pointer">
                            <img id="Img2" class="img" src="images/u12.png">
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
                     <div class="bookdetail1">
                     <asp:GridView ID="GridView1" runat="server"  
                         Font-Names="微软雅黑" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnRowDeleting="GridView1_RowDeleting" HorizontalAlign="Center" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit">
                         <AlternatingRowStyle BackColor="White" />
                         <Columns>
                             <asp:BoundField DataField="BookID" HeaderText="图书编号" />
                             <asp:BoundField DataField="BookName" HeaderText="图书名称" />
                             <asp:BoundField DataField="BookAuthor" HeaderText="作者" />
                             <asp:BoundField DataField="BookPress" HeaderText="存数" />
                             <asp:BoundField DataField="BookPrice" HeaderText="单价" />
                             <asp:BoundField DataField="BookSummary" HeaderText="摘要" />
                             <asp:CommandField ShowEditButton="True">
                             <ItemStyle ForeColor="#3399FF" Width="100px" />
                             </asp:CommandField>
                             <asp:CommandField ShowDeleteButton="True">
                             <ItemStyle ForeColor="#FF6666" Width="40px" />
                             </asp:CommandField>
                         </Columns>
                         <FooterStyle BackColor="#CCCC99" />
                         <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                         <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                         <RowStyle BackColor="#F7F7DE" Height="50px" HorizontalAlign="Center" VerticalAlign="Middle" />
                         <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                         <SortedAscendingCellStyle BackColor="#FBFBF2" />
                         <SortedAscendingHeaderStyle BackColor="#848384" />
                         <SortedDescendingCellStyle BackColor="#EAEAD3" />
                         <SortedDescendingHeaderStyle BackColor="#575357" />
                     </asp:GridView>

                     </div>
                     <asp:Button ID="Button1" runat="server" CssClass="addbutton" OnClientClick="return showFloat()" Text="添加" />
                 </div>
            </div>
        </div>
         <!--加一个半透明层--> 
    <div id="doing" style="filter:alpha(opacity=30);-moz-opacity:0.3;opacity:0.3;background-color:#000;width:100%;height:100%;z-index:1000;position: absolute;left:0;top:0;display:none;overflow: hidden;"> 
    </div>    
    <!--加一个登录层--> 
    <div id="divAdduser" style="border:solid 10px #898989;background:#fff;padding:10px;width:780px; z-index:1001; position: absolute; display:none;top:50%; left:50%;margin:-200px 0 0 -400px;"> 
            <div style="padding:3px 15px 3px 15px;text-align:left;vertical-align:middle;" > 
                <div> 
                    &nbsp;<asp:Label ID="Label1" runat="server" Text="图书编号："></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Width="160px"></asp:TextBox>
                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="存数："></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Width="177px"></asp:TextBox>
                </div>
                <div> 
                    &nbsp;<asp:Label ID="Label11" runat="server" Text="作者："></asp:Label>
                    <asp:TextBox ID="TextBox11" runat="server" Width="184px"></asp:TextBox>
                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label12" runat="server" Text="单价："></asp:Label>
                    <asp:TextBox ID="TextBox12" runat="server" Width="178px"></asp:TextBox>
                </div> 
                <div> 
                    &nbsp;<asp:Label ID="Label5" runat="server" Text="图书名称："></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" Width="460px"></asp:TextBox>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                                        
                </div> 
                <div>
                    &nbsp;<asp:Label ID="Label7" runat="server" Text="摘要："></asp:Label>
                    <asp:TextBox ID="TextBox7" runat="server" Width="485px"></asp:TextBox>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    </div>
                <br/> 
                <div> &nbsp; &nbsp; 
                    <asp:Button ID="ButtonAddSure" runat="server" Text=" 确认 " OnClick="ButtonAddSure_Click"/>&nbsp; 
                    <input id="BttCancel" type="button" value=" 取消 " onclick="ShowNo()" /> 
                </div> 
            </div> 
      </div> 
    </form>
    <asp:Image ID="Image2" runat="server" style="position:absolute; top:365px; right:2px; height: 177px; width: 340px;" ImageUrl="~/images/cloud-1.png" />
    <asp:Image ID="Image3" runat="server" style="position:absolute; top:300px;left:-200px; height: 298px; width: 619px; right: 931px;" ImageUrl="~/images/cloud-2.png" />
</body>
</html>
