# BulgeVertex Class

## Overview

#### Description
This class contains a bulge value and the 2D coordinates of the associated vertex.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.BulgeVertex
```

```text
public sealed class BulgeVertex;
```

### Constructors

- [BulgeVertex](#bulgevertex)

### Properties

- [Bulge](#bulge)
- [Vertex](#vertex)


## Constructors Details

### BulgeVertex

#### Description
Default constructor.
```text
public BulgeVertex(
    Point2d point, 
    double bulge
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point2d point | Input the 2D coordinates of the new vertex. |
| double bulge | Input the new bulge value. |

### Bulge

#### Description
Accesses the bulge property value.
```text
public double Bulge;
```

#### Conditions
Read / Write
### Vertex

#### Description
Accesses the vertex property value.
```text
public Point2d Vertex;
```

#### Conditions
Read / Write