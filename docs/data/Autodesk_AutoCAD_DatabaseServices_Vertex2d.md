# Vertex2d Class

## Overview

#### Description
This .NET class wraps the AcDb2dVertex ObjectARX class. 
The 2dVertex class represents the vertices in 2D polylines. It is the only ObjectARX API entity that still passes its position in OCS. This is because the Z coordinate is kept in its owning 2dPolyline for historical purposes. If you are not working in two dimensions, it may be better to use an 3dPolyline, or an AcDbSpline. 
**Warning**
  * Do not derive from this class. Attempting to do so will cause your application to halt AutoCAD.
  * 2dVertex objects contain the AcDbEntity methods to set the entity properties such as color, layer, and linetype. However, vertices are subentities that must have the same entity properties as the parent polyline. Therefore, using the Entity methods within the AcDb2dVertex objects to change these properties to values other than those of the parent will result in corrupt vertices. An audit can fix those corrupt vertices.

Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Vertex
            Autodesk.AutoCAD.DatabaseServices.Vertex2d
```

```text
public class Vertex2d : Vertex;
```

### Constructors

- [Vertex2d()](#vertex2d())
- [Vertex2d(Point3d, double, double, double, double)](#vertex2d(point3d,-double,-double,-double,-double))

### Properties

- [Bulge](#bulge)
- [EndWidth](#endwidth)
- [Position](#position)
- [StartWidth](#startwidth)
- [Tangent](#tangent)
- [TangentUsed](#tangentused)
- [VertexType](#vertextype)


## Constructors Details

### Vertex2d()

#### Description
Constructor.
```text
public Vertex2d();
```

### Vertex2d(Point3d, double, double, double, double)

#### Description
Constructor.
```text
public Vertex2d(
    Point3d position, 
    double bulge, 
    double startWidth, 
    double endWidth, 
    double tangent
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d position | Input Autodesk.AutoCAD.Geometry.Point3d object. |
| double bulge | Input System.Double object. |
| double startWidth | Input System.Double object. |
| double endWidth | Input System.Double object. |
| double tangent | Input System.Double object. |

### Bulge

#### Description
Returns the vertex’s bulge value. The bulge is the tangent of 1/4 of the included angle for the arc between the selected vertex and the next vertex in the polyline’s vertex list. A negative bulge value indicates that the arc goes clockwise from the selected vertex to the next vertex. 
The bulge value is used for DXF group code 42.
```text
public double Bulge;
```

#### Conditions
Read / Write
### EndWidth

#### Description
Returns the end width for the vertex. The end width is used as the width at the end of the polyline segment from this vertex to the next vertex. 
The end width value is used for DXF group code 41.
```text
public double EndWidth;
```

#### Conditions
Read / Write
### Position

#### Description
Returns the position value of the vertex. The position point value must be in OCS coordinates (the OCS of the polyline containing the vertex), not WCS. The Z coordinate is kept in the owning 2dPolyline only for historical purposes. To find the WCS position of the vertex use AcDb2dPolyline.vertexPosition(), which takes a pointer to the vertex as an argument. To get the OCS Z coordinate, use the owning polyline’s AcDb2dPolyline.elevation() method. 
The position value is used for DXF group code 10. 
```text
public Point3d Position;
```

#### Conditions
Read / Write
### StartWidth

#### Description
Returns the start width for the vertex. The start width is used as the width at this vertex for the polyline segment from this vertex to the next vertex. 
The end width value is used for DXF group code 40.
```text
public double StartWidth;
```

#### Conditions
Read / Write
### Tangent

#### Description
Returns the curve-fit tangent direction for the vertex. This is the angle (in radians) between the OCS X axis for the polyline containing the vertex and the tangent direction vector. 
The tangent direction value is used for DXF group code 50.
```text
public double Tangent;
```

#### Conditions
Read / Write
### TangentUsed

#### Description
Checks whether the curve-fit tangent direction is in use by this vertex.
```text
public bool TangentUsed;
```

#### Conditions
Read / Write
### VertexType

#### Description
Returns the .Vertex2dType of this vertex.
```text
public Autodesk.AutoCAD.DatabaseServices.Vertex2dType VertexType;
```

#### Conditions
Read-only