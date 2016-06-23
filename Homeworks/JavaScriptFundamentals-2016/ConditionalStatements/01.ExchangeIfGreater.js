function solve(params) {
	var a = +params[0],
		b = +params[1],
		temp;
	if (a > b) {
		temp = a;
		a = b;
		b = temp;

	}
	console.log(a + ' ' + b);
}