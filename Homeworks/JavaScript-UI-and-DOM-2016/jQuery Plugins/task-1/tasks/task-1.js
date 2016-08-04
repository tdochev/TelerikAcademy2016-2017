/* global module, $ */

function solve() {
    "use strict";
    return function(selector) {
        let $selected = $(selector).hide(),
            $div = $("<div />").addClass("dropdown-list"),
            $options = $("option"),
            $firstOption = $options.first().html(),
            $currentDiv = $("<div />").addClass("current").attr("data-value", "").html($firstOption),
            $optionsContainer = $("<div />").addClass("options-container").css("position", "absolute").hide();

        $options.each(function(index) {
            let $this = $(this);
            let $optionDiv = $("<div />")
                .addClass("dropdown-item")
                .attr({
                    "data-index": index,
                    "data-value": $this.val()
                }).text($this.text()).on("click", function() {
                    $currentDiv.text($this.text());
                    $currentDiv.attr("data-value", $this.val());
                    $optionsContainer.hide();

                    $selected.val($this.val());
                });
            $optionsContainer.append($optionDiv);
        });
        $selected.wrap($div);
        $currentDiv.on("click", function() {
            $optionsContainer.toggle();
            $currentDiv.text('Select a value');
        });
        $currentDiv.insertAfter($selected);
        $optionsContainer.insertAfter($currentDiv);
    };
}

//module.exports = solve;