
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
class Solution:
    def isSubtree(self, s: TreeNode, t: TreeNode) -> bool:
        def check(a: TreeNode, b: TreeNode):
            if not b and not a:
                return True
            elif (not b and a) or (not a and b):
                return False

            if a.val != b.val:
                return False

            return check(a.left, b.left) and check(a.right, b.right)

        def dfs(a, b):
            if not a:
                return False

            if a.val == b.val and check(a, b):
                return True

            return dfs(a.left, b) or dfs(a.right, b)

        return dfs(s, t)
