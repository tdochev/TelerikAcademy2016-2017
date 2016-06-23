function solve(params) {
	var a = +params[0],
		b = +params[1],
		c = +params[2];
	if (a < b) {
		if (b < c) {
			console.log(c);
		} else {
			console.log(b);
		}
	} else if (b < a) {
		if (a > c) {
			console.log(a);
		} else {
			console.log(c);
		}
	} else {
		console.log(c);
	}
}