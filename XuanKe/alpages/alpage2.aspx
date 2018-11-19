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
                AllowPaging="True" CellPadding="3" Width="500px" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                HorizontalAlign="Center" onpageindexchanging="GridView1_PageIndexChanging">
                <Columns>
                    <asp:ButtonField ButtonType="Button"  CommandName="xiaxian" Text="下线" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#495A80" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066"  HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
        </div>
   </div>
    </form>
</body>
</html>
