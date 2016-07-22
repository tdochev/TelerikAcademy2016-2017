function solve(params) {
    "use strict";
    let nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        result = s;

    for (let i = 0; i < nk[1]; i += 1) {
        result = [];
        for (let y = 0; y < s.length; y += 1) {
            let previous = s[y - 1];
            let next = s[y + 1];
            if (previous === undefined) {
                previous = s[s.length - 1];
            }
            if (next === undefined) {
                next = s[0];
            }
            if (!s[y]) {
                result[y] = Math.abs(previous - next);
            } else if (s[y] % 2 === 0) {
                result[y] = Math.max(previous, next);
            } else if (s[y] === 1) {
                result[y] = previous + next;
            } else {
                result[y] = Math.min(previous, next);
            }
        }
        s = result;
    }
    console.log(result.reduce((prev, curr) => prev + curr));
}