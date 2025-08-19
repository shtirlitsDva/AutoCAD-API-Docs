# ConstrainedCurve Class

## Overview

#### Description
This class represents a constrained curve node in the owning Assoc2dConstraintGroup.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedCircle
            Autodesk.AutoCAD.DatabaseServices.ConstrainedEllipse
            Autodesk.AutoCAD.DatabaseServices.ConstrainedLine
            Autodesk.AutoCAD.DatabaseServices.ConstrainedSpline
```

```text
public class ConstrainedCurve : ConstrainedGeometry;
```

### Properties

- [ConstrainedImplicitPoints](#constrainedimplicitpoints)
- [IsBounded](#isbounded)


## Properties Details

### ConstrainedImplicitPoints

#### Description
Gets the array of references to ConstrainedImplicitPoint objects which belong to this constrained curve. 
An unbounded line (xline) does not have constrained implicit point.
```text
public virtual ConstrainedImplicitPoint ConstrainedImplicitPoints;
```

#### Conditions
Read-only
### IsBounded

#### Description
Indicates whether this constrained curve is bounded.
```text
public virtual bool IsBounded;
```

#### Conditions
Read-only