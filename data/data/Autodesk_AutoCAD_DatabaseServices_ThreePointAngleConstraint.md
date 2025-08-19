# ThreePointAngleConstraint Class

## Overview

#### Description
This class represents an angle constraint node in the owning Assoc2dConstraintGroup. 
It can be applied between 3 constrained points.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint
        Autodesk.AutoCAD.DatabaseServices.ExplicitConstraint
            Autodesk.AutoCAD.DatabaseServices.AngularConstraint
                Autodesk.AutoCAD.DatabaseServices.ThreePointAngleConstraint
```

```text
public class ThreePointAngleConstraint : AngularConstraint;
```

### Constructors

- [ThreePointAngleConstraint()](#threepointangleconstraint())
- [ThreePointAngleConstraint(AngularConstraint.AngularSectorType)](#threepointangleconstraint(angularconstraint.angularsectortype))


## Constructors Details

### ThreePointAngleConstraint()

#### Description
Default constructor. The angle sector type is set to ParallelAntiClockwise.
```text
public ThreePointAngleConstraint();
```

### ThreePointAngleConstraint(AngularConstraint.AngularSectorType)

#### Description
Constructor.
```text
public ThreePointAngleConstraint(
    AngularConstraint.AngularSectorType type
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| AngularConstraint.AngularSectorType type | Input SectorType indicating the angle sector which is used to measure the angle. |
