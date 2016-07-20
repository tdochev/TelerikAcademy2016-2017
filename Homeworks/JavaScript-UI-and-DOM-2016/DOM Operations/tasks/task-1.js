function solve() {
    "use strict";
    module.exports = function() {
        return function(element, contents) {
            const len = contents.length;

            function validateParameter(parameter) {
                if (parameter === undefined || parameter === null) {
                    throw new Error("Invalid parameter!");
                }
            }

            function validateContents(contents) {
                let i;
                if (!Array.isArray(contents)) {
                    throw new Error("Invalid array");
                }
                for (i = 0; i < len; i += 1) {
                    if (typeof contents[i] !== "string" && typeof contents[i] !== "number") {
                        throw new Error("Invalid array content!");
                    }
                }
            }

            function getValidElement(element) {
                if (typeof element === "string") {
                    element = document.getElementById(element);
                }
                if (!(element instanceof HTMLElement)) {
                    throw new Error("Provided first parameter is neither string or existing DOM element");
                }

                return element;
            }

            function addDivsToElelemnt(element, contents) {
                let div,
                    fragment,
                    i,
                    divToBeAdded;

                element.innerHTML = '';
                div = document.createElement('div');
                fragment = document.createDocumentFragment();

                for (i = 0; i < len; i += 1) {
                    divToBeAdded = div.cloneNode(true);
                    divToBeAdded.innerHTML = contents[i];
                    fragment.appendChild(divToBeAdded);
                }

                element.appendChild(fragment);
            }


            validateParameter(element);
            validateParameter(contents);
            validateContents(contents);
            const validElement = getValidElement(element);
            addDivsToElelemnt(validElement, contents);
        };
    };
};