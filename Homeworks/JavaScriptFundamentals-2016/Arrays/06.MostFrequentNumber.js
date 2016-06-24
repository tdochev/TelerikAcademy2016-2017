function solve(params) {
    var arr = params[0].split('\n').map(Number),
        len = arr[0],
        dict = {
            number: [],
            count: [],
        },
        i,
        bestIndex,
        maxIndex = 0;

    arr.shift();
    for (i = 0; i < len; i += 1) {
        if (dict.number.indexOf(arr[i]) == -1) {
            dict.number.push(arr[i]);
            dict.count.push(1);
        } else {
            dict.count[dict.number.indexOf(arr[i])] += 1;
        }
    }
    console.log(dict.number);
    console.log(dict.count);
    for (i = 0; i < dict.count.length; i+=1) {
        if (dict.count[i]>maxIndex) {
            maxIndex = dict.count[i];
            bestIndex = i;
        }
    }
    console.log( dict.number[bestIndex] + ' (' + dict.count[bestIndex] + ' times)');
}
//solve(['13\n1\n4\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);
