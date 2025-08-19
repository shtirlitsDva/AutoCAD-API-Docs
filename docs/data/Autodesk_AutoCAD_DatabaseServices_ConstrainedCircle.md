# ConstrainedCircle Class

## Overview

#### Description
This class represents a constrained circle node in the owning Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedCircle
                Autodesk.AutoCAD.DatabaseServices.ConstrainedArc
```

```text
public class ConstrainedCircle : ConstrainedCurve;
```

### Constructors

- [ConstrainedCircle()](#constrainedcircle())
- [ConstrainedCircle(ObjectId)](#constrainedcircle(objectid))

### Properties

- [CenterPoint](#centerpoint)
- [Radius](#radius)


## Constructors Details

### ConstrainedCircle()

#### Description
Default constructor.
```text
public ConstrainedCircle();
```

### ConstrainedCircle(ObjectId)

#### Description
Constructor.
```text
public ConstrainedCircle(
    ObjectId geomDependencyId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId geomDependencyId | Input ObjectId indicating the AssocGeomDependency object to which this constrained circle is holding on. |

### CenterPoint

#### Description
Gets the center point of the constrained circle, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d CenterPoint;
```

#### Conditions
Read-only
### Radius

#### Description
Gets the radius of the constrained circle.
```text
public double Radius;
```

#### Conditions
Read-only