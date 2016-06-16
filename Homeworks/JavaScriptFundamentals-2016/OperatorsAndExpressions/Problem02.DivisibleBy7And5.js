function solve(parmas) {
	var divisibleBy7and5,
		number = +parmas[0];

	divisibleBy7and5 = !(number % 5) && !(number % 7);
	console.log(divisibleBy7and5 + ' ' + number);
}