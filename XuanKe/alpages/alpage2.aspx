<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alpage2.aspx.cs" Inherits="pages_alpage2"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线状态</title>

    <link href="/css/pagebase.css" rel="stylesheet" />
    <link href="/css/bootstrap.min.css" rel="stylesheet" />

</head>
<body class="bg">
    <form id="form1" runat="server">
    <div style="position:absolute;top:30px;left:100px;">
        <div style="width:500px;font-size:large;">
            <center>
                <asp:Label ID="Label10" runat="server" Text="Label">在线状态</asp:Label>
            </center>
        </div>
        <div style="width:500px;height:50px;">
            <center>
                <asp:Button ID="Button1" runat="server" Text="刷新" OnClick="Button1_Click" Font-Size="Large" Height="31px" Width="95px" />
            </center>
        </div>
        <div >
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AllowPaging="True" CellPadding="4" Width="500px" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Center">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="xiaxian" Text="下线" />
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" HorizontalAlign="Center" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099"  HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
        </div>
        <div>
            <center>
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </center>
        </div>
   </div>
    </form>
</body>
</html>
