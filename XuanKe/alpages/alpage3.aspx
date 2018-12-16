<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alpage3.aspx.cs" Inherits="pages_alpage2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加帐户</title>
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/pagebase.css" rel="stylesheet" />
    <link href="/css/mycss.css" rel="stylesheet" />
    <style type="text/css">
        
        .main
        {
        	width:370px;
        	height:400px;
        	font-size:large;
            font-family: glfont;
            font-family: 'Microsoft YaHei UI';
        	background-color:#2A8FBD;
        	position:absolute;
        	top:30px;
        	left:300px;
            -moz-box-shadow: 2px 2px 5px #333333;
            -webkit-box-shadow: 2px 2px 5px #333333;
            box-shadow: 5px 10px 30px #285a63;
        }
    </style>
</head>
<body class ="bg">
    <form id="form1" runat="server">
    <div>
        <div class="main">
                    <center>
                    <div style="width:290px;height:370px;">
                        <center>
                        <div style="height:50px;display:flex;justify-content:center;align-items:center;">
                            <div>
                                <asp:Label ID="Label3" runat="server" Text="添加帐户" ForeColor="White" Font-Size="X-Large"></asp:Label>
                            </div>
                        </div>
                        <div style="height:70px;">
                            <div style="float:left;">
                                <asp:Label ID="Label4" runat="server" Text="账号：" ForeColor="White"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox1" Height="40px" Width="170px" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        
                        <div style="height:70px;">
                            <div style="float:left;">
                                <asp:Label ID="Label5" runat="server" Text="密码：" ForeColor="White"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox3" Height="40px" Width="170px" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:70px;">
                            <div style="float:left;">
                                <asp:Label ID="Label6" runat="server" Text="用户名：" ForeColor="White"></asp:Label>
                            </div>
                            <div style="float:right;">
                                <asp:TextBox ID="TextBox4" Height="40px" Width="170px" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div style="height:70px;">
                            <div style="float:left;">
                                <asp:Label ID="Label1" runat="server" Text="性别:" ForeColor="White"></asp:Label>
                            </div>
                            <div style="float:right; height: 70px;">
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Height="40px" Width="170px">
                                    <asp:ListItem>男</asp:ListItem>
                                    <asp:ListItem>女</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div style="height:70px;">
                            <center>
                                <div>
                                    <asp:Button ID="Button1" CssClass="mybutton2" runat="server" Text="提交" Font-Size="Large" Width="170px" Height="40px" onclick="Button1_Click" ForeColor="#2A8FBD" />
                                </div>
                                <div>
                                    <asp:Label ID="Show" runat="server" ForeColor="White"></asp:Label>
                                </div>
                            </center>
                        </div>
                        </center>
                    </div>
                    </center>
                </div>
    </div>
    </form>
    <script type="text/javascript" src="/js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="/js/click.js"></script>
    <script type="text/javascript" src="/js/input.js" data-no-instant></script>
    <script type="text/javascript">
        POWERMODE.colorful = true;
        POWERMODE.shake = false;
        document.body.addEventListener('input', POWERMODE);
    </script>
</body>
</html>
