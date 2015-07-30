(function ($) {
    $.fn.dropShadow = function ()
    {
        this.on('click', function (e)
        {
            //debugger
            // You can wrap any element and transform it into a 
            // jQuery wrapset.
            $(e.target).css('boxShadow', '50px 50px 50px 5px black');
        })

        return this;
    }
})(jQuery);