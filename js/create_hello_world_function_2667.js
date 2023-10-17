var createHelloWorld = function () {
  return function (...args) {
    return "Hello World";
  };
};

let f = createHelloWorld();
console.log(f());
