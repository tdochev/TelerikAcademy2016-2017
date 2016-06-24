function solve(params) {
	var arr = params[0].split('\n'),
	currentSequence = 1, 
	maxSequence=0,
	len = arr[0],
	i;

	for (i = 1; i < len; i+=1) {
		if (+arr[i] < +arr[i+1]) {
			currentSequence+=1;
		} else {
			currentSequence=1;
		}
		if (currentSequence>maxSequence) {
			maxSequence=currentSequence;
		}
	}
	console.log(maxSequence);
}
//solve(['8\n7\n3\n2\n3\n4\n5\n2\n4']);