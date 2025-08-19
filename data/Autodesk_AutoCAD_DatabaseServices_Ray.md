# Ray Class

## Overview

#### Description
This .NET class wraps the AcDbRay ObjectARX class. 
The Ray class represents the RAY entity type within AutoCAD. 
A ray entity is a line that has a start point, but continues on to infinity in some direction.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Ray
```

```text
public class Ray : Curve;
```

#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), [Point3d](Autodesk_AutoCAD_Geometry_Point3d.md), [Vector3d](Autodesk_AutoCAD_Geometry_Vector3d.md)

## Members

### Constructors

- [Ray](#ray)

### Properties

- [BasePoint](#basepoint)
- [SecondPoint](#secondpoint)
- [UnitDir](#unitdir)


## Constructors Details

### Ray

#### Description
The default constructor. A Ray object is constructed with a basepoint of (0,0,0) and a direction of (0,0,1).
```text
public Ray();
```

### BasePoint

#### Description
Accesses the base point of the ray.
```text
public Point3d BasePoint;
```

#### Conditions
Read / Write
### SecondPoint

#### Description
Accesses the second alignment point.
```text
public Point3d SecondPoint;
```

#### Conditions
Read / Write
### UnitDir

#### Description
Accesses the unit direction vector of the ray.
```text
public Vector3d UnitDir;
```

#### Conditions
Read / Write