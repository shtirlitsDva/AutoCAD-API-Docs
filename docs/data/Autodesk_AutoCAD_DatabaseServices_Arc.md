# Arc Class

## Overview

#### Description
This .NET class wraps the AcDbArc ObjectARX class. 
The Arc class represents the arc entity within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Arc
```

```text
public class Arc : Curve;
```

#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Point3d](Autodesk_AutoCAD_Geometry_Point3d.md), [Vector3d](Autodesk_AutoCAD_Geometry_Vector3d.md)

## Members

### Constructors

- [Arc()](#arc())
- [Arc(Point3d, double, double, double)](#arc(point3d,-double,-double,-double))
- [Arc(Point3d, Vector3d, double, double, double)](#arc(point3d,-vector3d,-double,-double,-double))

### Properties

- [Center](#center)
- [EndAngle](#endangle)
- [Length](#length)
- [Normal](#normal)
- [Radius](#radius)
- [StartAngle](#startangle)
- [Thickness](#thickness)
- [TotalAngle](#totalangle)


## Constructors Details

### Arc()

#### Description
Default constructor. Initializes the normal to (0,0,1), the center point to (0,0,0), the radius, start, and end angles to 0.0. The radius needs to be changed to a non-zero value before closing the arc for the first time. The center point and normal must be in WCS coordinates.
```text
public Arc();
```

### Arc(Point3d, double, double, double)

#### Description
This constructor creates an arc using the values passed in. center must be in WCS coordinates. The arc is initialized with a normal of (0,0,1) and a thickness of 0.0.
```text
public Arc(
    Point3d center, 
    double radius, 
    double startAngle, 
    double endAngle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d center | Input the center point of the arc. |
| double radius | Input the radius of the arc. |
| double startAngle | Input the starting angle of the arc. |
| double endAngle | Input the ending angle of the arc. |

### Arc(Point3d, Vector3d, double, double, double)

#### Description
This constructor creates an arc using the values passed in. center must be in WCS coordinates. The arc is initialized with a thickness of 0.0.
```text
public Arc(
    Point3d center, 
    Vector3d normal, 
    double radius, 
    double startAngle, 
    double endAngle
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d center | Input the center point of the arc. |
| Vector3d normal | Input the normal vector of the plane containing the arc. |
| double radius | Input the radius of the arc. |
| double startAngle | Input the starting angle of the arc. |
| double endAngle | Input the ending angle of the arc. |

### Center

#### Description
Accesses the center to be the center point for the arc; it must be in WCS coordinates.
```text
public Point3d Center;
```

#### Conditions
Read / Write
#### Notes
The center point value is the WCS equivalent of DXF group code 10.
### EndAngle

#### Description
Accesses the end angle of the arc, which must be in radians.
```text
public double EndAngle;
```

#### Conditions
Read / Write
#### Notes
The angle is relative to the OCS X axis for the arc with positive angles going counterclockwise when looking down the Z axis towards the origin. The OCS X axis is determined by using the arc’s normal, the WCS Z axis, and the arbitrary axis algorithm. 
If the angle is provided with a negative value, the arc is still drawn counterclockwise but measured in the reverse direction. For example, an arc specified with 4.7124 radians (270 degrees) is the same as -1.5708 (-90 degrees). 
The end angle value is used for DXF group code 51.
### Length

#### Description
Accesses the length of the arc.
```text
public double Length;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the normal vector of the plane containing the arc. normal must be in WCS coordinates and must be non-zero length.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
#### Notes
The normal value is used for DXF group code 210.
### Radius

#### Description
Accesses the radius of the arc.
```text
public double Radius;
```

#### Conditions
Read / Write
#### Notes
The radius value is assigned to the DXF group code 40.
### StartAngle

#### Description
Accesses the the start angle of the arc, which must be in radians.
```text
public double StartAngle;
```

#### Conditions
Read / Write
#### Notes
The angle is relative to the OCS X axis for the arc with positive angles going counterclockwise when looking down the Z axis towards the origin. The OCS X axis is determined by using the arc’s normal, the WCS Z axis, and the arbitrary axis algorithm. 
If the angle is provided with a negative value, the arc is still drawn counterclockwise but measured in the reverse direction. For example, an arc specified with 4.7124 radians (270 degrees) is the same as -1.5708 (-90 degrees). 
The start angle value is used for DXF group code 50.
### Thickness

#### Description
Accesses the arc’s thickness
```text
public double Thickness;
```

#### Conditions
Read / Write
#### Notes
The thickness is the arc’s dimension along its normal vector direction (sometimes called the extrusion direction). 
The thickness value is used for DXF group code 39.
### TotalAngle

#### Description
Accesses the angle sweep of the arc segment.
```text
public double TotalAngle;
```

#### Conditions
Read / Write