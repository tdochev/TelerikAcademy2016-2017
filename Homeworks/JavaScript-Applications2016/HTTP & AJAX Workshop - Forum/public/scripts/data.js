/* global $*/
var data = (function() {
    'use strict';
    let USERNAME_STORAGE_KEY = 'username-key';

    // start users
    function userLogin(user) {
        localStorage.setItem(USERNAME_STORAGE_KEY, user);
        return Promise.resolve(user);
    }

    function userLogout() {
        localStorage.removeItem(USERNAME_STORAGE_KEY);
        return Promise.resolve();
    }

    function userGetCurrent() {
        return Promise.resolve(localStorage.getItem(USERNAME_STORAGE_KEY));
    }
    // end users

    // start threads
    function threadsGet() {
        return new Promise((resolve, reject) => {
            $.getJSON('api/threads')
                .done(resolve)
                .fail(reject);
        });
    }

    function threadsAdd(title) {
        return new Promise((resolve, reject) => {
            $.ajax({
                type: "post",
                url: "api/threads",
                contentType: "application/json",
                data: JSON.stringify({
                    title: title,
                    username: localStorage.getItem(USERNAME_STORAGE_KEY)
                }),
                success: (data) => resolve(data),
                error: (msg) => reject(msg)
            });
        });
    }

    function threadById(id) {
        return new Promise((resolve, reject) => {
            $.ajax({
                type: "get",
                url: "api/threads/" + id,
                contentType: "application/json",
                success: (data) => resolve(data),
                error: (msg) => reject(msg)
            });
        });
    }

    function threadsAddMessage(threadId, content) {
        return new Promise((resolve, reject) => {
            $.ajax({
                type: "post",
                url: "api/threads/" + threadId + "/messages",
                contentType: "application/json",
                data: JSON.stringify({
                    username: localStorage.getItem(USERNAME_STORAGE_KEY),
                    content: content
                }),
                success: (data) => resolve(data),
                error: (msg) => reject(msg)
            });
        });
    }
    // end threads

    // start gallery
    function galleryGet() {
        const REDDIT_URL = `https://www.reddit.com/r/aww.json?jsonp=?`;
        return new Promise((resolve, reject) => {
            $.ajax({
                    url: REDDIT_URL,
                    dataType: 'jsonp'
                })
                .done(resolve)
                .fail(reject);
        });
    }
    // end gallery

    return {
        users: {
            login: userLogin,
            logout: userLogout,
            current: userGetCurrent
        },
        threads: {
            get: threadsGet,
            add: threadsAdd,
            getById: threadById,
            addMessage: threadsAddMessage
        },
        gallery: {
            get: galleryGet,
        }
    }
})();