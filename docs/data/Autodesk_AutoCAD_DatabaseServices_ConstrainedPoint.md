# ConstrainedPoint Class

## Overview

#### Description
This class represents a constrained point node in the owning Assoc2dConstraintGroup. 
Usually It holds a reference to a AssocGeomDependency object which may be the insertion point of a block reference or a grip point of a custom entity.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedPoint
            Autodesk.AutoCAD.DatabaseServices.ConstrainedImplicitPoint
```

```text
public class ConstrainedPoint : ConstrainedGeometry;
```

### Constructors

- [ConstrainedPoint()](#constrainedpoint())
- [ConstrainedPoint(ObjectId)](#constrainedpoint(objectid))

### Properties

- [Point](#point)


## Constructors Details

### ConstrainedPoint()

#### Description
Default constructor
```text
public ConstrainedPoint();
```

### ConstrainedPoint(ObjectId)

#### Description
Constructor.
```text
public ConstrainedPoint(
    ObjectId geomDependencyId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId geomDependencyId | Input ObjectId indicating the AssocGeomDependency object to which this constrained line is holding on. |

### Point

#### Description
Gets the point position, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public virtual Point3d Point;
```

#### Conditions
Read-only