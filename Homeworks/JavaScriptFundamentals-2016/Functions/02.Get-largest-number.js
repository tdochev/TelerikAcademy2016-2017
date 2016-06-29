function solve(params) {
	var numbers = params[0].split(' ').map(Number),
		result;

	function GetMax(firstNumber, secondNumber) {
		if (firstNumber > secondNumber) {
			return firstNumber;
		} else {
			return secondNumber;
		}

	}
	result = GetMax(numbers[0], GetMax(numbers[1], numbers[2]));
	console.log(result);
}
//solve(['8 3 6']);