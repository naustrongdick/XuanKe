<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alpage3.aspx.cs" Inherits="pages_alpage2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加帐户</title>
    <link href="bootstrap/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .bg{
            background-color:#E9CFAE; 
            font-family:'Microsoft YaHei UI';
        }
        .main
        {
        	width:300px;
        	height:320px;
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
    <div>
        <div class=main>
                    <center>
                    <div style="width:280px;height:320px;">
                        <center>
                        <div style="height:50px;display:flex;justify-content:center;align-items:center;">
                            <div>
                                <asp:Label ID="Label3" runat="server" Text="添加帐户"></asp:Label>
                            </div>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label4" runat="server" Text="账号："></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox1" Height="25px" Width="152px" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label5" runat="server" Text="密码："></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox3" Height="25px" Width="152px" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label6" CssClass="form-control" runat="server" Text="用户名："></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox4" Height="25px" Width="152px" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:50px;">
                            <div style="float:left;">
                                <asp:Label ID="Label1" runat="server" Text="性别:"></asp:Label>
                            </div>
                            <div style="float:right; height: 25px;">
                                <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="152px">
                                    <asp:ListItem>男</asp:ListItem>
                                    <asp:ListItem>女</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div style="height:70px;">
                            <center>
                                <div>
                                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="提交" Font-Size="Large" Width="170px" Height="40px" onclick="Button1_Click" />
                                </div>
                                <div>
                                    <asp:Label ID="Show" runat="server" ForeColor="Red"></asp:Label>
                                </div>
                            </center>
                        </div>
                        </center>
                    </div>
                    </center>
                </div>
    </div>
    </form>
</body>
</html>
