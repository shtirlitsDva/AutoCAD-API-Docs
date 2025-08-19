# DataCell Class

## Overview

#### Description
This .NET class wraps the AcDbDataCell ObjectARX class. 
The DataCell class provides a way to represent the following data types in a generic manner: Boolean, integer, double, char*, Point3d, ObjectId, AcDbHardOwnershipId, SoftOwnershipId, AcDbHardPointerId, and AcDbSoftPointerId. It provides a full complement of copy constructors, assignment operators, and cast operators to make it simple and safe to use DataCell cells as an underlying type.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DataCell
```

```text
public sealed class DataCell : RXObject;
```

### Constructors

- [DataCell](#datacell)

### Methods

- [Init](#init)
- [SetBool](#setbool)
- [SetDouble](#setdouble)
- [SetHardOwnershipId](#sethardownershipid)
- [SetHardPointerId](#sethardpointerid)
- [SetInteger](#setinteger)
- [SetObjectId](#setobjectid)
- [SetPoint](#setpoint)
- [SetSoftOwnershipId](#setsoftownershipid)
- [SetSoftPointerId](#setsoftpointerid)
- [SetString](#setstring)
- [SetVector](#setvector)

### Properties

- [CellType](#celltype)
- [Value](#value)


## Constructors Details

### DataCell

#### Description
Default constructor.
```text
public DataCell();
```

### Init

#### Description
This function re-initializes the cell by clearing its value.
```text
public void Init();
```

### SetBool

#### Description
Sets a boolean value for this cell.
```text
public void SetBool(
    [MarshalAs(UnmanagedType.U1)] bool value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool value | Input System.Boolean object. |

### SetDouble

#### Description
Sets a double value for this cell.
```text
public void SetDouble(
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double value | Input System.Double object. |

### SetHardOwnershipId

#### Description
Sets the hard ownership id for this cell.
```text
public void SetHardOwnershipId(
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object. |

### SetHardPointerId

#### Description
Sets the hard pointer ID for this cell.
```text
public void SetHardPointerId(
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object |

### SetInteger

#### Description
Sets an integer value for this cell.
```text
public void SetInteger(
    int value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int value | Input System.Int32 object. |

### SetObjectId

#### Description
Sets an object ID value for this cell.
```text
public void SetObjectId(
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object |

### SetPoint

#### Description
Sets a 3D point ID value for this cell.
```text
public void SetPoint(
    Point3d value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d value | Input Autodesk.AutoCAD.Geometry.Point3d object |

### SetSoftOwnershipId

#### Description
Sets a soft ownership ID value for this cell.
```text
public void SetSoftOwnershipId(
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object |

### SetSoftPointerId

#### Description
Sets a soft pointer ID value for this cell.
```text
public void SetSoftPointerId(
    ObjectId value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId value | Input Autodesk.AutoCAD.DatabaseServices.ObjectId object |

### SetString

#### Description
Sets a string value for this cell.
```text
public void SetString(
    string value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string value | Input System.String object |

### SetVector

#### Description
Sets a 3D vector value for this cell.
```text
public void SetVector(
    Vector3d value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vector3d value | Input Autodesk.AutoCAD.Geometry.Vector3d object. |

### CellType

#### Description
Accesses the type associated with this cell
```text
public Autodesk.AutoCAD.DatabaseServices.CellType CellType;
```

#### Conditions
Read-only
### Value

#### Description
Accesses the value of this cell
```text
public object Value;
```

#### Conditions
Read-only