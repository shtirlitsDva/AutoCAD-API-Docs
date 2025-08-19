# CompositeConstraint Class

## Overview

#### Description
This class represents a composite constraint node in the owning Assoc2dConstraintGroup. It is the base class for all the kind of composite constraints, the owned constraints are all applied on(connected with) the same constrained geometries.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.GeometricalConstraint
        Autodesk.AutoCAD.DatabaseServices.CompositeConstraint
            Autodesk.AutoCAD.DatabaseServices.G2SmoothConstraint
```

```text
public class CompositeConstraint : GeometricalConstraint;
```

### Properties

- [OwnedConstraints](#ownedconstraints)


## Properties Details

### OwnedConstraints

#### Description
Gets the array of references to GeometricalConstraint objects which are owned by this composite constraint.
```text
public GeometricalConstraint OwnedConstraints;
```

#### Conditions
Read-only