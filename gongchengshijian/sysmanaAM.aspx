<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sysmanaAM.aspx.cs" Inherits="sysmanaAM" %>

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
                <div class="leftplane">
                    <div id="u9" class="ax_表格" style="position: absolute; top: 13px; left: 10px">
                        <div id="u10" class="ax_单元格" style="cursor: pointer; text-align: center;">
                            <img id="u10_img" class="img" src="images/u12.png" tabindex="0">
                            <div id="u11" onclick="window.location.href= 'sysmanaAM.aspx';return false">
                            <p><span>账号管理</span></p>
                            </div>
                        </div>
                        <div id="u12" class="ax_单元格" style="cursor: pointer">
                            <img id="u12_img" class="img" src="images/u10.png">
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
            <div class="rightside" style=" height: 600px; right: 0px; position: relative; top: auto; bottom: auto; left: auto;">
                 <div class="rightplane">
                     <asp:GridView ID="GridView1" runat="server" CssClass="pagetable1" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" HorizontalAlign="Center" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">
                         <Columns>
                             <asp:BoundField DataField="AccontName" HeaderText="账户名">
                             <ControlStyle Width="80px" />
                             <FooterStyle Width="80px" />
                             <HeaderStyle Wrap="False" Width="80px" />
                             <ItemStyle Width="80px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="UserPassword" HeaderText="账户密码">
                             <ControlStyle Width="80px" />
                             <FooterStyle Width="80px" />
                             <HeaderStyle Wrap="False" Width="80px" />
                             <ItemStyle Width="80px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="UserAccontType" HeaderText="账户类型">
                             <ControlStyle Width="50px" />
                             <FooterStyle Width="50px" />
                             <HeaderStyle Wrap="False" Width="50px" />
                             <ItemStyle Width="50px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="Name" HeaderText="姓名">
                             <ControlStyle Width="60px" />
                             <FooterStyle Width="60px" />
                             <HeaderStyle Wrap="False" Width="60px" />
                             <ItemStyle Width="60px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="Address" HeaderText="地址">
                             <ControlStyle Width="80px" />
                             <FooterStyle Width="80px" />
                             <HeaderStyle Wrap="False" Width="80px" />
                             <ItemStyle Width="80px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="TelNumber" HeaderText="电话号码">
                             <ControlStyle Width="80px" />
                             <FooterStyle Width="80px" />
                             <HeaderStyle Wrap="False" Width="80px" />
                             <ItemStyle Width="80px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="College" HeaderText="学院">
                             <ControlStyle Width="80px" />
                             <FooterStyle Width="80px" />
                             <HeaderStyle Wrap="False" Width="80px" />
                             <ItemStyle Width="80px" Wrap="False" />
                             </asp:BoundField>
                             <asp:BoundField DataField="Profession" HeaderText="专业">
                             <ControlStyle Width="80px" />
                             <FooterStyle Width="80px" />
                             <HeaderStyle Wrap="False" Width="80px" />
                             <ItemStyle Width="80px" Wrap="False" />
                             </asp:BoundField>
                             <asp:CommandField ShowEditButton="True">
                             <ControlStyle Width="80px" />
                             <FooterStyle Width="80px" />
                             <HeaderStyle Width="80px" />
                             <ItemStyle ForeColor="#0066FF" Width="80px" />
                             </asp:CommandField>
                             <asp:CommandField ShowDeleteButton="True">
                             <ControlStyle Width="40px" />
                             <FooterStyle Width="40px" />
                             <HeaderStyle Width="40px" />
                             <ItemStyle ForeColor="#0066FF" Width="40px" />
                             </asp:CommandField>
                         </Columns>
                         <HeaderStyle BackColor="Silver" />
                         <RowStyle BackColor="White" />
                         <SelectedRowStyle BackColor="#999999" BorderColor="#999999" />
                     </asp:GridView>
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
                    &nbsp;<asp:Label ID="Label1" runat="server" Text="账户名："></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Width="160px"></asp:TextBox>
                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="账户密码："></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Width="168px"></asp:TextBox>
                </div>
                <div> 
                    &nbsp;<asp:Label ID="Label11" runat="server" Text="账户类型："></asp:Label>
                    <asp:TextBox ID="TextBox11" runat="server" OnTextChanged="TextBox11_TextChanged" Width="147px"></asp:TextBox>
                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label12" runat="server" Text="姓名："></asp:Label>
                    <asp:TextBox ID="TextBox12" runat="server" Width="185px"></asp:TextBox>
                </div> 
                <div> 
                    &nbsp;<asp:Label ID="Label5" runat="server" Text="电话："></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" Width="170px"></asp:TextBox>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" Text="学院："></asp:Label>
                    <asp:TextBox ID="TextBox6" runat="server" Width="186px"></asp:TextBox>
                    
                </div> 
                <div>
                    &nbsp;<asp:Label ID="Label7" runat="server" Text="专业："></asp:Label>
                    <asp:TextBox ID="TextBox7" runat="server" Width="170px"></asp:TextBox>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" Text="地址："></asp:Label>
                    <asp:TextBox ID="TextBox8" runat="server" Width="187px"></asp:TextBox>
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
    <asp:Image ID="Image3" runat="server" style="position:absolute; top:300px;left:-200px; height: 298px; width: 619px; right: 806px;" ImageUrl="~/images/cloud-2.png" />
</body>
</html>