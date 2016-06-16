function solve(args) {
	var number = +args[0];

	if (!(number % 2)) {
		console.log('even ' + args[0]);
	} else {
		console.log('odd ' + args[0]);
	}
}