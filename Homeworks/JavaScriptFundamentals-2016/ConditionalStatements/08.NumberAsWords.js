function solve(params) {
    var number = +params[0],
        hundreds = Math.floor((number / 100) % 10),
        tens = Math.floor((number / 10) % 10),
        ones = number % 10,
        result = "";

    //console.log(hundreds + " " + tens + " " + ones);

    if (!hundreds && !tens && !ones) {
        result = "zero";
    }
    if (hundreds) {
        switch (hundreds) {
            case 1:
                result += "one hundred";
                break;
            case 2:
                result += "two hundred";
                break;
            case 3:
                result += "three hundred";
                break;
            case 4:
                result += "four hundred";
                break;
            case 5:
                result += "five hundred";
                break;
            case 6:
                result += "six hundred";
                break;
            case 7:
                result += "seven hundred";
                break;
            case 8:
                result += "eight hundred";
                break;
            case 9:
                result += "nine hundred";
                break;

        }
        if (tens != 0 || ones != 0) {
            result += " and";
        }
    }
    if (tens) {
        if (hundreds) {
            result += " ";
        }
        if (tens < 2) {
            tens = (tens * 10) + ones;
        }
        switch (tens) {
            case 2:
                result += "twenty";
                break;
            case 3:
                result += "thirty";
                break;
            case 4:
                result += "forty";
                break;
            case 5:
                result += "fifty";
                break;
            case 6:
                result += "sixty";
                break;
            case 7:
                result += "seventy";
                break;
            case 8:
                result += "eighty";
                break;
            case 9:
                result += "ninety";
                break;
            case 10:
                result += "ten";
                break;
            case 11:
                result += "eleven";
                break;
            case 12:
                result += "twelve";
                break;
            case 13:
                result += "thirteen";
                break;
            case 14:
                result += "fourteen";
                break;
            case 15:
                result += "fifteen";
                break;
            case 16:
                result += "sixteen";
                break;
            case 17:
                result += "seventeen";
                break;
            case 18:
                result += "eighteen";
                break;
            case 19:
                result += "nineteen";
                break;
        }
    }
    if (tens || hundreds) {
        result += " ";
    }
    if (ones) {
        if (tens > 20 || tens < 10 || tens == 0) {
            switch (ones) {
                case 1:
                    result += "one";
                    break;
                case 2:
                    result += "two";
                    break;
                case 3:
                    result += "three";
                    break;
                case 4:
                    result += "four";
                    break;
                case 5:
                    result += "five";
                    break;
                case 6:
                    result += "six";
                    break;
                case 7:
                    result += "seven";
                    break;
                case 8:
                    result += "eight";
                    break;
                case 9:
                    result += "nine";
                    break;
            }
        }
    }
    console.log(result.charAt(0).toUpperCase() + result.slice(1));
}
