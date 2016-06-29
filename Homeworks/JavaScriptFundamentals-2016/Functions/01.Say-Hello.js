function solve(params) {
	var name = params[0];

	function sayHello(name) {
		console.log('Hello, ' + name + '!');
	}
	sayHello(name);
}
//solve(['Peter']);