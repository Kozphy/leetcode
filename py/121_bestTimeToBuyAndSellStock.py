from typing import List


def maxProfit(prices: List[int]) -> int:
    max_profit = 0
    smaller_price = prices[0]

    for price in prices:
        if price < smaller_price:
            smaller_price = price
        have_profit = price - smaller_price
        if max_profit < have_profit:
            max_profit = have_profit

    return max_profit


prices = [7, 1, 5, 3, 6, 4]

ans = maxProfit(prices)
print(ans)
