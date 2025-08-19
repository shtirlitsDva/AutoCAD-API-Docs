# Solid Class

## Overview

#### Description
This .Net class wraps AcDbSolid ObjectARX class. 
The Solid class is the representation for the SOLID entity within AutoCAD. The SOLID entity is a 2D entity, not the 3D solids that are represented by the 3dSolid and Body classes.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Solid
```

```text
public class Solid : Entity;
```

### Constructors

- [Solid()](#solid())
- [Solid(Point3d, Point3d, Point3d)](#solid(point3d,-point3d,-point3d))
- [Solid(Point3d, Point3d, Point3d, Point3d)](#solid(point3d,-point3d,-point3d,-point3d))

### Methods

- [GetPointAt](#getpointat)
- [SetPointAt](#setpointat)

### Properties

- [Normal](#normal)
- [Thickness](#thickness)


## Constructors Details

### Solid()

#### Description
Constructor.
```text
public Solid();
```

### Solid(Point3d, Point3d, Point3d)

#### Description
This constructor uses pointer1-pointer3 as the first three points for the solid and then uses pointer2 as the fourth point as well. All points must be in WCS coordinates. The normal vector is initialized to (0,0,1) and the thickness is set to 0.0.
```text
public Solid(
    Point3d pointer1, 
    Point3d pointer2, 
    Point3d pointer3
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pointer1 | Input first point (in WCS) for solid |
| Point3d pointer2 | Input second point (in WCS) for solid |
| Point3d pointer3 | Input third point (in WCS) for solid |

### Solid(Point3d, Point3d, Point3d, Point3d)

#### Description
This constructor uses pointer1-pointer4 as the four points for the solid. All points must be in WCS coordinates. The normal vector is initialized to (0,0,1) and the thickness is set to 0.0.
```text
public Solid(
    Point3d pointer1, 
    Point3d pointer2, 
    Point3d pointer3, 
    Point3d pointer4
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d pointer1 | Input first point (in WCS) for solid |
| Point3d pointer2 | Input second point (in WCS) for solid |
| Point3d pointer3 | Input third point (in WCS) for solid |
| Point3d pointer4 | Input fourth point (in WCS) for solid |

### GetPointAt

#### Description
This function fills the output value of the desired point with the value of the point in the solid whose index is index. index can have a value of 0, 1, 2, or 3, depending on which point is desired (that is, 0 for the first point, 1 for the second point, etc.). If there are only three corners on the solid, then the points with indices 2 and 3 will have the same value. The returned point will be in WCS coordinates.
```text
public Point3d GetPointAt(
    short index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| short index | Input index (1-4) of the desired point in the solid |

### SetPointAt

#### Description
This function sets the index'th point in the solid to the pointValue. index must be 0, 1, 2, or 3. pt must be in WCS coordinates.
```text
public void SetPointAt(
    short index, 
    Point3d pointValue
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| short index | Input index (1-4) of the point to set in the solid |
| Point3d pointValue | Input point value |

### Normal

#### Description
Returns the unit normal vector of the plane containing the solid. 
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### Thickness

#### Description
Returns the thickness of the solid. The thickness is the shape's dimension along its normal vector direction (sometimes called the extrusion direction). 
The thickness value is used for DXF group code 39.
```text
public double Thickness;
```

#### Conditions
Read / Write