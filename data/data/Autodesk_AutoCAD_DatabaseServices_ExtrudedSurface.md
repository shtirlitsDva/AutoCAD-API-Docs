# ExtrudedSurface Class

## Overview

#### Description
This class represents an extruded surface entity. It provides methods to create and manipulate ASM surfaces.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ExtrudedSurface
```

```text
public class ExtrudedSurface : Autodesk.AutoCAD.DatabaseServices.Surface;
```

#### See Also
SweepOptions

## Members

### Constructors

- [ExtrudedSurface](#extrudedsurface)

### Methods

- [CreateExtrudedSurface](#createextrudedsurface)
- [SetExtrude](#setextrude)

### Properties

- [Height](#height)
- [SweepEntity](#sweepentity)
- [SweepOptions](#sweepoptions)
- [SweepProfile](#sweepprofile)
- [SweepVec](#sweepvec)
- [TaperAngle](#taperangle)


## Constructors Details

### ExtrudedSurface

#### Description
Default constructor.
```text
public ExtrudedSurface();
```

### CreateExtrudedSurface

#### Description
Creates an extruded surface by sweeping a planar curve, region, or planar surface in the direction of the given vector using a distance equal to the length of the vector. Optional parameters may be set through the sweepOptions parameter such as draft angle.
```text
public virtual void CreateExtrudedSurface(
    Entity sweepEnt, 
    Vector3d directionVec, 
    Autodesk.AutoCAD.DatabaseServices.SweepOptions sweepOptions
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity sweepEnt | Input the curve, region, or planar surface to be swept |
| Vector3d directionVec | Input the vector that indicates the direction and distance of the sweep operation |
| Autodesk.AutoCAD.DatabaseServices.SweepOptions sweepOptions | Input sweep options |

### SetExtrude

#### Description
Sets all defining data for the extruded surface.
```text
public void SetExtrude(
    Vector3d sweepVec, 
    Autodesk.AutoCAD.DatabaseServices.SweepOptions sweepOptions
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Vector3d sweepVec | Input extrusion vector |
| Autodesk.AutoCAD.DatabaseServices.SweepOptions sweepOptions | Input sweep options |

### Height

#### Description
Accesses the extrusion height.
```text
public double Height;
```

#### Conditions
Read / Write
### SweepEntity

#### Description
Accesses the sweep entity used to create the extruded surface.
```text
public Entity SweepEntity;
```

#### Conditions
Read-only
### SweepOptions

#### Description
Accesses the options used to create this extruded surface.
```text
public Autodesk.AutoCAD.DatabaseServices.SweepOptions SweepOptions;
```

#### Conditions
Read / Write
### SweepProfile

#### Description
This wraps the ObjectARX [AcDbExtrudedSurface::sweepProfile](AcDbExtrudedSurface__sweepProfile@const.md)() method.
```text
public Profile3d SweepProfile;
```

### SweepVec

#### Description
Accesses the sweep vector.
```text
public Vector3d SweepVec;
```

#### Conditions
Read / Write
### TaperAngle

#### Description
Accesses the angle of taper in radians.
```text
public double TaperAngle;
```

#### Conditions
Read / Write