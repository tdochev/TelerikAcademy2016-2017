function solve(params) {
    "use strict";
    let word = params[0].toLowerCase(),
        sentence = params[1].toLowerCase(),
        count = 0,
        sentenceLength = sentence.length;

    for (let i = 0; i < sentenceLength; i += 1) {
        if (sentence.substr(i, word.length) == word) {
            count += 1;
        }
    }
    console.log(count);

}
//solve([
//    'in',
//    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will //move out of it in 5 days.'
//]);