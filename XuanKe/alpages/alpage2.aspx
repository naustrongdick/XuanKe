<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alpage2.aspx.cs" Inherits="pages_alpage2"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线状态</title>

    <link href="/css/pagebase.css" rel="stylesheet" />
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/mycss.css" rel="stylesheet" />

</head>
<body class="bg">
    <form id="form1" runat="server">
    <div style="position:absolute;top:30px;left:100px;">
        <div style="width:500px;font-size:large;">
            <center>
                <asp:Label ID="Label10" runat="server" Text="在线状态" Font-Size="X-Large"></asp:Label>
            </center>
        </div>
        <div style="height:15px;"></div>
        <div style="width:500px;height:50px;">
            <center>
                <asp:Button ID="Button1" runat="server" Text="刷新" CssClass="mybutton" OnClick="Button1_Click" Font-Size="Large" Height="31px" Width="95px" />
            </center>
        </div>
        <div >
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" 
                AllowPaging="True" CellPadding="4" Width="500px" 
                HorizontalAlign="Center" onpageindexchanging="GridView1_PageIndexChanging" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:ButtonField ButtonType="Button"  CommandName="xiaxian" Text="下线" >
                    <ControlStyle Width="50px" />
                    </asp:ButtonField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle ForeColor="#333333"  HorizontalAlign="Center" BackColor="#F7F6F3" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
   </div>
    </form>
    <script type="text/javascript" src="/js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="/js/click.js"></script>
</body>
</html>
