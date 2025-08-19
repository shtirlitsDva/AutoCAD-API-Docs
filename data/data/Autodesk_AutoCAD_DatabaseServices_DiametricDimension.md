# DiametricDimension Class

## Overview

#### Description
This .NET class wraps the AcDbDiametricDimension ObjectARX class. It represents the diameter dimension type in AutoCAD. 
This dimension type requires two points that define a diameter chord on the curve being dimensioned to be able to draw the dimension line from one chord point to the other. In addition, if the text is located outside the curve being dimensioned, then a "leader length" value is used to determine how far the dimension line extends out past the curve before doing a horizontal dogleg (if necessary) to the annotation text.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.DiametricDimension
```

```text
public class DiametricDimension : Dimension;
```

#### Notes
When a newly created dimension entity is first closed, an anonymous block (an BlockTableRecord that contains all the appropriate line, arc, arrowhead solids, text, and others, and with *D as the block name prefix) will automatically be created for it to reference for display. 
The LeaderLength property is only used during the creation of the dimension (and even then only if the dimension is set to use the default text position value). After the dimension is closed for the first time, changing the LeaderLength value will not affect how the dimension displays. However, the new setting will be stored and will show up in DXF and AutoLISP. 
If the dimension is set to use the text position value rather than the default text position, then the text position will take precedence over both the ChordPoint and FarChordPoint properties, as well as the LeaderLength value, in placing the dimension line so it will be positioned properly relative to the text position. 
When creating an DiametricDimension for which the dimension line must align with the ChordPoint and FarChordPoint, set the dimension to use the default text position and use the leaderLength to position the text. 
If the text position is more important than the chord points, then set the dimension to ignore the default text position and set the text position as desired.
#### See Also
DBObject, Entity

## Members

### Constructors

- [DiametricDimension()](#diametricdimension())

### Properties

- [ChordPoint](#chordpoint)
- [FarChordPoint](#farchordpoint)
- [LeaderLength](#leaderlength)


## Constructors Details

### DiametricDimension()

#### Description
Default constructor. Initializes the chord points to (0,0,0), and the leader length to 0.0. In addition, all the initializations of the default constructor for Dimension, Entity, and others are performed.
```text
public DiametricDimension();
public DiametricDimension(
    Point3d chordPoint, 
    Point3d farChordPoint, 
    double leaderLength, 
    string dimensionText, 
    ObjectId dimensionStyle
);
```

### ChordPoint

#### Description
Accesses the point (in WCS coordinates) where the dimension line intersects the curve being dimensioned and extends outside the curve, if the text is outside the curve.
```text
public Point3d ChordPoint;
```

#### Conditions
Read / Write
### FarChordPoint

#### Description
Accesses the far chord point (in WCS coordinates) of the curve being dimensioned. This is the point on the curve that is diametrically opposite the point where the dimension line extends outside the curve, if the text is outside the curve. 
**Note** This point is the primary definition point for the DiametricDimension type. 
```text
public Point3d FarChordPoint;
```

#### Conditions
Read / Write
### LeaderLength

#### Description
Accesses the table name. 
Obsolete.
```text
public double LeaderLength;
```

#### Conditions
Read / Write