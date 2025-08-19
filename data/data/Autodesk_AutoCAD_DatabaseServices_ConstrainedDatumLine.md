# ConstrainedDatumLine Class

## Overview

#### Description
This class represents a constrained datum unbounded line node in the owning Assoc2dConstraintGroup. 
It is read-only and for reference as datum line, e.g., X datum line and Y datum line.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedLine
                Autodesk.AutoCAD.DatabaseServices.ConstrainedConstructionLine
                    Autodesk.AutoCAD.DatabaseServices.ConstrainedDatumLine
```

```text
public class ConstrainedDatumLine : ConstrainedConstructionLine;
```

### Constructors

- [ConstrainedDatumLine()](#constraineddatumline())
- [ConstrainedDatumLine(Point3d, Vector3d)](#constraineddatumline(point3d,-vector3d))


## Constructors Details

### ConstrainedDatumLine()

#### Description
Default constructor.
```text
public ConstrainedDatumLine();
```

### ConstrainedDatumLine(Point3d, Vector3d)

#### Description
Constructor.
```text
public ConstrainedDatumLine(
    Point3d pointOnLine, 
    Vector3d direction
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d pointOnLine | Input any 3D point. Relative to the work plane of the owning Assoc2dConstraintGroup object. |
| Vector3d direction | Input any 3D vector(must not be zero length). Relative to the work plane of the owning Assoc2dConstraintGroup object. |
