from typing import List


def twoSum_brute(nums: List[int], target: int) -> List[int]:
    for i, val in enumerate(nums):
        print(i, val)


def twoSum(nums: List[int], target: int) -> List[int]:
    di = {}
    for i, val in enumerate(nums):
        want = target - val
        want_index = di.get(want)
        if want_index != None and i != want_index:
            return i, want_index
        di[val] = i


nums = [2, 7, 11, 15]
target = 6
ans = twoSum_brute(nums, target)
print(ans)
# ans = twoSum(nums, target)
# print(ans)
