function solve(params) {
    var firstArr = params[0].split("\n")[0],
        secondArr = params[0].split("\n")[1];

    if (firstArr > secondArr) {
        console.log('>');
    } else if (firstArr < secondArr) {
        console.log('<');
    } else {
         console.log('=');
    }
}
