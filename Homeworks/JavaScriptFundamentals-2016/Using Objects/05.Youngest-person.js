function solve(params) {
    var people = [],
        i;

    function Person(firstName, lastName, age) {
        return {
            firstName: firstName,
            lastName: lastName,
            age: age,
            fullName: function() {
                return this.firstName + ' ' + this.lastName;
            }
        };
    }
    for (i = 0; i < params.length; i += 3) {
        people.push(new Person(params[i], params[i + 1], +params[i + 2]));
    }
    people.sort(function(a, b) {
        return b.age - a.age;
    });
    console.log(people[0].fullName());
}
solve([
    'Gosho', 'Petrov', '32',
    'Bay', 'Ivan', '81',
    'John', 'Doe', '42'
]);