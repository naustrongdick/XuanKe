var x = 1000, y = 800
var xin = true, yin = true
var step = 1
var delay = 1
var obj = document.getElementById("codefans_net")
function w() {
    var width = 0;
    if (document.documentElement && document.documentElement.clientWidth) {
        width = document.documentElement.clientWidth;
    }
    else if (document.body && document.body.clientWidth) {
        width = document.body.clientWidth;
    }
    else if (window.innerWidth) {
        width = window.innerWidth - 18;
    }
    return width;
} function h() {
    var height = 0;
    if (window.innerHeight) {
        height = window.innerHeight - 18;
    }
    else if (document.documentElement && document.documentElement.clientHeight) {
        height = document.documentElement.clientHeight;
    }
    else if (document.body && document.body.clientHeight) {
        height = document.body.clientHeight;
    }
    return height;
} function floath() {
    L = T = 0
    var R = w() - obj.offsetWidth
    var B = h() - obj.offsetHeight
    obj.style.left = x + document.body.scrollLeft + "px"
    obj.style.top = y + document.body.scrollTop + "px"
    x = x + step * (xin ? 1 : -1)
    if (x < L) { xin = true; x = L }
    if (x > R) { xin = false; x = R }
    y = y + step * (yin ? 1 : -1)
    if (y < T) { yin = true; y = T }
    if (y > B) { yin = false; y = B }
}
obj.style.visibility = "visible"
var itl = setInterval("floath()", delay)
obj.onmouseover = function () { clearInterval(itl) }
obj.onmouseout = function () { itl = setInterval("floath()", delay) } 