<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
 
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width",initial-scale="1.0,minimun-scale=0.5,maximun-scale=2.0,user-scalable=yes" />
    <title>登录界面</title>
    
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/loginmain.css" rel="stylesheet" />

    <style type="text/css">
        .main{
            background-image: url("bg/bg.png");
        }
    </style>
</head>
<body>
    <script type="text/javascript" src ="js/canvas-nest.min.js" count="250" zindex="-2" opacity="0.8" color="78,29,76"></script>
    <form id="form1" runat="server" >
    <div class="top">
        <div style="display: table-cell;vertical-align: middle;padding-left:20px;">
            <asp:Label ID="Label4" runat="server" Text="教师选课系统" Font-Size="X-Large" ForeColor="White"></asp:Label>
        </div>
    </div>
    <div class="main">
        <div class ="inside">
        <center>
        <div style="height:120px;width:300px;line-height:85px;">
            <asp:Label ID="Label1" runat="server" Text="账号登陆" Font-Size="XX-Large"></asp:Label>
        </div>
        <div style="height:90px;width:300px;">
            <div style="float:left;">
                <asp:Label ID="Label2" runat="server" Text="账号：" Font-Size="X-Large"></asp:Label>
            </div>
            <div style="float:right;">
                <asp:TextBox ID="usernm" CssClass="form-control" runat="server" Width="200px" Font-Size="X-Large" Font-Underline="False"></asp:TextBox>
            </div>
        </div>
        <div style="height:90px;width:300px;">
            <div style="float:left;">
                <asp:Label ID="Label3" runat="server" Text="密码：" Font-Size="X-Large"></asp:Label>
            </div>
            <div style="float:right;">
                <asp:TextBox ID="passwd" CssClass="form-control" runat="server" Width="200px" MaxLength="10" TextMode="Password" Font-Size="X-Large"></asp:TextBox>
            </div>
        </div>
        <div style="height:70px;width:300px;">
            <asp:Button class="btn btn-primary" ID="tologin" runat="server" Text="登录" onclick="Button1_Click" Font-Size="X-Large" Width="300px" Height="50px" />
        </div>
        <div style="height:35px;width:300px;">
            <asp:Label ID="Show" runat="server" Font-Size="Large"></asp:Label></div>
        
    </center>
    </div>
        <div class ="ot">
		    <a href="http://www.rosecat707.top/Adminlo.aspx" style="font-size: large">管理员登录</a>
	    </div>
    </div>
    </form>
</body>
</html>
