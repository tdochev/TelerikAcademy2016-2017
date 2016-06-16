function solve(params) {
	var number = +params[0],
		thirdbit = ((number) >> 3) & 1;

	console.log(thirdbit);
}