function solve(params) {
	var a = +params[0],
		b = +params[1],
		c = +params[2];

	function print(a, b, c) {
		console.log(a + ' ' + b + ' ' + c);
	}

	if (a >= b && a > c) {
		if (b > c) {
			print(a, b, c);
		} else {
			print(a, c, b);
		}
	}
	if (b >= a && b > c) {
		if (a > c) {
			print(b, a, c);
		} else {
			print(b, c, a);
		}
	}
	if (c >= a && c >= b) {
		if (a > b) {
			print(c, a, b);
		} else {
			print(c, b, a);
		}
	}
}