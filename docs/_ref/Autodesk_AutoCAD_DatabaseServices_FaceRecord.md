# FaceRecord Class

## Overview

#### Description
This .NET class wraps the AcDbFaceRecord ObjectARX class. 
The FaceRecord class is a special class of vertex that is used by the PolyFaceMesh class to group together mesh point vertices that represent faces in the mesh. Each FaceRecord stores the vertex indices of the vertices that are the face's corner points and the visibility information for the edges determined by the vertices.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Vertex
            Autodesk.AutoCAD.DatabaseServices.FaceRecord
```

```text
public class FaceRecord : Vertex;
```

#### Notes
Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD.
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), PolyFaceMesh, [Face](Autodesk_AutoCAD_DatabaseServices_Face.md "Face Class")

## Members

### Constructors

- [FaceRecord()](#facerecord())
- [FaceRecord(short, short, short, short)](#facerecord(short,-short,-short,-short))

### Methods

- [GetVertexAt](#getvertexat)
- [IsEdgeVisibleAt](#isedgevisibleat)
- [MakeEdgeInvisibleAt](#makeedgeinvisibleat)
- [MakeEdgeVisibleAt](#makeedgevisibleat)
- [SetVertexAt](#setvertexat)


## Constructors Details

### FaceRecord()

#### Description
Default constructor.
```text
public FaceRecord();
```

### FaceRecord(short, short, short, short)

#### Description
This constructor initializes the FaceRecord to use the mesh vertices specified by the indices vertex0 through vertex3 as the four corner points of the face. The vertex indices start with 1. Negative index numbers can be used to indicate that the edge that starts at that vertex is to be invisible. 
If the face this FaceRecord is to represent has only three vertices, then set vertex3 to 0.
```text
public FaceRecord(
    short vertex0, 
    short vertex1, 
    short vertex2, 
    short vertex3
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short vertex0 | Input index number of first vertex for the face |
| short vertex1 | Input index number of second vertex for the face |
| short vertex2 | Input index number of third vertex for the face |
| short vertex3 | Input index number of fourth vertex for the face |

### GetVertexAt

#### Description
This function returns the index number PolyFaceMesh vertex used as the faceIndex corner of the face. Face corner indices start with 0, so faceIndex must be 0, 1, 2, or 3. PolyFaceMesh vertex indices start with 1, and will be negative if the edge is invisible or positive if the edge is visible.
```text
public short GetVertexAt(
    short faceIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short faceIndex | Input face corner index number (must be 0 through 3) |

### IsEdgeVisibleAt

#### Description
This function uses the visible argument to return the visibility value for the edge that starts with the face corner specified by faceIndex. A visibility value of truer indicates that the edge is visible. Face corner indices start with 0, so faceIndex must be 0, 1, 2, or 3.
```text
public bool IsEdgeVisibleAt(
    short faceIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short faceIndex | Input face corner index number (must be 0 through 3) |

### MakeEdgeInvisibleAt

#### Description
This function sets the edge that starts at the corner specified by faceIndex to be invisible. Face corner indices start with 0, so faceIndex must be 0, 1, 2, or 3.
```text
public void MakeEdgeInvisibleAt(
    short faceIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short faceIndex | Input index number of starting corner for edge (must be 0 - 3) |

### MakeEdgeVisibleAt

#### Description
This function sets the edge that starts at the corner specified by faceIndex to be visible. Face corner indices start with 0, so faceIndex __must be 0, 1, 2, or 3.
```text
public void MakeEdgeVisibleAt(
    short faceIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short faceIndex | Input index number of starting corner for edge (must be 0 - 3) |

### SetVertexAt

#### Description
This function sets the FaceRecord so that the PolyFaceMesh vertex list index number vertexIndex is used as the vertex index for the faceIndex corner of the face. Face corner indices start with 0, so faceIndex must be 0, 1, 2, or 3. PolyFaceMesh vertex indices start with 1, so vertexIndex must be greater than or equal to 1.
```text
public void SetVertexAt(
    short faceIndex, 
    short vertexIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| short faceIndex | Input face corner index number (must be 0 - 3) |
| short vertexIndex | Input index of vertex in PolyFaceMesh's vertex list that is to be used for this face corner |
