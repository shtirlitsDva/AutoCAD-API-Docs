# SweptSurface Class

## Overview

#### Description
This .NET class wraps the AcDbSweptSurface ObjectARX class. This class represents a swept surface entity. It provides methods to create and manipulate ASM surfaces
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Surface
            Autodesk.AutoCAD.DatabaseServices.SweptSurface
```

```text
public class SweptSurface : Surface;
```

### Constructors

- [SweptSurface](#sweptsurface)

### Methods

- [CreateSweptSurface](#createsweptsurface)

### Properties

- [Bank](#bank)
- [PathEntity](#pathentity)
- [PathLength](#pathlength)
- [PathProfile](#pathprofile)
- [ProfileRotation](#profilerotation)
- [ScaleAlongPath](#scalealongpath)
- [SweepEntity](#sweepentity)
- [SweepOptions](#sweepoptions)
- [SweepProfile](#sweepprofile)
- [TwistAlongPath](#twistalongpath)


## Constructors Details

### SweptSurface

#### Description
Constructor.
```text
public SweptSurface();
```

### CreateSweptSurface

#### Description
Creates a swept surface by sweeping a curve, region, or planar surface (sweepEnt) along the path curve pathEnt. Optional parameters, such as draft angle may be set through the sweepOptions parameter.
```text
public virtual void CreateSweptSurface(
    Entity sweepEnt, 
    Entity pathEnt, 
    Autodesk.AutoCAD.DatabaseServices.SweepOptions sweepOptions
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity sweepEnt | Input the curve, region, or planar surface to be swept |
| Entity pathEnt | Input the curve entity that specifies the path along which sweepEnt is to be swept |
| Autodesk.AutoCAD.DatabaseServices.SweepOptions sweepOptions | Input sweep options |

### Bank

#### Description
The sweep face or curve will be banked along the sweep path.
```text
public bool Bank;
```

#### Conditions
Read / Write
### PathEntity

#### Description
Returns the sweep path of this surface.
```text
public Entity PathEntity;
```

#### Conditions
Read-only
### PathLength

#### Description
Returns the length of the path curve.
```text
public double PathLength;
```

#### Conditions
Read-only
### PathProfile

#### Description
This wraps the ObjectARX[AcDbSweptSurface::pathProfile](AcDbSweptSurface__pathProfile@const.md)() method.
```text
public Profile3d PathProfile;
```

### ProfileRotation

#### Description
Specifies angle sweep of profile object.
```text
public double ProfileRotation;
```

#### Conditions
Read / Write
### ScaleAlongPath

#### Description
Specifies scaling of profile object.
```text
public double ScaleAlongPath;
```

#### Conditions
Read / Write
### SweepEntity

#### Description
Returns the sweep entity that describes this surface.
```text
public Entity SweepEntity;
```

#### Conditions
Read-only
### SweepOptions

#### Description
Returns the sweep options associated with this surface.
```text
public Autodesk.AutoCAD.DatabaseServices.SweepOptions SweepOptions;
```

#### Conditions
Read / Write
### SweepProfile

#### Description
This wraps the ObjectARX [AcDbSweptSurface::sweepProfile](AcDbSweptSurface__sweepProfile@const.md)() method.
```text
public Profile3d SweepProfile;
```

### TwistAlongPath

#### Description
Specifies rotation of profile object.
```text
public double TwistAlongPath;
```

#### Conditions
Read / Write