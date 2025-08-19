# XrefObjectId Structure

## Overview

#### Description
This .NET class wraps the AcDbXrefObjectId ObjectARX class. 
The purpose of XrefObjectId is to provide a convenient way to refer to a specific DBObject within an xref'd database. XrefObjectId is persistent across drawing sessions. 
Note that if the object in question is wblock'd into another file, the XrefObjectId still refers to the original object, and not to the new object.
```text
public struct XrefObjectId {
}
```

### Constructors

- [XrefObjectId(Autodesk.AutoCAD.DatabaseServices.ObjectId)](#xrefobjectid(autodesk.autocad.databaseservices.objectid))
- [XrefObjectId(Autodesk.AutoCAD.DatabaseServices.ObjectId, Autodesk.AutoCAD.DatabaseServices.Handle)](#xrefobjectid(autodesk.autocad.databaseservices.objectid,-autodesk.autocad.databaseservices.handle))

### Methods

- [Deserialize](#deserialize)
- [Equals](#equals)
- [ResolveObjectId](#resolveobjectid)
- [Serialize](#serialize)

### Other

- [!= Operator](#!=-operator)
- [== Operator](#==-operator)

### Properties

- [Handle](#handle)
- [IsNull](#isnull)
- [IsValid](#isvalid)
- [IsXref](#isxref)
- [ObjectId](#objectid)


## Constructors Details

### XrefObjectId(Autodesk.AutoCAD.DatabaseServices.ObjectId)

#### Description
Constructor.
```text
public XrefObjectId(
    Autodesk.AutoCAD.DatabaseServices.ObjectId LocalId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ObjectId LocalId | Input Autodesk.AutoCAD.DatabaseServices.ObjectId  object. |

### XrefObjectId(Autodesk.AutoCAD.DatabaseServices.ObjectId, Autodesk.AutoCAD.DatabaseServices.Handle)

#### Description
Constructor.
```text
public XrefObjectId(
    Autodesk.AutoCAD.DatabaseServices.ObjectId XrefBlockTableRecordId, 
    Autodesk.AutoCAD.DatabaseServices.Handle hand
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.ObjectId XrefBlockTableRecordId | Input Autodesk.AutoCAD.DatabaseServices.ObjectId  object. |
| Autodesk.AutoCAD.DatabaseServices.Handle hand | Input Autodesk.AutoCAD.DatabaseServices.Handle object. |

### Deserialize

#### Description
Turns the sequence of data between rbStart and rbEnd back into this object.
```text
public static XrefObjectId Deserialize(
    ResultBuffer rbStart, 
    out ResultBuffer rbEnd
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ResultBuffer rbStart | Input Autodesk.AutoCAD.DatabaseServices.ResultBuffer object. |
| out ResultBuffer rbEnd | Input Autodesk.AutoCAD.DatabaseServices.ResultBuffer object. |

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
| object obj | Input System.Object object. |

### ResolveObjectId

#### Description
Returns the ID of the object within the xref.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId ResolveObjectId();
```

### Serialize

#### Description
Serializes or files out DBObject.
```text
public ResultBuffer Serialize();
```

### != Operator

#### Description
Returns true if a does not equal b.
```text
public static bool operator !=(
    XrefObjectId a, 
    XrefObjectId b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| XrefObjectId a | Left operand |
| XrefObjectId b | Right operand |

### == Operator

#### Description
Returns true if a is equal to b.
```text
public static bool operator ==(
    XrefObjectId a, 
    XrefObjectId b
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| XrefObjectId a | Left operand |
| XrefObjectId b | Right operand |

### Handle

#### Description
Handle of the object within the Xref data.
```text
public Autodesk.AutoCAD.DatabaseServices.Handle Handle;
```

#### Conditions
Read-only
### IsNull

#### Description
Returns true if this object does not refer to any other object.
```text
public bool IsNull;
```

#### Conditions
Read-only
### IsValid

#### Description
This returns true if the xref is loaded and the handle is valid within that xref. This method actually performs the check and does not rely on a cached value. 
**Warning** Calling this too frequently may have performance implications. 
```text
public bool IsValid;
```

#### Conditions
Read-only
### IsXref

#### Description
```text
public bool IsXref;
```

#### Conditions
Read-only 
Read-only
### ObjectId

#### Description
Object ID of the object local to the host database.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId ObjectId;
```

#### Conditions
Read / Write