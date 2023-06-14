/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
  let dic = {};
  for (let i = 0; i < nums.length; i++) {
    let want = target - nums[i];
    if (dic.hasOwnProperty(want)) {
      return [dic[want], i];
    }
    dic[nums[i]] = i;
  }
};

let res = twoSum([2, 7, 11, 15], 9);
console.log(res);
