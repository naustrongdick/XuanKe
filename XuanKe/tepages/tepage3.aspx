<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tepage3.aspx.cs" Inherits="pages_tepage3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>个人信息维护</title>
    <link href="bootstrap/bootstrap.min.css" rel="stylesheet">
    <style>
        .bg{
            background-color:#FFF0F5;
        }
        .main
        {
        	width:300px;
        	height:300px;
        	font-size:large;
        	background-color:White;
        	position:absolute;
        	top:20%;
        	left:40%;
        }
    </style>
</head>
<body class ="bg">
    <form id="form1" runat="server">
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </div>

                <div class=main>
                    <center>
                    <div style="width:280px;height:280px;">
                        <center>
                        <div style="height:50px;">
                            <asp:Label ID="Label3" runat="server" Text="个人信息维护"></asp:Label>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label4" runat="server" Text="用户名:"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label1" runat="server" Text="性别:"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label5" runat="server" Text="邮箱:"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label6" CssClass="form-control" runat="server" Text="手机号:"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:30px;">
                            <center>
                                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="提交" 
                                    Font-Size="Large" Width="170px" Height="40px" onclick="Button1_Click" />
                            </center>
                        </div>
                        </center>
                    </div>
                    </center>
                </div>
    </form>
</body>
</html>
