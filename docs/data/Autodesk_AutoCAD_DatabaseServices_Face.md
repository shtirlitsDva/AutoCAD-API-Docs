# Face Class

## Overview

#### Description
This .NET class wraps the AcDbFace ObjectARX class. 
It represents the 3dface entity within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Face
```

```text
public class Face : Entity;
```

#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), FaceRecord

## Members

### Constructors

- [Face()](#face())
- [Face(Point3d, Point3d, Point3d, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#face(point3d,-point3d,-point3d,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [Face(Point3d, Point3d, Point3d, Point3d, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#face(point3d,-point3d,-point3d,-point3d,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))

### Methods

- [GetVertexAt](#getvertexat)
- [IsEdgeVisibleAt](#isedgevisibleat)
- [MakeEdgeInvisibleAt](#makeedgeinvisibleat)
- [MakeEdgeVisibleAt](#makeedgevisibleat)
- [SetVertexAt](#setvertexat)


## Constructors Details

### Face()

#### Description
Default constructor. Initializes the visibility flag to 0 (that is, all edges are visible). In addition, standard Entity initialization occurs. The corner points are not explicitly initialized, so any initialization that may occur for them is compiler dependent.
```text
public Face();
```

### Face(Point3d, Point3d, Point3d, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This constructor initializes the Face to use the points pointer1 through pointer3 as the four corner points of the face with pointer2 being used for both the third and fourth corner points. This produces a face that is triangular. The points must be in WCS coordinates. 
The value1 through value4 arguments control the edge visibilities. value1 controls the visibility of the edge between pointer1 and pointer2, value2 the edge between pointer2 and pointer3, etc. A true value indicates the edge is to be visible. 
In addition, standard Entity initialization occurs.
```text
public Face(
    Point3d pointer1, 
    Point3d pointer2, 
    Point3d pointer3, 
    [MarshalAs(UnmanagedType.U1)] bool value1, 
    [MarshalAs(UnmanagedType.U1)] bool value2, 
    [MarshalAs(UnmanagedType.U1)] bool value3, 
    [MarshalAs(UnmanagedType.U1)] bool value4
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d pointer1 | Input first corner point (in WCS coordinates) |
| Point3d pointer2 | Input second corner point (in WCS coordinates) |
| Point3d pointer3 | Input third corner point (in WCS coordinates) |
| [MarshalAs(UnmanagedType.U1)] bool value1 | Input Boolean indicating whether or not first edge will be visible |
| [MarshalAs(UnmanagedType.U1)] bool value2 | Input Boolean indicating whether or not second edge will be visible |
| [MarshalAs(UnmanagedType.U1)] bool value3 | Input Boolean indicating whether or not third edge will be visible |
| [MarshalAs(UnmanagedType.U1)] bool value4 | Input Boolean indicating whether or not fourth edge will be visible |

### Face(Point3d, Point3d, Point3d, Point3d, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This constructor initializes the Face to use the points pointer1 through pointer4 as the four corner points of the face. The points must be in WCS coordinates. 
The value1 through value4 arguments control the edge visibilities. value1 controls the visibility of the edge between pointer1 and pointer2, value2 the edge between pointer2 and pointer3, etc. A true value indicates the edge is to be visible. 
In addition, standard Entity initialization occurs.
```text
public Face(
    Point3d pointer1, 
    Point3d pointer2, 
    Point3d pointer3, 
    Point3d pointer4, 
    [MarshalAs(UnmanagedType.U1)] bool value1, 
    [MarshalAs(UnmanagedType.U1)] bool value2, 
    [MarshalAs(UnmanagedType.U1)] bool value3, 
    [MarshalAs(UnmanagedType.U1)] bool value4
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d pointer1 | Input first corner point (in WCS coordinates) |
| Point3d pointer2 | Input second corner point (in WCS coordinates) |
| Point3d pointer3 | Input third corner point (in WCS coordinates) |
| Point3d pointer4 | Input fourth corner point (in WCS coordinates) |
| [MarshalAs(UnmanagedType.U1)] bool value1 | Input Boolean indicating whether or not first edge will be visible |
| [MarshalAs(UnmanagedType.U1)] bool value2 | Input Boolean indicating whether or not second edge will be visible |
| [MarshalAs(UnmanagedType.U1)] bool value3 | Input Boolean indicating whether or not third edge will be visible |
| [MarshalAs(UnmanagedType.U1)] bool value4 | Input Boolean indicating whether or not fourth edge will be visible |

### GetVertexAt

#### Description
This function uses the value argument to return the WCS value of the vertex.
```text
public Point3d GetVertexAt(
    short value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short value | Input vertex index number (must be 1 through 4) |

### IsEdgeVisibleAt

#### Description
Returns true if the edge of the vertex specified is visible.
```text
public bool IsEdgeVisibleAt(
    short vertexIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short vertexIndex | Input vertex index number (must be 1 through 4) |

### MakeEdgeInvisibleAt

#### Description
This function sets the edge that starts at the vertex specified by vertexIndex to be invisible.
```text
public void MakeEdgeInvisibleAt(
    short vertexIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short vertexIndex | Input vertex index number of starting vertex for edge |

### MakeEdgeVisibleAt

#### Description
This function sets the edge that starts at the vertex specified by vertexIndex to be visible.
```text
public void MakeEdgeVisibleAt(
    short vertexIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short vertexIndex | Input vertex index number of starting vertex for edge |

### SetVertexAt

#### Description
This function sets the vertex specified by vertexIndex to use the position value vertexPosition, which must be in WCS coordinates.
```text
public void SetVertexAt(
    short vertexIndex, 
    Point3d vertexPosition
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short vertexIndex | Input vertex index number (must be 1 through 4) |
| Point3d vertexPosition | Input vertex position (in WCS coordinates) |
