<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tepage1.aspx.cs" Inherits="pages_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>预约课时</title>
    <link href="/bootstrap/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .style2 {
            height: 50px;
            width: 120px;
            color:white;
            background-color:#3B200C;
        }
        .style1 {
            height: 50px;
            width: 120px;
            background-color:#DE8100;
        }

    </style>
</head>
<body style="background-color:#E9CFAE; font-family:'Microsoft YaHei UI';">
    <form id="form1" runat="server" style="width:1400;">
        <div style="position:absolute;top:30px;left:100px;width:700px;">
            <div style="width:700px;">
                
                <div style="font-size:large;width:700px;">
                    <center><asp:Label ID="Label11" runat="server" Text="Label">预约课时</asp:Label></center>
                </div>
                <div style="width:700px;">
                    <div style="font-size:large;float:left;">
                        <asp:Label ID="Ke" runat="server" Text="label">你要上的课有：</asp:Label>
                    </div>
                    <div style="font-size:large;float:right;">
                        <asp:Label ID="Label1" runat="server" Text="label">选课截止时间：</asp:Label>
                    </div>
                </div>
                <div style="font-size:large;width:700px;float:left;">
                    <center><asp:Label ID="Label10" runat="server" Text="Label">请根据自身安排选择空闲时间，系统将根据预约结果安排课程。</asp:Label></center>
                </div>
                
            </div>
            <div>
                <div style="text-align:center;">
                <table class="table table-hover table-bordered" style ="width:600px;">
                    <tr>
                        <td class="style2"></td>
                        <td class="style2"><asp:Label ID="Label2" runat="server" Text=" 星期一 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label3" runat="server" Text=" 星期二 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label4" runat="server" Text=" 星期三 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label8" runat="server" Text=" 星期四 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label5" runat="server" Text=" 星期五 "></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="style2"><asp:Label ID="Label7" runat="server" Text=" 上午 " Width="50px"></asp:Label></td>
                        <td class="style1">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="120px"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList3" runat="server" Width="120px"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList5" runat="server" Width="120px"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList7" runat="server" Width="120px"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList9" runat="server" Width="120px"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="style2"><asp:Label ID="Label6" runat="server" Text=" 下午 "></asp:Label></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList2" runat="server" Width="120px"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList4" runat="server" Width="120px"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList6" runat="server" Width="120px"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList8" runat="server" Width="120px"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList10" runat="server" Width="120px"></asp:DropDownList></td>
                    </tr>
                </table>
                </div>
                <div>
                <center>
                    <div><asp:Button CssClass="btn btn-info" ID="Button1" runat="server" Text="提交" 
                        onclick="Button1_Click" /></div>
                    <div style="color:red; font-size:large"><asp:Label ID="Label9" runat="server" Text=""></asp:Label></div>
                </center>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
