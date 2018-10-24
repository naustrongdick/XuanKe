<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tepage4.aspx.cs" Inherits="pages_tepage4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改密码</title>
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/pagebase.css" rel="stylesheet" />
    <style type="text/css">
        
        .main
        {
        	width:300px;
        	height:270px;
        	font-size:large;
        	background-color:#D9D9D9;
        	position:absolute;
        	top:30px;
        	left:300px;
            border-radius:15px;
            border-style:outset;
        }
    </style>
</head>
<body class ="bg">
    <form id="form1" runat="server">

                <div class=main>
                    <center>
                    <div style="width:280px;height:250px;">
                        <center>
                        <div style="height:50px;display:flex;justify-content:center;align-items:center;">
                            <div>
                                <asp:Label ID="Label3" runat="server" Text="修改密码"></asp:Label>
                            </div>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label4" runat="server" Text="旧密码:"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox1" Height="25px" Width="152px" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label1" runat="server" Text="新密码:"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox2" Height="25px" Width="152px" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label5" runat="server" Text="重复密码:"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox3" Height="25px" Width="152px" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:30px;">
                            <center>
                                <div>
                                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="提交" 
                                    Font-Size="Large" Width="170px" Height="40px" onclick="Button1_Click" />
                                </div>
                                <div>
                                    <asp:Label ID="Show" runat="server" ForeColor="Red">密码为5-20位字母或数字</asp:Label>
                                </div>
                            </center>
                        </div>
                        </center>
                    </div>
                    </center>
                </div>
    </form>
</body>
</html>
