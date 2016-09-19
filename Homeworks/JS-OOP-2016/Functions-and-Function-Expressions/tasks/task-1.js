/* global module*/
/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum() {
    'use strict';
    let numbers = arguments[0];
    let result = 0;

    if (typeof numbers === 'undefined') {
        throw ("Number cannot be undefined");
    } else {
        if (numbers.length === 0) {
            return null;
        }
        numbers.forEach(function(i) {
            i = +i;
            if (isNaN(i)) {
                throw "Some of the elements is not convertible to number!";
            }
            result += i;
        });
    }
    return result;
}
//console.log(sum([1, 3, "3"]));
module.exports = sum;