# Shape Class

## Overview

#### Description
This .NET class wraps the AcDbShape ObjectARX class. It represents the SHAPE entity within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Shape
```

```text
public class Shape : Entity;
```

### Constructors

- [Shape()](#shape())
- [Shape(Point3d, double, double, double)](#shape(point3d,-double,-double,-double))

### Properties

- [Name](#name)
- [Normal](#normal)
- [Oblique](#oblique)
- [Position](#position)
- [Rotation](#rotation)
- [ShapeIndex](#shapeindex)
- [ShapeNumber](#shapenumber)
- [Size](#size)
- [StyleId](#styleid)
- [Thickness](#thickness)
- [WidthFactor](#widthfactor)


## Constructors Details

### Shape()

#### Description
Constructor.
```text
public Shape();
```

### Shape(Point3d, double, double, double)

#### Description
Constructor.
```text
public Shape(
    Point3d position, 
    double size, 
    double rotation, 
    double widthFactor
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d position | Input insertion point of the shape, in WCS coordinates |
| double size | Input height of the shape |
| double rotation | Input rotation of the shape |
| double widthFactor | Input width factor of the shape |

### Name

#### Description
Returns the name of the shape. If no name has been set, then NULL is returned. The caller of this function is responsible for freeing the memory used by the returned string. 
The name of a shape is not part of the shape but is derived from the shapeNumber()and the shapeIndex().
```text
public string Name;
```

#### Conditions
Read / Write
### Normal

#### Description
Returns the normal vector of the plane containing the shape. The normal vector is in WCS coordinates.
```text
public Vector3d Normal;
```

### Oblique

#### Description
Returns the oblique angle of the shape. The obliquing angle is the angle of slant from the shape's vertical.
```text
public double Oblique;
```

#### Conditions
Read / Write
### Position

#### Description
Returns the insertion point of the shape in WCS coordinates.
```text
public Point3d Position;
```

#### Conditions
Read / Write
### Rotation

#### Description
Returns the rotation angle of the shape. The rotation angle is relative to the X axis of the shape's OCS with positive angles going counterclockwise when looking down the Z axis towards the origin. The OCS X axis is determined by using the shape's normal, the WCS Z axis, and the arbitrary axis algorithm. 
```text
public double Rotation;
```

#### Conditions
Read / Write
### ShapeIndex

#### Description
Returns the object ID of the font symbol table record containing this shape's SHX font. 
A shape is stored as a reference to a font, and a character within that font. Essentially a shape is a single character of a special SHX font.
```text
public ObjectId ShapeIndex;
```

#### Conditions
Read / Write
### ShapeNumber

#### Description
Returns the number of the shape. A shape is stored as a reference to a font, and a character within that font. Essentially a shape is a single character of a special SHX font. This function sets the number of that character.
```text
public short ShapeNumber;
```

#### Conditions
Read / Write
### Size

#### Description
Returns the height of the shape.
```text
public double Size;
```

#### Conditions
Read / Write
### StyleId

#### Description
Returns the object ID of the font symbol table record containing this shape's SHX font. 
A shape is stored as a reference to a font, and a character within that font. Essentially a shape is a single character of a special SHX font.
```text
public ObjectId StyleId;
```

#### Conditions
Read / Write
### Thickness

#### Description
Returns the thickness of the shape. The thickness is the shape's dimension along its normal vector direction (sometimes called the extrusion direction).
```text
public double Thickness;
```

#### Conditions
Read / Write
### WidthFactor

#### Description
Returns the width factor (sometimes referred to as the relative X-scale factor). The widthFactor is applied to the shape's width to allow the width to be adjusted independently of the height. For example, if the widthFactor value is 0.8, then the shape will be drawn with a width that is 80% of its normal "unadjusted" width. 
The width factor value is used for DXF group code 41.
```text
public double WidthFactor;
```

#### Conditions
Read / Write