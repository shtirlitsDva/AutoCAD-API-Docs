# Mline Class

## Overview

#### Description
This .NET class wraps the Mline ObjectARX class. 
The Mline class represents the AutoCAD MLINE entity. This multi-line entity allows the user to create a complex line with multiple parallel line parts, each with its own linetype. The space between these parallel lines can be filled if desired.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Mline
```

```text
public class Mline : Entity;
```

#### See Also
DBObject, MlineStyle, [Point3d](Autodesk_AutoCAD_Geometry_Point3d.md), [Vector3d](Autodesk_AutoCAD_Geometry_Vector3d.md), Extents3d, [Plane](Autodesk_AutoCAD_Geometry_Plane.md), ObjectId

## Members

### Constructors

- [Mline](#mline)

### Methods

- [AppendSegment](#appendsegment)
- [Element](#element)
- [GetClosestPointTo(Point3d, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#getclosestpointto(point3d,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [GetClosestPointTo(Point3d, Vector3d, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#getclosestpointto(point3d,-vector3d,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [MoveVertexAt](#movevertexat)
- [RemoveLastSegment](#removelastsegment)
- [VertexAt](#vertexat)

### Properties

- [IsClosed](#isclosed)
- [Justification](#justification)
- [Normal](#normal)
- [NumberOfVertices](#numberofvertices)
- [Scale](#scale)
- [Style](#style)
- [SupressEndCaps](#supressendcaps)
- [SupressStartCaps](#supressstartcaps)


## Constructors Details

### Mline

#### Description
Default constructor does no explicit initialization of data members at all for the new Mline object.
```text
public Mline();
```

### AppendSegment

#### Description
Projects newVertex along the MLine object's normal vector onto the plane defined by the normal vector and the first vertex of the MLine object. The result of this projection is appended to the end of the MLine object's vertex list. This generates a new MLine object segment between the previously "last" vertex and the newly added vertex. 
After segments are appended, IsClosed must be called to close the MLine object.
```text
public void AppendSegment(
    Point3d newVertex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d newVertex | Input new vertex point (in WCS) to be added |

### Element

#### Description
This function attempts to find which element of the MLine object contains the point pt. If an element is not found that directly contains the point and the MLine object is not closed, then the ends of the MLine object are "virtually" extended to see if pt lies in the path of any element. 
If successful, the index number of the element (see MlineStyle for an explanation of elements) that contains pt is returned. If not successful, then -1 is returned.
```text
public int Element(
    Point3d pt
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d pt | Input search point |

### GetClosestPointTo(Point3d, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
Finds the point on the MLine object that is closest to givenPoint and returns it. If extend == true, then the MLine object will be "virtually" extended to find the closest point. If excludeCaps == true, then any endcaps on the MLine object will be ignored.
```text
public Point3d GetClosestPointTo(
    Point3d givenPoint, 
    [MarshalAs(UnmanagedType.U1)] bool extend, 
    [MarshalAs(UnmanagedType.U1)] bool excludeCaps
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d givenPoint | Input point to find nearest point to |
| [MarshalAs(UnmanagedType.U1)] bool extend | Input Boolean indicating if search should include "virtual" extension of Mline |
| [MarshalAs(UnmanagedType.U1)] bool excludeCaps | Input Boolean indicating if endcaps should not be included in nearest point search |

### GetClosestPointTo(Point3d, Vector3d, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
In this function, givenPoint is projected along the normal vector onto the plane containing the MLine object. Then the resulting projected point is used to find the point on the MLine object that is closest. pointOnCurve is filled in with the closest point found. If extend == true, then the MLine object will be "virtually" extended to find the closest point. If excludeCaps == true, then any endcaps on the MLine object will be ignored.
```text
public Point3d GetClosestPointTo(
    Point3d givenPoint, 
    Vector3d normal, 
    [MarshalAs(UnmanagedType.U1)] bool extend, 
    [MarshalAs(UnmanagedType.U1)] bool excludeCaps
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d givenPoint | Input point to find nearest point to |
| Vector3d normal | Input direction of projection |
| [MarshalAs(UnmanagedType.U1)] bool extend | Input Boolean indicating if search should include "virtual" extension of Mline |
| [MarshalAs(UnmanagedType.U1)] bool excludeCaps | Input Boolean indicating if endcaps should not be included in nearest point search |

### MoveVertexAt

#### Description
Changes vertex in index position in the MLine object's vertex array (0 based) to use a value determined by projecting the newPosition point along the MLine object's normal vector onto the plane defined by the normal vector and the MLine object's first vertex.
```text
public void MoveVertexAt(
    int index, 
    Point3d newPosition
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index of vertex to move in the vertex array |
| Point3d newPosition | Input new vertex value |

### RemoveLastSegment

#### Description
Removes the last vertex in the MLine object's vertex array. The value of the new "last" vertex is then copied into lastVertex.
```text
public void RemoveLastSegment(
    Point3d lastVertex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d lastVertex | Returns filled in with the value of the vertex that becomes last when current last is removed |

### VertexAt

#### Description
Input index (0 based) of desired vertex
```text
public Point3d VertexAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Returns the value of the vertex at the index location (0 based) in the MLine object's vertex array. |

### IsClosed

#### Description
Assesses if the MLine is closed.
```text
public bool IsClosed;
```

#### Conditions
Read / Write
### Justification

#### Description
Accesses the justification for the MLine object.
```text
public MlineJustification Justification;
```

#### Conditions
Read / Write
### Normal

#### Description
Accesses the unit normal vector the MLine object.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### NumberOfVertices

#### Description
Accesses the number of vertices in the MLine object.
```text
public int NumberOfVertices;
```

#### Conditions
Read-only
### Scale

#### Description
Accesses the current scale value in use by the MLine object. The scale value controls the overall width of the MLine object. This scale doesn't affect linetype scale. 
The scale factor is based on the width established in the MlineStyle definition. A scale factor of 2 produces an MLine object twice as wide as the style definition. A negative scale factor flips the order of the offset lines--the smallest on top, when the MLine object is drawn from left to right. A negative scale value also alters the scale by the absolute value. A scale factor of 0 collapses the MLine object into a single line. For information on the MlineStyle definition, see MlineStyle and the MLSTYLE command in the _AutoCAD User's Guide_.
```text
public double Scale;
```

#### Conditions
Read / Write
### Style

#### Description
Accesses the objectId of the MlineStyle currently used by the MLine object.
```text
public ObjectId Style;
```

#### Conditions
Read / Write
### SupressEndCaps

#### Description
Assesses if endcaps are currently suppressed for the MLine object.
```text
public bool SupressEndCaps;
```

#### Conditions
Read / Write
### SupressStartCaps

#### Description
Assesses if startcaps are currently suppressed for the MLine object. Conditions
```text
public bool SupressStartCaps;
```
