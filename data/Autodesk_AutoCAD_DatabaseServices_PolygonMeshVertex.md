# PolygonMeshVertex Class

## Overview

#### Description
This .NET class wraps the AcDbPolygonMeshVertex ObjectARX class. 
The PolygonMeshVertex class represents vertices within polygon meshes in AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Vertex
            Autodesk.AutoCAD.DatabaseServices.PolygonMeshVertex
```

```text
public class PolygonMeshVertex : Vertex;
```

#### Notes
Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD.
Warning
PolygonMeshVertex objects contain the Entity methods to set the entity properties such as color, layer, and linetype, but vertices are subentities that are supposed to have the same entity properties as the parent polygon mesh. So, using the Entity methods within the PolygonMeshVertex objects to change these properties to values other than those of the parent result in corrupt vertices (which audit can fix).
#### See Also
DBObject, Entity, PolygonMesh

## Members

### Constructors

- [PolygonMeshVertex()](#polygonmeshvertex())
- [PolygonMeshVertex(Point3d)](#polygonmeshvertex(point3d))

### Properties

- [Position](#position)
- [VertexType](#vertextype)


## Constructors Details

### PolygonMeshVertex()

#### Description
Default constructor. Initializes the position to (0,0,0) and the vertex type to SimpleVertex.
```text
public PolygonMeshVertex();
```

### PolygonMeshVertex(Point3d)

#### Description
Constructs a PolygonMeshVertex that uses position as the position point. The vertex type is initialized to SimpleVertex.
```text
public PolygonMeshVertex(
    Point3d point
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d point | Input WCS position point for the vertex |

### Position

#### Description
Accesses the WCS point value of this vertex.
```text
public Point3d Position;
```

#### Conditions
Read / Write
### VertexType

#### Description
Accesses the Vertex3dType of this vertex.
```text
public Autodesk.AutoCAD.DatabaseServices.Vertex3dType VertexType;
```

#### Conditions
Read / Write