# ObjectIdGraphNode Class

## Overview

#### Description
Wraps the ObjectARX [AcDbObjectIdGraphNode](AcDbObjectIdGraphNode.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GraphNode
    Autodesk.AutoCAD.DatabaseServices.ObjectIdGraphNode
```

```text
public sealed class ObjectIdGraphNode : GraphNode;
```

### Constructors

- [ObjectIdGraphNode](#objectidgraphnode)

### Methods

- [Create](#create)

### Properties

- [Id](#id)


## Constructors Details

### ObjectIdGraphNode

#### Description
Constructor.
```text
public ObjectIdGraphNode(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input ObjectId that the node will contain. |

### Create

#### Description
This static method creates and returns a new ObjectIdGraphNode.
```text
public static ObjectIdGraphNode Create(
    IntPtr unmanagedPointer, 
    [MarshalAs(UnmanagedType.U1)] bool autoDelete
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IntPtr unmanagedPointer | Input pointer to the AcDbObjectIdGraphNode object that the new ObjectIdGraphNode will wrap. |
| [MarshalAs(UnmanagedType.U1)] bool autoDelete | Input boolean indicating whether the wrapped AcDbObjectIdGraphNode should be deleted when this ObjectIdGraphNode is destroyed. |

### Id

#### Description
Gets the ObjectId contained by this ObjectIdGraphNode.
```text
public ObjectId Id;
```

#### Conditions
Read-only