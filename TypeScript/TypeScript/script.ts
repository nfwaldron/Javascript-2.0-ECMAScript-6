var numbers = [3, 4, 6, 5, 7, 8, 12, 14];

// The fat arrow notation is used to create a filter function that returns the even numbers
// in an array.
var evens = numbers.filter(item=> item % 2 == 0);

console.log(evens);

module ProductModule {

    // The _calculateTax method is private
    function _calculateTax(price: number) : number {
        return price * 0.8;
    }

    //exports
    // 
    export function calculatePrice(price: number) : number {
        return price + _calculateTax(price);
    }

}

var price: number = ProductModule.calculatePrice(100.00);