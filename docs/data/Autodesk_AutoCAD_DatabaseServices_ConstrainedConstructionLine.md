# ConstrainedConstructionLine Class

## Overview

#### Description
This class represents a constrained unbounded construction line node in the owning Assoc2dConstraintGroup. 
It does not take any initial value and its position is decided by the constraints applied on it.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ConstraintGroupNode
    Autodesk.AutoCAD.DatabaseServices.ConstrainedGeometry
        Autodesk.AutoCAD.DatabaseServices.ConstrainedCurve
            Autodesk.AutoCAD.DatabaseServices.ConstrainedLine
                Autodesk.AutoCAD.DatabaseServices.ConstrainedConstructionLine
                    Autodesk.AutoCAD.DatabaseServices.Constrained2PointsConstructionLine
                    Autodesk.AutoCAD.DatabaseServices.ConstrainedDatumLine
```

```text
public class ConstrainedConstructionLine : ConstrainedLine;
```

## Members

### Constructors

- [ConstrainedConstructionLine](#constrainedconstructionline)


## Constructors Details

### ConstrainedConstructionLine

#### Description
Protected default constructor.
```text
protected internal ConstrainedConstructionLine(
    IntPtr unmanagedObjPtr, 
    [MarshalAs(UnmanagedType.U1)] bool autoDelete
);
```
