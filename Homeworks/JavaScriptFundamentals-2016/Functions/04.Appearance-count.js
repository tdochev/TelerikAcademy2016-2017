function solve(params) {
	var n = +params[0],
		numbers = params[1].split(' ').map(Number),
		x = +params[2],
		result;

	function AppearanceCount(n, arr, value) {
		var i,
			count = 0;

		for (i = 0; i < n; i += 1) {
			if (arr[i] === value) {
				count += 1;
			}
		}
		return count;
	}
	result = AppearanceCount(n, numbers, x);
	console.log(result);
}
//solve(['8', '28 6 21 6 -7856 73 73 -56', '73']);