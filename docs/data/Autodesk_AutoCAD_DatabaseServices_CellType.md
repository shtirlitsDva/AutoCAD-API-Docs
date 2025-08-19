# Autodesk.AutoCAD.DatabaseServices.CellType Enumeration

## Overview

#### Description
This .NET class wraps the [AcDbDataCell::CellType](AcDbDataCell__CellType.md) ObjectARX enum. 
These values specify the data types that can be represented by an DataCell object.
```text
public enum CellType {
  Unknown,
  Integer,
  Double,
  CharPtr,
  Point,
  ObjectId,
  HardOwnerId,
  SoftOwnerId,
  HardPtrId,
  SoftPtrId,
  Bool,
  Vector
}
```

#### Members

| Members | Description |
| --- | --- |
| Unknown | Unspecified, default cell type |
| Integer | Signed 32-bit integer |
| Double | double |
| CharPtr | char * |
| Point | Point3d |
| ObjectId | ObjectId |
| HardOwnerId | HardOwnershipId |
| SoftOwnerId | SoftOwnershipId |
| HardPtrId | HardPointerId |
| SoftPtrId | SoftPointerId |
| Bool | Boolean |
| Vector | Vector3d |