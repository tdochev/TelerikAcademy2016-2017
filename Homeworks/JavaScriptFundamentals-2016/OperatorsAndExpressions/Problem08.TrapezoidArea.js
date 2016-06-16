function solve(params) {
	var a = +params[0],
		b = +params[1],
		h = +params[2],
		area;

	area = ((a + b) / 2 * h).toFixed(7);
	console.log(area);

}