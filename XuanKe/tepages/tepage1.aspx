<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tepage1.aspx.cs" Inherits="pages_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>预约选课</title>
    <link href="/bootstrap/bootstrap.min.css" rel="stylesheet">
    <style type="text/css">
        .auto-style1 {
            height: 50px;
            width: 120px;
        }
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
            <asp:Label ID="Label1" runat="server" Text="Label">预约选课</asp:Label>
            <div>
                <asp:Label ID="Ke" runat="server" Text="你要上的课有："></asp:Label>
            </div>
            <div class="mat">
                <table class="table table-hover table-bordered" style ="width:650px;background-color:lightpink;">
                    <tr>
                        <td class="auto-style1"></td>
                        <td class="auto-style1"><asp:Label ID="Label2" runat="server" Text=" 星期一 "></asp:Label></td>
                        <td class="auto-style1"><asp:Label ID="Label3" runat="server" Text=" 星期二 "></asp:Label></td>
                        <td class="auto-style1"><asp:Label ID="Label4" runat="server" Text=" 星期三 "></asp:Label></td>
                        <td class="auto-style1"><asp:Label ID="Label8" runat="server" Text=" 星期四 "></asp:Label></td>
                        <td class="auto-style1"><asp:Label ID="Label5" runat="server" Text=" 星期五 "></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:Label ID="Label7" runat="server" Text=" 上午 " Width="50px"></asp:Label></td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem>
                            </asp:DropDownList></td>
                        <td class="auto-style1"><asp:DropDownList ID="DropDownList2" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem></asp:DropDownList></td>
                        <td class="auto-style1"><asp:DropDownList ID="DropDownList3" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem></asp:DropDownList></td>
                        <td class="auto-style1"><asp:DropDownList ID="DropDownList4" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem></asp:DropDownList></td>
                        <td class="auto-style1"><asp:DropDownList ID="DropDownList5" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:Label ID="Label6" runat="server" Text=" 下午 "></asp:Label></td>
                        <td class="auto-style1"><asp:DropDownList ID="DropDownList6" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem></asp:DropDownList></td>
                        <td class="auto-style1"><asp:DropDownList ID="DropDownList7" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem></asp:DropDownList></td>
                        <td class="auto-style1"><asp:DropDownList ID="DropDownList8" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem></asp:DropDownList></td>
                        <td class="auto-style1"><asp:DropDownList ID="DropDownList9" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem></asp:DropDownList></td>
                        <td class="auto-style1"><asp:DropDownList ID="DropDownList10" runat="server" Width="120px">
                                <asp:ListItem Selected="True">两节课都行</asp:ListItem>
                                <asp:ListItem>两节课都不行</asp:ListItem></asp:DropDownList></td>
                    </tr>
                </table>
                <center>
                    <asp:Button CssClass="btn btn-info" ID="Button1" runat="server" Text="提交" 
                        onclick="Button1_Click" />
                </center>
            </div>
        </div>
    </form>
</body>
</html>
