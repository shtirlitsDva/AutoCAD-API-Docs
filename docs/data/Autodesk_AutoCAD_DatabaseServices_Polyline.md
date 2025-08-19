# Polyline Class

## Overview

#### Description
This .NET class wraps the AcDbPolyline ObjectARX class. 
Polyline is often called a lightweight polyline because of its efficient use of memory. Polyline provides greater performance and reduced overhead compared to Polyline2d. Its database representation is more efficient because it is stored as a single object with a single name, handle, type, space, layer, and width. 
A lightweight polyline has: 
  * Straight line segments
  * Bulge (arc segments)
  * Constant and variable width
  * Thickness

Functionality and command options not available in a lightweight polyline include: 
  * Arc Fit curve data
  * Spline Fit data
  * Curve fit tangent direction data

The lightweight polyline is created with the PLINE command and edited with the PEDIT command. When creating or editing lightweight polylines, the command options for PLINE and PEDIT remain the same as in previous releases. 
The PEDIT command edits lightweight polylines in the same manner as Polyline2d in previous releases. If the Spline or Fit option is entered, then the lightweight polyline is converted to an Polyline2d for the duration of the edit. The handle is always maintained; it does not change. The handle of the lightweight polyline becomes the handle for the Polyline2d (the header entity for the old style polyline entity that contains subentities). 
Grip behavior is identical to that of Polyline2d. Behavior with all AutoCAD edit commands also remains the same. 
Lightweight polyline properties include color, layer, linetype, ltype scale, width, and thickness. All properties apply to the entire object and cannot vary between individual segments.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Polyline
```

```text
public class Polyline : Curve;
```

#### Notes
The Polyline class overrides the Entity.SaveAs() method. Polyline.SaveAs() does not call the entity's WorldDraw(), nor does it draw graphics for proxies. Therefore, you need to implement your own SaveAs() method to generate graphics when AutoCAD is obtaining proxy graphics on any objects of your class. 
The number of vertices in a lightweight polyline must be greater than one. A polyline with 0 or 1 vertices should not be posted or left remaining in the database.
#### See Also
[Entity](Autodesk_AutoCAD_DatabaseServices_Entity.md "Entity Class"), DBObject, Polyline2d

## Members

### Constructors

- [Polyline()](#polyline())
- [Polyline(int)](#polyline(int))

### Methods

- [AddVertexAt](#addvertexat)
- [ConvertFrom](#convertfrom)
- [ConvertTo](#convertto)
- [GetArcSegment2dAt](#getarcsegment2dat)
- [GetArcSegmentAt](#getarcsegmentat)
- [GetBulgeAt](#getbulgeat)
- [GetEndWidthAt](#getendwidthat)
- [GetLineSegment2dAt](#getlinesegment2dat)
- [GetLineSegmentAt](#getlinesegmentat)
- [GetPoint2dAt](#getpoint2dat)
- [GetPoint3dAt](#getpoint3dat)
- [GetSegmentType](#getsegmenttype)
- [GetStartWidthAt](#getstartwidthat)
- [MaximizeMemory](#maximizememory)
- [MinimizeMemory](#minimizememory)
- [OnSegmentAt](#onsegmentat)
- [RemoveVertexAt](#removevertexat)
- [Reset](#reset)
- [SetBulgeAt](#setbulgeat)
- [SetEndWidthAt](#setendwidthat)
- [SetPointAt](#setpointat)
- [SetStartWidthAt](#setstartwidthat)

### Properties

- [Closed](#closed)
- [ConstantWidth](#constantwidth)
- [Elevation](#elevation)
- [HasBulges](#hasbulges)
- [HasWidth](#haswidth)
- [IsOnlyLines](#isonlylines)
- [Length](#length)
- [Normal](#normal)
- [NumberOfVertices](#numberofvertices)
- [Plinegen](#plinegen)
- [Thickness](#thickness)


## Constructors Details

### Polyline()

#### Description
Default constructor.
```text
public Polyline();
```

### Polyline(int)

#### Description
The Polyline dynamically allocates memory when vertices are added. However, if you know the number of vertices to be added, memory can be allocated to the exact size by specifying the number of vertices in the constructor. Specifying a non-zero value for vertices doesn't mean that the polyline automatically has that many vertices. It means that memory has been allocated, ready to be loaded with vertex information. The memory allocated is unused until it gets filled by Polyline.AddVertexAt() calls. 
If a polyline is being grown or shrunk by adding or removing vertices, the dynamic memory allocation will only grow and not shrink. When the user is finished adding or removing vertices, there may be unused allocated memory. To trim this unused memory, use Polyline.MinimizeMemory() when all additions or removals to the polyline are done. This is not done automatically for every Polyline.AddVertexAt() and Polyline.RemoveVertexAt() because it is a time-expensive operation.
```text
public Polyline(
    int vertices
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int vertices | Input number of vertices to allocate memory for |

### AddVertexAt

#### Description
This function adds a vertex to the polyline. If index is 0, the vertex will become the first vertex of the polyline. If index is the value returned by Polyline.NumberOfVertices, then the vertex will become the last vertex of the polyline. Otherwise the vertex will be added just before the index vertex. 
**Note**
pt must be specified in the Entity Coordinate System of the polyline, not in the World Coordinate System (WCS). 
```text
public void AddVertexAt(
    int index, 
    Point2d pt, 
    double bulge, 
    double startWidth, 
    double endWidth
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) before which to insert the vertex |
| Point2d pt | Input vertex location point |
| double bulge | Input bulge value for vertex |
| double startWidth | Input start width for vertex |
| double endWidth | Input end width for vertex |

### ConvertFrom

#### Description
This fills the Polyline with data from the Polyline2d pointed to by entity. entity must point to a SimplePoly or FitCurvePoly type of Polyline2d object in a database. This function should be called from an Polyline that is not yet database-resident. 
If transferId is true, the calling Polyline will become database-resident. The calling Polyline will assume the ObjectId and handle, plus any extended entity data (except data on vertices), the extension dictionary, and reactors of the Polyline2d entity entity. entity will then be deleted and set to NULL. 
If transferId is false, entity will remain in the database as is and the caller must close it. The resulting Polyline will not be database-resident, and if not appended to a database, should be deleted.
```text
public void ConvertFrom(
    Entity entity, 
    [MarshalAs(UnmanagedType.U1)] bool transferId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Entity entity | Input pointer to the Polyline2d to copy from |
| [MarshalAs(UnmanagedType.U1)] bool transferId | Input Boolean indicating whether or not to do a HandOverTo between the Polyline2d and the Polyline |

### ConvertTo

#### Description
This function creates an Polyline2d from the Polyline and returns the newly created Polyline2d. 
If transferId is true, the newly-created Polyline2d will become database-resident and will assume the ObjectId and handle, plus any extended entity data, extension dictionary, and reactors of the Polyline on which this method is called. The Polyline will then no longer be database-resident and can be deleted by the C++ delete operator. 
If transferId is false, then the Polyline will remain in the database as is and the caller must close it. The resulting Polyline2d and all its vertices will not be database-resident, and if not appended to a database, should be deleted.
```text
public Polyline2d ConvertTo(
    [MarshalAs(UnmanagedType.U1)] bool transferId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool transferId | Input Boolean indicating whether or not to do a handOverTo between the Polyline and the Polyline2d. |

### GetArcSegment2dAt

#### Description
If the segment at vertex index is an arc, then this function will fill in arc with the 2D arc information (radius, center, and so on) from the polyline in the polyline's own OCS.
```text
public CircularArc2d GetArcSegment2dAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex for start of arc |

### GetArcSegmentAt

#### Description
If the segment at vertex index is an arc, then this function will fill in arc with the 3D arc information (radius, center, and so on) from the polyline in WCS.
```text
public CircularArc3d GetArcSegmentAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex for start of arc |

### GetBulgeAt

#### Description
This function gets the bulge factor value at the index vertex. The bulge factor is used to indicate how much of an arc segment is present at this vertex. The bulge factor is the tangent of one fourth the included angle for an arc segment, made negative if the arc goes clockwise from the start point to the endpoint. A bulge of 0 indicates a straight segment, and a bulge of 1 is a semicircle.
```text
public double GetBulgeAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex for start of bulge |

### GetEndWidthAt

#### Description
Returns the polyline segment ending width value for the polyline. This value is used as the default end width for all vertices within the polyline.
```text
public double GetEndWidthAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the polyline |

### GetLineSegment2dAt

#### Description
If the segment at vertex index is a line, then this functions returns a representative 2D copy of that segment in the polyline's own object coordinate system (OCS).
```text
public LineSegment2d GetLineSegment2dAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex for start of segment |

### GetLineSegmentAt

#### Description
If the segment at vertex index is a line, then this functions returns a representative 3D copy of that segment in World Coordinates.
```text
public LineSegment3d GetLineSegmentAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex for start of segment |

### GetPoint2dAt

#### Description
This function returns the 2D location of the vertex index in the polyline's own object coordinate system (OCS).
```text
public Point2d GetPoint2dAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex |

### GetPoint3dAt

#### Description
This function returns the 3D location of the vertex index in World Coordinates.
```text
public Point3d GetPoint3dAt(
    int value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int value | Input index (0 based) of the vertex |

### GetSegmentType

#### Description
This function returns the type of segment (SegType) that is headed by the vertex index. 
If index is invalid, then this function will assume start and end vertex values of 0.0 and will return a SegType of Coincident.
```text
public SegmentType GetSegmentType(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex |

### GetStartWidthAt

#### Description
This returns the star width.
```text
public double GetStartWidthAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex |

### MaximizeMemory

#### Description
This function "decompresses" any memory compression that may currently be used by the polyline. This enables faster access to the polyline for modification.
```text
public void MaximizeMemory();
```

### MinimizeMemory

#### Description
This function optimizes the memory usage of the polyline. This process takes time and should not be used until all modifications in a session are complete.
```text
public void MinimizeMemory();
```

### OnSegmentAt

#### Description
This function determines whether or not pt2d (specified in the polyline's Entity Coordinate System) is on the segment of the polyline starting at vertex index . If pt2d is on the polyline's segment, then param is set to the location of the point on the segment. value will be in the parametric form of the segment type (in other words, linear or arc). 
Returns true if the point is on the polyline.
```text
public virtual bool OnSegmentAt(
    int index, 
    Point2d pt2d, 
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex |
| Point2d pt2d | Input point (in polyline OCS coords) to check at vertex index |
| double value | Output parameter of at vertex index |

### RemoveVertexAt

#### Description
This function removes the vertex at index.
```text
public void RemoveVertexAt(
    int index
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex to remove |

### Reset

#### Description
This function resets the polyline's vertex data. 
If reuse is true, then the NumberOfVertices number of vertices are left intact and all vertices beyond that number are deleted. 
If reuse is false, then NumberOfVertices is ignored and all existing vertex information will be deleted.
```text
public void Reset(
    [MarshalAs(UnmanagedType.U1)] bool reuse, 
    int vertices
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool reuse | Input Boolean indicating whether or not to retain some vertices |
| int vertices | Input number of vertices to retain |

### SetBulgeAt

#### Description
This function sets bulge to be the bulge value for the index vertex. This will determine the bulge for the polyline segment which follows the index vertex.
```text
public void SetBulgeAt(
    int index, 
    double bulge
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex |
| double bulge | Input bulge value for the vertex |

### SetEndWidthAt

#### Description
This function sets the end width for vertex index.
```text
public void SetEndWidthAt(
    int index, 
    double endWidth
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex |
| double endWidth | Input end width value for vertex index |

### SetPointAt

#### Description
This sets pt (in polyline OCS coordinates) to be the location of the index vertex.
```text
public void SetPointAt(
    int index, 
    Point2d pt
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex |
| Point2d pt | Input location for the vertex |

### SetStartWidthAt

#### Description
This function sets the start width for vertex index.
```text
public void SetStartWidthAt(
    int index, 
    double startWidth
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of the vertex |
| double startWidth | Input start width value for vertex index |

### Closed

#### Description
Accesses whether the polyline should be closed (that is, there is a segment drawn from the last vertex to the first) or not.
```text
public bool Closed;
```

#### Conditions
Read / Write
### ConstantWidth

#### Description
Accesses the polyline's constant width.
```text
public double ConstantWidth;
```

#### Conditions
Read / Write
### Elevation

#### Description
Accesses the distance of the polyline's plane from the WCS origin.
```text
public double Elevation;
```

#### Conditions
Read / Write
### HasBulges

#### Description
Assesses if the polyline has any bulge factors set for any of the segments. Bulge factor values are required for arc segments within the polyline.
```text
public bool HasBulges;
```

#### Conditions
Read-only
### HasWidth

#### Description
Assesses if the polyline has any width values set for any of the segments. Width values are required for varying width segments within the polyline.
```text
public bool HasWidth;
```

#### Conditions
Read-only
### IsOnlyLines

#### Description
Assesses if there are only lines in the polyline.
```text
public bool IsOnlyLines;
```

#### Conditions
Read-only
### Length

#### Description
Accesses the total length of the polyline.
```text
public double Length;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the normal (in WCS coordinates) to the plane containing the polyline.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### NumberOfVertices

#### Description
Accesses the number of vertices in the polyline.
```text
public int NumberOfVertices;
```

#### Conditions
Read-only
### Plinegen

#### Description
If true, the polyline displays its linetype across vertices
```text
public bool Plinegen;
```

#### Conditions
Read / Write
### Thickness

#### Description
Accesses the thickness (extrusion depth or height) of the polyline.
```text
public double Thickness;
```

#### Conditions
Read / Write