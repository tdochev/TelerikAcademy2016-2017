/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    "use strict";
    return function(selector) {
        let $selected = $(selector);

        if (selector.length < 1) {
            throw new Error("Error");
        }
        if (typeof selector !== "string") {
            throw new Error("Error");
        }
        if ($selected.length < 1) {
            throw new Error("Error");
        }
        $(".button").html("hide");
        $selected.on("click", ".button", function() {
            let $current = $(this);
            let $button = $(this);
            while ($current.length > 0) {
                if ($current.hasClass("content")) {
                    if ($current.css("display") === "none") {
                        $current.css("display", "");
                        $button.html("hide");
                    } else {
                        $current.css("display", "none");
                        $button.html("show");
                    }
                    break;
                }
                $current = $current.next();
            }
        });
    };
}
module.exports = solve;