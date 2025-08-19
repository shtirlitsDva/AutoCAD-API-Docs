# Xline Class

## Overview

#### Description
This .NET class wraps the AcDbXline ObjectARX class. 
The Xline class represents the XLINE entity type within AutoCAD. An xline entity is a line that extends to infinity in both directions.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Xline
```

```text
public class Xline : Curve;
```

### Constructors

- [Xline](#xline)

### Properties

- [BasePoint](#basepoint)
- [SecondPoint](#secondpoint)
- [UnitDir](#unitdir)


## Constructors Details

### Xline

#### Description
Constructor.
```text
public Xline();
```

### BasePoint

#### Description
Returns the base point of the xline.
```text
public Point3d BasePoint;
```

#### Conditions
Read / Write
### SecondPoint

#### Description
Returns the second point of the xline.
```text
public Point3d SecondPoint;
```

#### Conditions
Read / Write
### UnitDir

#### Description
Returns the unit direction vector of the xline.
```text
public Vector3d UnitDir;
```

#### Conditions
Read / Write