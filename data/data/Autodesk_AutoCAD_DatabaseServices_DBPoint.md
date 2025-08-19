# DBPoint Class

## Overview

#### Description
This .NET class wraps the AcDbPoint ObjectARX class. 
It represents the point entity within AutoCAD. A point entity has a position value to locate it in space. It also has a normal vector, which is used to determine its extrusion direction and to determine the plane on which to display the point's graphics if they are something other than a "." (the PDMODE system variable controls this display). The point entity has a thickness that is its "length" in the direction of its normal vector (that is, its extrusion length).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.DBPoint
```

```text
public class DBPoint : Entity;
```

#### See Also
DBObject

## Members

### Constructors

- [DBPoint()](#dbpoint())
- [DBPoint(Point3d)](#dbpoint(point3d))

### Properties

- [EcsRotation](#ecsrotation)
- [Normal](#normal)
- [Position](#position)
- [Thickness](#thickness)


## Constructors Details

### DBPoint()

#### Description
Default constructor.
```text
public DBPoint();
```

### DBPoint(Point3d)

#### Description
Constructs a point that uses position for its position value. The normal is initialized to (0,0,1) (in WCS coordinates), the OCS rotation to 0, and the thickness to 0.
```text
public DBPoint(
    Point3d position
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d position | Input position (in WCS coordinates) for the point |

### EcsRotation

#### Description
Accesses the angle (in radians) between the OCS (formerly ECS) X axis for the point (based on the point's normal vector) and the X axis that will be used when displaying the point. This is used when PDMODE is set to display the point as something other than a ".".
```text
public double EcsRotation;
```

#### Conditions
Read / Write
### Normal

#### Description
Accesses unit normal vector for the point in WCS coordinates. The normal is used as the extrusion direction when the point has non-zero thickness. The normal also determines the plane used to display the point when PDMODE is set to display the point as something other than a ".".
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### Position

#### Description
Accesses the points position value in WCS coordinates.
```text
public Point3d Position;
```

#### Conditions
Read / Write
### Thickness

#### Description
Accesses the point's thickness value. The thickness is the point's dimension along its normal vector direction (sometimes called the extrusion direction).
```text
public double Thickness;
```

#### Conditions
Read / Write