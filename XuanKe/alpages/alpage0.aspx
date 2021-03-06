﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alpage0.aspx.cs" Inherits="alpages_alpage0" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>预约信息</title>
    <link href="/css/pagebase.css" rel="stylesheet" />
    <link href="/css/mycss.css" rel="stylesheet" />
    <style type="text/css">
        .style1 {
            background-color:#FFFFFF;
        }
        .style2 {
            background-color:#495A80;
            height:32px;
        }
        .style3 {
            width:60px;
            height:32px;
        }
        .time0 {
        }
        .time1 {
        }
        .time2 {
        }
        .time3 {
        }
        .time4 {
        }
        .time5 {
            display:none;
        }
        .time6 {
        }
        .time7 {
        }
        .time8 {
        }
        .time9 {
        }
        .class0{
            width:60px;
            display:none;
        }
        .class1{
            width:60px;
        }
        .class2{
            width:60px;
        }
        .class3{
            width:60px;
        }
        .class4{
            width:60px;
        }
        .class5{
            width:60px;
            display:none;
        }
        .class6{
            width:60px;
        }
        .class7{
            width:60px;
        }
        .class8{
            width:60px;
        }
        .class9{
            width:60px;
        }

        .auto-style1 {
            width: 60px;
        }

    </style>

</head>
<body class="bg">
    <form id="form1" runat="server">
    <div style="position:absolute;top:30px;left:100px;">
        <div style="font-size:x-large"><center>预约信息</center></div>
        <div style="width:700px;">
            <div style="float:left;">
                <asp:Button ID="Button1" CssClass="mybutton" runat="server" Text="刷新" Width="100px" OnClick="Button1_Click" />
            </div>
            <div style="float:right;">
                <asp:Button ID="Button2" CssClass="mybutton" runat="server" Text="一键排课" Width="100px" OnClick="Button2_Click" />
            </div>
        </div>

    <div style="text-align:center; color:white; position:absolute; top:90px;">
        <table border="1" style="border:solid #7f8ba6;" width="700px" >
            <tr class="style1">
                <td class="style2" style="width:100px;"></td>
                <td class="style2 class0" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label2" runat="server" Text="书法"></asp:Label>
                </td>
                <td class="style2 class1" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label3" runat="server" Text="广场舞"></asp:Label>
                </td>
                <td class="style2 class2" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label4" runat="server" Text="瑜伽"></asp:Label>
                </td>
                <td class="style2 class3" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label5" runat="server" Text="游泳"></asp:Label>
                </td>
                <td class="style2 class4" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label6" runat="server" Text="羽毛球"></asp:Label>
                </td>
                <td class="style2 class5" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label7" runat="server" Text="网球"></asp:Label>
                </td>
                <td class="style2 class6" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label8" runat="server" Text="健美"></asp:Label>
                </td>
                <td class="style2 class7" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label9" runat="server" Text="编曲"></asp:Label>
                </td>
                <td class="style2 class8" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label10" runat="server" Text="二胡"></asp:Label>
                </td>
                <td class="style2 class9" style="width:60px;">
                    <asp:Label CssClass="style3" ID="Label11" runat="server" Text="挖掘机"></asp:Label>
                </td>
            </tr>
            <tr class="time0">
                <td class="style2">星期一上午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox1" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox2" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox3" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox4" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox5" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox6" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox7" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox8" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox9" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox10" runat="server" />
                </td>
            </tr>
            <tr class="time1">
                <td class="style2">星期一下午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox11" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox12" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox13" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox14" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox15" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox16" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox17" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox18" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox19" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox20" runat="server" />
                </td>
            </tr>
            <tr class="time2">
                <td class="style2">星期二上午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox21" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox22" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox23" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox24" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox25" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox26" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox27" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox28" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox29" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox30" runat="server" />
                </td>
            </tr>
            <tr class="time3">
                <td class="style2">星期二下午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox31" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox32" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox33" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox34" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox35" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox36" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox37" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox38" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox39" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox40" runat="server" />
                </td>
            </tr>
            <tr class="time4">
                <td class="style2">星期三上午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox41" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox42" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox43" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox44" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox45" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox46" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox47" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox48" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox49" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox50" runat="server" />
                </td>
            </tr>
            <tr class="time5">
                <td class="style2">星期三下午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox51" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox52" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox53" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox54" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox55" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox56" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox57" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox58" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox59" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox60" runat="server" />
                </td>
            </tr>
            <tr  class="time6">
                <td class="style2">星期四上午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox61" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox62" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox63" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox64" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox65" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox66" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox67" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox68" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox69" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox70" runat="server" />
                </td>
            </tr>
            <tr class="time7">
                <td class="style2">星期四下午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox71" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox72" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox73" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox74" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox75" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox76" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox77" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox78" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox79" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox80" runat="server" />
                </td>
            </tr>
            <tr class="time8">
                <td class="style2">星期五上午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox81" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox82" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox83" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox84" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox85" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox86" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox87" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox88" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox89" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox90" runat="server" />
                </td>
            </tr>
            <tr class="time9">
                <td class="style2">星期五下午</td>
                <td class="style1 class0">
                    <asp:CheckBox CssClass="style3" ID="CheckBox91" runat="server" />
                </td>
                <td class="style1 class1">
                    <asp:CheckBox CssClass="style3" ID="CheckBox92" runat="server" />
                </td>
                <td class="style1 class2">
                    <asp:CheckBox CssClass="style3" ID="CheckBox93" runat="server" />
                </td>
                <td class="style1 class3">
                    <asp:CheckBox CssClass="style3" ID="CheckBox94" runat="server" />
                </td>
                <td class="style1 class4">
                    <asp:CheckBox CssClass="style3" ID="CheckBox95" runat="server" />
                </td>
                <td class="style1 class5">
                    <asp:CheckBox CssClass="style3" ID="CheckBox96" runat="server" />
                </td>
                <td class="style1 class6">
                    <asp:CheckBox CssClass="style3" ID="CheckBox97" runat="server" />
                </td>
                <td class="style1 class7">
                    <asp:CheckBox CssClass="style3" ID="CheckBox98" runat="server" />
                </td>
                <td class="style1 class8">
                    <asp:CheckBox CssClass="style3" ID="CheckBox99" runat="server" />
                </td>
                <td class="style1 class9">
                    <asp:CheckBox CssClass="style3" ID="CheckBox100" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </form>
    <script type="text/javascript" src="/js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="/js/click.js"></script>
</body>
</html>
