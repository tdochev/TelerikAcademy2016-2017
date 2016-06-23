function solve(params) {
    var a = +params[0],
        i,
        result = [];

    for (i = 1; i <= a; i += 1) {
        result[i - 1] = i;
    }
    console.log(result.join(' '));
}
