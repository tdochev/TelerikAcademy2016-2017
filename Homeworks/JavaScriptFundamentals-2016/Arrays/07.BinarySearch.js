function solve(params) {
	var numbers = params[0].split('\n').map(Number),
		n = numbers[0],
		x = numbers[n + 1],
		arr = numbers.slice(1, n + 1),
		firstIndex = 0,
		lastIndex = arr.length - 1,
		currentIndex;
	isFound = false;

	while (firstIndex <= lastIndex) {
		currentIndex = (lastIndex + firstIndex) / 2 | 0;
		if (arr[currentIndex] == x) {
			isFound = true;
			break;
		} else if (arr[currentIndex] < x) {
			firstIndex = currentIndex + 1;
		} else if (arr[currentIndex] > x) {
			lastIndex = currentIndex - 1;
		}
	}
	if (!isFound) {
		console.log(-1);

	} else {
		console.log(currentIndex);
	}

}

//solve(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32']);