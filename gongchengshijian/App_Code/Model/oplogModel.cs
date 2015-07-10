using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// oplogModel 的摘要说明
/// </summary>
public class oplogModel
{
	public oplogModel(string gid, string userid, DateTime optime, string opdetail)
	{
        this.gid = gid;
	    this.userid = userid;
	    this.opTime = optime;
	    this.opDetail = opdetail;
	}

    private string gid;
    private string userid;
    private DateTime opTime;
    private string opDetail;

    public string Userid
    {
        get { return userid; }
        set { userid = value; }
    }

    public DateTime OpTime
    {
        get { return opTime; }
        set { opTime = value; }
    }

    public string OpDetail
    {
        get { return opDetail; }
        set { opDetail = value; }
    }

    public string Gid
    {
        get { return gid; }
        set { gid = value; }
    }
}