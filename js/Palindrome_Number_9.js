/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {
  let reverseStr = x.toString().split("").reverse().join("");

  if (x == reverseStr) {
    return true;
  }
  return false;
};

let res = isPalindrome(121);
console.log(res);
