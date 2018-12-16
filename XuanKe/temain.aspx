<%@ Page Language="C#" AutoEventWireup="true" CodeFile="temain.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教师选课系统</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
    <script type="text/javascript" src ="js/sha.js"></script>
    
    <div id="codefans_net" style="position: absolute;visibility :hidden;z-index:2;" align="right">
        <a href="game/line.aspx" target="_blank"><img border="0" src="res/guangg.gif"></a>
        <br>
        <span style="CURSOR:hand;color:red;font-weight:bold" onclick="clearInterval(itl);obj.style.visibility = 'hidden'">关闭</span>
    </div>
    <div id="gg2" style="position:absolute;right:0;top:400px;" align="right">
        <a href="http://www.rosecat707.top:84" target="_blank"><img border="0" src="res/guangg2.gif"></a>
        <br>
        <span style="CURSOR:hand;color:red;font-weight:bold" onclick="obj2.style.visibility = 'hidden'">关闭</span>
    </div>

    <form id="form1" runat="server">

        <div class="top">
            <center>
                <div class= "bar">
                    <div style="width:98%; font-size:large; color:white;">
                        <div style="float:left;">
                            <asp:Label ID="hello" runat="server" Text="欢迎您，"></asp:Label>
                        </div>
                        <div style="float:right;width:10%;">
                            <div style="float:left;">
                            <a href="help/tehelp.html" style="color:white;" target="_blank">帮助</a>
                        </div>
                        <div style="float:right;">
                            <asp:LinkButton ID="exit" ForeColor="White" runat="server" OnClick="exit_Click">安全退出</asp:LinkButton>
                        </div>

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
                <div class="logo" id ="lg">
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
            <div id ="divf" class="right" runat="server">
                <iframe class="frame" id="mainbox" name="iframeContent" frameborder="0" width="1330px" height="700px" marginheight="0" marginwidth="0" runat="server" scrolling="no" ></iframe>
            </div>
        </div>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    
    <script>
        var xlm_wid='13954';
        var xlm_url = 'https://www.xianliao.me/';
    </script>
<script type='text/javascript' charset='UTF-8' src='https://www.xianliao.me/embed.js'></script>
    
    </form>
    <script type="text/javascript" src="js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="js/click.js"></script>
    <script type="text/javascript" src ="js/gg.js"></script> 
    <script type="text/javascript" src="js/menu.js"></script>
</body>
</html>
