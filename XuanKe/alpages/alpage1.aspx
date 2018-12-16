<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alpage1.aspx.cs" Inherits="pages_alpage1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>排课管理</title>
    
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/pagebase.css" rel="stylesheet" />
    <link href="/css/mycss.css" rel="stylesheet" />
    <style type="text/css">
        .style2 {
            height: 50px;
            width: 120px;
            color:white;
            background-color:#495A80;
        }
        .style1 {
            height: 50px;
            width: 120px;
            background-color:#FFFFFF;
        }
    </style>
</head>
<body class="bg">
    <form id="form1" runat="server">
    
    <div style="position:absolute;top:30px;left:100px;">
        <div style="width:900px;font-size:large;">
            <center>
                <asp:Label ID="Label10" runat="server" Text="排课管理" Font-Size="X-Large"></asp:Label>
            </center>
        </div>
        <div style="width:900px;">
                <div style="float:left;width:425px;">
                    <div style="float:left;">
                        <asp:Label ID="Label1" Font-Size="Large" runat="server" Text="Label">截止时间:&nbsp;</asp:Label>
                    </div>
                    <div style="float:left;">
                        <asp:TextBox ID="TextBox1" CssClass=" form-control" Width="200px" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div style="float:right;width:425px;">
                    <div style="float:right;">
                        <asp:TextBox ID="TextBox2" CssClass=" form-control" Width="200px" runat="server"></asp:TextBox>
                    </div>
                    <div style="float:right;">
                        <asp:Label ID="Label12" Font-Size="Large" runat="server" Text="Label">发布时间:&nbsp;</asp:Label>
                    </div>
                    
                </div>
        </div>
        <br /><br />
        <div style="text-align:center;">
                <table class="table table-hover table-bordered" style ="width:900px;">
                    <tr>
                        <td class="style2"><asp:Label ID="Label9" runat="server" Text=" 单周 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label2" runat="server" Text=" 星期一 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label3" runat="server" Text=" 星期二 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label4" runat="server" Text=" 星期三 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label8" runat="server" Text=" 星期四 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label5" runat="server" Text=" 星期五 "></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="style2"><asp:Label ID="Label7" runat="server" Text=" 上午 " Width="50px"></asp:Label></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList5" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList7" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList9" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList9_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="style2"><asp:Label ID="Label6" runat="server" Text=" 下午 "></asp:Label></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList4" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList6" CssClass="form-control" Visible="false" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList8" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList10" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList10_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                    </tr>
                </table>
        </div>
        <div style="text-align:center;">
                <table class="table table-hover table-bordered" style ="width:900px;">
                    <tr>
                        <td class="style2"><asp:Label ID="Label13" runat="server" Text=" 双周 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label14" runat="server" Text=" 星期一 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label15" runat="server" Text=" 星期二 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label16" runat="server" Text=" 星期三 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label17" runat="server" Text=" 星期四 "></asp:Label></td>
                        <td class="style2"><asp:Label ID="Label18" runat="server" Text=" 星期五 "></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="style2"><asp:Label ID="Label19" runat="server" Text=" 上午 " Width="50px"></asp:Label></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList11" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList11_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList13" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList13_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList15" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList15_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList17" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList17_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList19" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList19_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="style2"><asp:Label ID="Label20" runat="server" Text=" 下午 "></asp:Label></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList12" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList12_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList14" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList14_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList16" CssClass="form-control" Visible="false" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList16_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList18" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList18_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                        <td class="style1"><asp:DropDownList ID="DropDownList20" CssClass="form-control" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList20_SelectedIndexChanged" AutoPostBack="true" ></asp:DropDownList></td>
                    </tr>
                </table>
        </div>
        <div style ="width:900px;"> 
            <div style="float:left;">
                    <asp:Button ID="Button1" CssClass="mybutton" runat="server" Text="保存修改" Width="150px" OnClick="Button1_Click" />
            </div>
            <div style="float:right;">
                    <asp:Button ID="Button2" CssClass="mybutton" runat="server" Text="立刻发布" Width="150px" OnClick="Button2_Click" />
            </div>
        </div>
        <br /><br />
        <div style="width:900px;">
            <center>
                <asp:Label ID="Label11" runat="server" ForeColor="Black">发布前请先保存修改</asp:Label>
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
