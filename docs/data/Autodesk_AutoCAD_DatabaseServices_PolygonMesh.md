# PolygonMesh Class

## Overview

#### Description
This .NET class wraps the AcDbPolygonMesh ObjectARX class. 
The PolygonMesh class represents the polygon mesh entity within AutoCAD. 
A PolygonMesh is an M x N mesh, where M represents the number of vertices in a row of the mesh and N represents the number of vertices in a column of the mesh. 
A mesh can be open or closed in either or both the M and N directions. A mesh that is closed in a given direction is considered to be continuous from the last row or column on to the first row or column. 
All the vertices in the mesh are stored in a single list. For a non-surface-fit mesh, the first N vertices are used to make up the first column, the second N vertices are used to make up the second column, and so on until all the vertices are used up (there do not have to be enough vertices to fully fill the M x N mesh). 
For a surface-fit mesh, the surface density values are used in place of M and N for the vertex row x column sizes.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.PolygonMesh
```

```text
public class PolygonMesh : Entity, IEnumerable;
```

#### Notes
The controlling application must explicitly delete the subentities of any complex entity that is not database resident. Otherwise, a small memory leak will result.
Warning
Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD.
#### See Also
DBObject, Entity, PolygonMeshVertex

## Members

### Constructors

- [PolygonMesh()](#polygonmesh())

### Methods

- [AppendVertex](#appendvertex)
- [ConvertToPolyMeshType](#converttopolymeshtype)
- [GetEnumerator](#getenumerator)
- [MakeMClosed](#makemclosed)
- [MakeMOpen](#makemopen)
- [MakeNClosed](#makenclosed)
- [MakeNOpen](#makenopen)
- [Straighten](#straighten)
- [SurfaceFit()](#surfacefit())

### Properties

- [IsMClosed](#ismclosed)
- [IsNClosed](#isnclosed)
- [MSize](#msize)
- [MSurfaceDensity](#msurfacedensity)
- [NSize](#nsize)
- [NSurfaceDensity](#nsurfacedensity)
- [PolyMeshType](#polymeshtype)


## Constructors Details

### PolygonMesh()

#### Description
Default constructor. Initializes the polyline flag to 16 (indicating a PolygonMesh open in both M and N directions). Initializes to 0 the MeshType, vertices in M direction, vertices in N direction, Smooth surface density in M direction, and Smooth surface density in N direction.
```text
public PolygonMesh();
public PolygonMesh(
    Autodesk.AutoCAD.DatabaseServices.PolyMeshType type, 
    int size, 
    int sizeValue, 
    Point3dCollection vertices, 
    [MarshalAs(UnmanagedType.U1)] bool closedValue, 
    [MarshalAs(UnmanagedType.U1)] bool closed
);
```

### AppendVertex

#### Description
This function appends the PolygonMeshVertex object pointed to by toAppend to the vertex list of the PolygonMesh, establishes the PolygonMesh as the vertex's owner, and adds the vertex to the database that contains the PolygonMesh (the PolygonMesh must be database-resident for this function to succeed). 
The appended vertex must be explicitly closed by the calling application after the AppendVertex() call returns.
```text
public ObjectId AppendVertex(
    PolygonMeshVertex toAppend
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PolygonMeshVertex toAppend | Input vertex to append to mesh |

### ConvertToPolyMeshType

#### Description
This method uses the SurfaceFit() method to convert the PolygonMesh to the type specified by the newVal argument value. 
Possible values for newVal are: 
| SimpleMesh | Plain mesh with no surface fitting or smoothing |
| --- | --- |
| QuadSurfaceMesh | Quadratic B-spline surface fit |
| CubicSurfaceMesh | Cubic B-spline surface fit |
| BezierSurfaceMesh | Bezier surface fit |

Note
If the PolyMeshType is SimpleMesh , then the M and N mesh size values will be used for vertex row column sizes. For any other PolyMeshType, the M and N surface density values will be used as the row and column sizes.
```text
public void ConvertToPolyMeshType(
    Autodesk.AutoCAD.DatabaseServices.PolyMeshType newVal
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.PolyMeshType newVal | Input type to which the polygon mesh should be converted |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public IEnumerator GetEnumerator();
```

### MakeMClosed

#### Description
This function sets the PolygonMesh to be closed in the M direction. This means that the mesh will be treated as continuous from the last row on to the first row.
```text
public void MakeMClosed();
```

### MakeMOpen

#### Description
This function sets the PolygonMesh to be open in the M direction. This means that the mesh will be discontinuous between the last row and the first row.
```text
public void MakeMOpen();
```

### MakeNClosed

#### Description
This function sets the PolygonMesh to be closed in the N direction. This means that the mesh will be treated as continuous from the last column on to the first column.
```text
public void MakeNClosed();
```

### MakeNOpen

#### Description
This function sets the PolygonMesh to be open in the N direction. This means that the mesh will be discontinuous between the last column and the first column.
```text
public void MakeNOpen();
```

### Straighten

#### Description
This function removes all spline-fit vertices and restores the original control point polygon mesh. This operation performs the same modification as the PEDIT command "Desmooth" option.
```text
public void Straighten();
```

### SurfaceFit()

#### Description
This function will fit a smooth surface to a control point mesh defined by vertices of this polygonal mesh. This operation performs the same modification as the PEDIT command "Smooth surface" option.
```text
public void SurfaceFit();
public void SurfaceFit(
    Autodesk.AutoCAD.DatabaseServices.PolyMeshType surfType, 
    int surfU, 
    int surfV
);
```

### IsMClosed

#### Description
Assesses if the PolygonMesh is closed in the M direction
```text
public bool IsMClosed;
```

#### Conditions
Read-only
### IsNClosed

#### Description
Assesses if the PolygonMesh is closed in the N direction
```text
public bool IsNClosed;
```

#### Conditions
Read-only
### MSize

#### Description
Accesses the vertex count in the M direction. This is the number of vertices that will be used to make up an M row in the PolygonMesh if the PolyMeshType is SimpleMesh. For any other PolyMeshType, the M surface density value will be used as the row size.
```text
public short MSize;
```

#### Conditions
Read / Write
### MSurfaceDensity

#### Description
Accesses the surface density in the M direction. 
The M surface density is the number of vertices in the M direction after a surface fit operation is performed. This value is used in place of the M size value if the PolyMeshType is anything other than SimpleMesh.
```text
public short MSurfaceDensity;
```

#### Conditions
Read / Write
### NSize

#### Description
Accesses the vertex count in the N direction. This is the number of vertices that will be used to make up an N column in the PolygonMesh if the PolyMeshType is SimpleMesh. For any other PolyMeshType, the N surface density value will be used as the column size.
```text
public short NSize;
```

#### Conditions
Read / Write
### NSurfaceDensity

#### Description
Accesses the surface density in the N direction. The N surface density is the number of vertices in the N direction after a surface fit operation is performed. This value is used in place of the N size value if the PolyMeshType is anything other than SimpleMesh.
```text
public short NSurfaceDensity;
```

#### Conditions
Read / Write
### PolyMeshType

#### Description
Accesses the PolyMeshType of the PolygonMesh.
```text
public Autodesk.AutoCAD.DatabaseServices.PolyMeshType PolyMeshType;
```

#### Conditions
Read / Write