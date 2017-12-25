$(document).ready(function () {
    var timer;
    $("#cityName").bind("click", function () {
      
        $("#cityList").css("display", "block");
      
      
    });

  
    
    $("#cityList").bind("mouseover", function () {
      
        $("#cityList").css("display", "block");
   
    });

    $("#cityList").bind("mouseout", function () {
      
        $("#cityList").css("display", "none");

    });


    $(".tab-control-item").click( // When a top menu item is clicked...
        function () {
          
            $(this).parents('.tab-control').children().removeClass("current");
            //$(this).addClass("current").parent.siblings().children().removeClass("current");
            $(this).addClass("current");
            if ($("#fucture").hasClass("current")) {
                $("#ContentPlaceHolder1_list_Hot").css("display", "none");
                $("#ContentPlaceHolder1_list_future").css("display", "block");
            }
            if ($("#Hot").hasClass("current"))
            {
                $("#ContentPlaceHolder1_list_Hot").css("display", "block");
                $("#ContentPlaceHolder1_list_future").css("display", "none");
            }
        }
    );
  

    $(".lili").hover(
        function () {
        //alert("vjhvbjhgbvhg");
        $(this).parent().children().removeClass("current");
        $(this).addClass("current");
        })
    $(".lili2").hover(
      function () {
          //alert("vjhvbjhgbvhg");
          $(this).parent().children().removeClass("current");
          $(this).addClass("current");
      })
});