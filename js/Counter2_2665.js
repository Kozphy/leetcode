let createCounter = function (init) {
  let first_init = init;
  return {
    increment: function () {
      return ++init;
    },
    reset: function () {
      return (init = first_init);
    },
    decrement: function () {
      return --init;
    },
  };
};

let counter = createCounter(5);
console.log(counter.increment());
console.log(counter.reset());
console.log(counter.decrement());
