using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTrees.NTree;

public class NodeNTree
{
    public int Value { get; set; }
    public LinkedList<NodeNTree>? children { get; set; }

    public override string ToString()
    {
        return "[ " + Value + "]";
    }
}
