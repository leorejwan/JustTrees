using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTrees.NTree;

public class NTree
{
    public NodeNTree? root;

    public NTree()
    {
        root = null;
    }

    public NodeNTree ReturnRoot()
    {
        return root;
    }

    public void Insert(int x)
    {
        NodeNTree newNode = new NodeNTree();
        newNode.Value = x;

        if (root == null)
            root = newNode;
        else
        {
            if (root.children == null)
                root.children = new LinkedList<NodeNTree>();

            root.children.AddFirst(newNode);
        }

    }
}
