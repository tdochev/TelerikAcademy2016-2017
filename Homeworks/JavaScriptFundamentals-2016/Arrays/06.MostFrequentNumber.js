function solve(params) {
	var arr = params[0].split('\n').map(Number),
		len = arr[0],
		dict = {
			number: [],
			count: [],
		},
		i,
		bestNumber,
		bestNumberIndex;

	arr.shift();
	for (i = 0; i < len; i += 1) {
		if (dict.number.indexOf(arr[i]) == -1) {
			dict.number.push(arr[i]);
			dict.count.push(1);
		} else {
			dict.count[dict.number.indexOf(arr[i])] += 1;
		}
	}
	bestNumber = Math.max.apply(null, dict.count);
	bestNumberIndex = dict.count.indexOf(bestNumber);
	//console.log(dict.number);
	//console.log(dict.count);
	//console.log(bestNumberIndex);

	console.log(dict.number[bestNumberIndex] + ' (' + dict.count[bestNumberIndex] + ' times)');
}
//solve(['13\n1\n4\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);