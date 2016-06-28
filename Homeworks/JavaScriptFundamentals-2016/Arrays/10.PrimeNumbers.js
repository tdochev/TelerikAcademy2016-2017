function solve(params) {
	var n = +params[0],
		firstPrimeNumber = 2,
		isPrime = [],
		i,
		j;

	for (i = firstPrimeNumber; i * i <= n; i += 1) {
		if (!isPrime[i]) {
			for (j = i * i; j < n; j += i) {
				isPrime[j] = true;
			}

		}
	}
	for (var y = isPrime.length; y >= 0; y = -1) {
		if (!isPrime[y]) {
			console.log(y);
			break;
		}
	}
}

solve([13]);