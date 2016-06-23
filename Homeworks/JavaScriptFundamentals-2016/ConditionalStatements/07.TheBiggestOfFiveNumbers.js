function solve(params) {
    var a = +params[0],
        b = +params[1],
        c = +params[2],
        d = +params[3],
        e = +params[4];

    if (a > b) {
        if (a > c) {
            if (a > d) {
                if (a > e) {
                    console.log(a);
                } else {
                    console.log(e);
                }
            } else {
                if (d > e) {
                    console.log(d);
                } else {
                    console.log(e);
                }
            }
        } else {
            if (c > d) {
                if (c > e) {
                    console.log(c);
                } else {
                    console.log(e);
                }
            } else {
                if (d > e) {
                    console.log(d);
                } else {
                    console.log(e);
                }
            }
        }
    } else {
        if (b > c) {
            if (b > d) {
                if (b > e) {
                    console.log(b);
                } else {
                    console.log(e);
                }
            } else {
                if (d > e) {
                    console.log(d);
                } else {
                    console.log(e);
                }
            }
        } else {
            if (c > d) {
                if (c > e) {
                    console.log(c);
                } else {
                    console.log(e);
                }
            } else {
                if (d > e) {
                    console.log(d);
                } else { console.log(e); }

            }
        }
    }
}
