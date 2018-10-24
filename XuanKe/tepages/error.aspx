<%@ Page Language="C#" AutoEventWireup="true" CodeFile="error.aspx.cs" Inherits="pages_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width",initial-scale="1.0,minimun-scale=0.5,maximun-scale=2.0,user-scalable=yes" />
    <title>未发布</title>
    <link href="/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/pagebase.css" rel="stylesheet" />
    <style type="text/css">
        
        .mat{
            position:absolute;
            top:30px;
            left:100px;
            font-size:larger;
            font-family:'Microsoft YaHei UI';
            font-size:x-large;
        }
    </style>
</head>
<body class ="bg">
    <form id="form1" runat="server">
        <div class="mat">
            <div>
                <asp:Label ID="Label1" runat="server" Text="课程结果未发布。。。"></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
