# RadiusDiameterConstraint Class

## Overview

#### Description
This class represents a radius or diameter constraint node in the owning Assoc2dConstraintGroup. 
It can be applied on one circle(arc) or ellipse(bounded ellipse).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint
        Autodesk.AutoCAD.DatabaseServices.ExplicitConstraint
            Autodesk.AutoCAD.DatabaseServices.RadiusDiameterConstraint
```

```text
public class RadiusDiameterConstraint : ExplicitConstraint;
```

### Constructors

- [RadiusDiameterConstraint()](#radiusdiameterconstraint())
- [RadiusDiameterConstraint(RadDiaConstrType)](#radiusdiameterconstraint(raddiaconstrtype))

### Other

- [AutoCAD.DatabaseServices.RadiusDiameterConstraint.RadDiaConstrType Enumeration](#autocad.databaseservices.radiusdiameterconstraint.raddiaconstrtype-enumeration)

### Properties

- [ConstrType](#constrtype)


## Constructors Details

### RadiusDiameterConstraint()

#### Description
Default constructor. The constraint type is set to [CircleRadius](Autodesk_AutoCAD_DatabaseServices_RadiusDiameterConstraint_RadDiaConstrType.md).
```text
public RadiusDiameterConstraint();
```

### RadiusDiameterConstraint(RadDiaConstrType)

#### Description
Constructor.
```text
public RadiusDiameterConstraint(
    RadDiaConstrType type
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| RadDiaConstrType type | Input [RadDiaConstrType](Autodesk_AutoCAD_DatabaseServices_RadiusDiameterConstraint_RadDiaConstrType.md) indicating the constraint type. |

### AutoCAD.DatabaseServices.RadiusDiameterConstraint.RadDiaConstrType Enumeration

#### Description
The constraint type of this constraint. It is used to indicate whether radius or diameter is measured.
```text
public enum RadDiaConstrType {
  CircleRadius,
  CircleDiameter,
  MinorRadius,
  MajorRadius
}
```

#### Members
| Members | Description |
| --- | --- |
| CircleRadius | The radius of a constrained circle or arc is measured. |
| CircleDiameter | The diameter of a constrained circle or arc is measured. |
| MinorRadius | The minor radius of a constrained (bounded) ellipse is measured. |
| MajorRadius | The major radius of a constrained (bounded) ellipse is measured. |


## Properties Details

### ConstrType

#### Description
Gets the constraint type of this constraint.
```text
public RadDiaConstrType ConstrType;
```

#### Conditions
Read-only