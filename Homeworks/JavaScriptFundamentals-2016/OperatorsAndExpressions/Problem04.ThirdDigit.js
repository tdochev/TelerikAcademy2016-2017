function solve(params) {
	var number = +params[0],
		thirdDigitIs7,
		thirdDigit;

	thirdDigitIs7 = (number / 100 % 10 | 0) === 7;
	if (thirdDigitIs7) {
		console.log(thirdDigitIs7);
	} else {
		thirdDigit = (number / 100 % 10 | 0);
		console.log(thirdDigitIs7 + ' ' + thirdDigit);
	}
}