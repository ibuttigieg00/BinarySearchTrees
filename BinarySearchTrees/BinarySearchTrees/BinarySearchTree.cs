public class BinarySearchTree{
    public TreeNode Root;

    public BinarySearchTree(){
        Root = null;
    }

    public void InsertNode(int key){
        Root = InsertRecursive(Root, key);
    }

    public TreeNode InsertRecursive(TreeNode node, int key){
        if(node == null)
        {
            return new TreeNode(key);
        }

        if(key < node.Key){
            node.Left = InsertRecursive(node.Left, key);
        }
        else{
            node.Right = InsertRecursive(node.Right, key);
        }

        return node;
    }
}