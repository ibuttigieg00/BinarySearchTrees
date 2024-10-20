public class TreeNode{
    public int Key;         //The value of the node 
    public TreeNode Left;   // Pointer to the left child
    public TreeNode Right;  // Pointer to the right child

    public TreeNode(int Key){
        this.Key = Key;
        Left = null;        // initially no left child
        Right = null;       // initially no right child
    }
}