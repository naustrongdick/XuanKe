<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Adminlo.aspx.cs" Inherits="Adminlo" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width",initial-scale="1.0,minimun-scale=0.5,maximun-scale=2.0,user-scalable=yes" />
<title>管理员登录</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/loginmain.css" rel="stylesheet" />

    <style type="text/css">
        .main{
            background-image: url("bg/bg2.png");
        }
    </style>
</head>
<body>
    <form id="form2" runat="server" >
        <script type="text/javascript" src ="js/canvas-nest.min.js" count="250" zindex="-2" opacity="0.9" color="77,21,125"></script>
    <div class="top">
        <div style="display: table-cell;vertical-align: middle;padding-left:20px;">
            <asp:Label ID="Label4" runat="server" Text="教师选课系统" Font-Size="X-Large" ForeColor="White"></asp:Label>
        </div>
    </div>
    <div class="main">
        <div class ="inside">
        <center>
        <div style="height:120px;width:300px;line-height:85px;">
            <asp:Label ID="Label1" runat="server" Text="管理员登陆" Font-Size="XX-Large"></asp:Label>
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
            <asp:Label ID="Show" runat="server" Text="" Font-Size="Large"></asp:Label></div>
        <br/>
    </center>
            </div>
        <div class ="ot">
		<a href="http://www.rosecat707.top" style="font-size: large">账号登录</a>
	</div>
    </div>
	
    </form>
    <script type="text/javascript" src="js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="js/click.js"></script>
    <script type="text/javascript" src="js/input.js" data-no-instant></script>
    <script type="text/javascript">
        POWERMODE.colorful = true;
        POWERMODE.shake = false;
        document.body.addEventListener('input', POWERMODE);
    </script>
</body>
</html>
