# FullSubentityPath Structure

## Overview

#### Description
This .NET class wraps the AcDbFullSubentPath ObjectARX class. 
This class is used for uniquely identifying a subentity within a particular entity. An object of this class consists of array of object IDs and an SubentityId object. 
The subentity ID object contains the graphics system marker of the subentity and the type of the subentity (that is, edge, face, vertex). The object ID array contains a sequential list of the object IDs for all the objects that make up the "path" from the outermost entity (in Model or Paper space) down into the "main" entity that the subentity is a part of. If the subentity's "main" entity is directly owned by the Model Space or Paper Space BlockTableRecords then the object ID array will have only one entry--the object ID of the "main" entity itself. 
For example, an edge of an Solid3d that's within a block definition that's referenced by an BlockReference would result in an object ID array with two object IDs. The first would be the object ID of the BlockReference. The second would be the object ID of the Solid3d.
```text
public struct FullSubentityPath {
}
```

#### Notes
GetSubentPathAtGsMarker() method of Entity class returns object of this class for subentity identification purposes. Objects of this class are further used for highlighting and unhighlighting of a particular subentity and creating new entity
### Constructors

- [FullSubentityPath](#fullsubentitypath)

### Methods

- [Equals](#equals)
- [GetHashCode](#gethashcode)
- [GetObjectIds](#getobjectids)

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [IsNull](#isnull)
- [Null](#null)
- [SubentId](#subentid)


## Constructors Details

### FullSubentityPath

#### Description
Initializes the embedded ObjectIdCollection with __ ids and the embedded SubentityId with index.
```text
public FullSubentityPath(
    ObjectId\[\] ids, 
    SubentityId index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId[] ids | Input object ID array |
| SubentityId index | Input subent ID object |

### Equals

#### Description
Returns true if this object is identical to the argument object.
```text
public sealed override bool Equals(
    object obj
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| object obj | Object to compare to |

### GetHashCode

#### Description
Returns the hash code for this object. See the Microsoft .NET API documentation for details.
```text
public sealed override int GetHashCode();
```

### GetObjectIds

#### Description
Returns an array of object IDs for all objects in this subentity path.
```text
public ObjectId\[\] GetObjectIds();
```

### != Operator

#### Description
Returns true if a does not equal b
```text
public static bool operator !=(
    FullSubentityPath a, 
    FullSubentityPath b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath a | Left operand |
| FullSubentityPath b | Right operand |

### == Operator

#### Description
Returns true if a does not equal b
```text
public static bool operator ==(
    FullSubentityPath a, 
    FullSubentityPath b
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| FullSubentityPath a | Left operand |
| FullSubentityPath b | Right operand |

### IsNull

#### Description
Compares if the object is a null subentity or not.
```text
public bool IsNull;
```

#### Conditions
Read / Write
### Null

#### Description
Accesses the Null property value. 
```text
public static FullSubentityPath Null;
```

#### Conditions
Read-only
### SubentId

#### Description
Accesses the const copy of the embedded SubentityId.
```text
public SubentityId SubentId;
```

#### Conditions
Read-only