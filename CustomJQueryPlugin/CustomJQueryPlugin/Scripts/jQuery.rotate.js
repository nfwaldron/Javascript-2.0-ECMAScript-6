(function ($) {
    $.fn.rotate = function()
    {

        var settings = $.extend({
            degrees: 20
        });


        this.click('click', function (e) {
            e.target.style.transform = 'rotate(45deg)';
        });
        return this;
    }

})(jQuery);