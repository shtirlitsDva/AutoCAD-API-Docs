# ConstrainedSpline Class

## Overview

#### Description
This class represents a constrained NURBS spline node in the owning Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedSpline
```

```text
public class ConstrainedSpline : ConstrainedCurve;
```

### Constructors

- [ConstrainedSpline()](#constrainedspline())
- [ConstrainedSpline(ObjectId, NurbCurve3d)](#constrainedspline(objectid,-nurbcurve3d))

### Methods

- [DefinePointAt](#definepointat)

### Properties

- [NumOfDefinePoints](#numofdefinepoints)
- [NurbSpline](#nurbspline)


## Constructors Details

### ConstrainedSpline()

#### Description
Default constructor.
```text
public ConstrainedSpline();
```

### ConstrainedSpline(ObjectId, NurbCurve3d)

#### Description
Constructor.
```text
public ConstrainedSpline(
    ObjectId geomDependencyId, 
    NurbCurve3d spline
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId geomDependencyId | Input ObjectId indicating the AssocGeomDependency object to which this constrained spline is holding on. |
| NurbCurve3d spline | Input NurbCurve3d indicating the AcGe representation of this constrained spline Relative to the work plane of the owning Assoc2dConstraintGroup object. |

### DefinePointAt

#### Description
Returns the define point of the constrained spline. Relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public Point3d DefinePointAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input the index. |

#### Returns
Point3d.
### NumOfDefinePoints

#### Description
Gets the number of define points of the constrained spline. 
Currently, only spline control points are supported. For closed spline, the number of define point is number of control point minus 1.
```text
public int NumOfDefinePoints;
```

#### Conditions
Read-only
### NurbSpline

#### Description
Gets the NurbCurve3d representation of the constrained spline, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public NurbCurve3d NurbSpline;
```

#### Conditions
Read-only