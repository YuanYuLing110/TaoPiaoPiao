$(function () {
    alert("开始");
    $("#cityName").mouseover(function () {
        //取得鼠标指向小图片的路径:src
        //$("#cityList").attr("display", "none");
        //$("#cityList").css("display", "none");
        //$(this).css("font-size", "24px");
        alert("选中");
        //$("#largepic").attr("src", src);
        //$(this).css("border", "1px solid #ff0000");
    })

    $("#cityName").mouseout(function () {
        $("#cityList").attr("display", "block");
    })
})