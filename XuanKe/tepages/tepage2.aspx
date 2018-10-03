<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tepage2.aspx.cs" Inherits="pages_tepage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>课表结果</title>
    <link href="/bootstrap/bootstrap.min.css" rel="stylesheet">
    <style>
        .bg{
            background-color:#E9CFAE; 
            font-family:'Microsoft YaHei UI';
        }
        .style2 {
            color:white;
            background-color:#3B200C;
        }
        .style1 {
            background-color:#DE8100;
        }
    </style>
</head>
<body class ="bg">
    <form id="form1" runat="server">
        <div style="position:absolute;top:30px;left:100px;width:700px;">
            <div style="font-size:large;width:700px;">
                <center><asp:Label ID="Label1" runat="server" Text="Label">课表结果</asp:Label></center>
            </div>
            <div style="font-size:large;width:700px;">
                <div style="float:left;">
                    <asp:Label ID="Label17" runat="server" Text="Label">您的课程安排如下：</asp:Label>
                </div>
            </div>
            <div>
                <table class="table table-striped table-hover table-bordered" style ="width:700px;">
                    <tr>
                        <td class =" style2"><asp:Label ID="Label2" runat="server" Text="课程"></asp:Label></td>
                        <td class =" style2"><asp:Label ID="Label3" runat="server" Text="时间"></asp:Label></tdc>
                        <td class =" style2"><asp:Label ID="Label4" runat="server" Text="地点"></asp:Label></td>
                        <td class =" style2"><asp:Label ID="Label5" runat="server" Text="上课人数"></asp:Label></td>
                        <td class =" style2"><asp:Label ID="Label6" runat="server" Text="学分"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class =" style1"><asp:Label ID="Label7" runat="server"></asp:Label></td>
                        <td class =" style1"><asp:Label ID="Label8" runat="server"></asp:Label></td>
                        <td class =" style1"><asp:Label ID="Label9" runat="server"></asp:Label></td>
                        <td class =" style1"><asp:Label ID="Label10" runat="server"></asp:Label></td>
                        <td class =" style1"><asp:Label ID="Label11" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class =" style1"><asp:Label ID="Label12" runat="server"></asp:Label></td>
                        <td class =" style1"><asp:Label ID="Label13" runat="server"></asp:Label></td>
                        <td class =" style1"><asp:Label ID="Label14" runat="server"></asp:Label></td>
                        <td class =" style1"><asp:Label ID="Label15" runat="server"></asp:Label></td>
                        <td class =" style1"><asp:Label ID="Label16" runat="server"></asp:Label></td>
                    </tr>
                </table>
            </div>
            
            <div>
                <div style="float:right;">
                    <asp:Label ID="Label18" runat="server" Text="Label">对课程安排有任何疑议，可联系：10086</asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
