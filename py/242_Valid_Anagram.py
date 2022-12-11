def isAnagram(s: str, t: str) -> bool:
    d = dict()
    count = len(s)
    if len(s) != len(t):
        return False

    for num in range(count):
        d[s[num]] = d.get(s[num], 0) + 1
        d[t[num]] = d.get(t[num], 0) - 1

    for key, val in d.items():
        if val != 0:
            return False
    return True
