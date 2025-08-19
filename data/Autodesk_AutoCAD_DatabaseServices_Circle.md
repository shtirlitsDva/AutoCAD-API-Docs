# Circle Class

## Overview

#### Description
This .NET class wraps the AcDbCircle ObjectARX class. The Circle class represents the circle entity within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Circle
```

```text
public class Circle : Curve;
```

#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Point3d](Autodesk_AutoCAD_Geometry_Point3d.md), [Vector3d](Autodesk_AutoCAD_Geometry_Vector3d.md)

## Members

### Constructors

- [Circle()](#circle())
- [Circle(Point3d, Vector3d, double)](#circle(point3d,-vector3d,-double))

### Properties

- [Center](#center)
- [Circumference](#circumference)
- [Diameter](#diameter)
- [Normal](#normal)
- [Radius](#radius)
- [Thickness](#thickness)


## Constructors Details

### Circle()

#### Description
Default constructor.
```text
public Circle();
```

### Circle(Point3d, Vector3d, double)

#### Description
Constructs a specific circle.
```text
public Circle(
    Point3d center, 
    Vector3d normal, 
    double radius
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d center | Input center location |
| Vector3d normal | Input normal vector |
| double radius | Input radius length |

### Center

#### Description
Accesses the center point.
```text
public Point3d Center;
```

#### Conditions
Read / Write
### Circumference

#### Description
Accesses the circumference of the circle.
```text
public double Circumference;
```

#### Conditions
Read / Write
### Diameter

#### Description
Accesses the diameter of the circle.
```text
public double Diameter;
```

#### Conditions
Read / Write
### Normal

#### Description
Accesses a vector which is at a normal to the center.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### Radius

#### Description
Accesses the radius of the circle.
```text
public double Radius;
```

#### Conditions
Read / Write
### Thickness

#### Description
Accesses the thickness of the circumference.
```text
public double Thickness;
```

#### Conditions
Read / Write