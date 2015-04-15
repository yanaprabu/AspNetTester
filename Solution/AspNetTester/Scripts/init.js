smoothScroll.init({
	speed: 1000,
	easing: 'swing',
	offset: 0,
	updateURL: true,
	callbackBefore: function (toggle, anchor) { },
	callbackAfter: function (toggle, anchor) { }
});
skrollr.init({
	forceHeight: false
});
wow = new WOW(
  {
	  animateClass: 'animated',
	  offset: 100,
	  callback: function (box) {
		  console.log("WOW: animating <" + box.tagName.toLowerCase() + ">")
	  }
  }
);
wow.init();