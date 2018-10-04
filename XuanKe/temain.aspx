<%@ Page Language="C#" AutoEventWireup="true" CodeFile="temain.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width",initial-scale="1.0,minimun-scale=0.5,maximun-scale=2.0,user-scalable=yes" />
    <title>教师选课系统</title>
    <link href="bootstrap/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .top
        {
            width: 1600px;
            height: 200px;
            background-color:#16245C;
            background-size:contain;
        }
        .left
        {
            width: 192px;
            height: 700px;
            float: left;
            background-color:#F8F2DC;
        }
        .btleft 
        {
            text-align:left;
            float:left;
        }
        .content
        {
            width: 1400px;
            height:700px;
        }
        .alabal
        {
        	background-color:#A39F93;
            height:40px;
            display:flex;
            justify-content:center;
            align-items:center;
            font-size:large;
        }
    </style>  

</head>
<body style="font-family:'Microsoft YaHei UI';background-color:#aabce6;">
    <form id="form1" runat="server">

        <div class="top">
            <center>
            <div style="width:98%; background-color:#0D1740;height:50px;display:flex;justify-content:center;align-items:center;border-bottom-left-radius:20px;border-bottom-right-radius:20px;">
                <div style="width:98%; font-size:large; color:white;">
                    <div style="float:left;">
                        <asp:Label ID="hello" runat="server" Text="欢迎您，"></asp:Label>
                    </div>
                    <div style="float:right;">
                        <asp:LinkButton ID="exit" ForeColor="White" runat="server" OnClick="exit_Click">安全退出</asp:LinkButton>
                    </div>
                    用户界面</div>
            </div>
            <div style="height:150px;display:flex;justify-content:center;align-items:center;font-size:large;">
                <img alt="" src="bg\logo.png" style="height: 80px; width: 423px" />
            </div>
        </div>

        <div style="height:10px;"></div>
        <div style="width:1600px;">
        <div class="left">

            <div class=alabal>
                <asp:Label ID="Label1" runat="server" Text="Label">教师选课</asp:Label>
            </div>

            <div>

                <div>
                    <asp:Button class="btleft" ID="Button2" CssClass="btn btn-link" runat="server" Text="课表结果" OnClick="Button2_Click"/>
                </div>

                <div>
                    <asp:Button class="btleft" ID="Button1" CssClass="btn btn-link" runat="server" Text="预约课时" OnClick="Button1_Click"/>
                </div>

            </div>

            <div class=alabal>
                <asp:Label ID="Label2" runat="server" Text="Label">账号管理</asp:Label>
            </div>

            <div>

                <div>
                    <asp:Button class="btleft" ID="Button3" CssClass="btn btn-link" runat="server" Text="信息维护" OnClick="Button3_Click"/>
                </div>

                <div>
                    <asp:Button class="btleft" ID="Button4" CssClass="btn btn-link" runat="server" Text="修改密码" OnClick="Button4_Click"/>
                </div>

            </div>

        </div>
        <div style="float:right;width: 1400px;height: 700px;">
        <iframe class ="content" id="mainbox" name="iframeContent" frameborder="0" 
            src="tepages/error.aspx" runat="server" ></iframe>
        </div>
        </div>
    </form>
</body>
</html>
