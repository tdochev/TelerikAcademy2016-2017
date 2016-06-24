function solve(params) {
    var arr = params[0].split('\n'),
        len = arr[0],
        min,
        swapIndex,
        i,
        j;
        
    arr.shift();
    for (i = 0; i < len-1; i += 1) {
        min = i;
        for (j = i + 1; j < len; j += 1) {
            if (+arr[j] < +arr[min]) {
                min = j;
            }
        }
        swapIndex = arr[i];
        arr[i] = arr[min];
        arr[min] = swapIndex;
    }
    console.log(arr.join('\n'))
}
//solve(['6\n3\n4\n1\n5\n2\n6']);