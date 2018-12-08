<%@ Page Language="C#" AutoEventWireup="true" CodeFile="line.aspx.cs" Inherits="game_line" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:1330px;position:absolute;left:200px;top:100px;background-color:cadetblue">
    <center>
    <div style="width:1000px;">
                <div style="float:left">
                    <h3 style="-webkit-user-select: none" id="tdisp"> </h3>
                    <canvas id="canvas" style="position: relative; background: white; margin-left: auto; margin-right: auto; -webkit-box-shadow: #ccc 0px 0px 4px; -moz-box-shadow: #ccc 0px 0px 4px; -o-box-shadow: #ccc 0px 0px 4px; box-shadow: #ccc 0px 0px 4px" width="500" height="500" >Error - Your browser does not support HTML5 Canvas!</canvas>
                    <div style="width: 500px; margin: 10px auto;text-align:center">
                        <input type="button" value="开始新游戏" id="ngbtn" />
                    </div>
                </div>
                <script type="text/javascript" src="../js/lines.js"></script>
                
                    <div style="width:500px;float:right;">
                        <div>
                            <h2>解开绳子</h2>
                            <ul><li>通过鼠标扯动蓝色的点，来理清出绳子之间的关系，成功让所有的绳子不重叠为胜利！</li></ul>
                            <ul><li>觉得这一个太难，需要跳过，只需要点击“开始新游戏”即可随机开启下一个。</li></ul>
                        </div>
                        <div>
                            <table border="1" >
                                <tr style="height:30px;">
                                    <td style="width:100px;">排名</td>
                                    <td style="width:100px;">姓名</td>
                                    <td style="width:100px;">时间</td>
                                </tr>
                                <tr style="height:30px;">
                                    <td>第一名</td>
                                    <td><asp:Label ID="Label1" runat="server" Text="-"></asp:Label></td>
                                    <td><asp:Label ID="Label2" runat="server" Text="-"></asp:Label></td>
                                </tr>
                                <tr style="height:30px;">
                                    <td>第二名</td>
                                    <td><asp:Label ID="Label3" runat="server" Text="-"></asp:Label></td>
                                    <td><asp:Label ID="Label4" runat="server" Text="-"></asp:Label></td>
                                </tr>
                                <tr style="height:30px;">
                                    <td>第三名</td>
                                    <td><asp:Label ID="Label5" runat="server" Text="-"></asp:Label></td>
                                    <td><asp:Label ID="Label6" runat="server" Text="-"></asp:Label></td>
                                </tr>
                                <tr style="height:30px;">
                                    <td>第四名</td>
                                    <td><asp:Label ID="Label7" runat="server" Text="-"></asp:Label></td>
                                    <td><asp:Label ID="Label8" runat="server" Text="-"></asp:Label></td>
                                </tr>
                                <tr style="height:30px;">
                                    <td>第五名</td>
                                    <td><asp:Label ID="Label9" runat="server" Text="-"></asp:Label></td>
                                    <td><asp:Label ID="Label10" runat="server" Text="-"></asp:Label></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    
        </div>
    </center>
    </div>
        <div style="display:none;">
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </div>
    </form>
</body>
</html>
