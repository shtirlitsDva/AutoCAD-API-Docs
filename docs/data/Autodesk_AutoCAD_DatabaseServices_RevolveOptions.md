# RevolveOptions Class

## Overview

#### Description
This .NET class wraps the AcDbRevolveOptions ObjectARX class. 
Utility class for setting options used by CreateRevolvedSurface() and CreateRevolvedSolid(). These options can be used to control the shape of the resulting surface or solid. The default constructor for this class assigns default values to these options.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.RevolveOptions
```

```text
public sealed class RevolveOptions : DisposableWrapper, ICloneable;
```

#### See Also
RevolvedSurface

## Members

### Constructors

- [RevolveOptions()](#revolveoptions())
- [RevolveOptions(RevolveOptions)](#revolveoptions(revolveoptions))

### Methods

- [CheckRevolveCurve](#checkrevolvecurve)
- [Clone](#clone)

### Properties

- [CloseToAxis](#closetoaxis)
- [DraftAngle](#draftangle)
- [TwistAngle](#twistangle)


## Constructors Details

### RevolveOptions()

#### Description
Default constructor.
```text
public RevolveOptions();
```

### RevolveOptions(RevolveOptions)

#### Description
Copy constructor.
```text
public RevolveOptions(
    RevolveOptions opts
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| RevolveOptions opts | Input object to be copied. |

### CheckRevolveCurve

#### Description
Checks whether the entity is valid for revolve operation. This function is called by CreateRevolvedSurface() and CreateRevolvedSolid(), so it is not necessary for an application to call this function.
```text
public RevolveOptionsCheckRevolveCurveOut CheckRevolveCurve(
    Entity __unnamed000, 
    Point3d axisPnt, 
    Vector3d axisDir, 
    [MarshalAs(UnmanagedType.U1)] bool displayErrorMessages
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d axisPnt | Input point on axis of revolution |
| Vector3d axisDir | Input direction of axis of revolution |
| [MarshalAs(UnmanagedType.U1)] bool displayErrorMessages | Input Boolean value indicating whether to display error messages |
| unnamed | Input the curve or region to be revolved |

### Clone

#### Description
Clones the object.
```text
public object Clone();
```

### CloseToAxis

#### Description
Accesses the close to axis option. If this option is set for an open profile, then the ends of the profile will be extended to the axis of revolution before revolving. The default value of this option is false.
```text
public bool CloseToAxis;
```

#### Conditions
Read-only
### DraftAngle

#### Description
Accesses the draft angle in radians. 
This is the angle by which profile will taper as it is revolved around the axis. The default value of this option is 0.
```text
public double DraftAngle;
```

#### Conditions
Read-only
### TwistAngle

#### Description
Accesses the angle by which the profile will be twisted as it revolves around the axis in radians. The default value of this option is 0.
```text
public double TwistAngle;
```

#### Conditions
Read-only