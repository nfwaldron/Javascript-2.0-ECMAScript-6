var numbers = [3, 4, 6, 5, 7, 8, 12, 14];

// The fat arrow notation is used to create a filter function that returns the even numbers
// in an array.
var evens = numbers.filter(function (item) {
    return item % 2 == 0;
});

console.log(evens);

var ProductModule;
(function (ProductModule) {
    // The _calculateTax method is private
    function _calculateTax(price) {
        return price * 0.8;
    }

    //exports
    //
    function calculatePrice(price) {
        return price + _calculateTax(price);
    }
    ProductModule.calculatePrice = calculatePrice;
})(ProductModule || (ProductModule = {}));

var price = ProductModule.calculatePrice(100.00);
//# sourceMappingURL=script.js.map
