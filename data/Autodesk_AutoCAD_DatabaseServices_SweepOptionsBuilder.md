# SweepOptionsBuilder Class

## Overview

#### Description
Allows SweepOptions to be set.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.SweepOptionsBuilder
```

```text
public class SweepOptionsBuilder;
```

### Methods

- [ToSweepOptions](#tosweepoptions)

### Properties

- [Align](#align)
- [AlignAngle](#alignangle)
- [AlignStart](#alignstart)
- [Bank](#bank)
- [BasePoint](#basepoint)
- [CheckIntersections](#checkintersections)
- [DraftAngle](#draftangle)
- [EndDraftDist](#enddraftdist)
- [PathEntityTransform](#pathentitytransform)
- [ScaleFactor](#scalefactor)
- [StartDraftDist](#startdraftdist)
- [SweepEntityTransform](#sweepentitytransform)
- [TwistAngle](#twistangle)


## Methods Details

### ToSweepOptions

#### Description
Returns SweepOptions.
```text
public SweepOptions ToSweepOptions();
```

### Align

#### Description
Gets and sets the alignment.
```text
public SweepOptionsAlignOption Align;
```

#### Conditions
Read / Write
### AlignAngle

#### Description
Gets and sets the align angle.
```text
public double AlignAngle;
```

#### Conditions
Read / Write
### AlignStart

#### Description
Gets and sets the align start option.
```text
public bool AlignStart;
```

#### Conditions
Read / Write
### Bank

#### Description
Gets and sets the bank option.
```text
public bool Bank;
```

#### Conditions
Read / Write
### BasePoint

#### Description
Gets and sets the alignment base point.
```text
public Point3d BasePoint;
```

#### Conditions
Read / Write
### CheckIntersections

#### Description
Gets and sets the self-intersection check option.
```text
public bool CheckIntersections;
```

#### Conditions
Read / Write
### DraftAngle

#### Description
Gets and sets the draft angle option.
```text
public double DraftAngle;
```

#### Conditions
Read / Write
### EndDraftDist

#### Description
Gets and sets the end draft distance.
```text
public double EndDraftDist;
```

#### Conditions
Read / Write
### PathEntityTransform

#### Description
Gets and sets the coordinate system at the start/end of the path curve.
```text
public Matrix3d PathEntityTransform;
```

#### Conditions
Read / Write
### ScaleFactor

#### Description
Gets and sets the scale factor.
```text
public double ScaleFactor;
```

#### Conditions
Read / Write
### StartDraftDist

#### Description
Gets and sets the draft distance.
```text
public double StartDraftDist;
```

#### Conditions
Read / Write
### SweepEntityTransform

#### Description
Gets and sets the coordinate system for the sweep entity.
```text
public Matrix3d SweepEntityTransform;
```

#### Conditions
Read / Write
### TwistAngle

#### Description
Gets and sets the twist angle.
```text
public double TwistAngle;
```

#### Conditions
Read / Write