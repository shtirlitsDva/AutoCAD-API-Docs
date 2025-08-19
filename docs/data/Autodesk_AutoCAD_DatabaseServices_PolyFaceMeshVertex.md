# PolyFaceMeshVertex Class

## Overview

#### Description
This .NET class wraps the AcDbPolyFaceMeshVertex ObjectARX class. 
The PolyFaceMeshVertex class represents the vertices within PolyFaceMesh entities in AutoCAD drawings.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Vertex
            Autodesk.AutoCAD.DatabaseServices.PolyFaceMeshVertex
```

```text
public class PolyFaceMeshVertex : Vertex;
```

#### Notes
Warning
Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD. PolyFaceMeshVertex objects contain the Entity methods to set the entity properties such as color, layer, and linetype, but vertices are subentities that are supposed to have the same entity properties as the parent polyface mesh. So, using the Entity methods within the PolyFaceMeshVertex objects to change these properties to values other than those of the parent results in corrupt vertices (which audit can fix).
#### See Also
PolyFaceMesh

## Members

### Constructors

- [PolyFaceMeshVertex()](#polyfacemeshvertex())
- [PolyFaceMeshVertex(Point3d)](#polyfacemeshvertex(point3d))

### Properties

- [Position](#position)


## Constructors Details

### PolyFaceMeshVertex()

#### Description
Default constructor. Initializes the position to (0,0,0) and the vertex type to SimpleVertex.
```text
public PolyFaceMeshVertex();
```

### PolyFaceMeshVertex(Point3d)

#### Description
Constructs an PolyFaceMeshVertex that uses position as the position point. The vertex type is initialized to SimpleVertex.
```text
public PolyFaceMeshVertex(
    Point3d position
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d position | Input WCS position point for the vertex |

### Position

#### Description
Accesses the WCS point value of this vertex.
```text
public Point3d Position;
```

#### Conditions
Read / Write