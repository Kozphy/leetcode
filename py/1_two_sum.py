from typing import List


def twoSum(nums: List[int], target: int) -> List[int]:
    di = {}
    for i, val in enumerate(nums):
        want = target - val
        want_index = di.get(want)
        if want_index != None and i != want_index:
            return i, want_index
        di[val] = i


nums = [3, 3]
target = 6
ans = twoSum(nums, target)
print(ans)
