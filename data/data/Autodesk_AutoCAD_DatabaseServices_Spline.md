# Spline Class

## Overview

#### Description
This class implements the AutoCAD SPLINE entity. 
Objects of the Spline class use an embedded gelib object to maintain the actual spline information. The spline itself may either be a simple curve fit (within a specified tolerance which may be 0) through a set of "fit points," or it may be a NURBS spline (that is, a set of control points, knots, and weights used to define the spline path). Internally, a curve-fit spline still has NURBS data; however the reverse is not true. 
The following books are a good place to start to get a basic understanding of spline curves: 
  * _Curves and Surfaces for CAGD_ by Gerald Farin
  * _Mathematical Elements for Computer Graphics_ by David Rogers and Alan Adams
  * _An Introduction To Splines For Use In Computer Graphics & Geometric Modeling_ by Richard H. Bartels, John C. Beatty, and Brian A Barsky

Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Spline
                Autodesk.AutoCAD.DatabaseServices.Helix
```

```text
public class Spline : Curve;
```

#### Notes
The Spline class provides functions to query and set a curve-fit spline and a set of functions to query and set a NURBS spline. It is not recommended that the curve fit functions be called on a NURBS spline or that the NURBS functions be called on a curve fit spline. Invalid data, or worse, may result. The Spline.hasFitData() method can be used to determine which type of spline is in hand. 
Creating a NURBS spline with a sequential series of identical control points results in an unusable spline due to continuity problems.
### Constructors

- [Spline()](#spline())
- [Spline(int, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, Point3dCollection, DoubleCollection, DoubleCollection, double, double)](#spline(int,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool,-point3dcollection,-doublecollection,-doublecollection,-double,-double))
- [Spline(Point3d, Vector3d, Vector3d, double, double, double)](#spline(point3d,-vector3d,-vector3d,-double,-double,-double))
- [Spline(Point3dCollection, [MarshalAs(UnmanagedType.U1)] bool, KnotParameterizationEnum, int, double)](#spline(point3dcollection,-[marshalas(unmanagedtype.u1)]-bool,-knotparameterizationenum,-int,-double))
- [Spline(Point3dCollection, int, double)](#spline(point3dcollection,-int,-double))
- [Spline(Point3dCollection, KnotParameterizationEnum, int, double)](#spline(point3dcollection,-knotparameterizationenum,-int,-double))
- [Spline(Point3dCollection, Vector3d, Vector3d, int, double)](#spline(point3dcollection,-vector3d,-vector3d,-int,-double))
- [Spline(Point3dCollection, Vector3d, Vector3d, KnotParameterizationEnum, int, double)](#spline(point3dcollection,-vector3d,-vector3d,-knotparameterizationenum,-int,-double))

### Methods

- [ElevateDegree](#elevatedegree)
- [GetControlPointAt](#getcontrolpointat)
- [GetFitPointAt](#getfitpointat)
- [InsertControlPointAt](#insertcontrolpointat)
- [InsertFitPointAt](#insertfitpointat)
- [InsertKnot](#insertknot)
- [ModifyPositionAndTangent](#modifypositionandtangent)
- [PurgeFitData](#purgefitdata)
- [Rebuild](#rebuild)
- [RemoveControlPointAt](#removecontrolpointat)
- [RemoveFitPointAt](#removefitpointat)
- [SetControlPointAt](#setcontrolpointat)
- [SetFitPointAt](#setfitpointat)
- [SetWeightAt](#setweightat)
- [ToPolyline()](#topolyline())
- [ToPolyline([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#topolyline([marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [ToPolyline(uint)](#topolyline(uint))
- [ToPolyline(uint, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#topolyline(uint,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [ToPolylineWithPrecision(int)](#topolylinewithprecision(int))
- [ToPolylineWithPrecision(int, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#topolylinewithprecision(int,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [UpdateFitData](#updatefitdata)
- [WeightAt](#weightat)

### Properties

- [Degree](#degree)
- [EndFitTangent](#endfittangent)
- [FitData](#fitdata)
- [FitTolerance](#fittolerance)
- [HasFitData](#hasfitdata)
- [IsNull](#isnull)
- [IsPlanar](#isplanar)
- [IsRational](#isrational)
- [NumControlPoints](#numcontrolpoints)
- [NumFitPoints](#numfitpoints)
- [NurbsData](#nurbsdata)
- [StartFitTangent](#startfittangent)
- [Type](#type)


## Constructors Details

### Spline()

#### Description
Default constructor. Initializes to line segment between (0,0,0) and (1,0,0).
```text
public Spline();
```

### Spline(int, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool, Point3dCollection, DoubleCollection, DoubleCollection, double, double)

#### Description
Creates a spline using the parameters passed in. 
If the spline is to be rational, then isRational should be true. 
If the spline is to be closed (that is, a closed loop), then isClosed should be true. 
If the spline is to be periodic, then isPeriodic should be true. This parameter should only be set to true if the spline is closed. A periodic spline is a spline with period T such that the point at parameter value t + T is the same as the point at parameter t for any value of t. 
The weights array is only used when isRational == true. If used, it must have the same number of entries as the controlPoints collection. All weight values must be greater than 0.0. 
If periodic = false, then the length of the knot vector must be greater than length of the control array by degree+1. 
If periodic = true, then the length of knot vector must be greater than the length of the control array by 1. The first and the last control points must NOT be identical. 
The knotTolerance value is used to determine which knot values are to be treated as the same. If the difference between two knot values is less than knotTolerance, then the two values will be treated as the same (and the first of the two values will be used for both). 
The controlPointTolerance value is used to determine if two control points are to be treated as the same point. If the distance (in drawing units) between two control points is less than controlPointTolerance, then those two control points will be treated as the same point. If the first and last control points are within controlPointTolerance of each other, the spline will be closed regardless of the isClosed value. 
If any of the parameters are not acceptable, then the gelib object for the spline is not created and this constructor behaves like the default constructor (that is, the passed in values will not be used and the data query methods on the spline returns invalid values). 
Use Spline.IsNull to determine if this constructor succeeded in initializing the spline to the values passed in. If Spline.IsNull returns false, then the initialization succeeded.
```text
public Spline(
    int degree, 
    [MarshalAs(UnmanagedType.U1)] bool rational, 
    [MarshalAs(UnmanagedType.U1)] bool closed, 
    [MarshalAs(UnmanagedType.U1)] bool periodic, 
    Point3dCollection controlPoints, 
    DoubleCollection knots, 
    DoubleCollection weights, 
    double controlPointTolerance, 
    double knotTolerance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int degree | Specifies degree of spline |
| [MarshalAs(UnmanagedType.U1)] bool rational | True if the spline is rational |
| [MarshalAs(UnmanagedType.U1)] bool closed | True if the spline is closed |
| [MarshalAs(UnmanagedType.U1)] bool periodic | True if the spline is periodic |
| Point3dCollection controlPoints | Specifies collection of control points (in WCS coordinates) of the spline |
| DoubleCollection knots | Collection of doubles that specifies the knot values of the spline |
| DoubleCollection weights | Collection of doubles that specifies the weights at each control point |
| double controlPointTolerance | Specifies control points tolerance of spline |
| double knotTolerance | Specifies knot value tolerance of spline |

### Spline(Point3d, Vector3d, Vector3d, double, double, double)

#### Description
This constructor creates a spline initialized to be an elliptical arc. 
The center, unitNormal, and majorAxis are used to calculate the start point. majorAxis is the vector from the ellipse center point to the ellipse start point (or, half the major axis length). This vector is the zero angle for startAngle and endAngle. Positive angles are counterclockwise when looking down the normal vector (that is, right hand rule). 
radiusRatio must be in the range 1e-6 to 1.0. 
The dot product of normal with itself and majorAxis with itself must be greater than 1e-12. 
majorAxis must perpendicular to normal within 1e-6. 
The difference between startAngle and endAngle must be greater than 1e-6. 
If any of the parameters are not acceptable, then the gelib object for the spline is not created and this constructor behaves like the default constructor (that is, the passed in values are not used and the data query methods on the spline return invalid values). 
Use Spline.IsNull to determine if this constructor succeeded in initializing the spline to the values passed in. If Spline.IsNull returns false, then the initialization succeeded.
```text
public Spline(
    Point3d center, 
    Vector3d unitNormal, 
    Vector3d majorAxis, 
    double radiusRatio, 
    double startAngle, 
    double endAngle
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3d center | Center point (in WCS coordinates) of the elliptical arc |
| Vector3d unitNormal | Vector (in WCS coordinates) representing the normal to the elliptical arc |
| Vector3d majorAxis | Major axis vector (in WCS coordinates) of the elliptical arc, measured from the ellipse center point to the ellipse start point |
| double radiusRatio | Ratio of minor or major axis length |
| double startAngle | Angle (in radians) of start point of elliptical arc |
| double endAngle | Angle (in radians) of end point of elliptical arc |

### Spline(Point3dCollection, [MarshalAs(UnmanagedType.U1)] bool, KnotParameterizationEnum, int, double)

#### Description
Creates a spline that attempts to fit a curve to the array of points within the tolerance fitTolerance. 
A fitTolerance of 0 causes the curve to be interpolated precisely through all the points in the points array. The curve degree may be in the range 1 to 11. 
The periodic specifies whether to create a periodic spline fitting the array of points or not. 
The knotParam specifies the way that the knots are created. The different knot sequence has impact on the curve shape. AutoCAD provides three options : Chord, SqrtChord and Uniform. Uniform is the default value. If any of the parameters are not acceptable, then the gelib object for the spline is not created and this constructor behaves like the default constructor (that is, the passed in values are not used and the data query methods on the spline return invalid values). 
Use Spline.IsNull to determine if this constructor succeeded in initializing the spline to the values passed in. If Spline.IsNull returns false, then the initialization succeeded. 
```text
public Spline(
    Point3dCollection fitPoints, 
    [MarshalAs(UnmanagedType.U1)] bool isPeriodic, 
    KnotParameterizationEnum knotParam, 
    int degree, 
    double fitTolerance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3dCollection fitPoints | Array of points (in WCS coordinates) through which to fit the curve. |
| [MarshalAs(UnmanagedType.U1)] bool isPeriodic | Indicate whether or not a periodic spline fitting the array of points is created. |
| KnotParameterizationEnum knotParam | Knot parameterization defining the knot values . |
| int degree | Degree of the spline to be created (in the range 1 to 11) |
| double fitTolerance | Tolerance to which the spline should approximate fitPoints. |

#### See Also
Autodesk.AutoCAD.Geometry.KnotParameterizationEnum

### Spline(Point3dCollection, int, double)

#### Description
Creates a spline that attempts to fit an order degree curve to the array of points within the tolerance fitTolerance. A fitTolerance of 0 causes the curve to be interpolated precisely through all the points in the points array. The curve order may be in the range 2 to 26. 
The curve end tangent directions are allowed to "float" to whatever value allows for the best curve fit of the points in the points array. 
If any of the parameters are not acceptable, then the gelib object for the spline is not created and this constructor behaves like the default constructor (that is, the passed in values are not used and the data query methods on the spline return invalid values). 
Use Spline.IsNull to determine if this constructor succeeded in initializing the spline to the values passed in. If Spline.IsNull returns false, then the initialization succeeded.
```text
public Spline(
    Point3dCollection point, 
    int order, 
    double fitTolerance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3dCollection point | Array of points (in WCS coordinates) through which to fit the curve |
| int order | Order of the spline to be created (in the range 2 to 26) |
| double fitTolerance | Tolerance to which the spline should approximate fitPoints |

### Spline(Point3dCollection, KnotParameterizationEnum, int, double)

#### Description
This wraps [AcDbSpline::AcDbSpline](AcDbSpline__AcDbSpline@AcGePoint3dArray_@AcGe__KnotParameterization@int@double.md)() method
```text
public Spline(
    Point3dCollection fitPoints, 
    KnotParameterizationEnum knotParam, 
    int degree, 
    double fitTolerance
);
```

### Spline(Point3dCollection, Vector3d, Vector3d, int, double)

#### Description
Creates a spline that attempts to fit an order degree curve to the array of points within the tolerance fitTolerance. A fitTolerance of 0 will cause the curve to be interpolated precisely through all the points in the points array. The curve order may be in the range 2 to 26. 
The curve uses the startTangent vector as the tangent at the first point of the spline and the endTangent vector as the tangent at the end point of the spline. 
If any of the parameters are not acceptable, then the gelib object for the spline is not created and this constructor behaves like the default constructor (that is, the passed in values are not used and the data query methods on the spline return invalid values). 
Use Spline.IsNull to determine if this constructor succeeded in initializing the spline to the values passed in. If Spline.IsNull returns false, then the initialization succeeded.
```text
public Spline(
    Point3dCollection point, 
    Vector3d startTangent, 
    Vector3d endTangent, 
    int order, 
    double fitTolerance
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Point3dCollection point | Array of points (in WCS coordinates) through which to fit the curve |
| Vector3d startTangent | Specifies the tangent at the start of the curve |
| Vector3d endTangent | Specifies the tangent at the end of the curve |
| int order | Order of the spline to be created (in the range 2 to 26) |
| double fitTolerance | Tolerance to which the spline should approximate fitPoints |

### Spline(Point3dCollection, Vector3d, Vector3d, KnotParameterizationEnum, int, double)

#### Description
This wraps [AcDbSpline::AcDbSpline](AcDbSpline__AcDbSpline@AcGePoint3dArray_@AcGeVector3d_@AcGeVector3d_@AcGe__KnotParameterization@int@double.md)() method
```text
public Spline(
    Point3dCollection fitPoints, 
    Vector3d startTangent, 
    Vector3d endTangent, 
    KnotParameterizationEnum knotParam, 
    int degree, 
    double fitTolerance
);
```

### ElevateDegree

#### Description
Increases the degree (which is the same as the order -1) of the spline to _newDegree_. Once incremented it cannot be decremented. The valid range is between (current degree) and 25.
```text
public void ElevateDegree(
    int newDegree
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int newDegree | Input new spline degree value (in the range (existing degree) to 25) |

#### Remarks
The spline's order is the degree + 1. 
Elevating degree won't change the shape. When the spline is periodic, elevating degree will make it non-periodic.
### GetControlPointAt

#### Description
Returns the value of the control point at position index in the list of control points. If index is negative or more than the number of control points in the spline, then point at index is set to the last control point.
```text
public Point3d GetControlPointAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of point to get |

### GetFitPointAt

#### Description
Returns the value of the fit point at position index.
```text
public Point3d GetFitPointAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) value |

### InsertControlPointAt

#### Description
This wraps the ObjectARX [AcDbSpline::insertControlPointAt](AcDbSpline__insertControlPointAt@double@AcGePoint3d_@double.md)() method
```text
public Autodesk.AutoCAD.Runtime.ErrorStatus InsertControlPointAt(
    double knotParam, 
    Point3d controlPoint, 
    double weight
);
```

### InsertFitPointAt

#### Description
Adds point to the list of fit points and refits the spline. point is added at the index position in the fit points list. If index is negative, then point is added at the beginning of the spline. If index is greater than the number of fit points in the spline, then point is added at the end of the spline.
```text
public void InsertFitPointAt(
    int index, 
    Point3d point
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) where new fit point is to be inserted |
| Point3d point | Input new fit point (in WCS coordinates) |

### InsertKnot

#### Description
Inserts a new knot into the spline at the location on the spline defined by value. The value must be within the spline's parameter range. 
To obtain the spline's parameter range, use the Spline.NurbsData property to obtain a collection of the current knot values. The first knot value is the spline's start parameter value, while the last knot is the spline's end parameter.
```text
public void InsertKnot(
    double value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double value | Input parameter where knot is to be added |

### ModifyPositionAndTangent

#### Description
Adjusts the location and tangent of a point on the spline curve with the given parameter. The local control points are adjusted accordingly. If _deriv_ is null, only the location of the point is adjusted.
```text
public Autodesk.AutoCAD.Runtime.ErrorStatus ModifyPositionAndTangent(
    double param, 
    Point3d point, 
    Vector3d deriv
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| double param | Parameter |
| Point3d point | Specify the new location of the point on the spline curve |
| Vector3d deriv | Specify the tangent vector |

### PurgeFitData

#### Description
Purges the fit data if the spline is a fitted spline. Once the fit data has been removed, the spline uses its control point or NURBS data.
```text
public void PurgeFitData();
```

#### Notes
In ARX SDK versions 1.0 and 1.1, calling this function on a spline with no fit data triggers an assert in non production versions of AutoCAD. This assert can be safely ignored.
### Rebuild

#### Description
This wraps the ObjectARX [AcDbSpline::rebuild](AcDbSpline__rebuild@int@int.md)() method
```text
public Autodesk.AutoCAD.Runtime.ErrorStatus Rebuild(
    int degree, 
    int numCtrlPts
);
```

### RemoveControlPointAt

#### Description
This wraps the ObjectARX [AcDbSpline::removeControlPointAt](AcDbSpline__removeControlPointAt@int.md)() method
```text
public Autodesk.AutoCAD.Runtime.ErrorStatus RemoveControlPointAt(
    int index
);
```

### RemoveFitPointAt

#### Description
Removes the fit point at index in the list of fit points of the spline and refits the spline. There must be at least three fit points in the spline for this function to succeed.
```text
public void RemoveFitPointAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Index (0 based) of fit point to be removed |

### SetControlPointAt

#### Description
Sets point (in WCS coordinates) to be the control point at the index position in the control points list replacing the point value that was previously at index position.
```text
public void SetControlPointAt(
    int index, 
    Point3d point
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of control point to replace |
| Point3d point | Input new control point (in WCS coordinates) |

### SetFitPointAt

#### Description
Sets point (in WCS coordinates) to be the fit point at the index position in the fit points list (replacing the point value previously at index) and then refits the spline.
```text
public void SetFitPointAt(
    int index, 
    Point3d point
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of fit point to replace |
| Point3d point | Input new fit point (in WCS coordinates) |

### SetWeightAt

#### Description
Changes the weight of the point at the index location in the control points array to weight. If the spline is not a rational spline, then it is converted to a rational spline.
```text
public void SetWeightAt(
    int index, 
    double weight
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of control point at which to change the weight |
| double weight | Input new weight value |

### ToPolyline()

#### Description
Generates a polyline to approximate a spline.
```text
public Curve ToPolyline();
```

#### Returns
The resulting polyline.
#### Remarks
The resulting curve could be an AcDbPolyline, an AcDb2dPolyline, or an AcDb3dPolyline. It depends on the system variable PLINETYPE and the spline itself. An AcDb3dPolyline will always have line segments. Otherwise, the resulting polyline has line segments when the system varaible PLINECONVERTMODE is 0, and has arc segments when PLINECONVERTMODE is 1.
### ToPolyline([MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This .NET method wraps the ObjectARX method
```text
public Curve ToPolyline(
    [MarshalAs(UnmanagedType.U1)] bool bConvertAsArcs, 
    [MarshalAs(UnmanagedType.U1)] bool bToLWPolyline
);
```

### ToPolyline(uint)

#### Description
Generates a polyline to approximate a spline.
```text
public Curve ToPolyline(
    uint numOfVertices
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| uint numOfVertices | Target number of vertices. The resulting polyline will have vertices no more than this value. |

#### Returns
The resulting polyline.
#### Remarks
The resulting curve could be an AcDbPolyline, an AcDb2dPolyline, or an AcDb3dPolyline. It depends on the system variable PLINETYPE and the spline itself. An AcDb3dPolyline will always have line segments. Otherwise, the resulting polyline has line segments when the system variable PLINECONVERTMODE is 0, and has arc segments when PLINECONVERTMODE is 1. 
More polyline vertices make a more accurate apporximation, but too many vertices reduces the display performance of the polyline. 
numOfVertices must be no smaller than the number of spline fit points.
### ToPolyline(uint, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This .NET method wraps the ObjectARX method. 
Generates a polyline to approximate a spline without using PLINETYPE and PLINECONVERTMODE. The resulting curve could be an Polyline or an 3dPolyline. If the spline is not planar, then the result will always be an AcDb3dPolyline and will always have line segments. If the spline is planar, then if bConvertAsArcs is truen, the resulting polyline will be arc segments, otherwise it will be line segments. And, if the spline is planar and bToLWPolyline is true, then the result will be an AcDbPolyline, otherwise it will be an AcDb2dPolyline.
```text
public Curve ToPolyline(
    uint numOfVertices, 
    [MarshalAs(UnmanagedType.U1)] bool bConvertAsArcs, 
    [MarshalAs(UnmanagedType.U1)] bool bToLWPolyline
);
```

### ToPolylineWithPrecision(int)

#### Description
Generates a polyline to approximate a spline.
```text
public Curve ToPolylineWithPrecision(
    int precision
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int precision | Target precision |

#### Returns
The resulting polyline
#### Remarks
The resulting curve could be an AcDbPolyline, an AcDb2dPolyline, or an AcDb3dPolyline. It depends on the system variable PLINETYPE and the spline itself. An AcDb3dPolyline will always have line segments. Otherwise, the resulting polyline has line segments when the system varible PLINECONVERTMODE is 0, and has arc segments when PLINECONVERTMODE is 1. 
The target precision is expected to be between 0 to 99, but larger values are also acceptable. The default value used in AutoCAD is 10. If the precision is unnecessarily high, the resulting polyline could have too many vertices, thus significantly degrading display performance.
### ToPolylineWithPrecision(int, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This .NET method wraps the ObjectARX method. 
Generates a polyline to approximate a spline without using PLINETYPE and PLINECONVERTMODE. The resulting curve could be an AcDbPolyline, an AcDb2dPolyline, or an AcDb3dPolyline. If the spline is not planar, then the result will always be an AcDb3dPolyline and will always have line segments. If the spline is planar, then if bConvertAsArcs is truen, the resulting polyline will be arc segments, otherwise it will be line segments. And, if the spline is planar and bToLWPolyline is true, then the result will be an AcDbPolyline, otherwise it will be an AcDb2dPolyline.
```text
public Curve ToPolylineWithPrecision(
    int precision, 
    [MarshalAs(UnmanagedType.U1)] bool bConvertAsArcs, 
    [MarshalAs(UnmanagedType.U1)] bool bToLWPolyline
);
```

### UpdateFitData

#### Description
Updates the fit data of the spline. If the spline's fit tolerance == 0, then the spline is refitted; otherwise the fit data is purged (in which case the control point or NURBS data will be used by the spline).
```text
public void UpdateFitData();
```

### WeightAt

#### Description
Returns the weight of the control point at index. 
Weights can only exist for rational splines, so if the spline is not rational, -1 is returned. 
If index is negative or greater than the number of control points, then 1 is returned.
```text
public double WeightAt(
    int index
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| int index | Input index (0 based) of control point |

### Degree

#### Description
Returns the degree of the spline's polynomial representation. The value is in the range 1 to 25.
```text
public int Degree;
```

#### Conditions
Read-only
### EndFitTangent

#### Description
Returns the start point and end point tangent vectors in WCS coordinates.
```text
public Vector3d EndFitTangent;
```

#### Conditions
Read-only
### FitData

#### Description
Returns all the fit points (in WCS coordinates), fit tolerance, and, if tangents exist, the start and end tangents of the spline.
```text
public Autodesk.AutoCAD.DatabaseServices.FitData FitData;
```

#### Conditions
Read / Write
### FitTolerance

#### Description
Returns the tolerance value used for curve fitting. This is the maximum distance (in drawing units) that the spline curve is allowed to deviate from the fit points.
```text
public double FitTolerance;
```

#### Conditions
Read / Write
### HasFitData

#### Description
Returns true if and only if the spline has fit data associated with it.
```text
public bool HasFitData;
```

#### Conditions
Read-only
### IsNull

#### Description
Returns true if this Spline object does not have an gelib object within it.
```text
public bool IsNull;
```

#### Conditions
Read-only
### IsPlanar

#### Description
Returns true if the object lies completely within a plane.
```text
public override bool IsPlanar;
```

#### Conditions
Read-only
### IsRational

#### Description
Returns true if and only if the spline is rational.
```text
public bool IsRational;
```

#### Conditions
Read-only
### NumControlPoints

#### Description
Returns the number of control points in the spline.
```text
public int NumControlPoints;
```

#### Conditions
Read-only
### NumFitPoints

#### Description
Returns the number of fit points associated with the spline. 
**Warning** Do not call this function unless the spline has fit data (that is, Spline.hasFitData() is true). 
```text
public int NumFitPoints;
```

#### Conditions
Read-only
### NurbsData

#### Description
Replaces any existing spline data with the data passed in via NurbsData parameters.
```text
public Autodesk.AutoCAD.DatabaseServices.NurbsData NurbsData;
```

#### Conditions
Read / Write
### StartFitTangent

#### Description
Returns the start point of tangent vector in WCS coordinates.
```text
public Vector3d StartFitTangent;
```

#### Conditions
Read-only
### Type

#### Description
This wraps [AcDbSpline::type](AcDbSpline__type.md)() and [AcDbSpline::setType](AcDbSpline__setType@SplineType.md)() methods.
```text
public Autodesk.AutoCAD.DatabaseServices.SplineType Type;
```
