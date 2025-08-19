# Point3AngularDimension Class

## Overview

#### Description
This .NET class wraps the AcDb3PointAngularDimension ObjectARX class. 
The Point3AngularDimension class represents the angular dimension defined by three points (as opposed to two lines) within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.Point3AngularDimension
```

```text
public class Point3AngularDimension : Dimension;
```

#### Notes
When a newly created dimension entity is first closed, an anonymous block (an BlockTableRecord that contains all the appropriate line, arc, arrowhead solids, text, among others, and with *D as the block name prefix) will automatically be created for it to reference for display.
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class")

## Members

### Constructors

- [Point3AngularDimension()](#point3angulardimension())

### Properties

- [ArcPoint](#arcpoint)
- [CenterPoint](#centerpoint)
- [XLine1Point](#xline1point)
- [XLine2Point](#xline2point)


## Constructors Details

### Point3AngularDimension()

#### Description
Default constructor. Initializes the arc point angle center point and extension lines 1 & 2 start points all to (0,0,0). In addition, all the initializations of the default constructor for Dimension, Entity, and others, are performed.
```text
public Point3AngularDimension();
public Point3AngularDimension(
    Point3d centerPoint, 
    Point3d line1Point, 
    Point3d line2Point, 
    Point3d arcPoint, 
    string dimensionText, 
    ObjectId dimensionStyle
);
```

### ArcPoint

#### Description
Accesses This function returns the dimension definition point (in WCS coordinates) that is used to determine the location of the arc of the dimension. 
**Note** This point is the primary definition point for the Point3AngularDimension type. 
```text
public Point3d ArcPoint;
```

#### Conditions
Read / Write
### CenterPoint

#### Description
Accesses the dimension definition point (in WCS coordinates) that is located at the vertex of the angle being dimensioned.
```text
public Point3d CenterPoint;
```

#### Conditions
Read / Write
### XLine1Point

#### Description
Accesses the
```text
public Point3d XLine1Point;
```

#### Conditions
Read / Write
### XLine2Point

#### Description
Accesses the dimension definition point (in WCS coordinates) that is used for the start point of the second extension line of the dimension. This point and the dimension's center point (which is located at the angle's vertex) define one side of the angle being dimensioned. 
The AutoCAD DIMEXO dimension variable will affect how the extension line is displayed relative to this point.
```text
public Point3d XLine2Point;
```

#### Conditions
Read / Write