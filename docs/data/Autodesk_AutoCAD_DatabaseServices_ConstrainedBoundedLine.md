# ConstrainedBoundedLine Class

## Overview

#### Description
This class represents a constrained bounded line node in the owning Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedLine
                Autodesk.AutoCAD.DatabaseServices.ConstrainedBoundedLine
```

```text
public class ConstrainedBoundedLine : ConstrainedLine;
```

### Constructors

- [ConstrainedBoundedLine()](#constrainedboundedline())
- [ConstrainedBoundedLine(ObjectId, [MarshalAs(UnmanagedType.U1)] bool)](#constrainedboundedline(objectid,-[marshalas(unmanagedtype.u1)]-bool))

### Properties

- [EndPoint](#endpoint)
- [IsRay](#isray)
- [MidPoint](#midpoint)
- [StartPoint](#startpoint)


## Constructors Details

### ConstrainedBoundedLine()

#### Description
Default constructor.
```text
public ConstrainedBoundedLine();
```

### ConstrainedBoundedLine(ObjectId, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Constructor.
```text
public ConstrainedBoundedLine(
    ObjectId geomDependencyId, 
    [MarshalAs(UnmanagedType.U1)] bool ray
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId geomDependencyId | Input ObjectId indicating the AssocGeomDependency object to which this constrained line is holding on. |
| [MarshalAs(UnmanagedType.U1)] bool ray | Input Boolean indicating whether this bounded line is a ray. |

### EndPoint

#### Description
Gets the end point of the bounded line, relative to the work plane of the owning Assoc2dConstraintGroup object. 
It is invalid for ray.
```text
public Point3d EndPoint;
```

#### Conditions
Read-only
### IsRay

#### Description
Indicates whether this bounded line is a ray - a partially bounded line. 
If it is true, the start point represents the single bounding point, and the ray is considered to point away from this point in the direction specified by direction().
```text
public bool IsRay;
```

#### Conditions
Read-only
### MidPoint

#### Description
Gets the mid point of the bounded line, relative to the work plane of the owning Assoc2dConstraintGroup object. 
It is invalid for ray.
```text
public Point3d MidPoint;
```

#### Conditions
Read-only
### StartPoint

#### Description
Gets the start point of the bounded line, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d StartPoint;
```

#### Conditions
Read-only