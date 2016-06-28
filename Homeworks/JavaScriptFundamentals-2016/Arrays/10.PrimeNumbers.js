function solve(params) {
	var n = +params[0],
		firstPrimeNumber = 2,
		isPrime,
		i,
		y;

	for (i = n; i >= 0; i -= 1) {
		isPrime = true;
		for (y = firstPrimeNumber; y <= Math.sqrt(i); y += 1) {
			if (i % y === 0) {
				//console.log(y);
				isPrime = false;
				break;
			}
		}
		if (isPrime) {
			console.log(i);
			break;
		}
	}
}
//solve([26]);