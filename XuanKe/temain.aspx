﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="temain.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 390px">
            <asp:TextBox ID="TextBox1" runat="server" Height="198px" Width="383px" TextMode="MultiLine"></asp:TextBox>
            <br><br>
            <asp:Button ID="exit" runat="server" Text="安全退出" onclick="exit_Click" />
        </div>
    </form>
</body>
</html>
