/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public void inorder(TreeNode root, IList<int> list){
        if(root == null){
            return;
        }

        inorder(root.left, list);
        list.Add(root.val);
        inorder(root.right, list);
    }

    public bool IsValidBST(TreeNode root) {
        IList<int> list = new List<int>();
        inorder(root, list);
        for(int i = 0; i < list.Count() - 1; i++){
            if(list[i] >= list[i + 1]){
                return(false);
            }
        }
        return(true);
    }
}
