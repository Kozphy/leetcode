from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


def mergeTwoLists(
    list1: Optional[ListNode], list2: Optional[ListNode]
) -> Optional[ListNode]:

    if not list1:
        return list2

    if not list2:
        return list1

    head = ListNode()
    dummy = head

    while list1 and list2:
        if list1.val > list2.val:
            dummy.next = list2
            dummy = dummy.next
            list2 = list2.next
            continue
        elif list1.val <= list2.val:
            dummy.next = list1
            dummy = dummy.next
            list1 = list1.next
            continue

    while list1:
        dummy.next = list1
        dummy = dummy.next
        list1 = list1.next

    while list2:
        dummy.next = list2
        dummy = dummy.next
        list2 = list2.next

    return head.next


def link_Node(list):
    head = ListNode()
    dummy = head
    for num in list:
        dummy.next = ListNode(num)
        dummy = dummy.next
    return head.next


def print_ListNode(description: str, Node: ListNode):
    while Node:
        print(f"{description}: {Node.val}")
        Node = Node.next


list1 = [1, 2, 4]
list2 = [1, 3, 4]
list1_Node = link_Node(list1)
list2_Node = link_Node(list2)
print_ListNode("list1_Node: ", list1_Node)
print_ListNode("list2_Node: ", list2_Node)

node = mergeTwoLists(list1_Node, list2_Node)

print_ListNode(f"ans: ", node)
