<%@ Page Language="C#" AutoEventWireup="true" CodeFile="temain.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教师选课系统</title>
    <script type="text/javascript" src="js/adapter.js"></script>

    <link href="css/base.css" rel="stylesheet" />
    <link href="css/menu.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/mainpage.css" rel="stylesheet" />
    <style type="text/css">
        .top {
            background-image:url("bg/bg3.png");
        }
        #Button1 {
            height: 40px;
        }
    </style>  

</head>
<body style="font-family:'Microsoft YaHei UI';">
    <script type="text/javascript" src ="js/canvas-nest.min.js" count="250" zindex="-2" opacity="0.9" color="77,21,125"></script>
    <form id="form1" runat="server">

        <div class="top">
            <center>
                <div class= "bar">
                    <div style="width:98%; font-size:large; color:white;">
                        <div style="float:left;">
                            <asp:Label ID="hello" runat="server" Text="欢迎您，"></asp:Label>
                        </div>
                        <div style="float:right;">
                            <asp:LinkButton ID="exit" ForeColor="White" runat="server" OnClick="exit_Click">安全退出</asp:LinkButton>
                        </div>
                        <div id="time">
                        </div>
                   </div>
                </div>
                <script type="text/javascript">
                    function time() {
                        var vWeek, vWeek_s, vDay;
                        vWeek = ["星期天", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六"];
                        var date = new Date();
                        year = date.getFullYear();
                        month = date.getMonth() + 1;
                        day = date.getDate();
                        hours = date.getHours();
                        minutes = date.getMinutes();
                        seconds = date.getSeconds();
                        vWeek_s = date.getDay();
                        document.getElementById("time").innerHTML = year + "年" + month + "月" + day + "日" + "\t" + hours + ":" + minutes + ":" + seconds + "\t" + vWeek[vWeek_s];

                    };
                    setInterval("time()", 1000);
                </script>
                <div class="logo">
                    <img alt="" src="bg\logo.png" style="height: 80px; width: 423px" />
                </div>
            </center>
        </div>

        <div style="height:10px;"></div>
        <div style="width:1600px;">
        <div class="left">
            <div id="menu">
            <div id="open">
                <div class="navH">
                    教师选课
                </div>
            <div class="navBox">
                <ul>
                    <li>
                        <h2 class="obtain">教师选课<i></i></h2>
                        <div class="secondary">
                            <h3 id="kbjg">课表结果</h3>
                            <h3 id="yyks">预约课时</h3>
                        </div>
                    </li>
                    <li>
                        <h2 class="obtain">账户管理<i></i></h2>
                        <div class="secondary">
                            <h3 id="xxwh">信息维护</h3>
                            <h3 id="xgmm">修改密码</h3>
                        </div>
                    </li>
                </ul>
            </div>
            </div>
        </div>
        </div>
        
        <div style="float:left;width:10px;height:700px;"></div>
            <div id ="divf" class="dis right" runat="server">
                <iframe class="frame" id="mainbox" name="iframeContent" frameborder="0" width="1330px" height="700px" marginheight="0" marginwidth="0" runat="server" ></iframe>
            </div>
        </div>
    <div style="position:absolute;right:10px;bottom:10px; width: 128px;">
        <input id="Button1" type="button" value="不如玩个游戏吧" style="background-color:deeppink;color:aqua;height:43px; width:128px;" onclick="window.open('game.html');" />
    </div>
    </form>
    
    <script type="text/javascript" src="js/menu.js"></script>
</body>
</html>
