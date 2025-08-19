# BlendOptions Class

## Overview

#### Description
The wraps the ObjectARX [AcDbBlendOptions](AcDbBlendOptions.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.BlendOptions
```

```text
public sealed class BlendOptions : DisposableWrapper, ICloneable;
```

### Constructors

- [BlendOptions](#blendoptions)

### Other

- [AutoCAD.DatabaseServices.BlendOptions.DriveModeType Enumeration](#autocad.databaseservices.blendoptions.drivemodetype-enumeration)

### Properties

- [CoplanarDirection](#coplanardirection)
- [CoplanarPoint](#coplanarpoint)
- [DriveMode](#drivemode)
- [Quality](#quality)
- [Simplify](#simplify)
- [Solid](#solid)


## Constructors Details

### BlendOptions

#### Description
This wraps the ObjectARX [AcDbBlendOptions::AcDbBlendOptions](AcDbBlendOptions__AcDbBlendOptions.md)() method.
```text
public BlendOptions();
```

### AutoCAD.DatabaseServices.BlendOptions.DriveModeType Enumeration

#### Description
This wraps the ObjectARX [AcDbBlendOptions::DriveModeType](AcDbBlendOptions__DriveModeType.md) enum.
```text
public enum DriveModeType {
  DriveModeFirst,
  DriveModeSecond,
  DriveModeBoth
}
```


## Properties Details

### CoplanarDirection

#### Description
This wraps the ObjectARX [AcDbBlendOptions::coplanarDirection](AcDbBlendOptions__coplanarDirection@const.md) () method.
```text
public Vector3d? CoplanarDirection;
```

### CoplanarPoint

#### Description
This wraps the ObjectARX [AcDbBlendOptions::coplanarPoint](AcDbBlendOptions__coplanarPoint@const.md)() method.
```text
public Point3d? CoplanarPoint;
```

### DriveMode

#### Description
This wraps the ObjectARX [AcDbBlendOptions::driveMode](AcDbBlendOptions__driveMode@const.md) () method.
```text
public DriveModeType DriveMode;
```

### Quality

#### Description
This wraps the ObjectARX [AcDbBlendOptions::quality](AcDbBlendOptions__quality@const.md)() method.
```text
public uint Quality;
```

### Simplify

#### Description
This wraps the ObjectARX [AcDbBlendOptions::simplify](AcDbBlendOptions__simplify@const.md)() method.
```text
public bool Simplify;
```

### Solid

#### Description
This wraps the ObjectARX [AcDbBlendOptions::solid](AcDbBlendOptions__solid@const.md)() method.
```text
public bool Solid;
```
