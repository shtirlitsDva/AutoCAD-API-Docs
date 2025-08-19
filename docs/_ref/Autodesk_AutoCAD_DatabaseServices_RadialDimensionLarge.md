# RadialDimensionLarge Class

## Overview

#### Description
This .NET class wraps the AcDbRadialDimensionLarge ObjectARX class. 
This class represents a large radial dimension, also known as a jogged radius dimension.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.RadialDimensionLarge
```

```text
public class RadialDimensionLarge : Dimension;
```

### Constructors

- [RadialDimensionLarge()](#radialdimensionlarge())

### Properties

- [Center](#center)
- [ChordPoint](#chordpoint)
- [JogAngle](#jogangle)
- [JogPoint](#jogpoint)
- [OverrideCenter](#overridecenter)


## Constructors Details

### RadialDimensionLarge()

#### Description
Default constructor.
```text
public RadialDimensionLarge();
public RadialDimensionLarge(
    Point3d center, 
    Point3d chordPoint, 
    Point3d overrideCenter, 
    Point3d jogPoint, 
    double jogAngle, 
    string dimensionText, 
    ObjectId dimensionStyle
);
```

### Center

#### Description
Accesses the center point of the arc dimensioned by the jogged radius dimension.
```text
public Point3d Center;
```

#### Conditions
Read / Write
### ChordPoint

#### Description
Accesses the chord point on the arc dimensioned by the jogged radius dimension.
```text
public Point3d ChordPoint;
```

#### Conditions
Read / Write
### JogAngle

#### Description
Accesses the jog angle used by the jogged radius dimension.
```text
public double JogAngle;
```

#### Conditions
Read / Write
### JogPoint

#### Description
Accesses the jog point used by the jogged radius dimension.
```text
public Point3d JogPoint;
```

#### Conditions
Read / Write
### OverrideCenter

#### Description
Accesses the overridden center point used by the jogged radius dimension.
```text
public Point3d OverrideCenter;
```

#### Conditions
Read / Write