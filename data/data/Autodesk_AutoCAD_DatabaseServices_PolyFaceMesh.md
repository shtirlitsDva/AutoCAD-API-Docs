# PolyFaceMesh Class

## Overview

#### Description
This .NET class wraps the AcDbPolyFaceMesh ObjectARX class. 
The PolyFaceMesh class represents the PolyFaceMesh special polyline entity type within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.PolyFaceMesh
```

```text
public class PolyFaceMesh : Entity, IEnumerable;
```

#### Notes
The PolyFaceMesh uses a list of vertices made up of coordinate point vertices and FaceRecord vertices. The coordinate point vertices come first in the list, followed by all of the FaceRecord vertices. 
The controlling application must explicitly delete the subentities of any complex entity that is not database resident. Otherwise, a small memory leak will result. 
Warning
Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD.
### Constructors

- [PolyFaceMesh](#polyfacemesh)

### Methods

- [AppendFaceRecord](#appendfacerecord)
- [AppendVertex](#appendvertex)
- [GetEnumerator](#getenumerator)

### Properties

- [NumFaces](#numfaces)
- [NumVertices](#numvertices)


## Constructors Details

### PolyFaceMesh

#### Description
Default constructor. Initializes the face and vertex counts to 0.
```text
public PolyFaceMesh();
```

### AppendFaceRecord

#### Description
This function appends the FaceRecord pointed to by toAppend to the end of the facelist of the PolyFaceMesh, establishes the PolyFaceMesh object as the FaceRecord's owner, and adds the FaceRecord to the database that contains the PolyFaceMesh (the PolyFaceMesh must be database-resident for this function to succeed). 
The appended FaceRecord must be explicitly closed by the calling application after the AppendFaceRecord() call returns. 
**Warning**
All vertices must be appended before any FaceRecords are appended. Once even one FaceRecord has been appended, the AppendVertex() methods no longer work.
```text
public ObjectId AppendFaceRecord(
    FaceRecord toAppend
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| FaceRecord toAppend | Input FaceRecord to append to the mesh |

### AppendVertex

#### Description
This function appends the PolyFaceMeshVertex object pointed to by vertexToAppend to the end of the vertex list of the PolyFaceMesh, establishes the PolyFaceMesh as the vertex's owner, and adds the vertex to the database that contains the PolyFaceMesh (the PolyFaceMesh must be database-resident for this function to succeed). 
The appended vertex must be explicitly closed by the calling application after the AppendVertex() call returns. 
**Warning**
All vertices must be appended before any FaceRecords are appended. Once even one FaceRecord has been appended, the AppendVertex() methods no longer work.
```text
public ObjectId AppendVertex(
    PolyFaceMeshVertex vertexToAppend
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| PolyFaceMeshVertex vertexToAppend | Input vertex to append to mesh |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public virtual IEnumerator GetEnumerator();
```

### NumFaces

#### Description
Accesses the number of faces in the PolyFaceMesh. For PolyFaceMeshes created via the ObjectARX API, this value will accurately reflect the number of FaceRecords that have been appended to the PolyFaceMesh. For PolyFaceMeshes created via the AutoCAD PFACE command, it is possible for this value to be lower than the number of FaceRecords owned by the PolyFaceMesh.
```text
public int NumFaces;
```

#### Conditions
Read-only
### NumVertices

#### Description
Accesses the number of point coordinate vertices in the vertex list of the PolyFaceMesh. This count does not include the FaceRecords in the vertex list.
```text
public int NumVertices;
```

#### Conditions
Read-only