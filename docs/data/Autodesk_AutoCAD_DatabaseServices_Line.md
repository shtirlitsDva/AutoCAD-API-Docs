# Line Class

## Overview

#### Description
This .NET class wraps the AcDbLine ObjectARX class. 
This class represents the line entity in AutoCAD. A line object is a 3D object that is specified by its start point, endpoint, and normal vector. In addition, the line object supports thickness along its normal vector direction (that is, height or "extrusion").
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Line
```

```text
public class Line : Curve;
```

#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Point3d](Autodesk_AutoCAD_Geometry_Point3d.md), [Vector3d](Autodesk_AutoCAD_Geometry_Vector3d.md)

## Members

### Constructors

- [Line()](#line())
- [Line(Point3d, Point3d)](#line(point3d,-point3d))

### Properties

- [Angle](#angle)
- [Delta](#delta)
- [EndPoint](#endpoint)
- [Length](#length)
- [Normal](#normal)
- [StartPoint](#startpoint)
- [Thickness](#thickness)


## Constructors Details

### Line()

#### Description
Default constructor. Initializes the normal vector to (0,0,1), the start and end points to (0,0,0), and the thickness to 0.0. All coordinates are WCS.
```text
public Line();
```

### Line(Point3d, Point3d)

#### Description
This constructor initializes the line object to use pointer1 as the start point, and pointer2 as the endpoint. Both points must be in WCS coordinates.
```text
public Line(
    Point3d pointer1, 
    Point3d pointer2
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pointer1 | Input line start point (WCS coordinates) |
| Point3d pointer2 | Input line end point (WCS coordinates) |

### Angle

#### Description
Accesses the angle of the line expressed in radians relative to the world coordinate system.
```text
public double Angle;
```

#### Conditions
Read-only
### Delta

#### Description
Accesses the vector formed by start and end points of the line.
```text
public Vector3d Delta;
```

#### Conditions
Read-only
### EndPoint

#### Description
Accesses the line's endpoint in WCS coordinates.
```text
public override Point3d EndPoint;
```

#### Conditions
Read / Write
### Length

#### Description
Accesses the length of the line.
```text
public double Length;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the line's unit normal vector in WCS coordinates.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### StartPoint

#### Description
Accesses the line's start point in WCS coordinates.
```text
public override Point3d StartPoint;
```

#### Conditions
Read / Write
### Thickness

#### Description
Accesses the line's thickness value. The thickness is the line's dimension along its normal vector direction (sometimes called the extrusion direction).
```text
public double Thickness;
```

#### Conditions
Read / Write