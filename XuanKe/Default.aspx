﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>登录界面</title>
    <style>
        .bg
        {
        	background-image:url('Computer.jpg');
        }
        .main
        {
        	text-align:left;
        	background-color:#FAFAFA;
        	width:300px;
        	height:300px;
        	margin:auto;
        	position:absolute;
            top:100px;
        	right:200px;
            font-family:'Microsoft YaHei UI';
        }
    	.ot 
		{
			position:absolute;
            bottom:50px;
			width:100%;
			text-align:center;
			margin:auto;
            font-family:'Microsoft YaHei UI';
            height: 13px;
        }
        
    </style>
</head>
<body class="bg">
    <form id="form1" runat="server" >
    <div class=main>
        <br><br>
        &nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="账号登陆" Font-Size="X-Large"></asp:Label>
        <br><br>
        &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="账号：" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="usernm" runat="server" Width="170px" Font-Size="Larger" Font-Underline="False"></asp:TextBox>
        <br><br><br>
         &nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="密码：" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="passwd" runat="server" Width="170px" MaxLength="10" TextMode="Password" Font-Size="Larger"></asp:TextBox>
        <br><br><br>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="tologin" runat="server" Text="登录" onclick="Button1_Click" BackColor="#00CCFF" BorderColor="Black" BorderStyle="None" Font-Size="Large" Width="170px" />
        &nbsp;&nbsp;
        <br><br><br>
        <asp:Label ID="Show" runat="server" Text=""></asp:Label>
        <br>
		
    </div>
	<div class ="ot">
		<asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Small" OnClick="LinkButton1_Click">管理员登录</asp:LinkButton>
	</div>
    </form>
</body>
</html>