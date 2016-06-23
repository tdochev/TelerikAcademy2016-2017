function solve(params) {
    var negativeCount = 0,
        noZero = true,
        i;

    for (i = 0; i < params.length; i += 1) {
        if (!+params[i]) {
            noZero = +params[i];
        } else {
            if (+params[i] < 0) {
                negativeCount += 1;
            }
        }
    }
    if (!noZero) {
        console.log(0);
    } else {
        console.log(!(negativeCount % 2 === 0) ? '-' : '+');
    }
}
