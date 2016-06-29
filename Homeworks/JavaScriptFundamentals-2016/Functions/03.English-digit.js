function solve(params) {
	var integer = +params[0];

	function LastDigitToNumber(integer) {
		var lastDigit = (integer % 10),
			result;
		switch (lastDigit) {
			case 0:
				return 'zero';
			case 1:
				return 'one';
			case 2:
				return 'two';
			case 3:
				return 'three';
			case 4:
				return 'four';
			case 5:
				return 'five';
			case 6:
				return 'six';
			case 7:
				return 'seven';
			case 8:
				return 'eight';
			case 9:
				return 'nine';
		}
		return (result);
	}
	console.log(LastDigitToNumber(integer));
}
//solve(['42']);