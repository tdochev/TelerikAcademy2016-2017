(function popUpThenLoad() {
    'use strict';

    const REDIRECTION_TARGET = "http://telerikacademy.com";
    const TIME_OUT_IN_SECONDS = 2;

    //window.setTimeout(
    //    function() {
    //        let element = document.getElementById('log');
    //        element.innerHTML += "You are going to be redirected to " + REDIRECTION_TARGET + " in " + TIME_OUT_IN_SECONDS + " seconds!";
    //    }, TIME_OUT_IN_SECONDS * 1000);

    let element = document.getElementById('log');
    element.innerHTML += "You are going to be redirected to " + REDIRECTION_TARGET + " in " + TIME_OUT_IN_SECONDS + " seconds!";

    let myPromise = new Promise(
        function(resolve, reject) {
            window.setTimeout(
                function() {
                    resolve();
                }, TIME_OUT_IN_SECONDS * 1000);
        }
    );

    let redirect = function redirect() {
        console.log("Promise Resolved!");
        window.location.href = REDIRECTION_TARGET;
    };

    myPromise.then(redirect)
        .catch(
            function(reason) {
                console.log('Promise rejected.' + reason);
            });
})();