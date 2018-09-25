<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tepage2.aspx.cs" Inherits="pages_tepage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>课表结果</title>
    <link href="/bootstrap/bootstrap.min.css" rel="stylesheet">
    <style>
        .bg{
            background-color:#FFF0F5;
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
            <asp:Label ID="Label1" runat="server" Text="Label">课表结果</asp:Label>
            <div class="mat">
                <table class="table table-striped table-hover table-bordered" style ="width:700px;">
                    <tr>
                        <td><asp:Label ID="Label2" runat="server" Text="课程"></asp:Label></td>
                        <td><asp:Label ID="Label3" runat="server" Text="时间"></asp:Label></td>
                        <td><asp:Label ID="Label4" runat="server" Text="地点"></asp:Label></td>
                        <td><asp:Label ID="Label5" runat="server" Text="上课人数"></asp:Label></td>
                        <td><asp:Label ID="Label6" runat="server" Text="学分"></asp:Label></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label7" runat="server"></asp:Label></td>
                        <td><asp:Label ID="Label8" runat="server"></asp:Label></td>
                        <td><asp:Label ID="Label9" runat="server"></asp:Label></td>
                        <td><asp:Label ID="Label10" runat="server"></asp:Label></td>
                        <td><asp:Label ID="Label11" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label12" runat="server"></asp:Label></td>
                        <td><asp:Label ID="Label13" runat="server"></asp:Label></td>
                        <td><asp:Label ID="Label14" runat="server"></asp:Label></td>
                        <td><asp:Label ID="Label15" runat="server"></asp:Label></td>
                        <td><asp:Label ID="Label16" runat="server"></asp:Label></td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
