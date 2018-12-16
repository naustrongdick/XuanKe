
window.onload = function () {
    var flag = true;
    var liC = document.querySelectorAll(".navBox li h2");
    var av = true;
    var str = document.getElementById("HiddenField1").value;

    // 主导航nav点击事件
    for (var i = 0; i < liC.length; i++) {
        liC[i].onclick = function () {
            if (flag) {
                // 节流阀
                flag = false;
                setTimeout(function () {
                    flag = true;
                }, 500)
                // 自点
                if (this.className === "obFocus") {
                    this.querySelector("i").classList.remove("arrowRot");
                    getNext(this).style.height = "0";
                    this.classList.add("obtain");
                    this.classList.remove("obFocus");
                    return
                }

                var sec = getNext(this);
                var sib = siblings(sec.parentNode);
                var otherArr = [];
                var arrowClass = [];
                // 排他 secondary arrowRot obFocus
                for (var j = 0; j < sib.length; j++) {
                    var sibSec = sib[j].getElementsByTagName('*');
                    for (var i = 0; i < sibSec.length; i++) {
                        if (sibSec[i].className == "secondary") {
                            otherArr.push(sibSec[i])
                        }
                        if (sibSec[i].className == "arrowRot") {
                            arrowClass.push(sibSec[i])
                        }
                        if (sibSec[i].className == "obFocus") {
                            sibSec[i].classList.remove("obFocus");
                            sibSec[i].classList.add("obtain");

                        }
                    }
                }
                for (var i = 0; i < otherArr.length; i++) {
                    otherArr[i].style.height = "0";
                }
                if (arrowClass[0]) {
                    arrowClass[0].classList.remove("arrowRot");
                }

                // 留自己
                sec.style.height = 2.5078 + "rem";
                this.getElementsByTagName("i")[0].classList.add("arrowRot");
                this.classList.remove("obtain");
                this.classList.add("obFocus");
            }

        }
    }
    var logo = document.getElementById("lg");
    logo.onclick = function () {
        if (av == false) {
            av = true;
            document.getElementById("mainbox").src = str;
        }
        else {
            document.getElementById("mainbox").contentWindow.location.reload(true);
        }
    }


    // 子导航点击事件
    var seconC = document.querySelectorAll(".secondary h3");
    var div = document.getElementById("divf");
    for (var i = 0; i < seconC.length; i++) {
        seconC[i].onclick = function () {
            for (var i = 0; i < seconC.length; i++) {
                seconC[i].classList.remove("seconFocus");
            }
            this.classList.add("seconFocus");
            //div.classList.remove("dis");
            var txt = this.id;
            switch (txt) {
                case "kbjg": document.getElementById("mainbox").src = "tepages/tepage2.aspx"; av = false;break;
                case "yyks": document.getElementById("mainbox").src = "tepages/tepage1.aspx"; av = false;break;
                case "xxwh": document.getElementById("mainbox").src = "tepages/tepage3.aspx"; av = false;break;
                case "xgmm": document.getElementById("mainbox").src = "tepages/tepage4.aspx"; av = false;break;
                case "yyxx": document.getElementById("mainbox").src = "alpages/alpage0.aspx"; av = false;break;
                case "pkgl": document.getElementById("mainbox").src = "alpages/alpage1.aspx"; av = false;break;
                case "zxzt": document.getElementById("mainbox").src = "alpages/alpage2.aspx"; av = false;break;
                case "tjzh": document.getElementById("mainbox").src = "alpages/alpage3.aspx"; av = false;break;
            }
            
        }
    }
    
    
}

function getByClass(clsName, parent) {
    var oParent = parent ? document.getElementById(parent) : document,
        boxArr = new Array(),
        oElements = oParent.getElementsByTagName('*');
    for (var i = 0; i < oElements.length; i++) {
        if (oElements[i].className == clsName) {
            boxArr.push(oElements[i]);
        }
    }
    return boxArr;
}
// 获取下一个兄弟元素
function getNext(node) {
    if (!node.nextSibling) return null;
    var nextNode = node.nextSibling;
    if (nextNode.nodeType == 1) {
        return nextNode;
    }
    return getNext(node.nextSibling);
}

// 获取除了自己以外的其他亲兄弟元素
function siblings(elem) {
    var r = [];
    var n = elem.parentNode.firstChild;
    for (; n; n = n.nextSibling) {
        if (n.nodeType === 1 && n !== elem) {
            r.push(n);
        }
    }
    return r;
}