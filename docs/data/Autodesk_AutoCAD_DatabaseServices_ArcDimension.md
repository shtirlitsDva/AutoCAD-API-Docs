# ArcDimension Class

## Overview

#### Description
This .NET class wraps the AcDbArcDimension ObjectARX class. 
That class represents an arc length dimension.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.ArcDimension
```

```text
public class ArcDimension : Dimension;
```

### Constructors

- [ArcDimension](#arcdimension)

### Properties

- [ArcEndParam](#arcendparam)
- [ArcPoint](#arcpoint)
- [ArcStartParam](#arcstartparam)
- [ArcSymbolType](#arcsymboltype)
- [CenterPoint](#centerpoint)
- [HasLeader](#hasleader)
- [IsPartial](#ispartial)
- [Leader1Point](#leader1point)
- [Leader2Point](#leader2point)
- [XLine1Point](#xline1point)
- [XLine2Point](#xline2point)


## Constructors Details

### ArcDimension

#### Description
The primary constructor.
```text
public ArcDimension(
    Point3d centerPoint, 
    Point3d xLine1Point, 
    Point3d xLine2Point, 
    Point3d arcPoint, 
    string dimensionText, 
    ObjectId dimensionStyle
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d centerPoint | Input the center of the arc being dimensioned |
| Point3d xLine1Point | Input the first extension line end point |
| Point3d xLine2Point | Input the second extension line end point |
| Point3d arcPoint | Input the point on arc being dimensioned |
| string dimensionText | Input the dimension text to use instead of calculated value |
| ObjectId dimensionStyle | Input the dimension style object ID. |

### ArcEndParam

#### Description
Accesses the parameter of the arc being dimensioned corresponding to the arc length dimension's second definition point.
```text
public double ArcEndParam;
```

#### Conditions
Read / Write
### ArcPoint

#### Description
Accesses the point through which the arc length dimension's dimension arc passes.
```text
public Point3d ArcPoint;
```

#### Conditions
Read / Write
### ArcStartParam

#### Description
Accesses the point through which the arc length dimension's dimension arc passes.
```text
public double ArcStartParam;
```

#### Conditions
Read / Write
### ArcSymbolType

#### Description
Accesses the type of symbol to use in the arc length dimension's text string.
```text
public int ArcSymbolType;
```

#### Conditions
Read / Write
#### Notes
A value of 0 indicates that the arc symbol precedes text, 1 indicates that the arc symbol is above text, and 2 indicates that no arc symbol is used. 
This overrides the setting of this value in the dimension's style.
### CenterPoint

#### Description
Accesses the center point of the arc dimensioned by the arc length dimension.
```text
public Point3d CenterPoint;
```

#### Conditions
Read / Write
### HasLeader

#### Description
Determines whether the arc length dimension has an extra leader drawn to resolve ambiguity.
```text
public bool HasLeader;
```

#### Conditions
Read / Write
### IsPartial

#### Description
Reserved for future use.
```text
public bool IsPartial;
```

#### Conditions
Read / Write
### Leader1Point

#### Description
Accesses the start point for the arc length dimension's extra leader, if drawn.
```text
public Point3d Leader1Point;
```

#### Conditions
Read / Write
### Leader2Point

#### Description
Accesses the end point for the arc length dimension's extra leader, if drawn.
```text
public Point3d Leader2Point;
```

#### Conditions
Read / Write
### XLine1Point

#### Description
Accesses the start point for the arc length dimension's first extension line.
```text
public Point3d XLine1Point;
```

#### Conditions
Read / Write
### XLine2Point

#### Description
Accesses the start point for the arc length dimension's second extension line.
```text
public Point3d XLine2Point;
```

#### Conditions
Read / Write