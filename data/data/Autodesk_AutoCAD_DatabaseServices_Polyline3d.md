# Polyline3d Class

## Overview

#### Description
This .NET class wraps the AcDb3dPolyline ObjectARX class. 
The Polyline3d class represents the 3D polyline entity within AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Polyline3d
```

```text
public class Polyline3d : Curve, IEnumerable;
```

#### Notes
The controlling application must explicitly delete the subentities of any complex entity that is not database resident. Otherwise, a small memory leak will result. 
**Do not derive from this class**. Attempting to do so will cause your application to halt AutoCAD. 
#### See Also
DBObject, [Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class")

## Members

### Constructors

- [Polyline3d()](#polyline3d())

### Methods

- [AppendVertex](#appendvertex)
- [ConvertToPolyType](#converttopolytype)
- [GetEnumerator](#getenumerator)
- [InsertVertexAt(ObjectId, PolylineVertex3d)](#insertvertexat(objectid,-polylinevertex3d))
- [InsertVertexAt(PolylineVertex3d, PolylineVertex3d)](#insertvertexat(polylinevertex3d,-polylinevertex3d))
- [SplineFit()](#splinefit())
- [Straighten](#straighten)

### Properties

- [Closed](#closed)
- [Length](#length)
- [PolyType](#polytype)


## Constructors Details

### Polyline3d()

#### Description
Default constructor. Constructs an open polyline with the type initialized to SimplePoly.
```text
public Polyline3d();
public Polyline3d(
    Autodesk.AutoCAD.DatabaseServices.Poly3dType type, 
    Point3dCollection vertices, 
    [MarshalAs(UnmanagedType.U1)] bool closed
);
```

### AppendVertex

#### Description
This function appends the PolylineVertex3d object pointed to by vertexToAppend to the vertex list of the polyline and establishes the polyline as the vertex's owner. In addition, if the polyline is resident within an Database, the vertex will be added to the same database. If the polyline is not database-resident, when it is added to a database the vertex will be added as well. 
If the polyline is database-resident, then the appended vertex must be explicitly closed by the calling application after the AppendVertex() call returns. If the polyline is not database-resident, then there is no need to close the vertex since it has not been added to the database yet.
```text
public ObjectId AppendVertex(
    PolylineVertex3d vertexToAppend
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| PolylineVertex3d vertexToAppend | Input pointer to the vertex to add to the polyline |

### ConvertToPolyType

#### Description
Uses the SplineFit() method to convert the polyline to the type specified by the type argument value. that DXF group code 75 is set to 6.
```text
public void ConvertToPolyType(
    Autodesk.AutoCAD.DatabaseServices.Poly3dType newVal
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.Poly3dType newVal | Input type to which the polyline should be converted |

### GetEnumerator

#### Description
Returns an enumerator object for this collection.
```text
public virtual IEnumerator GetEnumerator();
```

### InsertVertexAt(ObjectId, PolylineVertex3d)

#### Description
This function inserts the PolylineVertex3d object pointed to by newVertex into the vertex list of the polyline just after the PolylineVertex3d object pointed to by indexVertexId and establishes the polyline as the vertex's owner. In addition, if the polyline is database-resident, then when it is added to a database, the vertex will be added as well. 
To insert a vertex at the beginning of the polyline, pass in a NULL for the indexVertexId argument. 
If the polyline is database-resident then the inserted vertex must be explicitly closed by the calling application after the InsertVertexAt() call returns.
```text
public ObjectId InsertVertexAt(
    ObjectId indexVertexId, 
    PolylineVertex3d newVertex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId indexVertexId | Input vertex in polyline after which the new vertex is to be inserted |
| PolylineVertex3d newVertex | Input vertex to be inserted |

### InsertVertexAt(PolylineVertex3d, PolylineVertex3d)

#### Description
This function inserts the PolylineVertex3d object pointed to by newVertex into the vertex list of the polyline just after the PolylineVertex3d object with objectId indexVertId, establishes the polyline as the vertex's owner, and adds the vertex to the Database that contains the polyline (the polyline must be database-resident for this function to succeed). 
To insert a vertex at the beginning of the polyline, pass in Null for the indexVertex argument. 
The inserted vertex must be explicitly closed by the calling application after the InsertVertexAt() call returns.
```text
public void InsertVertexAt(
    PolylineVertex3d indexVertex, 
    PolylineVertex3d newVertex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| PolylineVertex3d indexVertex | Input objectId of the vertex in the polyline after which the new vertex is to be inserted |
| PolylineVertex3d newVertex | Input vertex to be inserted |

### SplineFit()

#### Description
This function removes any existing spline or curve-fit vertices, converts all remaining vertices to spline-control vertices, and generates a new set of spline-fit vertices. The resultant polyline or mesh is spline fit through the new set of vertices. This operation performs the same modification as the PEDIT command "Spline fit" option.
```text
public void SplineFit();
public void SplineFit(
    Autodesk.AutoCAD.DatabaseServices.Poly3dType value, 
    int segments
);
```

### Straighten

#### Description
This function removes all spline and curve-fit vertices from the polyline or mesh and sets all remaining vertices to be simple vertices. This operation performs the same modification as the PEDIT command "Decurve" option.
```text
public void Straighten();
```

### Closed

#### Description
Assesses if the polyline to be closed. A line segment will be drawn between the last vertex and the first vertex to form a closed polygon.
```text
public bool Closed;
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
### PolyType

#### Description
Accesses the Poly3dType, which indicates the spline-fit type for this 3D polyline.
```text
public Autodesk.AutoCAD.DatabaseServices.Poly3dType PolyType;
```

#### Conditions
Read / Write