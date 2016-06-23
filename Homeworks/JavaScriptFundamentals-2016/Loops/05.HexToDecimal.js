function solve(params) {
    var hex = params[0],
        radix = 16,
        result = 0,
        i;

    for (i = 0; i < hex.length; i += 1) {
        switch (hex[i]) {
            case 'A':
                result = 10 + result * radix;
                break;
            case 'B':
                result = 11 + result * radix;
                break;
            case 'C':
                result = 12 + result * radix;
                break;
            case 'D':
                result = 13 + result * radix;
                break;
            case 'E':
                result = 14 + result * radix;
                break;
            case 'F':
                result = 15 + result * radix;
                break;
            default:
                result = +hex[i] + result * radix;
        }
    }
    console.log(result);
}