# ConstrainedImplicitPoint Class

## Overview

#### Description
This class represents a constrained implicit point node in the owning Assoc2dConstraintGroup. 
A constrained implicit point is always associated with a constrained curve; it may be the start point, end point, center point or define point (only valid for spline control point now) of the curve. 
A constrained implicit point does not hold a reference to a AssocGeomDependency object.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedPoint
            Autodesk.AutoCAD.DatabaseServices.ConstrainedImplicitPoint
```

```text
public class ConstrainedImplicitPoint : ConstrainedPoint;
```

### Constructors

- [ConstrainedImplicitPoint()](#constrainedimplicitpoint())
- [ConstrainedImplicitPoint(uint, Autodesk.AutoCAD.DatabaseServices.ImplicitPointType, int)](#constrainedimplicitpoint(uint,-autodesk.autocad.databaseservices.implicitpointtype,-int))

### Properties

- [ConstrainedCurveId](#constrainedcurveid)
- [Point](#point)
- [PointIndex](#pointindex)
- [PointType](#pointtype)


## Constructors Details

### ConstrainedImplicitPoint()

#### Description
Default constructor.
```text
public ConstrainedImplicitPoint();
```

### ConstrainedImplicitPoint(uint, Autodesk.AutoCAD.DatabaseServices.ImplicitPointType, int)

#### Description
Constructor.
```text
public ConstrainedImplicitPoint(
    uint constrCurvId, 
    Autodesk.AutoCAD.DatabaseServices.ImplicitPointType ptype, 
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| uint constrCurvId | Input ConstraintGroupNodeId indicating the constrained curve to which this implicit point belongs. |
| Autodesk.AutoCAD.DatabaseServices.ImplicitPointType ptype | Input ImplicitPointType indicating the type of this implicit point. |
| int index | Input int indicating the define point index of this implicit point. It is only valid when the point type is kDefineImplicit. Default value is -1 (invalid index). |

### ConstrainedCurveId

#### Description
Gets the ConstraintGroupNodeId of the constrained curve to which this implicit point belongs.
```text
public uint ConstrainedCurveId;
```

#### Conditions
Read-only
### Point

#### Description
Gets the point position, relative to the work plane of the owning Assoc2dConstraintGroup object.
```text
public override Point3d Point;
```

#### Conditions
Read-only
### PointIndex

#### Description
Gets the defined point index of this implicit point 
If the point type is not DefineImplicit, it is -1.
```text
public int PointIndex;
```

#### Conditions
Read-only
### PointType

#### Description
Gets the type of this implicit point.
```text
public Autodesk.AutoCAD.DatabaseServices.ImplicitPointType PointType;
```

#### Conditions
Read-only