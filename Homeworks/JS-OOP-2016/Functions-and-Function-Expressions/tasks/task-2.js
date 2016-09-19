/*global module */
/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes() {
    'use strict';
    let start = +arguments[0];
    let end = +arguments[1];
    let result = [];
    if (start === undefined || end === undefined) {
        throw "Params as missing";
    }
    if (isNaN(start) || isNaN(end)) {
        throw "Params must be convertible to number!";
    }

    function isPrime(number) {
        let i;
        if (number <= 1) {
            return false;
        }
        for (i = 2; i <= Math.sqrt(number); i += 1) {
            if (!(number % i)) {
                return false;
            }
        }
        return true;
    }

    for (let i = start, len = end + 1; i < len; i += 1) {
        if (isPrime(i)) {
            result.push(i);
        }
    }
    return result;
}
//console.log(findPrimes("1", "5"));
module.exports = findPrimes;