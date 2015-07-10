using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
public partial class adminInfo : System.Web.UI.Page
{
    private static userlogModel userinfomodel;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            return;
        }
        userinfomodel = ReaderInfoOP.GetInfo(Session["UserName"].ToString().Trim());
        if (userinfomodel.Imagefs != null)
        {
            System.Drawing.Image img = System.Drawing.Image.FromStream(userinfomodel.Imagefs);
            img.Save("images\\touxiang.bmp");
            Image4.ImageUrl = "images\\touxiang.bmp";
        }
        else
        {
            Image4.ImageUrl = "images\\morentouxiang.png";
            pic.ImageUrl = "images\\morentouxiang.png";
        }
        Label8.Text = userinfomodel.Name;
        Label9.Text = userinfomodel.AccontName;
        Label10.Text = userinfomodel.UserPassword;
        Label11.Text = userinfomodel.College;
    }
    protected void btn_upload_Click(object sender, EventArgs e)
    {
        Response.Write("<script type='text/javascript'>alert('" + "大哥别点这个行么！" + "');</script>");
        //Boolean fileOk = false;
        //if (pic_upload.HasFile)//验证是否包含文件
        //{
        //    //取得文件的扩展名,并转换成小写
        //    string fileExtension = Path.GetExtension(pic_upload.FileName).ToLower();
        //    //验证上传文件是否图片格式
        //    fileOk = IsImage(fileExtension);

        //    if (fileOk)
        //    {
        //        if (pic_upload.PostedFile.ContentLength < 1024000)
        //        {

                    
        //            //显示图片
                    
        //            //清空提示
        //            lbl_pic.Text = "";
        //        }
        //        else
        //        {
        //            pic.ImageUrl = "";
        //            lbl_pic.Text = "文件大小超出1M！请重新选择！";
        //        }
        //    }
        //    else
        //    {
        //        pic.ImageUrl = "";
        //        lbl_pic.Text = "要上传的文件类型不对！请重新选择！";
        //    }
        //}
        //else
        //{
        //    pic.ImageUrl = "";
        //    lbl_pic.Text = "请选择要上传的图片！";
        //}
    }

    //public bool IsImage(string str)
    //{
    //    bool isimage = false;
    //    string thestr = str.ToLower();
    //    //限定只能上传jpg和gif图片
    //    string[] allowExtension = {".bmp"};
    //    //对上传的文件的类型进行一个个匹对
    //    for (int i = 0; i < allowExtension.Length; i++)
    //    {
    //        if (thestr == allowExtension[i])
    //        {
    //            isimage = true;
    //            break;
    //        }
    //    }
    //    return isimage;
    //}
    //public string CreateSalt(int saltLenght)
    //{
    //    //生成一个加密的随机数
    //    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
    //    byte[] buff = new byte[saltLenght];
    //    rng.GetBytes(buff);
    //    //返回一个Base64随机数的字符串
    //    return Convert.ToBase64String(buff);
    //}
    //public string CreatePasswordHash(string pwd, int saltLenght)
    //{
    //    string strSalt = CreateSalt(saltLenght);
    //    //把密码和Salt连起来
    //    string saltAndPwd = String.Concat(pwd, strSalt);
    //    //对密码进行哈希
    //    string hashenPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(saltAndPwd, "sha1");
    //    //转为小写字符并截取前16个字符串
    //    hashenPwd = hashenPwd.ToLower().Substring(0, 16);
    //    //返回哈希后的值
    //    return hashenPwd;
    //}
    protected void Label15_Click(object sender, EventArgs e)
    {
        if (Label15.Text == "编辑")
        {
            TextBox1.Visible = true;
            Label15.Text = "确认";
            LinkButton2.Visible = true;
        }
        else
        {
            TextBox1.Visible = false;
            Label15.Text = "编辑";
            LinkButton2.Visible = false;
            ReaderInfoOP.Delete(userinfomodel.AccontName);
            ReaderInfoOP.Insert(userinfomodel.AccontName, userinfomodel.UserPassword
                , userinfomodel.UserAccontType, userinfomodel.TelNumber, userinfomodel.College
                , userinfomodel.Address, userinfomodel.Profession,  TextBox1.Text.Trim());
            Response.Redirect("adminInfo.aspx");
        }
        
        
    }
    protected void Label16_Click(object sender, EventArgs e)
    {
        if (Label16.Text == "编辑")
        {
            TextBox2.Visible = true;
            Label16.Text = "确认";
            LinkButton3.Visible = true;
        }
        else
        {
            TextBox2.Visible = false;
            Label16.Text = "编辑";
            LinkButton3.Visible = false;
            ReaderInfoOP.Delete(userinfomodel.AccontName);
            ReaderInfoOP.Insert(userinfomodel.AccontName, TextBox2.Text.Trim()
                , userinfomodel.UserAccontType, userinfomodel.TelNumber, userinfomodel.College
                , userinfomodel.Address, userinfomodel.Profession, userinfomodel.Name);
            Response.Redirect("adminInfo.aspx");
        }
        
    }
    protected void Label17_Click(object sender, EventArgs e)
    {
        if (Label17.Text == "编辑")
        {
            TextBox3.Visible = true;
            Label17.Text = "确认";
            LinkButton4.Visible = true;
        }
        else
        {
            TextBox3.Visible = false;
            Label17.Text = "编辑";
            LinkButton4.Visible = false;
            ReaderInfoOP.Delete(userinfomodel.AccontName);
            ReaderInfoOP.Insert(userinfomodel.AccontName, userinfomodel.UserPassword
                , userinfomodel.UserAccontType, TextBox3.Text.Trim(), userinfomodel.College
                , userinfomodel.Address, userinfomodel.Profession, userinfomodel.Name);
            Response.Redirect("adminInfo.aspx");
        }
        
    }
    protected void Label18_Click(object sender, EventArgs e)
    {
        if (Label18.Text == "编辑")
        {
            TextBox4.Visible = true;
            Label18.Text = "确认";
            LinkButton5.Visible = true;
        }
        else
        {
            TextBox4.Visible = false;
            Label18.Text = "编辑";
            LinkButton5.Visible = false;
            ReaderInfoOP.Delete(userinfomodel.AccontName);
            ReaderInfoOP.Insert(userinfomodel.AccontName, userinfomodel.UserPassword
                ,Convert.ToInt32(TextBox4.Text.Trim()) , userinfomodel.TelNumber, userinfomodel.College
                , userinfomodel.Address, userinfomodel.Profession, userinfomodel.Name);
            Response.Redirect("adminInfo.aspx");
        }
       
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        TextBox1.Visible = false;
        Label15.Text = "编辑";
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        TextBox2.Visible = false;
        Label15.Text = "编辑";
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        TextBox3.Visible = false;
        Label15.Text = "编辑";
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        TextBox4.Visible = false;
        Label15.Text = "编辑";
    }
    
}

