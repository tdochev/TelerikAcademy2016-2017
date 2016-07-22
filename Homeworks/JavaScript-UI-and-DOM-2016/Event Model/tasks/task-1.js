function solve() {
    "use strict";
    return function(selector) {
        let i,
            len,
            element,
            buttons,
            contents;

        function getValidElement(element) {
            if (typeof element === "string") {
                element = document.getElementById(element);
            }
            if (!(element instanceof HTMLElement)) {
                throw new Error("Provided first parameter is neither string or existing DOM element");
            }
            return element;
        }

        function getButtonsAndAddEvent(element) {
            let elements = element.children,
                result = [];
            for (let i = 0, len = elements.length; i < len; i += 1) {
                let current = elements[i];
                if (current.className === "button") {
                    current.innerHTML = "hide";
                    current.addEventListener("click", clickFunc, false);
                    result.push(current);
                };
            }
            return result;
        }

        function getContents(element) {
            let elements = element.children,
                result = [];
            for (let i = 0, len = elements.length; i < len; i += 1) {
                let current = elements[i];
                if (current.className === "content") {
                    result.push(current);
                };
            }
            return result;
        }

        function clickFunc() {
            let target = this,
                next = target.nextElementSibling,
                content;

            while (next) {
                if (next.className === 'content') {
                    content = next;
                    while (next) {
                        if (next.className === 'button') {
                            if (content.style.display === '') {
                                content.style.display = 'none';
                                target.innerHTML = 'show';
                            } else {
                                content.style.display = '';
                                target.innerHTML = 'hide';
                            }
                            break;
                        }
                        next = next.nextElementSibling;
                    }
                    break;
                } else {
                    next = next.nextElementSibling;
                }
            }
        }
        element = getValidElement(selector);
        buttons = getButtonsAndAddEvent(element);
        contents = getContents(element);
    }
}

//module.exports = solve;