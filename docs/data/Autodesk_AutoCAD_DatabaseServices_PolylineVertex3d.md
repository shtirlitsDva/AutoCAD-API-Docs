# PolylineVertex3d Class

## Overview

#### Description
This .NET class wraps the AcDb3dPolylineVertex ObjectARX class. 
The PolylineVertex3d class represents the vertices within 3D polylines in AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Vertex
            Autodesk.AutoCAD.DatabaseServices.PolylineVertex3d
```

```text
public class PolylineVertex3d : Vertex;
```

#### Notes
PolylineVertex3d objects contain the Entity methods to set the entity properties such as color, layer, and linetype. However, vertices are subentities that are supposed to have the same entity properties as the parent polyline. Therefore, using the Entity methods within the PolylineVertex3d objects to change these properties to values other than those of the parent will result in corrupt vertices. An audit can fix the corrupt vertices. 
**Do not derive from this class**. Attempting to do so will cause your application to halt AutoCAD. 
#### See Also
DBObject, Entity, Polyline3d

## Members

### Constructors

- [PolylineVertex3d()](#polylinevertex3d())
- [PolylineVertex3d(Point3d)](#polylinevertex3d(point3d))

### Properties

- [Position](#position)
- [VertexType](#vertextype)


## Constructors Details

### PolylineVertex3d()

#### Description
Default constructor. Initializes the position to (0,0,0) and the vertex type to SimpleVertex.
```text
public PolylineVertex3d();
```

### PolylineVertex3d(Point3d)

#### Description
Constructs an PolylineVertex3d that uses position as the position point. The vertex type is initialized to SimpleVertex.
```text
public PolylineVertex3d(
    Point3d param0
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d param0 | Input WCS position point for the vertex |

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
Accesses the the Vertex3dType of this vertex.
```text
public Autodesk.AutoCAD.DatabaseServices.Vertex3dType VertexType;
```

#### Conditions
Read-only