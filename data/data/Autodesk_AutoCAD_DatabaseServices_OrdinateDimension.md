# OrdinateDimension Class

## Overview

#### Description
This is class Autodesk.AutoCAD.DatabaseServices.OrdinateDimension.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Dimension
            Autodesk.AutoCAD.DatabaseServices.OrdinateDimension
```

```text
public class OrdinateDimension : Dimension;
```

### Constructors

- [OrdinateDimension()](#ordinatedimension())
- [OrdinateDimension([MarshalAs(UnmanagedType.U1)] bool, Point3d, Point3d, string, ObjectId)](#ordinatedimension([marshalas(unmanagedtype.u1)]-bool,-point3d,-point3d,-string,-objectid))

### Properties

- [DefiningPoint](#definingpoint)
- [LeaderEndPoint](#leaderendpoint)
- [Origin](#origin)
- [UsingXAxis](#usingxaxis)
- [UsingYAxis](#usingyaxis)


## Constructors Details

### OrdinateDimension()

#### Description
This is OrdinateDimension, a member of class OrdinateDimension.
```text
public OrdinateDimension();
```

### OrdinateDimension([MarshalAs(UnmanagedType.U1)] bool, Point3d, Point3d, string, ObjectId)

#### Description
This is OrdinateDimension, a member of class OrdinateDimension.
```text
public OrdinateDimension(
    [MarshalAs(UnmanagedType.U1)] bool useXAxis, 
    Point3d definingPoint, 
    Point3d leaderEndPoint, 
    string dimText, 
    ObjectId dimStyle
);
```

### DefiningPoint

#### Description
This is DefiningPoint, a member of class OrdinateDimension.
```text
public Point3d DefiningPoint;
```

### LeaderEndPoint

#### Description
This is LeaderEndPoint, a member of class OrdinateDimension.
```text
public Point3d LeaderEndPoint;
```

### Origin

#### Description
This is Origin, a member of class OrdinateDimension.
```text
public Point3d Origin;
```

### UsingXAxis

#### Description
This is UsingXAxis, a member of class OrdinateDimension.
```text
public bool UsingXAxis;
```

### UsingYAxis

#### Description
This is UsingYAxis, a member of class OrdinateDimension.
```text
public bool UsingYAxis;
```
