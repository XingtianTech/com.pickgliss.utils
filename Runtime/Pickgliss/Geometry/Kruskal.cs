using System.Collections.Generic;
using Unity.Mathematics;

namespace Pickgliss.Geometry
{
    public static class Kruskal 
    {
        public static List<Line2D> GetMinimum(List<Line2D> links)
        {
            var nodes = new Dictionary<int2,Node> ();
			var mst = new List<Line2D> ();
			var nodePool = new Stack<Node> ();

            links.Sort();

            for (int i = links.Count; --i > -1;) {
				var link = links [i];

                (Node node0,Node rootOfSet0) = CreateNode(link.p0);
                (Node node1,Node rootOfSet1) = CreateNode(link.p1);
				
				if (rootOfSet0 != rootOfSet1) {	// nodes not in same set
					mst.Add (link);
					
					// merge the two sets:
					int treeSize0 = rootOfSet0.treeSize;
					int treeSize1 = rootOfSet1.treeSize;
					if (treeSize0 >= treeSize1) {
						// set0 absorbs set1:
						rootOfSet1.parent = rootOfSet0;
						rootOfSet0.treeSize += treeSize1;
					} else {
						// set1 absorbs set0:
						rootOfSet0.parent = rootOfSet1;
						rootOfSet1.treeSize += treeSize0;
					}
				}
			}
            (Node,Node) CreateNode(int2 p)
            {
				if (!nodes.ContainsKey (p)) {
					var node = nodePool.Count > 0 ? nodePool.Pop () : new Node ();
					// initialize the node:
					var rootOfSet = node.parent = node;
					node.treeSize = 1;
					nodes [p] = node;
                    return (node,rootOfSet);
				} else {
					var node = nodes [p];
					var rootOfSet = Node.Find (node);
                    return (node,rootOfSet);
				}
            }
            nodePool.Clear();
            nodes.Clear();
            return mst;
        }
    }

    class Node
	{
        public static Node Find (Node node)
		{
			if (node.parent == node) {
				return node;
			} else {
				Node root = Find (node.parent);
				// this line is just to speed up subsequent finds by keeping the tree depth low:
				node.parent = root;
				return root;
			}
		}
		
		public Node parent;
		public int treeSize;
	}
}