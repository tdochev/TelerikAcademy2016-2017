function solve(params) {
    var arr = params;
    Array.prototype.remove = function() {
        var i,
            item = this[0],
            result = [];
        for (i in this) {
            if (this[i] !== item && typeof this[i] !== 'function') {
                result.push(this[i])
            }
        }
        return result;
    };
    console.log(arr.remove().join('\n'));
}
//solve([1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1']);