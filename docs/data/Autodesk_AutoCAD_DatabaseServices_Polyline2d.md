# Polyline2d Class

## Overview

#### Description
This .NET class wraps the AcDb2dPolyline ObjectARX class. 
The Polyline2d class represents the 2D polyline entity within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Polyline2d
```

```text
public class Polyline2d : Curve, IEnumerable;
```

#### Notes
The controlling application must explicitly delete the subentities of any complex entity that is not database resident. Otherwise, a small memory leak will result. 
**Do not derive from this class**. Attempting to do so will cause your application to halt AutoCAD. 
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), Vertex2d

## Members

### Constructors

- [Polyline2d()](#polyline2d())

### Methods

- [AppendVertex](#appendvertex)
- [ConvertToPolyType](#converttopolytype)
- [CurveFit](#curvefit)
- [GetEnumerator](#getenumerator)
- [InsertVertexAt(ObjectId, Vertex2d)](#insertvertexat(objectid,-vertex2d))
- [InsertVertexAt(Vertex2d, Vertex2d)](#insertvertexat(vertex2d,-vertex2d))
- [NonDBAppendVertex](#nondbappendvertex)
- [SplineFit()](#splinefit())
- [Straighten](#straighten)
- [VertexPosition](#vertexposition)

### Properties

- [Closed](#closed)
- [ConstantWidth](#constantwidth)
- [DefaultEndWidth](#defaultendwidth)
- [DefaultStartWidth](#defaultstartwidth)
- [Elevation](#elevation)
- [Length](#length)
- [LinetypeGenerationOn](#linetypegenerationon)
- [Normal](#normal)
- [PolyType](#polytype)
- [Thickness](#thickness)


## Constructors Details

### Polyline2d()

#### Description
Default constructor. Constructs an open polyline with linetype generation off and initializes the start and end widths to 0.0, the bulge to 0.0, the elevation to 0.0, the type to SimplePoly, the normal to (0,0,1), and the thickness to 0.0.
```text
public Polyline2d();
public Polyline2d(
    Autodesk.AutoCAD.DatabaseServices.Poly2dType type, 
    Point3dCollection vertices, 
    double elevation, 
    [MarshalAs(UnmanagedType.U1)] bool closed, 
    double startWidth, 
    double endWidth, 
    DoubleCollection bulges
);
```

### AppendVertex

#### Description
This function appends the Vertex2d object to the vertex list of the polyline, establishes the polyline as the vertex's owner, and adds the vertex the Database that contains the polyline (the polyline must be database-resident for this function to succeed). It returns the object ID of the appended vertex. 
The appended vertex must be explicitly closed by the calling application after the AppendVertex() call returns.
```text
public ObjectId AppendVertex(
    Vertex2d vertexToAppend
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vertex2d vertexToAppend | Input the vertex to add to the polyline |

### ConvertToPolyType

#### Description
Uses the SplineFit() and/or CurveFit() methods to convert the polyline to the type specified by the newType argument value.
```text
public void ConvertToPolyType(
    Autodesk.AutoCAD.DatabaseServices.Poly2dType newVal
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.Poly2dType newVal | Input type to which the polyline should be converted |

### CurveFit

#### Description
This function creates a smooth curve consisting of pairs of arcs joining each pair of vertices. The curve passes through all the vertices of the polyline and uses any tangent direction specified by the individual vertices. This operation performs the same modification as the PEDIT command "Fit" option.
```text
public void CurveFit();
```

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public virtual IEnumerator GetEnumerator();
```

### InsertVertexAt(ObjectId, Vertex2d)

#### Description
This function inserts the Vertex2d object pointed to by newVertex into the vertex list of the polyline just after indexVertex. 
In addition, if the polyline is resident within an Database, the vertex will be added to the same database. If the polyline is not database-resident, then when it is added to a database, the vertex will be added as well. 
To insert a vertex at the beginning of the polyline, pass in a NULL for the indexVertex argument. 
If the polyline is database-resident then the inserted vertex must be explicitly closed by the calling application after the InsertVertexAt() call returns. If the polyline is not database-resident, then there is no need to close the vertex since it hasn't been added to the database yet.
```text
public ObjectId InsertVertexAt(
    ObjectId vertexId, 
    Vertex2d newVertex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vertex2d newVertex | Input vertex to be inserted |
| indexVertex | Input vertex in polyline after which the new vertex is to be inserted |

### InsertVertexAt(Vertex2d, Vertex2d)

#### Description
This function inserts the Vertex2d object pointed to by newVertex into the vertex list of the polyline just after the Vertex2d object with objectId vertexId, establishes the polyline as the vertex's owner, and adds the vertex to the Database that contains the polyline (the polyline must be database-resident for this function to succeed). 
To insert a vertex at the beginning of the polyline, pass in Null for the vertexId argument. 
The inserted vertex must be explicitly closed by the calling application after the InsertVertexAt() call returns. 
Returns the object ID of newVertex.
```text
public void InsertVertexAt(
    Vertex2d indexVertex, 
    Vertex2d newVertex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vertex2d newVertex | Input pointer to vertex to be inserted |
| vertexId | Input objectId of the vertex in the polyline after which the new vertex is to be inserted |

### NonDBAppendVertex

#### Description
This function appends the Vertex2d object to the vertex list of the polyline, establishes the polyline as the vertex's owner. The polyline must not be database-resident.
```text
public void NonDBAppendVertex(
    Vertex2d vertexToAppend
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vertex2d vertexToAppend | Input the vertex to add to the polyline |

### SplineFit()

#### Description
This function removes any existing spline or curve-fit vertices, converts all remaining vertices to spline-control vertices, and generates a new set of spline-fit vertices. The resultant polyline is spline fit through the new set of vertices. This operation performs the same modification as the PEDIT command "Spline fit" option.
```text
public void SplineFit();
public void SplineFit(
    Autodesk.AutoCAD.DatabaseServices.Poly2dType value, 
    int segments
);
```

### Straighten

#### Description
This function removes all spline and curve-fit vertices from the polyline and sets all remaining vertices to be simple vertices. This operation performs the same modification as the PEDIT command "Decurve" option.
```text
public void Straighten();
```

### VertexPosition

#### Description
This function returns the WCS coordinate position value of vert. This function uses the _X_ and _Y_ coordinates from the vertex along with the _Z_ coordinate from the polyline and applies the polyline's OCS-to-WCS transformation to produce the WCS position value. This function will work with vertex objects that are not owned by the polyline. The position returned will be as though the vertex was owned by the polyline.
```text
public Point3d VertexPosition(
    Vertex2d vertex
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vertex2d vertex | Input vertex object to get the WCS coordinate for |

### Closed

#### Description
Assesses if the polyline is to be closed (a line segment will be drawn between the last vertex and the first vertex to form a closed polygon).
```text
public bool Closed;
```

#### Conditions
Read / Write
### ConstantWidth

#### Description
Accesses the width of the polyline.
```text
public double ConstantWidth;
```

#### Conditions
Read / Write
### DefaultEndWidth

#### Description
Accesses the default polyline segment ending width value for the polyline. This value is used as the default end width for all vertices within the polyline. So, for DXFOUT, vertices that have this end width will not write the value out. For DXFIN, vertices that do not have a DXF group code 41 value will use the polyline's default end width.
```text
public double DefaultEndWidth;
```

#### Conditions
Read / Write
### DefaultStartWidth

#### Description
Accesses the default polyline segment starting width value for the polyline. This value is used as the default start width for all vertices within the polyline. So, for DXFOUT, vertices that have this start width will not write the value out. For DXFIN, vertices that do not have a DXF group code 40 value will use the polyline's default start width.
```text
public double DefaultStartWidth;
```

#### Conditions
Read / Write
### Elevation

#### Description
Accesses the elevation of the polyline. The elevation is the OCS _Z_ axis value of the polyline (that is, the shortest distance from the WCS origin to the plane containing the polyline).
```text
public double Elevation;
```

#### Conditions
Read / Write
### Length

#### Description
Accesses the total length of the polyline.
```text
public double Length;
```

#### Conditions
Read-only
### LinetypeGenerationOn

#### Description
Assesses if linetype generation is turned on for the polyline. When linetype generation is on, the linetype pattern used by the polyline is generated continuously across all vertices rather than starting over at each vertex.
```text
public bool LinetypeGenerationOn;
```

#### Conditions
Read / Write
### Normal

#### Description
Accesses the normal vector of the plane containing the polyline. The normal vector is in WCS coordinates.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### PolyType

#### Description
Accesses the Poly2dType, which indicates the curve/spline-fit type for this polyline.
```text
public Autodesk.AutoCAD.DatabaseServices.Poly2dType PolyType;
```

#### Conditions
Read / Write
### Thickness

#### Description
Accesses the thickness for the polyline. The vector direction is sometimes called the extrusion direction.
```text
public double Thickness;
```

#### Conditions
Read / Write