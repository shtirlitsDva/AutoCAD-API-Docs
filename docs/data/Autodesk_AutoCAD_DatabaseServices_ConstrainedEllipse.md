# ConstrainedEllipse Class

## Overview

#### Description
This class represents a constrained ellipse node in the owning Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedEllipse
                Autodesk.AutoCAD.DatabaseServices.ConstrainedBoundedEllipse
```

```text
public class ConstrainedEllipse : ConstrainedCurve;
```

### Constructors

- [ConstrainedEllipse()](#constrainedellipse())
- [ConstrainedEllipse(ObjectId)](#constrainedellipse(objectid))

### Properties

- [CenterPoint](#centerpoint)
- [Direction](#direction)
- [MajorRadius](#majorradius)
- [MinorRadius](#minorradius)


## Constructors Details

### ConstrainedEllipse()

#### Description
Default constructor.
```text
public ConstrainedEllipse();
```

### ConstrainedEllipse(ObjectId)

#### Description
Constructor.
```text
public ConstrainedEllipse(
    ObjectId geomDependencyId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId geomDependencyId | Input ObjectId indicating the AssocGeomDependency object to which this constrained ellipse is holding on. |

### CenterPoint

#### Description
Gets the center point of the constrained ellipse, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d CenterPoint;
```

#### Conditions
Read-only
### Direction

#### Description
Gets the direction unit vector of the major axis of the constrained ellipse, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Vector3d Direction;
```

#### Conditions
Read-only
### MajorRadius

#### Description
Gets the major radius of the constrained ellipse. The major radius may be smaller than minor radius, this is different from EllipArc3d.
```text
public double MajorRadius;
```

#### Conditions
Read-only
### MinorRadius

#### Description
Gets the minor radius of the constrained ellipse. 
The minor radius may be larger than major radius, this is different from EllipArc3d.
```text
public double MinorRadius;
```

#### Conditions
Read-only