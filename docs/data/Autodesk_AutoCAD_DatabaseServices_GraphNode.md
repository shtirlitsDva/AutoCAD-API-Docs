# GraphNode Class

## Overview

#### Description
This .NET class wraps the AcDbGraphNode ObjectARX class. 
This class provides a generic graph node implementation. One other class is also involved in the graph mechanism: Graph. 
Detection for circular references is done by internally creating a duplicate set of references in each node, then trimming away all leaf nodes which terminate without circularity. If any nodes remain in the duplicate graph, those nodes exist in a cycle. Graph.FindCycles() is used to set up the internal cycle information and enable several query methods to return information about any cycles found.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GraphNode
    Autodesk.AutoCAD.DatabaseServices.ObjectIdGraphNode
    Autodesk.AutoCAD.DatabaseServices.XrefGraphNode
```

```text
public class GraphNode : DisposableWrapper;
```

#### See Also
[Graph](Autodesk_AutoCAD_DatabaseServices_Graph.md "Graph Class"), XrefGraph, XrefGraphNode

## Members

### Constructors

- [GraphNode](#graphnode)

### Methods

- [AddRefTo](#addrefto)
- [Clear](#clear)
- [CycleIn](#cyclein)
- [CycleOut](#cycleout)
- [DisconnectAll](#disconnectall)
- [In](#in)
- [IsMarkedAs](#ismarkedas)
- [MarkAs](#markas)
- [MarkTree](#marktree)
- [Out](#out)
- [RemoveRefTo](#removerefto)
- [SetEdgeGrowthRate](#setedgegrowthrate)

### Properties

- [Data](#data)
- [IsCycleNode](#iscyclenode)
- [NextCycleNode](#nextcyclenode)
- [NumCycleIn](#numcyclein)
- [NumCycleOut](#numcycleout)
- [NumIn](#numin)
- [NumOut](#numout)
- [Owner](#owner)


## Constructors Details

### GraphNode

#### Description
Default constructor.
```text
public GraphNode();
```

### AddRefTo

#### Description
Creates a reference from this node to an outgoing node. It also sets the outgoing node's incoming pointer to complete the graph edge connection. Both nodes must be in the same graph, and outGoingNode should not be NULL. Note that graph edges can also be created using Graph.AddEdge().
```text
public void AddRefTo(
    GraphNode outGoingNode
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode outGoingNode | Input to the outgoing node |

### Clear

#### Description
Clears the flag bit(s) passed in.
```text
public void Clear(
    byte flags
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| byte flags | Input flag values to clear for this node |

### CycleIn

#### Description
When FindCycles() is called, it creates an internal duplicate set of references used to detect and break cycles. 
Note
A call to CycleIn() will only return valid cycle information after a call to Graph.FindCycles(), and only when there are no further changes made to the graph.
```text
public GraphNode CycleIn(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input desired node index |

### CycleOut

#### Description
When FindCycles() is called, it creates an internal duplicate set of references used to detect and break cycles.
Note
A call to CycleOut() will only return valid cycle information after a call to Graph.FindCycles(), and only when there are no further changes made to the graph.
```text
public GraphNode CycleOut(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input desired node index |

### DisconnectAll

#### Description
Removes all of the references between this node and any In() or Out() nodes, or CycleIn() and CycleOut() nodes. It is always called in the destructor. It has the effect of cleaning up any node pointers **to** this node.
```text
public void DisconnectAll();
```

### In

#### Description
Returns the incoming reference at int.
```text
public GraphNode In(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input desired node index |

### IsMarkedAs

#### Description
Returns true if the flag bit(s) passed in match set flag bit(s) in this node.
```text
public bool IsMarkedAs(
    int flag
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int flag | Input flag values to check for this node |

### MarkAs

#### Description
Sets the flag bit(s) passed in.
```text
public void MarkAs(
    byte flags
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| byte flags | Input flag values to set for this node |

### MarkTree

#### Description
Marks this node and all nested out() nodes with the flags value supplied. If an collection is passed in, it also appends this node, and the nested Out() nodes, to the collection. If it finds that this node or any nested nodes already have the flag bit(s) set, it does not follow that branch any further. 
It is the caller's responsibility to clear the flags, using either Graph.ClearAll() or GraphNode.Clear() when done with the flags.
```text
public void MarkTree(
    byte flags, 
    GraphNodeCollection appendedTo
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| byte flags | Input flag values to set for this node and all nested out nodes |
| GraphNodeCollection appendedTo | Input collection that this node and all nested out nodes should optionally be appended to |

### Out

#### Description
Returns the outgoing reference.
```text
public GraphNode Out(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input desired node index |

### RemoveRefTo

#### Description
This is the opposite of AddRefTo(). It removes the entry from the Out() collection, and removes this node from the referenced node's In() collection.
```text
public void RemoveRefTo(
    GraphNode nodeToRemoveReference
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| GraphNode nodeToRemoveReference | Input node to remove reference of |

### SetEdgeGrowthRate

#### Description
This method sets the number of outgoing and incoming edges that are allocated at a time on a graph node. If the node-to-node relationship contains many edges, this method should be called to increase the rate of the outgoing and incoming edges from the defaults of 4 and 2 respectively. Setting the rates to higher values increases performance but may increase memory usage.
```text
public void SetEdgeGrowthRate(
    int outEdgeRate, 
    int inEdgeRate
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int outEdgeRate | Number of outgoing edges allocated at one time |
| int inEdgeRate | Number of incoming edges allocated at one time |

### Data

#### Description
Accesses the data associated with this node.
```text
public IntPtr Data;
```

#### Conditions
Read / Write
### IsCycleNode

#### Description
Assesses if this node is part of a cyclical reference.
```text
public bool IsCycleNode;
```

#### Conditions
Read-only
### NextCycleNode

#### Description
Accesses the next outgoing cyclical reference. It is the same as calling CycleOut(0).
```text
public GraphNode NextCycleNode;
```

#### Conditions
Read-only
### NumCycleIn

#### Description
Accesses the number of incoming cyclical references.
```text
public int NumCycleIn;
```

#### Conditions
Read-only
### NumCycleOut

#### Description
Accesses the number of outgoing cyclical references.
```text
public int NumCycleOut;
```

#### Conditions
Read-only
### NumIn

#### Description
Accesses the number of incoming references to this node.
```text
public int NumIn;
```

#### Conditions
Read-only
### NumOut

#### Description
Accesses the number of outgoing references from this node.
```text
public int NumOut;
```

#### Conditions
Read-only
### Owner

#### Description
Accesses the Graph to which this node is attached.
```text
public Graph Owner;
```

#### Conditions
Read-only