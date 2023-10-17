let nums = [1, 2, 3, 1];

var containsDuplicate = function (nums) {
  map_nums = {};
  for (let i = 0; i < nums.length; i++) {
    let element = nums[i];
    if (!map_nums.hasOwnProperty(element)) {
      map_nums[element] = 1;
    } else {
      return true;
    }
  }
  return false;
};

let res = containsDuplicate(nums);
console.log(res);
