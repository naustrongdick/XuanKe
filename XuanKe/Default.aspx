<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>登录界面</title>
    <style>
        .bg
        {
        	background-color:#99CCCC;
        }
        .main
        {
        	text-align:center;
        	background-color:#FFCCCC;
        	width:300px;
        	height:200px;
        	margin:auto;
        	position:absolute;
        	top:0;
        	left:0;
        	right:0;
        	bottom:0;
        }
        
    </style>
</head>
<body class=bg>
    <form id="form1" runat="server" >
    <div class=main>
        <br>
        <asp:Label ID="Label1" runat="server" Text="账号登陆"></asp:Label>
        <br><br>
        <asp:Label ID="Label2" runat="server" Text="账号："></asp:Label>
        <asp:TextBox ID="usernm" runat="server" Width="102px"></asp:TextBox>
        <br><br>
        <asp:Label ID="Label3" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="passwd" runat="server" Width="104px" MaxLength="10" TextMode="Password"></asp:TextBox>
        <br><br>
        <asp:Button ID="tologin" runat="server" Text="登录" onclick="Button1_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="clear" runat="server" Text="取消" OnClick="clear_Click" />
        <br><br>
        <asp:Label ID="Show" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
