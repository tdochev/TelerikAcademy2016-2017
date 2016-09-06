/* global module */
/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    'use strict';
    let library = (function() {
        const MIN_BOOK_TITLE_LENGTH = 2;
        const MAX_BOOK_TITLE_LENGTH = 100;
        const VALID_ISBN_LENGTH = [10, 13];

        let books = [];
        let categories = [];

        function listBooks(property) {
            let result = books.slice();
            if (property) {
                for (let prop in property) {
                    if (property.hasOwnProperty(prop)) {
                        result = result.filter(function(item) {
                            return item[prop] === property[prop];
                        });
                    }
                }
            }
            return result.sort(function(a, b) {
                return a.id - b.id;
            });
        }

        function addBook(book) {

            //Validate title
            if (book.title.length < MIN_BOOK_TITLE_LENGTH || book.title.length > MAX_BOOK_TITLE_LENGTH) {
                throw 'Title must be between ${MIN_BOOK_TITLE_LENGTH} characters and ${MAX_BOOK_TITLE_LENGTH}!';
            }

            //Validate ISBN
            if (book.isbn.length !== VALID_ISBN_LENGTH[0] && book.isbn.length !== VALID_ISBN_LENGTH[1]) {
                throw Error('Invalid ISBN!');
            }

            //Validate Author
            if (book.author.trim() === '') {
                throw 'Invalid Author!';
            }

            //Validate non-repeating Title and ISBN
            books.forEach(function(element) {
                if (element.title.toLowerCase() === book.title.toLowerCase()) {
                    throw Error('This title already exists!');
                }
                if (element.isbn === book.isbn) {
                    throw Error('This isbn already exists!');
                }
            });

            if (categories.indexOf(book.category) < 0) {
                categories.push(book.category);
            }

            //Add book if validation passes
            book.ID = books.length + 1;
            books.push(book);
            return book;
        }

        function listCategories() {
            //return Object.getOwnPropertyNames(categories);
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
let testBook = {
    title: "test",
    isbn: "1234567890",
    author: "Testomir Testova",
    category: "Zaza"
};
let secondTestBook = {
    title: "test 2",
    isbn: "1234567890123",
    author: "Testomir Testov",
    category: "test catagory"
};
let testLibrary = solve();
testLibrary.books.add(testBook);
testLibrary.books.add(secondTestBook);
console.log(testLibrary.books.list({ title: "test 2" }));
console.log(testLibrary.categories.list());

module.exports = solve;