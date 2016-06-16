function solve(params) {
	var r = 2,
		cx = 0,
		cy = 0,
		x = +params[0],
		y = +params[1],
		isInC,
		yesNo,
		distance;

	isInC = (x - cx) * (x - cx) + (y - cy) * (y - cy) <= r * r;
	yesNo = isInC ? 'yes' : 'no';
	distance = Math.sqrt(((cx - x) * (cx - x)) + ((cy - y) * (cy - y))).toFixed(2);

	console.log(yesNo + ' ' + distance);
}