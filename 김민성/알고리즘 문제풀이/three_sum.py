

def isPalindrome(self, head: listNode)-> bool:
    rev = None
    slow = fast = head

    while fast and fast.next:
        fast = fast.next.next
        rev, rev.next, slow = slow.next, rev, slow.next

    if fast:
        slow = slow.next

    while rev and rev.val == slow.val:
        rev, slow = rev.next, slow.next

    return not rev

