/* global $, handlebars, module */

function solve() {
    "use strict";
    return function() {
        $.fn.listview = function(data) {
            const $this = $(this),
                selectTemplate = "#" + $this.attr("data-template"),
                source = $(selectTemplate).html(),
                template = handlebars.compile(source),
                len = data.length;

            for (let i = 0; i < len; i += 1) {
                $this.append(template(data[i]));
            }
            return this;
        };
    };
}

//module.exports = solve;