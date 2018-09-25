<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admain.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员界面</title>
    <link href="bootstrap/bootstrap.min.css" rel="stylesheet">
    <style>
        .bg{
            background-color:lightblue;
        }
        .top
        {
            width: 100%;
            height: 180px;
            background-image:url('bg/logo.jpg');
            background-size:contain;
        }
        .left
        {
            width: 15%;
            height: 700px;
            float: left;
            background-color:aquamarine;
        }
        .btleft 
        {
            text-align:left;
        }
        .content
        {
            width: 84%;
            height: 700px;
        }
        .alabal
        {
        	background-color:#EEE8AA;
        }
    </style>  

</head>
<body>
    <form id="form1" runat="server">

        <div class="top">
            <center>
            <div style="width:98%">
                <div style="float:left;">
                    <asp:Label ID="hello" ForeColor="White" runat="server" Text="欢迎您，"></asp:Label>
                </div>
                <div style="float:right;">
                    <asp:LinkButton ID="exit" ForeColor="White" runat="server" OnClick="exit_Click">安全退出</asp:LinkButton>
                </div>
            </div>
            </center>
        </div>

        <div class="left">

            <div class=alabal>
                <asp:Label ID="Label1" runat="server" Text="Label">排课</asp:Label>
            </div>

            <div>

                <div>
                    <asp:Button class="btleft" ID="Button1" CssClass="btn btn-link" runat="server" Text="排课管理" OnClick="Button1_Click"/>
                </div>

                <div>
                    <asp:Button class="btleft" ID="Button2" CssClass="btn btn-link" runat="server" Text="预约结果" OnClick="Button2_Click"/>
                </div>

            </div>

            <div class=alabal>
                <asp:Label ID="Label2" runat="server" Text="Label">信息维护</asp:Label>
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
        <iframe class ="content" id="mainbox" name="iframeContent" frameborder="0" src="pages/tepage1.aspx" runat="server" ></iframe>
    </form>
</body>
</html>
