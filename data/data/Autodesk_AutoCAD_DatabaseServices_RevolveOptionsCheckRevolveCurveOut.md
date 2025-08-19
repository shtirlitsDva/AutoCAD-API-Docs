# RevolveOptionsCheckRevolveCurveOut Class

## Overview

#### Description
This class encapsulates the values output by the RevolveOptions.CheckRevolveCurve() method.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.RevolveOptionsCheckRevolveCurveOut
```

```text
public class RevolveOptionsCheckRevolveCurveOut;
```

### Constructors

- [RevolveOptionsCheckRevolveCurveOut](#revolveoptionscheckrevolvecurveout)

### Properties

- [Closed](#closed)
- [EndPointsOnAxis](#endpointsonaxis)
- [Planar](#planar)


## Constructors Details

### RevolveOptionsCheckRevolveCurveOut

#### Description
Constructor.
```text
public RevolveOptionsCheckRevolveCurveOut();
```

### Closed

#### Description
Assesses whether the region is closed.
```text
public bool Closed;
```

#### Conditions
Read-only
### EndPointsOnAxis

#### Description
Assesses whether whether the curve is open and its endpoints lie on the axis of revolution
```text
public bool EndPointsOnAxis;
```

#### Conditions
Read-only
### Planar

#### Description
Assesses whether the curve is planar.
```text
public bool Planar;
```

#### Conditions
Read-only