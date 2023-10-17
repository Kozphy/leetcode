let map = function (arr, fn) {
  let res = [];

  arr.forEach((element, index) => {
    res.push(fn(element, index));
  });

  return res;
};

let fn = function plusone(n) {
  return n + 1;
};

fn = function constant() {
  return 42;
};

fn = function plusI(n, i) {
  return n + i;
};

console.log(map([1, 2, 3], fn));
