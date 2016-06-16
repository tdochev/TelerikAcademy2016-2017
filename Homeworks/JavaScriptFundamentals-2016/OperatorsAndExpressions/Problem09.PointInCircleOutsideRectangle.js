function solve(params) {
	var x = params[0],
		y = params[1],
		inInCircleWithWords,
		isInRectangleWithWords;

	function isInCircle(x, y) {
		var cx = 1,
			cy = 1,
			r = 1.5;
		return (x - cx) * (x - cx) + (y - cy) * (y - cy) <= r * r;
	}
	//R(top=1, left=-1, width=6, height=2)
	function isInRectangle(x, y) {
		return !((x < -1) || (x > 5) || (y > 1) || (y < -1));
	}

	inInCircleWithWords = isInCircle(x, y) ? 'inside circle' : 'outside circle';
	isInRectangleWithWords = isInRectangle(x, y) ? 'inside rectangle' : 'outside rectangle';

	console.log(inInCircleWithWords + ' ' + isInRectangleWithWords);

}