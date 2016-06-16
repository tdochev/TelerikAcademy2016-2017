function solve(params) {
	var number = +params[0];

	console.log(isPrime(number));

	function isPrime(number) {
		var i;
		if (number <= 1) {
			return false;
		}
		for (i = 2; i <= Math.sqrt(number); i += 1) {
			if (!(number % i)) {
				return false;
			}
		}
		return true;
	}
}