def isPalindrome(s: str) -> bool:
    a = ""

    for char in [*s]:
        if char.isalpha() or char.isnumeric():
            a += char.lower()
    return a == a[::-1]


s = "A man, a plan, a canal: Panama"

print(isPalindrome(s))
