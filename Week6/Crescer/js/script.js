$(document).ready(function() {

$(".hamburger-block").on('click', function() {
	$(".navigation").animate({
    height: "toggle"
  }, 1000);
});


function playVideo() {
	var vid = document.getElementById("myVideo");
	if(vid.paused){
		vid.play();
		$("#playBtn").css("visibility", "hidden");
	} else {
		vid.pause();
		$("#playBtn").css("visibility", "visible");
	}
}
function videoEnded() {
	$("#playBtn").css("visibility", "visible");
};

$(".video-frame").on('click', playVideo);
$("#myVideo").on('ended', videoEnded);


// Button up

    // hide #back-top first
    $("#back-top").hide();

    // fade in #back-top
    $(function() {
        $(window).scroll(function() {
            if ($(this).scrollTop() > 300) {
                $('#back-top').fadeIn();
            } else {
                $('#back-top').fadeOut();
            }
        });
        // scroll body to 0px on click
        $('#back-top a').click(function() {
            $('body,html').animate({
                scrollTop: 0
            }, 800);
            return false;
        });
    });
});