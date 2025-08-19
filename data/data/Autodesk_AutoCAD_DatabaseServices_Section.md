# Section Class

## Overview

#### Description
This .NET class wraps the AcDbSection ObjectARX class. It represents the section plane entity in AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Section
```

```text
public class Section : Entity;
```

### Constructors

- [Section()](#section())
- [Section(Point3dCollection, Vector3d)](#section(point3dcollection,-vector3d))
- [Section(Point3dCollection, Vector3d, Vector3d)](#section(point3dcollection,-vector3d,-vector3d))

### Methods

- [AddVertex](#addvertex)
- [CreateJog](#createjog)
- [GenerateSectionGeometry](#generatesectiongeometry)
- [GetVertex](#getvertex)
- [GetVertices](#getvertices)
- [Height](#height)
- [HitTest](#hittest)
- [RemoveVertex](#removevertex)
- [SetHeight](#setheight)
- [SetVertex](#setvertex)

### Properties

- [BottomPlane](#bottomplane)
- [Boundary](#boundary)
- [Elevation](#elevation)
- [HasJogs](#hasjogs)
- [IndicatorFillColor](#indicatorfillcolor)
- [IndicatorTransparency](#indicatortransparency)
- [IsLiveSectionEnabled](#islivesectionenabled)
- [IsSlice](#isslice)
- [Name](#name)
- [Normal](#normal)
- [NumVertices](#numvertices)
- [SectionPlaneOffset](#sectionplaneoffset)
- [Settings](#settings)
- [State](#state)
- [ThicknessDepth](#thicknessdepth)
- [TopPlane](#topplane)
- [VerticalDirection](#verticaldirection)
- [Vertices](#vertices)
- [ViewingDirection](#viewingdirection)


## Constructors Details

### Section()

#### Description
Constructor.
```text
public Section();
```

### Section(Point3dCollection, Vector3d)

#### Description
Constructs a section plane using the specified points and vector.
```text
public Section(
    Point3dCollection pts, 
    Vector3d verticalDir
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3dCollection pts | Input vertex points on the section line; should contain at least two points |
| Vector3d verticalDir | Input vector on the first segment's plane, normal to the section line |

### Section(Point3dCollection, Vector3d, Vector3d)

#### Description
Constructor.
```text
public Section(
    Point3dCollection pts, 
    Vector3d verticalDir, 
    Vector3d vecViewingDir
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3dCollection pts | Input vertex points on the section line; should contain at least two points |
| Vector3d verticalDir | Input vector on the first segment's plane, normal to the section line |
| Vector3d vecViewingDir | Input vector specifying the viewing direction |

### AddVertex

#### Description
Inserts or adds a new vertex to the section plane. If nInsertAt is less than zero, or is equal to or more than the number of vertices, the new vertex will be added after the last vertex.
```text
public void AddVertex(
    int nInsertAt, 
    Point3d pt
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int nInsertAt | Input index at which to add the new vertex |
| Point3d pt | Input position of the new vertex |

#### Notes
This method is obsolete.
Boundary
### CreateJog

#### Description
Creates a jog in the section plane at the specified point.
```text
public void CreateJog(
    Point3d ptOnSection
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d ptOnSection | Input point on the section line at which to create the jog |

### GenerateSectionGeometry

#### Description
This function generates 2D or 3D section geometry. Sectionable entities include 3dSolid, Surface, Body, and Region.
```text
public void GenerateSectionGeometry(
    Entity pEnt, 
    out Array pIntFillEnts, 
    out Array pBackgroundEnts, 
    out Array pForegroundEnts, 
    out Array pFurveTangencyEnts, 
    out Array pCurveTangencyEnts
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Entity pEnt | Input sectionable entity |
| out Array pIntFillEnts | Return array containing intersection boundary geometry |
| out Array pBackgroundEnts | Return array containing intersection fill annotation geometry |
| out Array pForegroundEnts | Return array containing background geometry |
| out Array pFurveTangencyEnts | Return array containing foreground geometry |
| out Array pCurveTangencyEnts | Return array containing curve tangency geometry |

### GetVertex

#### Description
Gets the position of the specified vertex.
```text
public Point3d GetVertex(
    int nIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int nIndex | Input zero-based index of the vertex to be retrieved; should be less than the number of vertices |

#### Notes
This method is obsolete.
### GetVertices

#### Description
This function returns all section plane vertices in the pts array.
```text
public void GetVertices(
    Point3dCollection pts
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3dCollection pts | Output reference to receive vertices |

#### Notes
This method is obsolete.
### Height

#### Description
Returns the height of the section plane above or below the section line. The returned height is the indicator height when the section plane type is either plane or boundary, since the cut extends infinitely in the vertical direction for these two types. The height of the cut is returned when the section plane type is volume.
```text
public double Height(
    SectionHeight nHeightType
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SectionHeight nHeightType | Input one of the SectionHeight enum values |

### HitTest

#### Description
Performs a hit test on the section plane and returns the result.
```text
public SectionHitTestInfo HitTest(
    Point3d ptHit
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d ptHit | Input point to perform hit test |

### RemoveVertex

#### Description
Removes a vertex from the section plane. The first vertex cannot be removed.
```text
public void RemoveVertex(
    int nIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int nIndex | Input index of the vertex to remove |
| nHeightType | Input one of the Height enum values |
| fHeight | Input height |

#### Notes
This method is obsolete.
### SetHeight

#### Description
```text
public void SetHeight(
    SectionHeight nHeightType, 
    double fHeight
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| SectionHeight nHeightType | Input one of the Height enum val |
| double fHeight | Input height Sets the height of the section plane above or below the section line. The height is the indicator height when the section plane type is plane or boundary, since the cuts extends infinitely in the vertical direction for these two types. |

### SetVertex

#### Description
Sets the position of the specified vertex.
```text
public void SetVertex(
    int nIndex, 
    Point3d pt
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int nIndex | Input zero-based index of the vertex to set; should be less than the number of vertices |
| Point3d pt | Input new position of the vertex |

#### Notes
This method is obsolete.
### BottomPlane

#### Description
Returns the BottomPlane property value.
```text
public double BottomPlane;
```

#### Conditions
Read / Write
### Boundary

#### Description
Assesses the section plane that is bounded by the section line, two side lines, and a back line.
```text
public IList<Point3d> Boundary;
```

#### Conditions
Read-only
#### Notes
The plane may also extend infinitely up and down.
### Elevation

#### Description
Specifies elevation of the plane.
```text
public double Elevation;
```

#### Conditions
Read / Write
### HasJogs

#### Description
Returns if the section has jogs.
```text
public bool HasJogs;
```

#### Conditions
Read / Write
### IndicatorFillColor

#### Description
Returns the fill color of the section plane indicator. 
```text
public Autodesk.AutoCAD.Colors.Color IndicatorFillColor;
```

#### Conditions
Read / Write
### IndicatorTransparency

#### Description
Returns the transparency value for the section plane indicator. The transparency value is in the range 1 to 100.
```text
public int IndicatorTransparency;
```

#### Conditions
Read / Write
### IsLiveSectionEnabled

#### Description
Returns true if live sectioning is enabled in the section plane.
```text
public bool IsLiveSectionEnabled;
```

#### Conditions
Read-only
### IsSlice

#### Description
Specifies if a section object is a slice type. If it is, the state will be set as kBoundary and all jogs will be removed.
```text
public bool IsSlice;
```

#### Conditions
Read / Write
### Name

#### Description
Returns the name of the section plane. The name should not be blank and should be unique. It cannot contain the vertical bar, or pipe, character ("|").
```text
public string Name;
```

#### Conditions
Read / Write
### Normal

#### Description
Returns the normal vector. The returned unit vector is perpendicular to the first segment of the section plane.
```text
public Vector3d Normal;
```

#### Conditions
Read-only
### NumVertices

#### Description
Returns the number of vertices on the section line of the section plane. A valid section plane has a minimum of two vertices.
```text
public int NumVertices;
```

#### Conditions
Read-only
#### Notes
This property is obsolete.
### SectionPlaneOffset

#### Description
Returns the section plane offset distance. The offset is the distance between the section plane and the parallel plane passing through WCS origin. If the section line has multiple segments, it is the plane of the first segment.
```text
public double SectionPlaneOffset;
```

#### Conditions
Read / Write
### Settings

#### Description
Returns the setting property value.
```text
public ObjectId Settings;
```

#### Conditions
Read-only
### State

#### Description
Returns the state of this section object.
```text
public SectionState State;
```

#### Conditions
Read / Write
### ThicknessDepth

#### Description
Returns the thickness depth of a slice type section. Else it returns 0.0.
```text
public double ThicknessDepth;
```

#### Conditions
Read / Write
### TopPlane

#### Description
Returns TopPlane property value.
```text
public double TopPlane;
```

#### Conditions
Read / Write
### VerticalDirection

#### Description
Returns a unit vector specifying the vertical direction of the section plane. The returned vector is on first segment's plane, perpendicular to the section line.
```text
public Vector3d VerticalDirection;
```

#### Conditions
Read / Write
### Vertices

#### Description
Returns the 3d vertices of the section plane.
```text
public Point3dCollection Vertices;
```

#### Conditions
Read / Write
#### Notes
This property is obsolete.
### ViewingDirection

#### Description
Returns a unit vector that specifies the viewing direction of the section plane. The returned vector is perpendicular to the first segment's plane.
```text
public Vector3d ViewingDirection;
```

#### Conditions
Read / Write