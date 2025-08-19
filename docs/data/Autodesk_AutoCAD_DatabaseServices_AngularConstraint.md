# AngularConstraint Class

## Overview

#### Description
This class represents an angle constraint node in the owning Assoc2dConstraintGroup. It can be applied between two constrained lines.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint
        Autodesk.AutoCAD.DatabaseServices.ExplicitConstraint
            Autodesk.AutoCAD.DatabaseServices.AngularConstraint
                Autodesk.AutoCAD.DatabaseServices.ThreePointAngleConstraint
```

```text
public class AngularConstraint : ExplicitConstraint;
```

### Constructors

- [AngularConstraint()](#angularconstraint())
- [AngularConstraint(AngularSectorType)](#angularconstraint(angularsectortype))

### Methods

- [AngleMultiplier](#anglemultiplier)
- [SetAngleMultiplier](#setanglemultiplier)

### Other

- [AutoCAD.DatabaseServices.AngularConstraint.AngularSectorType Enumeration](#autocad.databaseservices.angularconstraint.angularsectortype-enumeration)

### Properties

- [SectorType](#sectortype)


## Constructors Details

### AngularConstraint()

#### Description
Default constructor. The angle sector type is set to kParallelAntiClockwise.
```text
public AngularConstraint();
```

### AngularConstraint(AngularSectorType)

#### Description
Constructor.
```text
public AngularConstraint(
    AngularSectorType type
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| AngularSectorType type | Input SectorType indicating the angle sector which is used to measure the angle. |

### AngleMultiplier

#### Description
Returns the current angle multipiler.
```text
public static double AngleMultiplier();
```

#### Returns
The current angle multipiler. The default is Pi/180.
### SetAngleMultiplier

#### Description
Sets a multiplier that is used to multiply angles obtained from AssocValueDependencies that depend on AssocVariables to convert the angles to radians. It is needed because the expression evaluator used by AssocVariables considers all angles to be in degrees. To convert from degrees to radians, the multiplier needs to be set to Pi/180. If no angle multiplier is set, the default is Pi/180.
```text
public static void SetAngleMultiplier(
    double multiplier
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double multiplier | The angle multiplication factor. |

### AutoCAD.DatabaseServices.AngularConstraint.AngularSectorType Enumeration

#### Description
The angle sector type of this angle constraint. It is used to indicate how the angle between two lines is measured.
```text
public enum AngularSectorType {
  ParallelAntiClockwise,
  AntiParallelClockwise,
  ParallelClockwise,
  AntiParallelAntiClockwise
}
```

#### Members

| Members | Description |
| --- | --- |
| ParallelAntiClockwise | The angle measured from the forward direction of line 1 to the forward direction of line 2 anticlockwise. |
| AntiParallelClockwise | The angle measured from the forward direction of line 1 to the non forward direction of line 2 clockwise. |
| ParallelClockwise | The angle measured from the forward direction of line 1 to the forward direction of line 2 clockwise. |
| AntiParallelAntiClockwise | The angle measured from the forward direction of line 1 to the non forward direction of line 2 anticlockwise. |


## Properties Details

### SectorType

#### Description
Gets the angle sector type of this angle constraint.
```text
public AngularSectorType SectorType;
```

#### Conditions
Read-only