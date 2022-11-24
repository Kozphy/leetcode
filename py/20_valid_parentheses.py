def isValid(s: str) -> bool:
    stack = []
    for val in s:
        if val == "(" or val == "[" or val == "{":
            stack.append(val)
        elif len(stack) != 0 and (
            stack[-1] == "("
            and val == ")"
            or stack[-1] == "["
            and val == "]"
            or stack[-1] == "{"
            and val == "}"
        ):
            print("stack:", stack[-1])
            print("val:", val)
            stack.pop()
        else:
            return False
    return len(stack) == 0


# print(isValid("()"))
# print(isValid("()[]{}"))
# print(isValid("(]"))
# print(isValid("(("))
print(isValid("({{{{}}}))"))
