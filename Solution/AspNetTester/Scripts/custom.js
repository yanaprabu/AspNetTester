$(window).on('load',function(){
	
    // Hide loader and display content
    $('#loader-wrapper').fadeOut('slow', function () {
        $('.slider').fractionSlider({
            'fullWidth': true,
            'controls': true,
            'pager': true,
            'responsive': true,
            'dimensions': "1000,480",
            'increase': false,
            'pauseOnHover': false,
            'slideEndAnimation': true
        });
    });
	
});