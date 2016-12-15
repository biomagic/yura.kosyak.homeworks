$(document).ready(function() {

	$(".categories__li:first").toggleClass("open").find(".submenu").css("display", "block");

	$(".categories__li").on('click', function(event) {
		event.preventDefault();

		if ($(this).find(".submenu").css("display") == "none") {
			$(".categories__li").removeClass("open").find(".submenu").css("display", "none");
			$(this).toggleClass("open").find(".submenu").css("display", "block");
		} else {
			$(".categories__li").removeClass("open");
			$(this).find(".submenu").css("display", "none");
		}		
	});
})
