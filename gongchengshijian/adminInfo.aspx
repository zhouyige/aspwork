<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminInfo.aspx.cs" Inherits="adminInfo" %>

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
<center>
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
                            <img id="Img2" class="img" src="images/u10.png">
                            <div id="u11" onclick="window.location.href= 'adminbookmana.aspx';return false">
                               <p><span>图书管理</span></p>
                            </div>
                        </div>
                        <div id="u20" class="ax_单元格" style="cursor: pointer">
                            <img id="Img3" class="img" src="images/u12.png">
                            <div id="u11" onclick="window.location.href= 'adminInfo.aspx';return false">
                                 <p><span>管理员信息</span></p>
                            </div>
                        </div>
             
                    </div>
                </div>
            </div>
            <div class="rightside" style=" height: 600px; right: 0px; position: relative; top: auto; bottom: auto; left: auto;">
                 <div class="rightplane">
                     <asp:Image ID="Image4" runat="server" Height="200px" Width="200px" Style="position:absolute; left: 99px; top:51px"/>

                     <asp:Label ID="Label1" runat="server" Text="姓名: " Style="position:absolute; left: 360px;top:60px" Font-Names="微软雅黑" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label2" runat="server" Text="登陆密码: " Style="position:absolute; left: 360px;top:100px" Font-Names="微软雅黑" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label3" runat="server" Text="联系电话: " Style="position:absolute; left: 360px;top:140px" Font-Names="微软雅黑" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label4" runat="server" Text="用户类型: " Style="position:absolute; left: 360px;top:180px" Font-Names="微软雅黑" Font-Size="Large"></asp:Label>

                     <asp:LinkButton ID="LinkButton1" runat="server" Style="position:absolute; left: 100px;top:260px;" ForeColor="Blue" OnClientClick="return showFloat()">头像编辑</asp:LinkButton>

                     <asp:Label ID="Label8" runat="server" Text="Label" Style="position:absolute; left: 410px;top:62px; " Font-Names="微软雅黑" Font-Size="Medium"></asp:Label>
                     <asp:Label ID="Label9" runat="server" Text="Label" Style="position:absolute; left: 450px;top:102px" Font-Names="微软雅黑" Font-Size="Medium"></asp:Label>
                     <asp:Label ID="Label10" runat="server" Text="Label" Style="position:absolute; left: 450px;top:142px" Font-Names="微软雅黑" Font-Size="Medium"></asp:Label>
                     <asp:Label ID="Label11" runat="server" Text="Label" Style="position:absolute; left: 450px;top:182px" Font-Names="微软雅黑" Font-Size="Medium"></asp:Label>
                     

                     <asp:LinkButton ID="Label15" runat="server" Text="编辑" Style="position:absolute; left: 500px;top:62px" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" OnClick="Label15_Click"></asp:LinkButton>
                     <asp:LinkButton ID="Label16" runat="server" Text="编辑" Style="position:absolute; left: 550px;top:102px" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" OnClick="Label16_Click"></asp:LinkButton>
                     <asp:LinkButton ID="Label17" runat="server" Text="编辑" Style="position:absolute; left: 550px;top:142px" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" OnClick="Label17_Click"></asp:LinkButton>
                     <asp:LinkButton ID="Label18" runat="server" Text="编辑" Style="position:absolute; left: 550px;top:182px;" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" OnClick="Label18_Click"></asp:LinkButton>

                    
                      <asp:LinkButton ID="LinkButton2" runat="server" Text="取消" Style="position:absolute; left: 530px;top:62px" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" Visible="False" OnClick="LinkButton2_Click"></asp:LinkButton>
                     <asp:LinkButton ID="LinkButton3" runat="server" Text="取消" Style="position:absolute; left: 580px;top:102px" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" Visible="False" OnClick="LinkButton3_Click"></asp:LinkButton>
                     <asp:LinkButton ID="LinkButton4" runat="server" Text="取消" Style="position:absolute; left: 580px;top:142px" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" Visible="False" OnClick="LinkButton4_Click"></asp:LinkButton>
                     <asp:LinkButton ID="LinkButton5" runat="server" Text="取消" Style="position:absolute; left: 580px;top:182px;" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" Visible="False" OnClick="LinkButton5_Click"></asp:LinkButton>
                     

                     <asp:TextBox ID="TextBox1" runat="server"  Style="position:absolute; left: 410px;top:60px; right: 513px;" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" Visible="False" Width="80px"></asp:TextBox>
                     <asp:TextBox ID="TextBox2" runat="server"  Style="position:absolute; left: 450px;top:100px" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" Visible="False" Width="90px"></asp:TextBox>
                     <asp:TextBox ID="TextBox3" runat="server"  Style="position:absolute; left: 450px;top:140px" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" Visible="False" Width="90px"></asp:TextBox>
                     <asp:TextBox ID="TextBox4" runat="server"  Style="position:absolute; left: 450px;top:180px" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Blue" Visible="False" Width="80px"></asp:TextBox>

                     

                 </div>
            </div>
        </div>
                 <!--加一个半透明层--> 
    <div id="doing" style="filter:alpha(opacity=30);-moz-opacity:0.3;opacity:0.3;background-color:#000;width:100%;height:100%;z-index:1000;position: absolute;left:0;top:0;display:none;overflow: hidden;"> 
    </div>    
    <!--加一个登录层--> 
    <div id="divAdduser" style="border:solid 10px #898989;background:#fff;padding:10px;width:780px; z-index:1001; position: absolute; display:none;top:50%; left:50%;margin:-200px 0 0 -400px;"> 
            <div style="padding:3px 15px 3px 15px;text-align:left;vertical-align:middle;" > 
            <div class="pic_image"><asp:Image ID="pic" runat="server" Height="200px" Width="200px" /></div>
            <div><asp:FileUpload ID="pic_upload" runat="server" /><asp:Label ID="lbl_pic" runat="server" class="pic_text"></asp:Label></div>
            <div class="pic_label">上传图片格式为.jpg, .gif, .bmp,.png,图片大小不得超过1M</div>
            <div>
                <asp:Button ID="btn_upload" runat="server"  Text="保存" onclick="btn_upload_Click"/>
                <input id="BttCancel" type="button" value=" 取消 " onclick="ShowNo()" /> 
            </div>
            </div> 
      </div> 
    </form>
    <asp:Image ID="Image2" runat="server" style="position:absolute; top:365px; right:2px; height: 177px; width: 340px;" ImageUrl="~/images/cloud-1.png" />
    <asp:Image ID="Image3" runat="server" style="position:absolute; top:300px;left:-200px; height: 298px; width: 619px; right: 806px;" ImageUrl="~/images/cloud-2.png" />
</body>
</center>
</html>
