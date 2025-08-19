# SweepOptions Class

## Overview

#### Description
This .NET class wrap the ObjectARX [AcDbSweepOptions](AcDbSweepOptions.md) class. 
Use [SweepOptionsBuilder class](Autodesk_AutoCAD_DatabaseServices_SweepOptionsBuilder.md "SweepOptionsBuilder Class") to set sweep options.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.SweepOptions
```

```text
public sealed class SweepOptions : DisposableWrapper, ICloneable;
```

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


## Properties Details

### Align

#### Description
This wraps the ObjectARX [AcDbSweepOptions::align](AcDbSweepOptions__align.md) method.
```text
public SweepOptionsAlignOption Align;
```

#### Conditions
Read-only
### AlignAngle

#### Description
This wraps the ObjectARX [AcDbSweepOptions::alignAngle](AcDbSweepOptions__alignAngle.md) method.
```text
public double AlignAngle;
```

#### Conditions
Read-only
### AlignStart

#### Description
This wraps the ObjectARX [AcDbSweepOptions::alignStart](AcDbSweepOptions__alignStart.md) method.
```text
public bool AlignStart;
```

#### Conditions
Read-only
### Bank

#### Description
This wraps the ObjectARX [AcDbSweepOptions::bank](AcDbSweepOptions__bank.md) method.
```text
public bool Bank;
```

#### Conditions
Read-only
### BasePoint

#### Description
The wraps the ObjectARX [AcDbSweepOptions::basePoint](AcDbSweepOptions__basePoint.md) method.
```text
public Point3d BasePoint;
```

#### Conditions
Read-only
### CheckIntersections

#### Description
This wraps the ObjectARX [AcDbSweepOptions::checkIntersections](AcDbSweepOptions__checkIntersections.md) method.
```text
public bool CheckIntersections;
```

#### Conditions
Read-only
### DraftAngle

#### Description
This wraps the ObjectARX [AcDbSweepOptions::draftAngle](AcDbSweepOptions__draftAngle.md) method.
```text
public double DraftAngle;
```

#### Conditions
Read-only
### EndDraftDist

#### Description
This wraps the ObjectARX [AcDbSweepOptions::endDraftDist](AcDbSweepOptions__endDraftDist.md) method.
```text
public double EndDraftDist;
```

#### Conditions
Read-only
### PathEntityTransform

#### Description
This wraps the ObjectARX [AcDbSweepOptions::getPathEntityTransform](AcDbSweepOptions__getPathEntityTransform@AcGeMatrix3d_.md) method.
```text
public Matrix3d PathEntityTransform;
```

#### Conditions
Read-only
### ScaleFactor

#### Description
This wraps the ObjectARX [AcDbSweepOptions::scaleFactor](AcDbSweepOptions__scaleFactor.md) method.
```text
public double ScaleFactor;
```

#### Conditions
Read-only
### StartDraftDist

#### Description
This wraps the ObjectARX [AcDbSweepOptions::startDraftDist](AcDbSweepOptions__startDraftDist.md) method.
```text
public double StartDraftDist;
```

#### Conditions
Read-only
### SweepEntityTransform

#### Description
This wraps the ObjectARX [AcDbSweepOptions::getSweepEntityTransform](AcDbSweepOptions__getSweepEntityTransform@AcGeMatrix3d_.md) method.
```text
public Matrix3d SweepEntityTransform;
```

#### Conditions
Read-only
### TwistAngle

#### Description
This wraps the ObjectARX [AcDbSweepOptions::twistAngle](AcDbSweepOptions__twistAngle.md) method.
```text
public double TwistAngle;
```

#### Conditions
Read-only