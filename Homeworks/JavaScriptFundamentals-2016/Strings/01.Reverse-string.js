function solve(params) {
    "use strict";
    let word = params[0],
        result = '';
    for (let index = word.length - 1; index >= 0; index -= 1) {
        result += word[index];
    }
    return result;
}
//console.log(solve(['qwertytrewq']));