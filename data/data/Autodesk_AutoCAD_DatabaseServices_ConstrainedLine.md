# ConstrainedLine Class

## Overview

#### Description
This class represents a constrained unbounded line node in the owning Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedLine
                Autodesk.AutoCAD.DatabaseServices.ConstrainedBoundedLine
                Autodesk.AutoCAD.DatabaseServices.ConstrainedConstructionLine
```

```text
public class ConstrainedLine : ConstrainedCurve;
```

### Constructors

- [ConstrainedLine()](#constrainedline())
- [ConstrainedLine(ObjectId)](#constrainedline(objectid))

### Properties

- [Direction](#direction)
- [PointOnLine](#pointonline)


## Constructors Details

### ConstrainedLine()

#### Description
Default constructor.
```text
public ConstrainedLine();
```

### ConstrainedLine(ObjectId)

#### Description
Constructor.
```text
public ConstrainedLine(
    ObjectId geomDependencyId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId geomDependencyId | Input ObjectId indicating the AssocGeomDependency object to which this constrained line is holding on. |

### Direction

#### Description
Gets the direction unit vector of the unbounded line, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Vector3d Direction;
```

#### Conditions
Read-only
### PointOnLine

#### Description
Gets some arbitrary point on the unbounded line, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d PointOnLine;
```

#### Conditions
Read-only