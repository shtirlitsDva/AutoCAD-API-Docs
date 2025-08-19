# LoftProfile Class

## Overview

#### Description
This wraps the ObjectARX [AcDbLoftProfile](AcDbLoftProfile.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Profile3d
    Autodesk.AutoCAD.DatabaseServices.LoftProfile
```

```text
public class LoftProfile : Profile3d;
```

### Constructors

- [LoftProfile()](#loftprofile())
- [LoftProfile(Entity)](#loftprofile(entity))
- [LoftProfile(LoftProfile)](#loftprofile(loftprofile))
- [LoftProfile(PathRef)](#loftprofile(pathref))
- [LoftProfile(Point3d)](#loftprofile(point3d))

### Methods

- [CopyFrom(LoftProfile)](#copyfrom(loftprofile))
- [CopyFrom(Profile3d)](#copyfrom(profile3d))

### Properties

- [Continuity](#continuity)
- [Magnitude](#magnitude)


## Constructors Details

### LoftProfile()

#### Description
This wraps the ObjectARX [AcDbLoftProfile::AcDbLoftProfile](AcDbLoftProfile__AcDbLoftProfile.md) () method.
```text
public LoftProfile();
```

### LoftProfile(Entity)

#### Description
This wraps the ObjectARX [AcDbLoftProfile::AcDbLoftProfile](AcDbLoftProfile__AcDbLoftProfile@AcDbEntity__.md) () method.
```text
public LoftProfile(
    Entity entity
);
```

### LoftProfile(LoftProfile)

#### Description
This wraps the ObjectARX [AcDbLoftProfile::AcDbLoftProfile](AcDbLoftProfile__AcDbLoftProfile@AcDbLoftProfile_.md) () method.
```text
public LoftProfile(
    LoftProfile LoftProfile
);
```

### LoftProfile(PathRef)

#### Description
This wraps the ObjectARX [AcDbLoftProfile::AcDbLoftProfile](AcDbLoftProfile__AcDbLoftProfile@AcDbPathRef__.md) ( const AcDbPathRef&amp; pathRef) method.
```text
public LoftProfile(
    PathRef pathRef
);
```

### LoftProfile(Point3d)

#### Description
This wraps the ObjectARX[AcDbLoftProfile::AcDbLoftProfile](AcDbLoftProfile__AcDbLoftProfile@AcGePoint3d_.md) () method.
```text
public LoftProfile(
    Point3d pnt
);
```

### CopyFrom(LoftProfile)

#### Description
This wraps the ObjectARX [AcDbLoftProfile::operator =](AcDbLoftProfile__=@AcDbLoftProfile_.md) () method.
```text
public void CopyFrom(
    LoftProfile source
);
```

### CopyFrom(Profile3d)

#### Description
This wraps the ObjectARX [AcDbLoftProfile::operator =](AcDbLoftProfile__=@AcDb3dProfile_.md) () method.
```text
public void CopyFrom(
    Profile3d source
);
```

### Continuity

#### Description
This wraps the ObjectARX [AcDbLoftProfile::continuity](AcDbLoftProfile__continuity@const.md)() and [AcDbLoftProfile::setContinuity](AcDbLoftProfile__setContinuity@Adesk__Int16.md)() methods.
```text
public short Continuity;
```

### Magnitude

#### Description
This wraps the ObjectARX [AcDbLoftProfile::magnitude](AcDbLoftProfile__magnitude@const.md)() and [AcDbLoftProfile::setMagnitude](AcDbLoftProfile__setMagnitude@double.md)() methods.
```text
public double Magnitude;
```
