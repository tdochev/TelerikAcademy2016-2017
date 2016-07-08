function solve(params) {
    "use strict";
    let sentence = params[0] + '',
        arr = sentence.split(/<|>/),
        result = '';
    for (let i = 0; i < arr.length; i += 1) {
        if (arr[i].toLowerCase() === 'upcase') {
            arr[i] = '';
            arr[i + 1] = arr[i + 1].toUpperCase();
        }
        if (arr[i].toLowerCase() === 'lowcase') {
            arr[i] = '';
            arr[i + 1] = arr[i + 1].toLowerCase();
        }
        if (arr[i].toLowerCase() === 'orgcase' || arr[i].toLowerCase() === '/orgcase' || arr[i].toLowerCase() === '/upcase' || arr[i].toLowerCase() === '/lowcase') {
            arr[i] = '';
        }
    }
    arr.forEach(function(element) {
        if (element !== '') {
            result += element;
        }
    }, this);
    console.log(result);
}
//solve(['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.']);