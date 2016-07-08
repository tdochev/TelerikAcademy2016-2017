function solve(params) {
    "use strict";
    let expression = params[0],
        brackets = [];

    for (let i = 0; i < expression.length; i += 1) {
        if (expression[i] === '(' || expression[i] === ')') {
            brackets.push(expression[i]);
        }
    }
    let bracketsL = brackets.length;
    for (let i = 0; i < bracketsL; i += 1) {
        if (brackets[0] === '(' && brackets[i + 1] === ')') {
            brackets.shift();
            brackets.shift();
        }
        if (brackets[0] === '(' && brackets[brackets.length - 1] === ')') {
            brackets.shift();
            brackets.pop();
        }
    }
    console.log(brackets);
    if (brackets.length > 0 || !brackets) {
        return 'Incorrect';
    } else {
        return 'Correct';
    }
}
//console.log(solve(['((a+b)/5-d)']));