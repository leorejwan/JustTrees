using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTrees.BTree;

public class NodeBTree
{
    public int Value { get; set; }
    public NodeBTree? Left { get; set; }
    public NodeBTree? Right { get; set; }

    public override string ToString()
    {
        return "[ " + Value + "]";
    }
}
