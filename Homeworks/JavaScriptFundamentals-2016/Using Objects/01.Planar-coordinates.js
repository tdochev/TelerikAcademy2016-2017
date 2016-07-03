function solve(params) {
    var input = params.map(Number),
        lines = [],
        i,
        firstPoint,
        secondPoint,
        currentLine;

    function CreatePoint(x, y) {
        return {
            x: x,
            y: y
        };
    }

    function CreateLine(pStart, pEnd) {
        return {
            pStart: pStart,
            pEnd: pEnd,
            calculateDistance: function() {
                var a = (this.pEnd.x - this.pStart.x) * (this.pEnd.x - this.pStart.x);
                var b = (this.pEnd.y - this.pStart.y) * (this.pEnd.y - this.pStart.y);
                return Math.sqrt(a + b);
            }
        };
    }

    function canFormTriangle(a, b, c) {
        return a.calculateDistance() + b.calculateDistance() > c.calculateDistance() &&
            b.calculateDistance() + c.calculateDistance() > a.calculateDistance() &&
            c.calculateDistance() + a.calculateDistance() > b.calculateDistance();
    }

    for (i = 0; i < input.length; i += 4) {
        firstPoint = new CreatePoint(input[i], input[i + 1]);
        secondPoint = new CreatePoint(input[i + 2], input[i + 3]);
        currentLine = new CreateLine(firstPoint, secondPoint);
        console.log(currentLine.calculateDistance().toFixed(2));
        lines.push(currentLine);
    }
    if (canFormTriangle(lines[0], lines[1], lines[2])) {
        console.log('Triangle can be built');
    } else {
        console.log('Triangle can not be built');
    }
}
//solve([
//    '7', '7', '2', '2',
//    '5', '6', '2', '2',
//    '95', '-14.5', '0', '-0.123'
//]);