using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTrees.BTree;

public class BTree
{
    public NodeBTree? root;

    public BTree()
    {
        root = null;
    }

    public NodeBTree ReturnRoot()
    {
        return root;
    }

    public void Insert(int x)
    {
        NodeBTree? newNode = new NodeBTree();
        newNode.Value = x;

        if (root == null)
            root = newNode;
        else
        {
            NodeBTree current = root;
            NodeBTree parent;

            while (true)
            {
                parent = current;
                if(x < current.Value)
                {
                    current = current.Left;
                    if(current == null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.Right;
                    if(current == null)
                    {
                        parent.Right = newNode;
                        return;
                    }
                }
            }
        }
    }

    public void Pre_order(NodeBTree root)
    {
        if(root != null)
        {
            Console.Write(root.Value + " ");
            Pre_order(root.Left);
            Pre_order(root.Right);
        }
    }

    public void In_Order(NodeBTree root)
    {
        if (root != null)
        {
            In_Order(root.Left);
            Console.Write(root.Value + " ");
            In_Order(root.Right);
        }
    }

    public void Post_Order(NodeBTree root)
    {
        if (root != null)
        {
            Post_Order(root.Left);
            Post_Order(root.Right);
            Console.Write(root.Value + " ");
        }
    }
}
