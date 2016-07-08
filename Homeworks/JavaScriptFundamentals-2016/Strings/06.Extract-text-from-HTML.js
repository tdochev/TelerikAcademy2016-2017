function solve(params) {
    "use strict";
    let result = '',
        myRegexp = /<.*>(.*)<\/.*>/ig;
    for (let i = 0; i < params.length; i += 1) {
        let match = myRegexp.exec(params[i]);
        while (match != null) {
            match = myRegexp.exec(params[i]);
            console.log(match);
        }
        result += match;
    }
    console.log(result);
}
solve([
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
]);