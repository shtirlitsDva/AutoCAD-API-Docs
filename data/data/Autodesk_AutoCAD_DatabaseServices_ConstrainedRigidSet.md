# ConstrainedRigidSet Class

## Overview

#### Description
This class represents a constrained rigid set node in the owning Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedRigidSet
```

```text
public class ConstrainedRigidSet : ConstrainedGeometry;
```

### Constructors

- [ConstrainedRigidSet()](#constrainedrigidset())
- [ConstrainedRigidSet([MarshalAs(UnmanagedType.U1)] bool, Matrix3d)](#constrainedrigidset([marshalas(unmanagedtype.u1)]-bool,-matrix3d))

### Methods

- [GetConstrainedGeomAt](#getconstrainedgeomat)

### Properties

- [NumOfConstrainedGeoms](#numofconstrainedgeoms)
- [Transform](#transform)


## Constructors Details

### ConstrainedRigidSet()

#### Description
Default constructor.
```text
public ConstrainedRigidSet();
```

### ConstrainedRigidSet([MarshalAs(UnmanagedType.U1)] bool, Matrix3d)

#### Description
Constructor.
```text
public ConstrainedRigidSet(
    [MarshalAs(UnmanagedType.U1)] bool bScalable, 
    Matrix3d trans
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool bScalable | Input boolean indicating whether this rigid set can be uniformly scaled or not. |
| Matrix3d trans | Input Matrix3d indicating the initial transform of this rigid set Relative to the work plane of the owning Assoc2dConstraintGroup object. |

### GetConstrainedGeomAt

#### Description
Returns the reference to the constrained geometry.
```text
public ConstrainedGeometry GetConstrainedGeomAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input the index. |

#### Returns
ConstrainedGeometry.
### NumOfConstrainedGeoms

#### Description
Gets the number of contained constrained geometries.
```text
public int NumOfConstrainedGeoms;
```

#### Conditions
Read-only
### Transform

#### Description
Gets the transform of this rigid set, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Matrix3d Transform;
```

#### Conditions
Read-only