# GeoCoordinateTransformer Class

## Overview

#### Description
This is class Autodesk.AutoCAD.DatabaseServices.GeoCoordinateTransformer.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GeoCoordinateTransformer
```

```text
public class GeoCoordinateTransformer : DisposableWrapper;
```

### Methods

- [Create](#create)
- [TransformPoint(Point3d)](#transformpoint(point3d))
- [TransformPoint(string, string, Point3d)](#transformpoint(string,-string,-point3d))
- [TransformPoints(Point3dCollection)](#transformpoints(point3dcollection))
- [TransformPoints(string, string, Point3dCollection)](#transformpoints(string,-string,-point3dcollection))

### Properties

- [SourceCSid](#sourcecsid)
- [TargetCSid](#targetcsid)


## Methods Details

### Create

#### Description
This is Create, a member of class GeoCoordinateTransformer.
```text
public static GeoCoordinateTransformer Create(
    string source, 
    string target
);
```

### TransformPoint(Point3d)

#### Description
This is TransformPoint, a member of class GeoCoordinateTransformer.
```text
public Point3d TransformPoint(
    Point3d sourcePt
);
```

### TransformPoint(string, string, Point3d)

#### Description
This is TransformPoint, a member of class GeoCoordinateTransformer.
```text
public static Point3d TransformPoint(
    string source, 
    string target, 
    Point3d sourcePt
);
```

### TransformPoints(Point3dCollection)

#### Description
This is TransformPoints, a member of class GeoCoordinateTransformer.
```text
public Point3dCollection TransformPoints(
    Point3dCollection sourcePts
);
```

### TransformPoints(string, string, Point3dCollection)

#### Description
This is TransformPoints, a member of class GeoCoordinateTransformer.
```text
public static Point3dCollection TransformPoints(
    string source, 
    string target, 
    Point3dCollection sourcePts
);
```

### SourceCSid

#### Description
This is SourceCSid, a member of class GeoCoordinateTransformer.
```text
public string SourceCSid;
```

### TargetCSid

#### Description
This is TargetCSid, a member of class GeoCoordinateTransformer.
```text
public string TargetCSid;
```
