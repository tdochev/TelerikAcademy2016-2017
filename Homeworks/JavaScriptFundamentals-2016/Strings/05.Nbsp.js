function solve(params) {
    "use strict";
    const nbsp = "&nbsp;";
    let sentence = params[0].split('');
    for (let i = 0; i < sentence.length; i += 1) {
        if (sentence[i] === ' ') {
            sentence[i] = nbsp;
        }
    }
    console.log(sentence.join(''));

}
solve(['hello world']);