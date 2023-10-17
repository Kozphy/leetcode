// TODO: complete

/**
 * @param {character[][]} board
 * @param {string} word
 * @return {boolean}
 */
var exist = function (board, word) {
  let flat_arr = board.flat();
  let split_word = word.split("");
  //   console.log(split_word);
  flat_arr.forEach((w, index) => {
    if (w === split_word) {
    }
  });
};

let board = [
  ["A", "B", "C", "E"],
  ["S", "F", "C", "S"],
  ["A", "D", "E", "E"],
];

let words = "ABCCED";
console.log(exist(board, words));
