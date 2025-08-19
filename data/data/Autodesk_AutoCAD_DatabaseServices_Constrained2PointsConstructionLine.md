# Constrained2PointsConstructionLine Class

## Overview

#### Description
This class represents a constrained unbounded construction line node in the owning Assoc2dConstraintGroup. Internally it is made coincident to two ConstrainedPoint objects.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedLine
                Autodesk.AutoCAD.DatabaseServices.ConstrainedConstructionLine
                    Autodesk.AutoCAD.DatabaseServices.Constrained2PointsConstructionLine
```

```text
public class Constrained2PointsConstructionLine : ConstrainedConstructionLine;
```

### Constructors

- [Constrained2PointsConstructionLine()](#constrained2pointsconstructionline())
- [Constrained2PointsConstructionLine(Point3d, Point3d)](#constrained2pointsconstructionline(point3d,-point3d))


## Constructors Details

### Constrained2PointsConstructionLine()

#### Description
Default constructor.
```text
public Constrained2PointsConstructionLine();
```

### Constrained2PointsConstructionLine(Point3d, Point3d)

#### Description
Constructor.
```text
public Constrained2PointsConstructionLine(
    Point3d point1, 
    Point3d point2
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d point1 | Input first 3D point. Relative to the work plane of the owning Assoc2dConstraintGroup object. |
| Point3d point2 | Input second 3D point. Relative to the work plane of the owning Assoc2dConstraintGroup object. |
