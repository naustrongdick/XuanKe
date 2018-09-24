<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tepage1.aspx.cs" Inherits="pages_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>预约选课</title>
    <link href="/bootstrap/bootstrap.min.css" rel="stylesheet">
    <style type="text/css">
        .auto-style1 {
            height: 37px;
        }
        .bg{
            background-color:lightblue;
        }
        .mat{
            position:absolute;
            top:20%;
            left:20%;
        }

    </style>
</head>
<body class ="bg">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">预约选课</asp:Label>
            <div class="mat">
                <table class="table table-hover table-bordered" style ="width:500px;background-color:lightpink;">
                    <tr>
                        <td><asp:Label ID="Label2" runat="server" Text=" 星期一 "></asp:Label></td>
                        <td><asp:Label ID="Label3" runat="server" Text=" 星期二 "></asp:Label></td>
                        <td><asp:Label ID="Label4" runat="server" Text=" 星期三 "></asp:Label></td>
                        <td><asp:Label ID="Label5" runat="server" Text=" 星期四 "></asp:Label></td>
                        <td><asp:Label ID="Label6" runat="server" Text=" 星期五 "></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:CheckBox ID="CheckBox1"  runat="server" Text="上午" /></td>
                        <td class="auto-style1"><asp:CheckBox ID="CheckBox2" runat="server" Text="上午" /></td>
                        <td class="auto-style1"><asp:CheckBox ID="CheckBox3" runat="server" Text="上午" /></td>
                        <td class="auto-style1"><asp:CheckBox ID="CheckBox4" runat="server" Text="上午" /></td>
                        <td class="auto-style1"><asp:CheckBox ID="CheckBox5" runat="server" Text="上午" /></td>
                    </tr>
                    <tr>
                        <td><asp:CheckBox ID="CheckBox6" runat="server" Text="下午" /></td>
                        <td><asp:CheckBox ID="CheckBox7" runat="server" Text="下午" /></td>
                        <td><asp:CheckBox ID="CheckBox8" runat="server" Text="下午" /></td>
                        <td><asp:CheckBox ID="CheckBox9" runat="server" Text="下午" /></td>
                        <td><asp:CheckBox ID="CheckBox10" runat="server" Text="下午" /></td>
                    </tr>
                </table>
                <center>
                    <asp:Button CssClass="btn btn-info" ID="Button1" runat="server" Text="提交" />
                </center>
            </div>
        </div>
    </form>
</body>
</html>
