<%@ Page Language="C#" AutoEventWireup="true" CodeFile="error.aspx.cs" Inherits="pages_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="/bootstrap/bootstrap.min.css" rel="stylesheet">
    <style>
        .bg{
            background-color:lightblue;
        }
        .mat{
            position:absolute;
            top:20%;
            left:20%;
            font-size:larger;
        }
    </style>
</head>
<body class ="bg">
    <form id="form1" runat="server">
        <div class="mat">
            <asp:Label ID="Label1" runat="server" Text="课程结果未发布。。。"></asp:Label>
        </div>
    </form>
</body>
</html>
