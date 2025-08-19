# ConstrainedArc Class

## Overview

#### Description
This class represents a constrained arc node in the owning Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedCircle
                Autodesk.AutoCAD.DatabaseServices.ConstrainedArc
```

```text
public class ConstrainedArc : ConstrainedCircle;
```

### Constructors

- [ConstrainedArc()](#constrainedarc())
- [ConstrainedArc(ObjectId)](#constrainedarc(objectid))

### Properties

- [EndPoint](#endpoint)
- [MidPoint](#midpoint)
- [StartPoint](#startpoint)


## Constructors Details

### ConstrainedArc()

#### Description
Default constructor.
```text
public ConstrainedArc();
```

### ConstrainedArc(ObjectId)

#### Description
Constructor.
```text
public ConstrainedArc(
    ObjectId geomDependencyId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId geomDependencyId | Input ObjectId indicating the AssocGeomDependency object to which this constrained arc is holding on. |

### EndPoint

#### Description
Gets the end point of the constrained arc, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d EndPoint;
```

#### Conditions
Read-only
### MidPoint

#### Description
Gets the mid point of the constrained arc, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d MidPoint;
```

#### Conditions
Read-only
### StartPoint

#### Description
Gets the start point of the constrained arc, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d StartPoint;
```

#### Conditions
Read-only