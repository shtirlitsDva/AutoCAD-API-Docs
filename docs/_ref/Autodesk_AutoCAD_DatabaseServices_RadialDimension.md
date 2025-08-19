# RadialDimension Class

## Overview

#### Description
This .NET class wraps the AcDbRadialDimension ObjectARX class. 
The RadialDimension class represents the radius dimension type in AutoCAD. 
This dimension type requires a center point and a point on the curve being dimensioned in order to be able to draw the dimension line from the center point through the point on the curve. In addition, it utilizes a "leader length" value to determine how far the dimension line extends out past the curve before doing a horizontal dogleg (if necessary) to the annotation text.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.RadialDimension
```

```text
public class RadialDimension : Dimension;
```

#### Notes
When a newly created dimension entity is first closed, an anonymous block (an BlockTableRecord that contains all the appropriate line, arc, arrowhead solids, text, etc. and with *D as the block name prefix) will automatically be created for it to reference for display. 
The leaderLength setting is only used during the creation of the dimension (and even then only if the dimension is set to use the default text position value). After the dimension has been closed for the first time, changing the leaderLength value does not affect how the dimension displays, but the new setting is stored and shows up in DXF, AutoLISP, ADSRX, and the leaderLength() method. 
If the dimension has been set to use the text position value rather than the default text position (that is, Dimension.TextPosition has been called), then the text position takes precedence over the chordPoint setting as well as the leaderLength value in placing the dimension line so that it is positioned properly relative to the text position. 
So, when creating an RadialDimension for which the dimension line must align with the centerPoint and chordPoint, then the dimension should be set to use the default text position and the leaderLength should be used to position the text. 
On the other hand, if the text position is more important than the chord points, then set the dimension to ignore the default text position and set the text position as desired.
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class")

## Members

### Constructors

- [RadialDimension()](#radialdimension())

### Properties

- [Center](#center)
- [ChordPoint](#chordpoint)
- [LeaderLength](#leaderlength)


## Constructors Details

### RadialDimension()

#### Description
Default constructor. Initializes the center and chord points to (0,0,0), and the leader length to 0.0. In addition, all the initializations of the default constructor for Dimension, Entity, etc. are performed.
```text
public RadialDimension();
public RadialDimension(
    Point3d center, 
    Point3d chordPoint, 
    double leaderLength, 
    string dimensionText, 
    ObjectId dimensionStyle
);
```

### Center

#### Description
Accesses the center point (in WCS coordinates) of the curve being dimensioned.
```text
public Point3d Center;
```

#### Conditions
Read / Write
### ChordPoint

#### Description
Accesses the point (in WCS coordinates) where the dimension line intersects the curve being dimensioned.
```text
public Point3d ChordPoint;
```

#### Conditions
Read / Write
### LeaderLength

#### Description
Accesses the leader length. 
This function is obsolete.
```text
public double LeaderLength;
```
