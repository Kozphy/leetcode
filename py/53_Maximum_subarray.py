from typing import List


def maxSubArray(nums: List[int]) -> int:
    lnums = len(nums)
    if lnums == 1:
        return nums[0]


nums = [-2, 1, -3, 4, -1, 2, 1, -5, -4]
maxSubArray(nums)
