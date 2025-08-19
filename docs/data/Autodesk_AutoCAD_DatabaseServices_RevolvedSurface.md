# RevolvedSurface Class

## Overview

#### Description
This .NET class wraps the AcDbRevolvedSurface ObjectARX class. 
This class represents a revolved surface entity. It provides methods to create and manipulate ASM surfaces.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.RevolvedSurface
```

```text
public class RevolvedSurface : Autodesk.AutoCAD.DatabaseServices.Surface;
```

#### See Also
RevolveOptions

## Members

### Constructors

- [RevolvedSurface](#revolvedsurface)

### Methods

- [CreateRevolvedSurface](#createrevolvedsurface)
- [SetRevolve](#setrevolve)

### Properties

- [AxisDirection](#axisdirection)
- [AxisPoint](#axispoint)
- [RevolveAngle](#revolveangle)
- [RevolveEntity](#revolveentity)
- [RevolveOptions](#revolveoptions)
- [RevolveProfile](#revolveprofile)
- [StartAngle](#startangle)


## Constructors Details

### RevolvedSurface

#### Description
Default constructor.
```text
public RevolvedSurface();
```

### CreateRevolvedSurface

#### Description
Creates a revolved surface of revolution from a given curve, region, or planar surface and an axis of revolution defined by a point and vector. The starting angle and revolve angles are also specified. revolveEntity will be revolved counterclockwise about the axisDirection vector.
```text
public virtual void CreateRevolvedSurface(
    Entity revolveEntity, 
    Point3d axisPoint, 
    Vector3d axisDirection, 
    double revolveAngle, 
    double startAngle, 
    Autodesk.AutoCAD.DatabaseServices.RevolveOptions revolveOptions
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity revolveEntity | Input the planar curve, region, or planar surface that is to be revolved |
| Point3d axisPoint | Input point on the axis of revolution |
| Vector3d axisDirection | Input direction on the axis of revolution |
| double revolveAngle | Input angle of rotation in radians |
| double startAngle | Input start angle of rotation, in radians. If 0, then rotation will start from current position of revolveEntity |
| Autodesk.AutoCAD.DatabaseServices.RevolveOptions revolveOptions | Input revolve options |

### SetRevolve

#### Description
Sets all the defining data for the revolved surface.
```text
public void SetRevolve(
    Point3d axisPoint, 
    Vector3d axisDirection, 
    double revolveAngle, 
    Autodesk.AutoCAD.DatabaseServices.RevolveOptions revolveOptions
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d axisPoint | Input axis point |
| Vector3d axisDirection | Input axis vector |
| double revolveAngle | Input angle of revolution, in radians |
| Autodesk.AutoCAD.DatabaseServices.RevolveOptions revolveOptions | Input revolve options |

### AxisDirection

#### Description
Accesses the axis direction.
```text
public Vector3d AxisDirection;
```

#### Conditions
Read / Write
### AxisPoint

#### Description
Accesses the axis point around which the entity will be revolved.
```text
public Point3d AxisPoint;
```

#### Conditions
Read / Write
### RevolveAngle

#### Description
Accesses the angle of revolution, in radians.
```text
public double RevolveAngle;
```

#### Conditions
Read / Write
### RevolveEntity

#### Description
Accesses the entity which is being revolved.
```text
public Entity RevolveEntity;
```

#### Conditions
Read-only
### RevolveOptions

#### Description
Accesses the revolve options for this surface.
```text
public Autodesk.AutoCAD.DatabaseServices.RevolveOptions RevolveOptions;
```

#### Conditions
Read / Write
### RevolveProfile

#### Description
This wraps the ObjectARX [AcDbRevolvedSurface::revolveProfile](AcDbRevolvedSurface__revolveProfile@const.md)() method.
```text
public Profile3d RevolveProfile;
```

### StartAngle

#### Description
Accesses the starting angle.
```text
public double StartAngle;
```

#### Conditions
Read-only