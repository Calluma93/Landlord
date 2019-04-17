require('intersection-observer');
import './scss/index.scss';
import 'bootstrap';
import 'lightgallery';
import 'slick-carousel';
var $ = require("jquery");

//###### Lazy Load Images ######\\

$(document).ready(function ($) {
	
	var imageObserver = new IntersectionObserver(
		function(entries, observer) {
			var i;
	
			for( i = 0; i < entries.length; i++) {
				var entry = entries[i];
				if (entry.isIntersecting) {
					var image = entry.target;
					image.src = image.dataset.src;
					image.classList.remove("lazy");
					imageObserver.unobserve(image);
				}
			}
		},
		{
			rootMargin: "0px 0px 120px 0px"
		}
	);
	
	$('.lazy').each(function(i, element) {
		imageObserver.observe(element);
	});

	$('.hamburger').click(function () {
		$('.menu').toggleClass('show');
    });

    if ($('.mobile-headings').is(':hidden'))
    {
        $(".gallery-images").removeClass("carousel");
    }

    if ($('.mobile-headings').is(':visible'))
    {
        $(".gallery-images").removeClass("lightgallery");
	}

	$(".menu-link-wrapper").click(function(e) {

		if ($(this).parents('.has-children').length && window.matchMedia("(max-width: 768px)").matches) {
			e.preventDefault();
			$(this).next().toggle();
		}
	});
	
	$(".sub-menu-list-item").click(function() {
		var open = "open-product-sub-menu-container";

		var subMenu = $(this).find("ul");

		if(subMenu.hasClass(open)) {
			$(this).removeClass("open-sub-menu-list-item");
			subMenu.removeClass(open);
		}
		else {
			$("ul").removeClass(open);
			$(".sub-menu-list-item").removeClass("open-sub-menu-list-item");
			subMenu.addClass(open);
			$(this).addClass("open-sub-menu-list-item");
		}
	});

    $('.carousel').slick({
        responsive: [{
            breakpoint: 769,
            settings: {
                slidesToShow: 1,
                slidesToScroll: 1,
                infinite: true,
                arrows: true
            }
        }]
    });

	$(".lightgallery").lightGallery(); 
	
	lazyLoading();

});