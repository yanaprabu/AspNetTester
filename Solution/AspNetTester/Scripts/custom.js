$(window).on('load',function(){
	
    $('#loader-wrapper').fadeOut('slow', function () {
        $('#page-wrapper').fadeIn('slow');
        function winHeight(el) {
            $(el).css('height', $(window).height());
        }

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