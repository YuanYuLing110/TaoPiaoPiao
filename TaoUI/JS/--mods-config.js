!function (a)
{
    var e = Math.floor((+new Date + 432e5) / 864e5), l = "//g.alicdn.com/kissy/k/1.3.2", o = function () { return !!~location.hostname.indexOf("https://g.alicdn.com/life/pc-movie/1.0.34/daily.taobao.net") };
    a.config({ combine: !a.Config.debug, packages: [{ name: "tbc/mtop", path: "//g.alicdn.com/tbc/mtop/0.1.8", ignorePackageNameInUri: !0 }, { name: "jbc", path: o() ? "//g-assets.daily.taobao.net/ju/" : "//g.alicdn.com/ju/", ignorePackageNameInUri: !0, tag: e }, { name: "fkbc", path: o() ? "//g-assets.daily.taobao.net/tbc/" : "//g.alicdn.com/tbc/", ignorePackageNameInUri: !0, tag: e }, { name: "kg", path: o() ? "//g-assets.daily.taobao.net/kg/" : "//g.alicdn.com/kg/", ignorePackageNameInUri: !0, tag: e }, { name: "ub", path: o() ? "//g-assets.daily.taobao.net/ju/ub/1.0.2/" : "//g.alicdn.com/ju/ub/1.0.2/", ignorePackageNameInUri: !0, debug: !0 }, { name: "mvc", path: l }, { name: "template", path: l }, { name: "lazyload", path: l }], modules: { "jbc/julogin": { alias: ["jbc/julogin/1.0.7/"] }, "jbc/jupopup": { alias: ["jbc/jupopup/v1/box"] }, "jbc/ju-countdown": { alias: ["jbc/ju-countdown/1.1.4/"] }, "jbc/julottery": { alias: ["jbc/julottery/1.0.8/"] }, "jbc/ju-elevator": { alias: ["jbc/ju-elevator/1.0.16/"] }, "jbc/juhistory": { alias: ["jbc/juhistory/1.0.5/"] }, "jbc/jufav": { alias: ["jbc/jufav/1.0.20/"] }, "jbc/julog": { alias: ["jbc/julog/1.0.3/"] }, "jbc/juseek": { alias: ["jbc/juseek/1.0.5/"] } } }), 1.4 <= a.version && a.config({
        modules: {
            sizzle: { alias: ["node"] }, calendar: { alias: ["gallery/calendar-deprecated/1.0/"] }, switchable: { alias: ["gallery/switchable/1.3.1/"] }, imagezoom: { alias: ["gallery/imagezoom/1.0/"] }, waterfall: { alias: ["gallery/waterfall/1.0/"] }, flash:
                { alias: ["gallery/flash/1.0/"] }
        }
    }), a.ready(function () { a.use("DepartureLayer.css"/*tpa=https://g.alicdn.com/life/pc-movie/1.0.34/gallery/DepartureLayer/1.0/index, gallery/DepartureLayer/1.0/DepartureLayer.css*/, function (a, e) { var l = new e({ browser: [{ browser: "ie", maxversion: "6" }] }); l.show() }) })
}(KISSY);