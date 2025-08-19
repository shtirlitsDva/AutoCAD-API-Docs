# DistanceConstraint Class

## Overview

#### Description
This class represents a distance constraint node in the owning Assoc2dConstraintGroup. It can be applied between two constrained geometries (normally two points).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint
        Autodesk.AutoCAD.DatabaseServices.ExplicitConstraint
            Autodesk.AutoCAD.DatabaseServices.DistanceConstraint
```

```text
public class DistanceConstraint : ExplicitConstraint;
```

### Constructors

- [DistanceConstraint()](#distanceconstraint())
- [DistanceConstraint(uint, DistanceDirectionType)](#distanceconstraint(uint,-distancedirectiontype))
- [DistanceConstraint(Vector3d)](#distanceconstraint(vector3d))

### Other

- [AutoCAD.DatabaseServices.DistanceConstraint.DistanceDirectionType Enumeration](#autocad.databaseservices.distanceconstraint.distancedirectiontype-enumeration)

### Properties

- [ConstrainedLineId](#constrainedlineid)
- [Direction](#direction)
- [DirectionType](#directiontype)


## Constructors Details

### DistanceConstraint()

#### Description
Default constructor. The direction type is set to NotDirected.
```text
public DistanceConstraint();
```

### DistanceConstraint(uint, DistanceDirectionType)

#### Description
Constructor. The direction type is set to PerpendicularToLine or ParallelToLine.
```text
public DistanceConstraint(
    uint consLineId, 
    DistanceDirectionType type
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| uint consLineId | Input AcConstraintGroupNodeId indicating the constrained line whose direction is used to measure the distance. |
| DistanceDirectionType type | Input DirectionType indicating the direction type which must be either PerpendicularToLine or ParallelToLine. |

### DistanceConstraint(Vector3d)

#### Description
Constructor. The direction type is set to FixedDirection.
```text
public DistanceConstraint(
    Vector3d direction
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Vector3d direction | Input AcGeVector3d indicating the fixed direction which is used to measure the distance. The vector length must not be zero. |

### AutoCAD.DatabaseServices.DistanceConstraint.DistanceDirectionType Enumeration

#### Description
The direction type of this distance constraint. It is mainly used to indicate how the distance between the two geometries are measured.
```text
public enum DistanceDirectionType {
  NotDirected,
  FixedDirection,
  PerpendicularToLine,
  ParallelToLine
}
```

#### Members
| Members | Description |
| --- | --- |
| NotDirected | Not directed distance. The minimum distance between the two geometries is measured. |
| FixedDirection | Directed distance with fixed direction. The distance between the two geometries is measured along the fixed direction. |
| PerpendicularToLine | Directed distance with relative direction. The distance between the two geometries is measured along the direction which is perpendicular to an existing constraint line. |
| ParallelToLine | Directed distance with relative direction. The distance between the two geometries is measured along the direction which is parallel to an existing constraint line. |


## Properties Details

### ConstrainedLineId

#### Description
Gets the constrained line id. Only valid when the direction type is PerpendicularToLine or ParallelToLine.
```text
public uint ConstrainedLineId;
```

#### Conditions
Read-only
### Direction

#### Description
Gets the fixed direction of this distance constraint. Only valid when the direction type is FixedDirection.
```text
public Vector3d Direction;
```

#### Conditions
Read-only
### DirectionType

#### Description
Gets the direction type of this distance constraint.
```text
public DistanceDirectionType DirectionType;
```

#### Conditions
Read-only