# ConstrainedBoundedEllipse Class

## Overview

#### Description
This class represents a constrained ellipse arc node in the owning Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedEllipse
                Autodesk.AutoCAD.DatabaseServices.ConstrainedBoundedEllipse
```

```text
public class ConstrainedBoundedEllipse : ConstrainedEllipse;
```

### Constructors

- [ConstrainedBoundedEllipse()](#constrainedboundedellipse())
- [ConstrainedBoundedEllipse(ObjectId)](#constrainedboundedellipse(objectid))

### Properties

- [EndPoint](#endpoint)
- [StartPoint](#startpoint)


## Constructors Details

### ConstrainedBoundedEllipse()

#### Description
Default constructor.
```text
public ConstrainedBoundedEllipse();
```

### ConstrainedBoundedEllipse(ObjectId)

#### Description
Constructor.
```text
public ConstrainedBoundedEllipse(
    ObjectId geomDependencyId
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId geomDependencyId | Input ObjectId indicating the AssocGeomDependency object to which this constrained bounded ellipse is holding on. |

### EndPoint

#### Description
Gets the end point of the constrained bounded ellipse, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d EndPoint;
```

#### Conditions
Read-only
### StartPoint

#### Description
Gets the start point of the constrained bounded ellipse, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d StartPoint;
```

#### Conditions
Read-only