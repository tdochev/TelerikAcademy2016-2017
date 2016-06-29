function solve(params) {
	var n = +params[0],
		numbers = params[1].split(' ').map(Number);

	function FirstLargerThanNeighbours(arr) {
		var i;
		for (i = 0; i < n; i += 1) {
			if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
				return i;
			}
		}
		return -1;
	}
	console.log(FirstLargerThanNeighbours(numbers));
}
//solve(['6', '-26 -25 -28 31 2 27']);