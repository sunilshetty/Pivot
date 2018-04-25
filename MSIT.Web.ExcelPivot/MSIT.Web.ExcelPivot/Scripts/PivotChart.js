$(function () {
    $('.arrow').click(function (obj) {
        if ($("#div" + obj.target.id.replace("img", "")).css("display") != "none") {
            $("#div" + obj.target.id.replace("img", "")).hide("slide", { direction: "left" }, 1000);
            $("#" + obj.target.id).css("display", "block");
        }else
        {
            $("#div" + obj.target.id.replace("img", "")).show("slide", { direction: "left" }, 1000);
            $("#" + obj.target.id).css("display", "none");
        }
    })
})