# Hatch Class

## Overview

#### Description
This .NET class wraps the Hatch ObjectARX class. 
Hatch is a planar entity that can be created and placed in an arbitrary plane in 3D space. 
The hatch plane can be uniquely defined by a normal vector in WCS (World Coordinate System) and an elevation indicating the distance from the WCS origin to the hatch plane. The hatch plane adopts a standard AutoCAD object coordinate system (OCS). Its origin coincides with the WCS origin and its X and Y axes are calculated using the arbitrary axis algorithm. 
The hatch boundary defines the area to be filled with the specified hatch pattern. The internal representation of the hatch boundary consists of a set of planar loops. Each loop is made of a collection of 2D edges of line, circular arc, elliptic arc and spline. If the hatch boundary contains two or more loops, the areas enclosed by individual loops must be completely disjoint or one will completely enclose the other. 
The hatch boundary defines the area to be filled with the specified hatch pattern. The internal representation of the hatch boundary consists of a set of planar loops. Each loop is made of a collection of 2D edges of line, circular arc, elliptic arc and spline. If the hatch boundary contains two or more loops, the areas enclosed by individual loops must be completely disjoint or one will completely enclose the other. 
A loop must be simple, closed, and continuous, intersecting itself only at its endpoints. Furthermore, its start point and end point must coincide. When defining the hatch boundary, the application must ensure that the loops and edges are well defined and structured. If the boundary contains two or more loops, they must be organized into a nested structure in which the external loop is constructed first, then followed by all its internal loops in nested order. If there is more than one external loop, repeat the process. AutoCAD provides limited validation of the hatch boundary in order to maintain API efficiency and performance. 
The internal representations of hatch boundary edges are GELIB 2D geometry, including LineSegment2d, CircularArc2d, EllipticalArc2d and NurbCurve2d. If the hatch boundary consists of a polyline, special methods are provided to construct the loop. 
Associative hatching allows the application to create a hatch entity that is associative to the boundaries of existing AutoCAD database entities, including LINE, ARC, CIRCLE, ELLIPSE, SPLINE, POLYLINE, TEXT, MTEXT, ATTRIBUTE DEFINITION, ATTRIBUTE, SHAPE, SOLID, TRACE, TOLERANCE, REGION, VIEWPORT, 3D FACE, BLOCK INSERT, XREF, LWPOLYLINE, RASTER etc. When you edit the source geometry, the hatch entity will adapt to the changes automatically. 
When using a custom entity, you must define an explode method in order for the hatching to work. Your explode method should break your entity down into less complicated entities. This will cause Hatch to recursively call the explode method on the entities that you return, until the entities have been broken down into native entities. 
When defining a hatch boundary using existing database entities, the application must ensure that the selected objects have a valid hatch boundary and are coplanar with the hatch plane. The selected objects must also form well-defined loops. You also need to set the associativity flag before you set the hatch boundary. InsertLoopAt() and AppendLoop() methods will extract the geometry from database objects and maintain the database object IDs with the loop structure for associative hatch. 
If the hatch boundary contains two or more loops for a solid fill operation, the areas enclosed by the individual loops must be completely disjoint or one will completely enclose the other. Also, each loop must be simple, closed, and continuous, in which it intersects itself only at its endpoints. If the hatch boundary does not meet these requirements, the results may be unpredictable and inconsistent between the regular hatch and the solid fill pattern. 
Mlines are complex entities that can produce more than one loop, which means they will be rejected as hatch boundaries. If you use the Hatch API and select an Mline object to be hatched, no hatching will be displayed. To work around this, you can explode the mline, get the resulting edges, and produce loops from them. If Mline.Explode() produces a set of edges that do not form a single closed loop, you can create a region by using the edges to construct an Region object. You can then explode the region to get simple closed loops, and pass those loops to the Hatch object. 
Currently, AutoCAD supports three hatch pattern types: User-defined, Predefined, and Custom. See the HatchPatternType enum for more information. 
The following methods enable the application to set and get hatch pattern-related data. If you use Hatch.PatternScale (or any of the pattern properties), the scale value changes but the pattern does not change on the display. This is by design. You need to use Hatch.Pattern after changing the pattern scale, angle, name, etc. One call to this function is sufficient for all combinations of pattern changes. 
AutoCAD currently supports three hatch styles: Normal, Outer, and Ignore. See the HatchStyle enum for more information. 
After defining the hatch boundary and specifying the hatch pattern and style, the application must elaborate the hatch lines or solid fill for display. The Hatch class implementation maintains the computed hatch lines and solid fill to support WorldDraw() and ViewportDraw() methods for hatch entity display. However, the computed hatch lines and solid fill are not saved with the drawing or DXF files for file size efficiency. Instead, AutoCAD recomputes the hatch lines or solid fill when a DWG or DXF file is opened by AutoCAD. 
If the hatch boundary definition loops or edges get changed or removed, the application must re-elaborate the hatch lines or solid fill to update the display. 
The hatch boundary definition loops and edges are not displayed. This should not present a problem because the hatch entity is always associative with existing geometry in the AutoCAD database in most cases.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Hatch
```

```text
public class Hatch : Entity;
```

#### Notes
AutoCAD always assumes that the x-axis for an CircularArc2d hatch boundary is an Vector2d of (1.0, 0.0).
### Constructors

- [Hatch](#hatch)

### Methods

- [AppendLoop(HatchLoop)](#appendloop(hatchloop))
- [AppendLoop(HatchLoopTypes, Curve2dCollection, IntegerCollection)](#appendloop(hatchlooptypes,-curve2dcollection,-integercollection))
- [AppendLoop(HatchLoopTypes, ObjectIdCollection)](#appendloop(hatchlooptypes,-objectidcollection))
- [AppendLoop(HatchLoopTypes, Point2dCollection, DoubleCollection)](#appendloop(hatchlooptypes,-point2dcollection,-doublecollection))
- [EvaluateGradientColorAt](#evaluategradientcolorat)
- [EvaluateHatch](#evaluatehatch)
- [GetAssociatedObjectIds](#getassociatedobjectids)
- [GetAssociatedObjectIdsAt](#getassociatedobjectidsat)
- [GetGradientColors](#getgradientcolors)
- [GetHatchLineDataAt](#gethatchlinedataat)
- [GetHatchLinesData](#gethatchlinesdata)
- [GetLoopAt](#getloopat)
- [GetPatternDefinitionAt](#getpatterndefinitionat)
- [InsertLoopAt(int, HatchLoop)](#insertloopat(int,-hatchloop))
- [InsertLoopAt(int, HatchLoopTypes, ObjectIdCollection)](#insertloopat(int,-hatchlooptypes,-objectidcollection))
- [LoopTypeAt](#looptypeat)
- [RemoveAssociatedObjectIds](#removeassociatedobjectids)
- [RemoveLoopAt](#removeloopat)
- [SetGradient](#setgradient)
- [SetGradientColors](#setgradientcolors)
- [SetHatchPattern](#sethatchpattern)

### Properties

- [Area](#area)
- [Associative](#associative)
- [BackgroundColor](#backgroundcolor)
- [Elevation](#elevation)
- [GradientAngle](#gradientangle)
- [GradientName](#gradientname)
- [GradientOneColorMode](#gradientonecolormode)
- [GradientShift](#gradientshift)
- [GradientType](#gradienttype)
- [HatchObjectType](#hatchobjecttype)
- [HatchStyle](#hatchstyle)
- [IsGradient](#isgradient)
- [IsHatch](#ishatch)
- [IsSolidFill](#issolidfill)
- [Normal](#normal)
- [NumberOfHatchLines](#numberofhatchlines)
- [NumberOfLoops](#numberofloops)
- [NumberOfPatternDefinitions](#numberofpatterndefinitions)
- [Origin](#origin)
- [PatternAngle](#patternangle)
- [PatternDouble](#patterndouble)
- [PatternName](#patternname)
- [PatternScale](#patternscale)
- [PatternSpace](#patternspace)
- [PatternType](#patterntype)
- [ShadeTintValue](#shadetintvalue)


## Constructors Details

### Hatch

#### Description
This is the default constructor for the hatch entity.
```text
public Hatch();
```

### AppendLoop(HatchLoop)

#### Description
This function appends a new boundary loop (polyline) to the hatch entity
```text
public void AppendLoop(
    HatchLoop hatchLoop
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| HatchLoop hatchLoop | Input type of loop |

### AppendLoop(HatchLoopTypes, Curve2dCollection, IntegerCollection)

#### Description
It is a wrapper for method AcDbHatch::appendLoop(Adesk::Int32, AcGeVoidPointerArray&amp;, AcGeIntArray&amp;).
```text
public void AppendLoop(
    HatchLoopTypes loopType, 
    Curve2dCollection edgePtrCollection, 
    IntegerCollection edgeTypeCollection
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| HatchLoopTypes loopType | Input loop type. |
| Curve2dCollection edgePtrCollection | Input set of curve 2d. |
| IntegerCollection edgeTypeCollection | Input set of enumerated edge types. |

### AppendLoop(HatchLoopTypes, ObjectIdCollection)

#### Description
This function appends a new boundary loop (path or polyline) to the hatch entity. loopType specifies the type for the loop, which is an enum number of Default or External. dbObjIds is a set of object IDs of Entitys that make up the boundary loop. The object IDs will be maintained if the hatch entity is an associative.
```text
public void AppendLoop(
    HatchLoopTypes loopType, 
    ObjectIdCollection dbObjIds
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| HatchLoopTypes loopType | Input loop type |
| ObjectIdCollection dbObjIds | Input set of object IDs |

### AppendLoop(HatchLoopTypes, Point2dCollection, DoubleCollection)

#### Description
It is a wrapper for method AcDbHatch::appendLoop(Adesk::Int32, AcGePoint2dArray&amp;, AcGeDoubleArray&amp;).
```text
public void AppendLoop(
    HatchLoopTypes loopType, 
    Point2dCollection vertexCollection, 
    DoubleCollection bulgeCollection
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| HatchLoopTypes loopType | Input type of loop. |
| Point2dCollection vertexCollection | Input set of point 2d. |
| DoubleCollection bulgeCollection | Input set of double values. |

### EvaluateGradientColorAt

#### Description
This method provides a way to evaluate the interpolated color that the current gradient definition and colors will produce at a specified location along the gradient. Returns the color of the current gradient evaluated at the location value. The point of evaluation is indicated by the argument value.
```text
public Autodesk.AutoCAD.Colors.Color EvaluateGradientColorAt(
    float value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| float value | Input normalized value, [0.0...1.0], at which to evaluate the gradient color |

### EvaluateHatch

#### Description
This function evaluates the hatch lines or solid fill for the hatch entity using the specified hatch pattern. For regular hatch patterns, except for solid, this function performs intersection calculations between pattern definition lines and hatch boundary curves to form hatch lines. For a solid fill hatch pattern, this function performs triangulation of the hatch area and fills in the triangular meshes with the given color. 
**Note** Be sure to call SetHatchPattern() before using this method in order to update the display. 
```text
public void EvaluateHatch(
    [MarshalAs(UnmanagedType.U1)] bool underEstimateNumLines
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool underEstimateNumLines | If true, underestimates the count before deciding to abort. That is, if Hatch::EvaluateHatch(true) is used, the function will abort if the count is in excess of 100,000. |

### GetAssociatedObjectIds

#### Description
This function gets all the object IDs of the source boundary geometries associative to the hatch entity.
```text
public ObjectIdCollection GetAssociatedObjectIds();
```

### GetAssociatedObjectIdsAt

#### Description
This function gets the object IDs of the source boundary geometries associative to the selected loop.
```text
public ObjectIdCollection GetAssociatedObjectIdsAt(
    int loopIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int loopIndex | Input index for the selected loop |

### GetGradientColors

#### Description
This method returns the colors and interpolation values describing how the gradient fill definition will be applied.
```text
public GradientColor\[\] GetGradientColors();
```

### GetHatchLineDataAt

#### Description
This function gets the hatch line data from the hatch entity.
```text
public Line2d GetHatchLineDataAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input number at which the hatch line data will be returned |

### GetHatchLinesData

#### Description
void Hatch.GetHatchLineDataAt(int index, Point2d* startPoint, Point2d* endPoint) { *startPoint = new Point2d(); *endPoint = new Point2d(); Interop.Check(GetImpObj()->getHatchLineDataAt(index,*(*startPoint)->GetImpObj(),*(*endPoint)->GetImpObj())); 
} void Hatch.GetHatchLinesData(Point2dCollection** startPoint, Point2dCollection** endPoint) { *startPoint = new Point2dCollection(); *endPoint = new Point2dCollection(); Interop.Check(GetImpObj()->getHatchLinesData(*(*startPoint)->GetImpObj(),*(*endPoint)->GetImpObj()));
```text
public Line2dCollection GetHatchLinesData();
```

### GetLoopAt

#### Description
This function gets the loop definition data (polyline) of a selected hatch boundary loop from the hatch entity. loopIndex specifies the index of the selected loop. 
An empty bulges set may be returned if the polyline loop contains all line segments only.
```text
public HatchLoop GetLoopAt(
    int loopIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int loopIndex | Input index of selected loop |

### GetPatternDefinitionAt

#### Description
This function gets the pattern definition line data from the hatch entity at the selected pattern line.
```text
public PatternDefinition GetPatternDefinitionAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input pattern index |

### InsertLoopAt(int, HatchLoop)

#### Description
This function inserts a new boundary loop (path or polyline) to the hatch entity. loopIndex specifies the index at which the loop will be inserted into the hatch boundary loop list. hatchLoop specifies the type for the loop.
```text
public void InsertLoopAt(
    int loopIndex, 
    HatchLoop hatchLoop
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int loopIndex | Input index for the selected loop |
| HatchLoop hatchLoop | Input loop type |

### InsertLoopAt(int, HatchLoopTypes, ObjectIdCollection)

#### Description
This function inserts a new boundary loop (path or polyline) to the hatch entity. loopIndex specifies the index at which the loop will be inserted into the hatch boundary loop list. loopType specifies the type for the loop. dbObjIds is a set of object IDs of Entities that make up the boundary loop. The object IDs will be maintained if the hatch entity is associative.
```text
public void InsertLoopAt(
    int loopIndex, 
    HatchLoopTypes loopType, 
    ObjectIdCollection dbObjIds
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int loopIndex | Input index for the selected loop |
| HatchLoopTypes loopType | Input loop type |
| ObjectIdCollection dbObjIds | Input set of object IDs |

### LoopTypeAt

#### Description
This function returns the loop type of a selected hatch boundary loop from the hatch entity
```text
public HatchLoopTypes LoopTypeAt(
    int loopIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int loopIndex | Input index of the selected loop |

### RemoveAssociatedObjectIds

#### Description
This function removes all the object IDs of the source boundary geometries associative to the hatch entity.
```text
public void RemoveAssociatedObjectIds();
```

### RemoveLoopAt

#### Description
This function removes a loop and its data from the hatch entity.
```text
public void RemoveLoopAt(
    int loopIndex
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int loopIndex | Input index for the selected loop |

### SetGradient

#### Description
This method provides the mechanism for specifying the shape definition of the gradient fill.
```text
public void SetGradient(
    Autodesk.AutoCAD.DatabaseServices.GradientPatternType gradientType, 
    string gradientName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.GradientPatternType gradientType | Input gradient type |
| string gradientName | Input name of the gradient to apply |

### SetGradientColors

#### Description
This method provides the mechanism for defining the colors to be applied to the gradient definition. In the simplest case, the color definition consists of the starting and ending color. The start color maps to colors[0] and the stop color maps to colors[count-1]. The current implementation supports only a count value of 2. The Hatch object makes a copy of the arrays provided as arguments.
```text
public void SetGradientColors(
    GradientColor\[\] value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| GradientColor[] value | Input array of floats representing the interpolation values defining the gradient |

### SetHatchPattern

#### Description
This function sets both pattern type and pattern name for hatch entity. patternType specifies an enumerated number of either UserDefined, PreDefined, or CustomDefined. patternName is the name of the pattern, which may be set to NULL for UserDefined pattern type. 
For the UserDefined pattern type, you may need to use SetPatternAngle(angle), SetPatternSpace(space), and SetPatternDouble(double) to define pattern data before you call this function. 
For the PreDefined pattern type, this function will read in pattern data from the AutoCAD standard hatch pattern file _acad.pat_ and maintain it with the hatch entity. 
For the CustomDefined pattern type, you must supply your own PAT file, where the name of the hatch pattern must match the name of the file. For instance, you must store the TEST hatch pattern in a file named _test.pat_ , and the file must be located in the ACAD search path. 
When you use a pre-defined or custom-defined pattern, you can also specify a scale and angle in order to modify the hatch's appearance. 
**Note** Be sure to call SetPattern() before calling Hatch.EvaluateHatch. 
```text
public void SetHatchPattern(
    Autodesk.AutoCAD.DatabaseServices.HatchPatternType patternType, 
    string patternName
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.HatchPatternType patternType | Input enumerated number of pattern type |
| string patternName | Input name of the pattern |

### Area

#### Description
Accesses the area of the hatch entity.
```text
public double Area;
```

#### Conditions
Read-only
### Associative

#### Description
Accesses true or false depending on whether this hatch entity is associative with its source boundary geometries. The source boundary geometries must be AutoCAD database-resident entities such as Line, Arc, etc. Using an associative hatch provides automatic re-calculation of the hatch lines when you modify the source boundary geometries.
```text
public bool Associative;
```

#### Conditions
Read / Write
### BackgroundColor

#### Description
Gets and sets the background color information for the hatch entity within an instance of Color
```text
public Autodesk.AutoCAD.Colors.Color BackgroundColor;
```

#### Conditions
Read / write
### Elevation

#### Description
Accesses the elevation for the hatch entity. Elevation defines the distance from the WCS origin to the hatch plane.
```text
public double Elevation;
```

#### Conditions
Read / Write
### GradientAngle

#### Description
Accesses the angle, in radians, at which the current gradient definition is applied.
```text
public double GradientAngle;
```

#### Conditions
Read / Write
### GradientName

#### Description
Accesses the name of the current gradient.
```text
public string GradientName;
```

#### Conditions
Read / Write
### GradientOneColorMode

#### Description
Assesses whether the gradient hatch is transitioning from a start to a stop color (two-color) or from a color to an adjusted luminance version of the same color (one-color). In the latter case, the full luminance version is the "tint" and the zero luminance version is the "shade."
```text
public bool GradientOneColorMode;
```

#### Conditions
Read / Write
### GradientShift

#### Description
Accesses the current interpolation value between the gradient definition's default and shifted values.
```text
public float GradientShift;
```

#### Conditions
Read / Write
### GradientType

#### Description
Accesses an enumerator specifying the type of the gradient pattern.
```text
public Autodesk.AutoCAD.DatabaseServices.GradientPatternType GradientType;
```

#### Conditions
Read-only
### HatchObjectType

#### Description
Accesses the current state of the gradient object.
```text
public Autodesk.AutoCAD.DatabaseServices.HatchObjectType HatchObjectType;
```

#### Conditions
Read / Write
### HatchStyle

#### Description
Accesses the hatch style of the hatch entity.
```text
public Autodesk.AutoCAD.DatabaseServices.HatchStyle HatchStyle;
```

#### Conditions
Read / Write
### IsGradient

#### Description
Assesses if the Hatch object is a gradient
```text
public virtual bool IsGradient;
```

#### Conditions
Read-only
### IsHatch

#### Description
Assesses if the Hatch object is a hatched pattern as opposed to a solid or gradient fill pattern.
```text
public virtual bool IsHatch;
```

#### Conditions
Read-only
### IsSolidFill

#### Description
Assesses if the hatch object is configured for solid fill.
```text
public bool IsSolidFill;
```

#### Conditions
Read-only
### Normal

#### Description
Accesses the normal vector of the hatch entity. The normal vector is expressed in WCS and normalized to unit length.
```text
public Vector3d Normal;
```

#### Conditions
Read / Write
### NumberOfHatchLines

#### Description
Accesses the total number of hatch lines contained in the hatch entity. The hatch lines are calculated by the function EvaluateHatch(). 
It returns 0 if the hatch pattern is SOLID.
```text
public int NumberOfHatchLines;
```

#### Conditions
Read-only
### NumberOfLoops

#### Description
Accesses the total number of boundary loops contained in the hatch entity. Boundary loops define the area to be hatched.
```text
public int NumberOfLoops;
```

#### Conditions
Read-only
### NumberOfPatternDefinitions

#### Description
Accesses the total number of pattern definition lines contained in the pattern of the hatch entity.
```text
public int NumberOfPatternDefinitions;
```

#### Conditions
Read-only
### Origin

#### Description
Accesses the origin point for the hatch pattern of this hatch entity. The returned point is expressed in WCS coordinates.
```text
public Point2d Origin;
```

#### Conditions
Read / Write
### PatternAngle

#### Description
Accesses the pattern angle (in radians) of the hatch entity.
```text
public double PatternAngle;
```

#### Conditions
Read / Write
### PatternDouble

#### Description
Accesses the value of double pattern flag for the hatch entity.
```text
public bool PatternDouble;
```

#### Conditions
Read / Write
### PatternName

#### Description
Accesses the pattern name of the hatch entity.
```text
public string PatternName;
```

#### Conditions
Read-only
### PatternScale

#### Description
Accesses the pattern scale of the hatch entity.
```text
public double PatternScale;
```

#### Conditions
Read / Write
### PatternSpace

#### Description
Accesses the pattern space of the hatch entity.
```text
public double PatternSpace;
```

#### Conditions
Read / Write
### PatternType

#### Description
Accesses an enumerated pattern type of either UserDefined, PreDefined, or CustomDefined for the hatch entity.
```text
public Autodesk.AutoCAD.DatabaseServices.HatchPatternType PatternType;
```

#### Conditions
Read-only
### ShadeTintValue

#### Description
Accesses the one-color tint shade (luminance) value.
```text
public float ShadeTintValue;
```

#### Conditions
Read / Write