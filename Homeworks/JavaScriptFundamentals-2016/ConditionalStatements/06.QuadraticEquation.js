function solve(parms) {
  var a = +parms[0],
    b = +parms[1],
    c = +parms[2],
    d = (b * b) - (4 * a * c),
    x1,
    x2;

  if (d < 0) {
    console.log("no real roots");
  } else if (d===0) {
    console.log('x1=x2=' + (-b / (2 * a)).toFixed(2));
  } else if (d > 0) {
    x1 = (-b - Math.sqrt(d)) / (2 * a);
    x2 = (-b + Math.sqrt(d)) / (2 * a);

    if (x2 < x1) {
      temp = x1;
      x1 = x2;
      x2 = temp;
    }

    console.log('x1=' + x1.toFixed(2) + "; x2=" + x2.toFixed(2));
  }
}