# RotatedDimension Class

## Overview

#### Description
This class wraps the AcDbRotatedDimension ObjectARX class. 
The RotatedDimension class represents the dimension type that dimensions the distance between two points in space when they are projected onto a line at a specific angle (the rotation angle) within the dimension's plane. 
A "horizontal" dimension is a rotated dimension with an angle equal to the angle between the dimension's OCS X axis and the X axis of the UCS used to define "horizontal." A "vertical" dimension is a rotated dimension with an angle equal to pi / 2 radians (90 degrees) greater than the angle for a "horizontal" dimension.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.RotatedDimension
```

```text
public class RotatedDimension : Dimension;
```

#### Notes
When a newly created dimension entity is first closed, an anonymous block (an BlockTableRecord that contains all the appropriate line, arc, arrowhead solids, text, etc. and with *D as the block name prefix) is automatically created for it to reference for display. 
If the dimension has been set to use the text position value rather than the default text position (that is, Dimension.UsingDefaultTextPosition has been called) and the DIMFIT system variable is not set to 4, then the text position takes precedence over the dimLine setting in placing the dimension line so that it lines up with the text position.
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class")

## Members

### Constructors

- [RotatedDimension()](#rotateddimension())

### Properties

- [DimLinePoint](#dimlinepoint)
- [Oblique](#oblique)
- [Rotation](#rotation)
- [XLine1Point](#xline1point)
- [XLine2Point](#xline2point)


## Constructors Details

### RotatedDimension()

#### Description
Default constructor.
```text
public RotatedDimension();
public RotatedDimension(
    double rotation, 
    Point3d line1Point, 
    Point3d line2Point, 
    Point3d dimensionLinePoint, 
    string dimensionText, 
    ObjectId dimensionStyle
);
```

### DimLinePoint

#### Description
Accesses the definition point (in WCS coordinates) that specifies where the dimension line will be (that is, this point will be somewhere on the dimension line).
```text
public Point3d DimLinePoint;
```

#### Conditions
Read / Write
### Oblique

#### Description
Accesses the extension line obliquing angle (in radians) for the dimension. 
This angle is relative to the RotatedDimension.Rotation value. Positive angles are counterclockwise when looking down the dimension's OCS Z axis towards the origin. 
The line containing the two extension line start points divides the plane containing the dimension into two half-planes. The extension lines can only be within the half-plane that contains the dimension line definition point. So, the obliquing angle is periodic with a period of 0 to pi. Obliquing angles greater than pi are simply mapped to the equivalent angle in the first period. 
Negative angles are periodic over 0 to -pi and result in the same obliquing as the positive angle that results if pi is added to their first period value (for example, -pi / 4 is the same as 3 x pi / 4) 
An angle of zero is a special case that is interpreted as "use the default," which is the same as an obliquing angle of pi / 2 (90 degrees).
```text
public double Oblique;
```

#### Conditions
Read / Write
### Rotation

#### Description
Accesses the dimension's rotation angle in radians. 
The rotation angle is the angle between the dimension's OCS X axis and the axis of the distance being dimensioned. Positive angles are counterclockwise when looking down the OCS positive Z axis towards the origin.
```text
public double Rotation;
```

#### Conditions
Read / Write
### XLine1Point

#### Description
Accesses the dimension to use (in WCS coordinates) as the definition point that's used as the start point for the first extension line of the dimension. 
The AutoCAD DIMEXO dimension variable affects how the extension line is displayed relative to this point.
```text
public Point3d XLine1Point;
```

#### Conditions
Read / Write
### XLine2Point

#### Description
Accesses the definition point (in WCS coordinates) that's used as the start point for the second extension line of the dimension. 
The AutoCAD DIMEXO dimension variable affects how the extension line is displayed relative to this point.
```text
public Point3d XLine2Point;
```

#### Conditions
Read / Write