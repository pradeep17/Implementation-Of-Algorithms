using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TreeTest
{
    public class TreeNode
    {
        public int iData; // data used as key value
        // other data
        public TreeNode leftChild; // this node's left child
         public TreeNode rightChild; // this node's right child

        public void displayNode()
        {
            // (see Listing 8.1 for method body)
        }
    }
    class TreeClass
    {
        private TreeNode root; // the only data field in Tree
        TreeNode parent;
        int maxleft;
        int maxright;

        public TreeNode find(int key) // find node with given key
        { // (assumes non-empty tree)
            TreeNode current = root; // start at root
            while (current.iData != key) // while no match,
            {
                if (key < current.iData) // go left?
                    current = current.leftChild;
                else
                    current = current.rightChild; // or go right?
                if (current == null) // if no child,
                    return null; // didn't find it
            }
            return current; // found it
        }
        public void insert(int id)
        {
            TreeNode newNode = new TreeNode(); // make new node
            newNode.iData = id; // insert data

            if (root == null) // no node in root
                root = newNode;
            else // root occupied
            {
                TreeNode current = root; // start at root

                while (true) // (exits internally)
                {
                    parent = current;
                    if (id < current.iData) // go left?
                    {
                        current = current.leftChild;
                        if (current == null) // if end of the line,
                        { // insert on left
                            parent.leftChild = newNode;
                            return;
                        }
                    } // end if go left
                    else //
                    {
                        current = current.rightChild;
                        if (current == null) // if end of the line
                        { // insert on right
                            parent.rightChild = newNode;
                            return;
                        }
                    } // end else go right
                } // end while
            } // end else not root
            // end insert()
        }
        public Boolean delete(int id)
        {
            TreeNode current = root;
            TreeNode parent = root;
            Boolean isLeftchild = true;
            while (current.iData != id)
            {
                parent = current;
                if (id < current.iData)
                {
                    isLeftchild = true;
                    current = current.leftChild;
                }
                else
                {
                    isLeftchild = true;
                    current = current.rightChild;
                }
                if (current == null)
                    return false;
            }
            // found node to delete



            // case 1 : if no children, simply delete it
            if (current.leftChild == null && current.rightChild == null)
            {
                if (current == root) // if root,
                    root = null; // tree is empty
                else if (isLeftchild)
                    parent.leftChild = null; // disconnect
                else // from parent
                    parent.rightChild = null;
            }
            else if (current.rightChild == null)
                if (current == root)
                    root = current.leftChild;
                else if (isLeftchild) // left child of parent
                    parent.leftChild = current.leftChild;
                else // right child of parent
                    parent.rightChild = current.leftChild;
            // if no left child, replace with right subtree
            else if (current.leftChild == null)
                if (current == root)
                    root = current.rightChild;
                else if (isLeftchild) // left child of parent
                    parent.leftChild = current.rightChild;
                else // right child of parent
                    parent.rightChild = current.rightChild;
            // continued

            return true;

        }
        public int maxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + Math.Max(maxDepth(root.leftChild), maxDepth(root.rightChild));
        }

        public int minDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + Math.Min(minDepth(root.leftChild), minDepth(root.rightChild));
        }

        public bool isBalanced(){
			 //TreeClass tree = new TreeClass();
		 bool isTrue = (maxDepth(root) - minDepth(root) <= 1);
		 return isTrue;
		 }
        public List<LinkedList<TreeNode>> findLevelLinkList()
        {
            int level = 0;
            List<LinkedList<TreeNode>> result =
            new List<LinkedList<TreeNode>>();


            LinkedList<TreeNode> list = new LinkedList<TreeNode>();
            list.AddLast(root);
            result.Insert(level, list);


            while (true)
            {
                list = new LinkedList<TreeNode>();
                for (int i = 0; i < result.ElementAt(level).Count; i++)
                {
                    TreeNode n = (TreeNode)result.ElementAt(level).ElementAt(i);
                    if (n != null)
                    {
                        if (n.leftChild != null) list.AddLast(n.leftChild);
                        if (n.rightChild != null) list.AddLast(n.rightChild);
                    }
                }
                if (list.Count > 0)
                {
                    result.Insert(level + 1, list);
             
                }
                else
                {
                    break;
                }
                level++;
            }
            return result;
        }

    }
  
    class Program
    {
        static void Main(string[] args)
        {
            TreeClass theTree = new TreeClass(); // make a tree
	theTree.insert(10); // insert 3 nodes
	theTree.insert(5);
	theTree.insert(12);
	theTree.insert(4);
	theTree.insert(6);
	theTree.insert(7);
	
	TreeNode found = theTree.find(25); // find node with key 25
	if(found != null)
	Console.WriteLine("Found the node with key 25");
	else
	Console.WriteLine("Could not find node with key 25");
	
	if(theTree.isBalanced())
	{
		Console.WriteLine("The tree is balanced");
	}
	else
		Console.WriteLine("The tree is not balanced");
	
	
	
	List<LinkedList<TreeNode>> print =theTree.findLevelLinkList();

    Console.ReadKey();
	
	} // end main()
        }
    }

