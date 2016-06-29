function solve(params) {
	var n = +params[0],
		numbers = params[1].split(' ').map(Number),
		count = 0;

	function LargerThanNeighbours(i, arr) {
		if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
			return true;
		} else {
			return false;
		}
	}
	for (var i = 0; i < n; i += 1) {
		if (LargerThanNeighbours(i, numbers)) {
			count += 1;
		}
	}
	console.log(count);
}
//solve(['6', '-26 -25 -28 31 2 27']);