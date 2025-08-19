# HatchLoop Class

## Overview

#### Description
This class encapsulates data for defining a hatch boundary loop. See the Hatch.appendLoop(Adesk.Int32 loopType, const Point2dArray vertices, const AcGeDoubleArray bulges) ObjectARX function documentation for information on this data and its use
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.HatchLoop
```

```text
public sealed class HatchLoop;
```

### Constructors

- [HatchLoop](#hatchloop)

### Properties

- [Curves](#curves)
- [IsPolyline](#ispolyline)
- [LoopType](#looptype)
- [Polyline](#polyline)


## Constructors Details

### HatchLoop

#### Description
Constructs a new HatchLoop object with a boundary loop (polyline) appended to the hatch entity.
```text
public HatchLoop(
    HatchLoopTypes loopType
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| HatchLoopTypes loopType | Input type of loop |

### Curves

#### Description
Accesses the curves in the hatch loop.
```text
public Curve2dCollection Curves;
```

#### Conditions
Read-only
### IsPolyline

#### Description
Assesses true if the hatch loop is a polyline.
```text
public bool IsPolyline;
```

#### Conditions
Read-only
### LoopType

#### Description
Accesses the type of loop.
```text
public HatchLoopTypes LoopType;
```

#### Conditions
Read-only
### Polyline

#### Description
Accesses the polylines in the hatch loop.
```text
public BulgeVertexCollection Polyline;
```

#### Conditions
Read-only