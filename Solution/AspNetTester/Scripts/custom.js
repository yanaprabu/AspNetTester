$(window).on('load',function(){
	
	// display sidemenu
	$('.hide-menu').on('click',function(e){
		e.preventDefault();
		$('.side-hide').stop().animate({
			right: '-240px'
		},{
			duration: 300,
			complete: function(){
				$('.show-menu').fadeIn();
			}
		}).removeClass('side-hide');
	});
	$('.show-menu').on('click',function(e){
		e.preventDefault();
		$('.sidemenu').stop().animate({
			right: '0px'
		},{
			duration: 300,
			complete: function(){
				$('.show-menu').fadeOut();
			}
		}).addClass('side-hide');
	});
	$(window).on('scroll', function() {
		var scrollTop = $(this).scrollTop();

		$('.white-bg').each(function() {
			var topDistance = $(this).offset().top;

			if ( (topDistance+100) < scrollTop ) {
				$('.side-hide').stop().animate({
					right: '0px'
				},{
					duration: 300,
					complete: function(){
						$('.show-menu').fadeOut();
					}
				});
			} else {
				$('.side-hide').stop().animate({
					right: '-190px'
				},{
					duration: 300,
					complete: function(){
						$('.show-menu').fadeIn();
					}
				});
			}
		});
	});
	// display sidemenu end
	
	// Hide loader and display content
    $('#loader-wrapper').fadeOut('fast', function () {
        $('.slider').fractionSlider({
			'slideTransitionSpeed' : 500,
            'fullWidth': false,
            'controls': true,
            'pager': true,
            'responsive': false,
            'dimensions': "1440,690",
            'increase': true,
            'pauseOnHover': false,
            'slideEndAnimation': true,
			'speedOut' : 300,
        });
    });

});