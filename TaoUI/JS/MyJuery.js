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