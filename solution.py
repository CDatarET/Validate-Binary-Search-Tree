# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def inorder(self, root, arr):
        if root is None:
            return
        
        self.inorder(root.left, arr)
        arr.append(root.val)
        self.inorder(root.right, arr)

    def isValidBST(self, root):
        arr = []
        self.inorder(root, arr)
        for i in range(len(arr) - 1):
            if arr[i] >= arr[i + 1]:
                return False
        return True
