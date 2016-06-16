function solve(params) {
	var width = +params[0],
		height = +params[1],
		area,
		perimeter;

	area = (width * height).toFixed(2);
	perimeter = (2 * width + 2 * height).toFixed(2);
	console.log(area + ' ' + perimeter);
}