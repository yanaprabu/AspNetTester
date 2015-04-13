$(window).on('load',function(){
	
	$('.slider').fractionSlider({
		'fullWidth': 			true,
		'controls': 			true, 
		'pager': 				true,
		'responsive': 			true,
		'dimensions': 			"1000,480",
	    'increase': 			false,
		'pauseOnHover': 		false,
		'slideEndAnimation': 	true
	});

});