!function (t, n, a) {

    function e(t, e) {
        var o = n.createElement(a);
        o.async = !0, o.src = t, o.id = e, l(o, r);
        var c = n.getElementsByTagName(a)[0]; c.parentNode.insertBefore(o, c)
    }
    function o() { var n = t.UA_Opt || UA_Opt; return n.LogVal ? t[n.LogVal] || "" : "" }
    function r() { var t = setTimeout(function () { o() ? (clearTimeout(t), UA_Opt.callback && UA_Opt.callback()) : r() }, 100) }
    function c(t) { return "file:" === location.protocol && /^\/\//.test(t) && (t = "https:" + t), t }
    function l(t, n) {
        function a() { t.onreadystatechange = t.onload = null, t = null, p(n) && n({ from: "script" }) }
        if ("onload" in t) t.onload = a;
        else {
            var e = function () { /loaded|complete/.test(t.readyState) && a() }; t.onreadystatechange = e, e()
        }
    }
    function i(t) { return function (n) { return {}.toString.call(n) == "[object " + t + "]" } }
    var u = 999, s = c("105.js"/*tpa=https://aeu.alicdn.com/js/cj/105.js*/), d = c("99.js"/*tpa=https://aeu.alicdn.com/js/cj/99.js*/), f = "sd-collina-acjs", p = (Array.isArray || i("Array"), i("Function"));
    Math.ceil(1e4 * Math.random()) <= u ? e(s, f) : e(d, f), t.UA_Opt && !UA_Opt.reload && (UA_Opt.reload = function () { }), t.acjs = 1
}(window, document, "script");
