<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
 
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width",initial-scale="1.0,minimun-scale=0.5,maximun-scale=2.0,user-scalable=yes" />
    <title>登录界面</title>
    
    <link href="bootstrap/bootstrap.min.css" rel="stylesheet" />
    <style>
        @font-face {
            font-family: 'glfont';
            src: url('bootstrap/glyphigcons-halflings-reular.ttf');
        }
        .bg
        {
        	background-image:url('bg/bg3.jpg');
            background-attachment:fixed;
            background-size:cover;
            background-repeat:no-repeat;
        }
        .main
        {
        	text-align:left;
        	background-color:#FAFAFA;
        	width:270px;
        	height:300px;
        	margin:auto;
        	position:absolute;
            font-family:glfont;
            font-family:'Microsoft YaHei UI';
            top:20%;
        	right:10%;
            border-radius:10px;
        }
    	.ot 
		{
			position:absolute;
            bottom:8%;
			width:100%;
			text-align:center;
			margin:auto;
            font-family:glfont;
            font-family:'Microsoft YaHei UI';
            height: 13px;
            left: 0px;
        }
        
    </style>
</head>
<body class="bg">
    <form id="form1" runat="server" >
    <div class=main>
        <center>
        <div style="height:85px;width:230px;line-height:85px;">
            <asp:Label ID="Label1" runat="server" Text="账号登陆" Font-Size="X-Large"></asp:Label>
        </div>
        <div style="height:70px;width:230px;">
            <div style="float:left;">
                <asp:Label ID="Label2" runat="server" Text="账号：" Font-Size="Large"></asp:Label>
            </div>
            <div style="float:right;">
                <asp:TextBox ID="usernm" CssClass="form-control" runat="server" Width="170px" Font-Size="Larger" Font-Underline="False"></asp:TextBox>
            </div>
        </div>
        <div style="height:70px;width:230px;">
            <div style="float:left;">
                <asp:Label ID="Label3" runat="server" Text="密码：" Font-Size="Large"></asp:Label>
            </div>
            <div style="float:right;">
                <asp:TextBox ID="passwd" CssClass="form-control" runat="server" Width="170px" MaxLength="10" TextMode="Password" Font-Size="Larger"></asp:TextBox>
            </div>
        </div>
        <div style="height:50px;width:230px;">
            <asp:Button class="btn btn-primary" ID="tologin" runat="server" Text="登录" onclick="Button1_Click" Font-Size="Large" Width="170px" Height="40px" />
        </div>
        <div style="height:25px;width:230px;">
            <asp:Label ID="Show" runat="server" Text=""></asp:Label></div>
        <br/>
    </center>
    </div>
	<div class ="ot">
		<a href="http://www.rosecat707.top/Adminlo.aspx">管理员登录</a>
	</div>
    </form>
</body>
</html>
