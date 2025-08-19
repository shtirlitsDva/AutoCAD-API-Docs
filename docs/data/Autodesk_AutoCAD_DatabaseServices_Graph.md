# Graph Class

## Overview

#### Description
This .NET class wraps the AcDbGraph ObjectARX class. 
This class provides a generic graph container implementation. One other class is also involved in the graph mechanism: GraphNode. 
Detection for circular references is done by internally creating a duplicate set of references in each node and then trimming away all leaf nodes, which terminate without circularity. If any nodes remain in the duplicate graph, those nodes exist in a cycle. Graph.FindCycles() is used to set up the internal cycle information and enable several query methods to return information about any cycles found.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Graph
    Autodesk.AutoCAD.DatabaseServices.ObjectIdGraph
    Autodesk.AutoCAD.DatabaseServices.XrefGraph
```

```text
public class Graph : DisposableWrapper;
```

#### See Also
GraphNode, XrefGraph, XrefGraphNode

## Members

### Constructors

- [Graph](#graph)

### Methods

- [AddEdge](#addedge)
- [AddNode](#addnode)
- [BreakCycleEdge](#breakcycleedge)
- [ClearAll](#clearall)
- [DelNode](#delnode)
- [FindCycles](#findcycles)
- [GetOutgoing](#getoutgoing)
- [Node](#node)
- [Reset](#reset)
- [SetNodeGrowthRate](#setnodegrowthrate)

### Properties

- [IsEmpty](#isempty)
- [NumNodes](#numnodes)
- [RootNode](#rootnode)


## Constructors Details

### Graph

#### Description
The first node in the graph is considered the root node.
```text
public Graph(
    GraphNode root
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode root | Input root node. Default is NULL. |

### AddEdge

#### Description
Adds an edge between two nodes to the graph. Neither node can be NULL, and must have already been added to this same graph. from->out() will now have an entry pointing to toPointer, as will toPointer->in() have an entry pointing to from.
```text
public void AddEdge(
    GraphNode from, 
    GraphNode toPointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode from | Input the node to begin the edge at |
| GraphNode toPointer | Input the node to end the edge at |

### AddNode

#### Description
Adds a new node to the graph. The node must be created on the heap and should not be deleted once it has been added to the graph. The graph will take care of deleting it when necessary. You cannot add a node to more than one graph.
```text
public void AddNode(
    GraphNode nodeToAdd
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode nodeToAdd | Node to add |

### BreakCycleEdge

#### Description
This method is used to break a cycle at a particular point. It removes both the cycle reference and the real reference between from and toPointer. It then calls FindCycles() to update the cycle information changes which result from the break.
```text
public void BreakCycleEdge(
    GraphNode from, 
    GraphNode toPointer
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode from | Input node that the edge begins at |
| GraphNode toPointer | Input node that the edge ends at |

### ClearAll

#### Description
Used to clear the flag bit(s) in all the nodes in the graph.
```text
public void ClearAll(
    byte flags
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| byte flags | Input flag values to clear for all nodes in the graph |

### DelNode

#### Description
Completely removes a node from the graph. It also disconnects the references from other nodes to this node, if present.
```text
public void DelNode(
    GraphNode nodeToDelete
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode nodeToDelete | Node to delete |

### FindCycles

#### Description
Sets up the internal cycle graph in order to find and label all nodes which cause circular references. The cycle information is kept within the graph, like a cache. An internal dirty bit indicates when the graph has changed, so that the cycle information needs to be updated. So, it is important to call FindCycles() whenever changes might have occured in the graph, before accessing any of the cycle information functions, such as GraphNode.IsCycleNode(). Calling FindCycles() when the graph has not changed simply checks the existing information, and is efficient. 
Cycles are detected by trimming away all leaf nodes (with no outgoing references) until there is nothing left in the cycle graph. If all leaf nodes are gone, but there are still nodes in the graph, then those nodes must comprise a cycle. 
Normally, callers do not supply any node. This means that the function will examine the entire graph for leaf nodes, and prune it from that list. However, in BreakCycles(), a single reference is cut, so it calls FindCycles() with the node whose outgoing reference was just cut. Since we then know that the node whose outgoing reference was cut is the only possible leaf node in the graph, that node is passed in, so that the search for leaf nodes is skipped. Callers should not supply a node parameter unless it is known that the node passed in is the only leaf in the graph.
```text
public virtual bool FindCycles(
    GraphNode start
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode start | Input node to begin the search for cycles at. Usually defaulted to NULL. |

### GetOutgoing

#### Description
Takes the nodes and returns all of the outgoing nested nodes as a collection. It sets the Selected bit on the original nodes in the array, and sets the InList bit on all the nodes in the resulting collection. Each node in the list will appear in the collection only once.
```text
public GraphNodeCollection GetOutgoing();
```

### Node

#### Description
Returns the node at the index. Returns NULL if the index is invalid.
```text
public GraphNode Node(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input desired node index |

### Reset

#### Description
Deletes all of the nodes and cycle nodes, and resets the graph to being empty. This is also called by Graph's destructor.
```text
public void Reset();
```

### SetNodeGrowthRate

#### Description
This method sets the number of nodes that are allocated to the graph at a time. If the graph consists of many nodes, this method should be called to increase the rate from the default of 8 nodes at a time. Setting a rate to a higher value increases performance but may cause increased memory usage due to unused but allocated node space.
```text
public void SetNodeGrowthRate(
    int rate
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int rate | Number of nodes to allocate at once |

### IsEmpty

#### Description
Assesses if the graph is empty.
```text
public bool IsEmpty;
```

#### Conditions
Read-only
### NumNodes

#### Description
Accesses the number of nodes in the graph.
```text
public int NumNodes;
```

#### Conditions
Read-only
### RootNode

#### Description
Accesses the root, or first, node in the graph. Returns NULL if the first node is NULL; that is, the graph is empty.
```text
public GraphNode RootNode;
```

#### Conditions
Read-only