function solve(params) {
    var n = +params[0],
        i,
        y,
        result = '';

    for (i = 0; i < n; i += 1) {
        for (y = 1; y <= n; y += 1) {
            if (y == n) {
                result += y + i;
            } else {
                result += y + i+ ' ';
            }
        }
        if (i != n - 1) {
            result += '\n';
        }

    }
    console.log(result);
}
