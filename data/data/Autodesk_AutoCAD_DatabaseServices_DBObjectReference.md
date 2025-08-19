# DBObjectReference Structure

## Overview

#### Description
This class contains an object's ID and the DXF group code that represents the object's type.
```text
public struct DBObjectReference {
}
```

### Constructors

- [DBObjectReference](#dbobjectreference)

### Properties

- [Kind](#kind)
- [ObjectId](#objectid)


## Constructors Details

### DBObjectReference

#### Description
This constructor sets the ID and kind of object reference.
```text
public DBObjectReference(
    Autodesk.AutoCAD.DatabaseServices.ObjectId id, 
    int kind
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ObjectId id | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object |
| int kind | Input System.Int32 object |

### Kind

#### Description
Returns the Kind property value.
```text
public int Kind;
```

#### Conditions
Read-only
### ObjectId

#### Description
Accesses the object ID.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId ObjectId;
```

#### Conditions
Read-only