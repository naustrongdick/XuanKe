var a_idx = 0;
jQuery(document).ready(function ($) {
    $(document).click(function (e) {
        var a = new Array("ヾ(≧O≦)〃嗷~", "(っ*´Д`)っ", "ο(=•ω＜=)ρ⌒☆", "Ｏ(≧口≦)Ｏ", "┑(￣Д ￣)┍", "(つω｀)～", "(๑•̀ㅂ•́)و✧", "(ˉ▽￣～) 切~~", "Σ(っ °Д °;)っ", "o( =•ω•= )m", "(*/ω＼*)", "╥﹏╥...");
        var $i = $("<span/>").text(a[a_idx]);
        a_idx = (a_idx + 1) % a.length;
        var x = e.pageX,
            y = e.pageY;
        $i.css({
            "z-index": 999999999999999999999999999999999999999999999999999999999999999999999,
            "top": y - 20,
            "left": x,
            "position": "absolute",
            "font-weight": "bold",
            "color": "#ff6651"
        });
        $("body").append($i);
        $i.animate({
            "top": y - 180,
            "opacity": 0
        },
            1500,
            function () {
                $i.remove();
            });
    });
});