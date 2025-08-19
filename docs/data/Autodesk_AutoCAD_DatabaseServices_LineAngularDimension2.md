# LineAngularDimension2 Class

## Overview

#### Description
This .NET class wraps the AcDb2LineAngularDimension ObjectARX class. 
This class represents the angular dimension defined by two lines (as opposed to three points) within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.LineAngularDimension2
```

```text
public class LineAngularDimension2 : Dimension;
```

#### Notes
When a newly created dimension entity is first closed, an anonymous block will automatically be created for it to reference for display. The anonymous block is an BlockTableRecord that contains all the appropriate line, arc, arrowhead solids, text, and so on. It has *D as the block name prefix.
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class")

## Members

### Constructors

- [LineAngularDimension2()](#lineangulardimension2())

### Properties

- [ArcPoint](#arcpoint)
- [XLine1End](#xline1end)
- [XLine1Start](#xline1start)
- [XLine2End](#xline2end)
- [XLine2Start](#xline2start)


## Constructors Details

### LineAngularDimension2()

#### Description
Default constructor. Initializes the arc point and the extension line 1 & 2 start and end points all to (0,0,0). In addition, all the initializations of the default constructor for Dimension, Entity, etc., are performed.
```text
public LineAngularDimension2();
public LineAngularDimension2(
    Point3d line1Start, 
    Point3d line1End, 
    Point3d line2Start, 
    Point3d line2End, 
    Point3d arcPoint, 
    string dimensionText, 
    ObjectId dimensionStyle
);
```

### ArcPoint

#### Description
Accesses the dimension definition point (in WCS coordinates) that is used to determine the location of the arc of the dimension.
```text
public Point3d ArcPoint;
```

#### Conditions
Read / Write
### XLine1End

#### Description
Accesses the dimension definition point (in WCS coordinates) that is used for the end point of the first extension line of the dimension.
```text
public Point3d XLine1End;
```

#### Conditions
Read / Write
### XLine1Start

#### Description
Accesses the dimension definition point (in WCS coordinates) that is used for the start point of the first extension line of the dimension.
```text
public Point3d XLine1Start;
```

#### Conditions
Read / Write
### XLine2End

#### Description
Accesses the dimension definition point (in WCS coordinates) that is used for the end point of the second extension line of the dimension.
```text
public Point3d XLine2End;
```

#### Conditions
Read / Write
### XLine2Start

#### Description
Accesses the dimension definition point (in WCS coordinates) that is used for the start point of the second extension line of the dimension.
```text
public Point3d XLine2Start;
```

#### Conditions
Read / Write