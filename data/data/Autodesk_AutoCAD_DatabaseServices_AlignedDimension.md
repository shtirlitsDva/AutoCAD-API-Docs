# AlignedDimension Class

## Overview

#### Description
This .NET class wraps the AcDbAlignedDimension ObjectARX class. 
The AlignedDimension class is used to represent the dimension type that dimensions the distance between two points located anywhere in space. The dimension’s normal vector must be perpendicular to the line between the two points. The two selected points are also used as the definition points for the start of the two dimension extension lines.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.AlignedDimension
```

```text
public class AlignedDimension : Dimension;
```

#### Notes
When a newly created dimension entity is first closed, an anonymous block will automatically be created for it to reference for display. The anonymous block is an BlockTableRecord that contains all the appropriate line, arc, arrowhead solids, text, and others, and with *D as the block name prefix. 
If the dimension has been set to use the text position value rather than the default text position (that is, Dimension.TextPosition has been set) and the DIMFIT system variable is not set to 4, then the text position will take precedence over the dimLine setting.
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class")

## Members

### Constructors

- [AlignedDimension()](#aligneddimension())

### Properties

- [DimLinePoint](#dimlinepoint)
- [Oblique](#oblique)
- [XLine1Point](#xline1point)
- [XLine2Point](#xline2point)


## Constructors Details

### AlignedDimension()

#### Description
Default constructor. Initializes the dimension line definition point and extension line 1 and 2 start points all to (0,0,0), and the obliquing angle to 0.0. In addition, all the initializations of the default constructor for Dimension, Entity, and others, are performed.
```text
public AlignedDimension();
public AlignedDimension(
    Point3d line1Point, 
    Point3d line2Point, 
    Point3d dimensionLinePoint, 
    string dimensionText, 
    ObjectId dimensionStyle
);
```

### DimLinePoint

#### Description
Accesses the definition point (in WCS coordinates) that specifies where the dimension line will be. This point will be somewhere on the dimension line.
```text
public Point3d DimLinePoint;
```

#### Conditions
Read / Write
#### Notes
This point is the primary definition point for the AlignedDimension type. 
The dimension line definition point is used for DXF group code 10.
### Oblique

#### Description
Accesses the extension line obliquing angle (in radians) for the dimension. 
This angle is relative to the line that contains the start points of both extension lines (xLine1Point and xLine2Point). Positive angles are counterclockwise when looking down the dimension’s OCS Z axis towards the origin. 
The line containing the two extension line start points divides the plane containing the dimension into two half-planes. The extension lines can only be within the half-plane that contains the dimension line definition point. Therefore, the obliquing angle is periodic with a period of 0 to pi. Obliquing angles greater than pi will simply be mapped to the equivalent angle in the first period. 
Negative angles are periodic over 0 to -pi and result in the same obliquing as the positive angle that results if pi is added to their first period value (for instance, -pi / 4 is the same as 3 ( pi / 4). 
An angle of zero is a special case that is interpreted as "use the default," which is the same as an obliquing angle of pi / 2 (90 degrees).
```text
public double Oblique;
```

#### Conditions
Read / Write
#### Notes
The obliquing angle is used for DXF group code 52.
### XLine1Point

#### Description
Accesses the definition point (in WCS coordinates) that is used as the start point for the first extension line of the dimension.
```text
public Point3d XLine1Point;
```

#### Conditions
Read / Write
#### Notes
The AutoCAD DIMEXO dimension variable will affect how the extension line is displayed relative to this point. 
The first extension line start point is used for DXF group code 13.
### XLine2Point

#### Description
Accesses the definition point (in WCS coordinates) that is used as the start point for the second extension line of the dimension.
```text
public Point3d XLine2Point;
```

#### Conditions
Read / Write
#### Notes
The AutoCAD DIMEXO dimension variable will affect how the extension line is displayed relative to this point. 
The second extension line start point is used for DXF group code 14.