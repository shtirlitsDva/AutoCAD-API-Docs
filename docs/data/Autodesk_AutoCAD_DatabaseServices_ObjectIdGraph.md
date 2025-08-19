# ObjectIdGraph Class

## Overview

#### Description
This .NET class wraps the AcDbObjectIdGraph ObjectARX class. 
ObjectIdGraph is derived from Graph and is used to represent the relationship of object IDs to one another. This class is used by the one pass purge method (Database.Purge(ObjectIdGraph idGraph)) to represent the references from one object ID to another. 
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Graph
    Autodesk.AutoCAD.DatabaseServices.ObjectIdGraph
```

```text
public sealed class ObjectIdGraph : Graph;
```

### Constructors

- [ObjectIdGraph](#objectidgraph)

### Methods

- [AddNode](#addnode)
- [DelNode](#delnode)
- [FindNode](#findnode)
- [IdNode](#idnode)


## Constructors Details

### ObjectIdGraph

#### Description
Constructor for the ObjectIdGraph class.
```text
public ObjectIdGraph();
```

### AddNode

#### Description
This function will add the ObjectIdGraphNode _nodeToAdd_ to the graph.
```text
public void AddNode(
    ObjectIdGraphNode nodeToAdd
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectIdGraphNode nodeToAdd | Input ObjectIdGraphNode to add to the graph. |

### DelNode

#### Description
Removes the ObjectIdGraphNode _nodeToDelete_ from the graph, and the AcDbObjectIdGraph wrapped by this ObjectIdGraph deletes the AcDbObjectIdGraphNode wrapped by _nodeToDelete_.
```text
public void DelNode(
    ObjectIdGraphNode nodeToDelete
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| nodeToAdd | Input ObjectIdGraphNode to remove from the graph. |

### FindNode

#### Description
Finds the ObjectIdGraphNode that contains the ObjectId _id_ and returns that ObjectIdGraphNode or null if no node with that id is found in the graph.
```text
public ObjectIdGraphNode FindNode(
    ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId id | Input ObjectId for node to find. |

### IdNode

#### Description
Returns the ObjectIdGraphNode at _index_ in the ObjectIdGraph, or null if that index is not valid.
```text
public ObjectIdGraphNode IdNode(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input zero based index of the node to get. |
