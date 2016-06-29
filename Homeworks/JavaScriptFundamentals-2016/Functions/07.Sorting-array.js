function solve(params) {
	var n = +params[0],
		numbers = params[1].split(' ').map(Number);
	//	i,
	//	maximalElement,
	//	maxElementIndex,
	//	swap,
	//	descedingArray;
	//
	//function GetMaximalElement(arr, start) {
	//	var maximal = arr[start],
	//		i;
	//
	//	for (i = start + 1; i < arr.length; i += 1) {
	//		if (arr[i] > maximal) {
	//			maximal = arr[i];
	//		}
	//	}
	//	return maximal;
	//}
	//
	//for (i = 0; i < numbers.length; i += 1) {
	//	maximalElement = GetMaximalElement(numbers, i);
	//	maxElementIndex = numbers.indexOf(maximalElement);
	//	swap = numbers[i];
	//	numbers[i] = numbers[maxElementIndex];
	//	numbers[maxElementIndex] = swap;
	//}
	//descedingArray = numbers.reverse();
	//console.log(descedingArray.join(' '));
	numbers.sort(function(a, b) {
		return a - b;
	});
	console.log(numbers.join(' '));
}
//solve(['10', '36 10 1 34 28 38 31 27 30 20']);