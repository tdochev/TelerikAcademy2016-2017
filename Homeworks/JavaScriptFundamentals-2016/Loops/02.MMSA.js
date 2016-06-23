function solve(params) {
    var numbers = params,
        min = +numbers[0],
        max = +numbers[0],
        sum = 0,
        avg,
        i;

    for (i = 0; i < numbers.length; i += 1) {
        numbers[i] = +numbers[i];
        if (numbers[i] > max) {
            max = numbers[i];
        }
        if (numbers[i] < min) {
            min = numbers[i];
        }
        sum += numbers[i];
    }
    avg = sum / numbers.length;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}