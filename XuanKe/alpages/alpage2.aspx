<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alpage2.aspx.cs" Inherits="pages_alpage3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#E9CFAE; font-family:'Microsoft YaHei UI';>
    <form id="form1" runat="server">
    <div style="position:absolute;top:30px;left:100px;">
    <div style="text-align:center;">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" GridLines="None" OnRowCommand="GridView1_RowCommand" Width="400px" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Btn_Operation" HeaderText="下线" Text="下线" />
            </Columns>
            <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </div>
    <div>
        <center>
        <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
        </center>
    </div>
    </div>
    </form>
</body>
</html>
