# SubentityGeometry Class

## Overview

#### Description
A simple class that just keeps geometry of a vertex or edge subentity.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.SubentityGeometry
```

```text
public class SubentityGeometry;
```

#### Remarks
Notice that no copy constructor, assignment operator or destructor are implemented that would manage the referenced curve. The SubentityGeometry is not the owner of the curve, it just references it.
### Constructors

- [SubentityGeometry()](#subentitygeometry())
- [SubentityGeometry(Curve3d)](#subentitygeometry(curve3d))
- [SubentityGeometry(Point3d)](#subentitygeometry(point3d))

### Properties

- [Curve](#curve)
- [Point](#point)
- [Type](#type)


## Constructors Details

### SubentityGeometry()

#### Description
Default constructor.
```text
public SubentityGeometry();
```

### SubentityGeometry(Curve3d)

#### Description
Constructor initializing with an edge subnetity.
```text
public SubentityGeometry(
    Curve3d curve
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Curve3d curve | The curve is not owned by this SubentityGeometry. |

### SubentityGeometry(Point3d)

#### Description
Constructor initializing with a vertex subentity.
```text
public SubentityGeometry(
    Point3d pnt
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d pnt | The coordinates of the point subentity. |

### Curve

#### Description
Gets a reference to the curve of the edge subentity. 
The curve is not owned by this SubentityGeometry.
```text
public Curve3d Curve;
```

#### Conditions
Read-only
### Point

#### Description
Gets the coordinates of the vertex subentity.
```text
public Point3d Point;
```

#### Conditions
Read-only
### Type

#### Description
Gets the [SubentityType](Autodesk_AutoCAD_DatabaseServices_SubentityType.md "SubentityType Enumeration") of the subentity.
```text
public SubentityType Type;
```

#### Conditions
Read-only