# Curve Class

## Overview

#### Description
This .NET class wraps the AcDbCurve ObjectARX class. 
The Curve class is the base class for all the entity classes that are variations of a curve such as Arc, Circle, Ellipse, Spline, and others. This base class provides the common functionality such as finding parameters for a point on the curve, finding offset curves, finding projections of the curve onto a plane, and so on.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.Entity
        Autodesk.AutoCAD.DatabaseServices.Curve
            Autodesk.AutoCAD.DatabaseServices.Arc
            Autodesk.AutoCAD.DatabaseServices.Circle
            Autodesk.AutoCAD.DatabaseServices.Ellipse
            Autodesk.AutoCAD.DatabaseServices.Leader
            Autodesk.AutoCAD.DatabaseServices.Line
            Autodesk.AutoCAD.DatabaseServices.Polyline
            Autodesk.AutoCAD.DatabaseServices.Polyline2d
            Autodesk.AutoCAD.DatabaseServices.Polyline3d
            Autodesk.AutoCAD.DatabaseServices.Ray
            Autodesk.AutoCAD.DatabaseServices.Spline
            Autodesk.AutoCAD.DatabaseServices.Xline
```

```text
public abstract class Curve : Entity;
```

#### See Also
DBObject

## Members

### Methods

- [CreateFromGeCurve(Curve3d)](#createfromgecurve(curve3d))
- [CreateFromGeCurve(Curve3d, Tolerance)](#createfromgecurve(curve3d,-tolerance))
- [CreateFromGeCurve(Curve3d, Vector3d)](#createfromgecurve(curve3d,-vector3d))
- [CreateFromGeCurve(Curve3d, Vector3d, Tolerance)](#createfromgecurve(curve3d,-vector3d,-tolerance))
- [Extend([MarshalAs(UnmanagedType.U1)] bool, Point3d)](#extend([marshalas(unmanagedtype.u1)]-bool,-point3d))
- [Extend(double)](#extend(double))
- [GetClosestPointTo(Point3d, [MarshalAs(UnmanagedType.U1)] bool)](#getclosestpointto(point3d,-[marshalas(unmanagedtype.u1)]-bool))
- [GetClosestPointTo(Point3d, Vector3d, [MarshalAs(UnmanagedType.U1)] bool)](#getclosestpointto(point3d,-vector3d,-[marshalas(unmanagedtype.u1)]-bool))
- [GetDistanceAtParameter](#getdistanceatparameter)
- [GetDistAtPoint](#getdistatpoint)
- [GetFirstDerivative(double)](#getfirstderivative(double))
- [GetFirstDerivative(Point3d)](#getfirstderivative(point3d))
- [GetGeCurve()](#getgecurve())
- [GetGeCurve(Tolerance)](#getgecurve(tolerance))
- [GetOffsetCurves](#getoffsetcurves)
- [GetOffsetCurvesGivenPlaneNormal](#getoffsetcurvesgivenplanenormal)
- [GetOrthoProjectedCurve](#getorthoprojectedcurve)
- [GetParameterAtDistance](#getparameteratdistance)
- [GetParameterAtPoint](#getparameteratpoint)
- [GetPointAtDist](#getpointatdist)
- [GetPointAtParameter](#getpointatparameter)
- [GetProjectedCurve](#getprojectedcurve)
- [GetSecondDerivative(double)](#getsecondderivative(double))
- [GetSecondDerivative(Point3d)](#getsecondderivative(point3d))
- [GetSplitCurves(DoubleCollection)](#getsplitcurves(doublecollection))
- [GetSplitCurves(Point3dCollection)](#getsplitcurves(point3dcollection))
- [ReverseCurve](#reversecurve)
- [SetFromGeCurve(Curve3d)](#setfromgecurve(curve3d))
- [SetFromGeCurve(Curve3d, Tolerance)](#setfromgecurve(curve3d,-tolerance))
- [SetFromGeCurve(Curve3d, Vector3d)](#setfromgecurve(curve3d,-vector3d))
- [SetFromGeCurve(Curve3d, Vector3d, Tolerance)](#setfromgecurve(curve3d,-vector3d,-tolerance))

### Properties

- [Area](#area)
- [Closed](#closed)
- [EndParam](#endparam)
- [EndPoint](#endpoint)
- [IsPeriodic](#isperiodic)
- [Spline](#spline)
- [StartParam](#startparam)
- [StartPoint](#startpoint)


## Methods Details

### CreateFromGeCurve(Curve3d)

#### Description
This is CreateFromGeCurve, a member of class Curve.
```text
public static Curve CreateFromGeCurve(
    Curve3d geCurve
);
```

### CreateFromGeCurve(Curve3d, Tolerance)

#### Description
This is CreateFromGeCurve, a member of class Curve.
```text
public static Curve CreateFromGeCurve(
    Curve3d geCurve, 
    Tolerance tolerance
);
```

### CreateFromGeCurve(Curve3d, Vector3d)

#### Description
This is CreateFromGeCurve, a member of class Curve.
```text
public static Curve CreateFromGeCurve(
    Curve3d geCurve, 
    Vector3d __unnamed001
);
```

### CreateFromGeCurve(Curve3d, Vector3d, Tolerance)

#### Description
This is CreateFromGeCurve, a member of class Curve.
```text
public static Curve CreateFromGeCurve(
    Curve3d geCurve, 
    Vector3d __unnamed001, 
    Tolerance tolerance
);
```

### Extend([MarshalAs(UnmanagedType.U1)] bool, Point3d)

#### Description
This function extends the curve to the point specified.
```text
public virtual void Extend(
    [MarshalAs(UnmanagedType.U1)] bool extendStart, 
    Point3d toPoint
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| [MarshalAs(UnmanagedType.U1)] bool extendStart | Input whether to extend the curve's start or end . |
| Point3d toPoint | Input the new start or end point of the curve. |

### Extend(double)

#### Description
This function extends the beginning or end of the curve to the new point determined by the newParameter value.
```text
public virtual void Extend(
    double newParameter
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double newParameter | Input the new start or end parameter on the curve |

### GetClosestPointTo(Point3d, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This function projects the curve onto the plane defined by givenPoint. Returns the point (in WCS coordinates) on the curve that is nearest to givenPoint.
```text
public virtual Point3d GetClosestPointTo(
    Point3d givenPoint, 
    [MarshalAs(UnmanagedType.U1)] bool extend
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d givenPoint | Input the point (in WCS coordinates) for which to find nearest point on curve |
| [MarshalAs(UnmanagedType.U1)] bool extend | Input whether or not to extend curve in search for nearest point. |

### GetClosestPointTo(Point3d, Vector3d, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This function finds the point on the curve that is nearest to givenPoint and returns the result.
```text
public virtual Point3d GetClosestPointTo(
    Point3d givenPoint, 
    Vector3d direction, 
    [MarshalAs(UnmanagedType.U1)] bool extend
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d givenPoint | Input the point (in WCS coordinates) for which to find nearest point on curve |
| Vector3d direction | Input the normal vector (in WCS coordinates) for plane to project onto |
| [MarshalAs(UnmanagedType.U1)] bool extend | Input whether or not to extend curve in search for nearest point. |

### GetDistanceAtParameter

#### Description
Returns the distance.
```text
public virtual double GetDistanceAtParameter(
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double value | Input the object representing the parameter. |

#### Conditions
Read-only 
### GetDistAtPoint

#### Description
Returns the distance to the point.
```text
public virtual double GetDistAtPoint(
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d point | Input the object representing the point. |

### GetFirstDerivative(double)

#### Description
Returns the first derivative of the vector.
```text
public virtual Vector3d GetFirstDerivative(
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double value | Input the derivative value |

### GetFirstDerivative(Point3d)

#### Description
Returns the first derivative.
```text
public virtual Vector3d GetFirstDerivative(
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d point | Input the derivative value |

### GetGeCurve()

#### Description
This is GetGeCurve, a member of class Curve.
```text
public Curve3d GetGeCurve();
```

### GetGeCurve(Tolerance)

#### Description
This is GetGeCurve, a member of class Curve.
```text
public Curve3d GetGeCurve(
    Tolerance tolerance
);
```

### GetOffsetCurves

#### Description
Returns the a collection of the offset curves.
```text
public virtual DBObjectCollection GetOffsetCurves(
    double offsetDist
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double offsetDist | Input the distance to offset the curve |

### GetOffsetCurvesGivenPlaneNormal

#### Description
Returns a collection of the offset curves.
```text
public virtual DBObjectCollection GetOffsetCurvesGivenPlaneNormal(
    Vector3d normal, 
    double offsetDist
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Vector3d normal | Input the normal vector for plane in which to offset |
| double offsetDist | Input distance to offset the curve |

### GetOrthoProjectedCurve

#### Description
This function creates a new curve entity that is the result of projecting the curve along the given plane.
```text
public virtual Curve GetOrthoProjectedCurve(
    Plane planeToProjectOn
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Plane planeToProjectOn | Input plane onto which the curve is to be projected |

### GetParameterAtDistance

#### Description
This function determines the parameter of the curve at the location that is a distance of dist along the curve from the curve start.
```text
public virtual double GetParameterAtDistance(
    double dist
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double dist | Input distance along the curve from the beginning of the curve to the location for the desired parameter. |

### GetParameterAtPoint

#### Description
This function determines the parameter of the curve at point and returns the parameter.
```text
public virtual double GetParameterAtPoint(
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d point | Input point (in WCS coordinates) on the curve at which the parameter is desired Returns the parameter of the curve at point |

### GetPointAtDist

#### Description
This function determines the point on the curve that is a distance of value along the curve from the curve start, and returns the point.
```text
public virtual Point3d GetPointAtDist(
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double value | Input distance along the curve from the beginning of the curve to the location of the desired point |

### GetPointAtParameter

#### Description
This function determines the point on the curve that corresponds to value, and returns the point.
```text
public virtual Point3d GetPointAtParameter(
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double value | Input parameter on the curve at which the point is desired |

### GetProjectedCurve

#### Description
This function creates a new curve entity that is the result of projecting the curve parallel to projectionDirection onto the planeToProjectOn and returns it.
```text
public virtual Curve GetProjectedCurve(
    Plane planeToProjectOn, 
    Vector3d projectionDirection
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Plane planeToProjectOn | Input plane onto which the curve is to be projected |
| Vector3d projectionDirection | Input direction (in WCS coordinates) of the projection |

### GetSecondDerivative(double)

#### Description
Returns the second derivative.
```text
public virtual Vector3d GetSecondDerivative(
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| double value | Input the derivative value |

### GetSecondDerivative(Point3d)

#### Description
Returns the second derivative.
```text
public virtual Vector3d GetSecondDerivative(
    Point3d point
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3d point | Input the derivative value |

### GetSplitCurves(DoubleCollection)

#### Description
This function creates one or more entities that are all subcurves of the original. The points collection must contain the points on the curve that are used as the start or end points of the newly created subcurves.
```text
public virtual DBObjectCollection GetSplitCurves(
    DoubleCollection value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| DoubleCollection value | Input collection of points (in WCS coordinates) on the curve |

### GetSplitCurves(Point3dCollection)

#### Description
This function creates one or more entities that are all subcurves of the original. The points collection must contain the points on the curve that are used as the start or end points of the newly created subcurves.
```text
public virtual DBObjectCollection GetSplitCurves(
    Point3dCollection points
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Point3dCollection points | Input collection of parameters on the curve |

### ReverseCurve

#### Description
This function reverses the parameterization of the curve: The start becomes the end and visa versa.
```text
public virtual void ReverseCurve();
```

### SetFromGeCurve(Curve3d)

#### Description
This is SetFromGeCurve, a member of class Curve.
```text
public void SetFromGeCurve(
    Curve3d geCurve
);
```

### SetFromGeCurve(Curve3d, Tolerance)

#### Description
This is SetFromGeCurve, a member of class Curve.
```text
public void SetFromGeCurve(
    Curve3d geCurve, 
    Tolerance tolerance
);
```

### SetFromGeCurve(Curve3d, Vector3d)

#### Description
This is SetFromGeCurve, a member of class Curve.
```text
public void SetFromGeCurve(
    Curve3d geCurve, 
    Vector3d __unnamed001
);
```

### SetFromGeCurve(Curve3d, Vector3d, Tolerance)

#### Description
This is SetFromGeCurve, a member of class Curve.
```text
public void SetFromGeCurve(
    Curve3d geCurve, 
    Vector3d __unnamed001, 
    Tolerance tolerance
);
```

### Area

#### Description
Accesses the area of the curve.
```text
public virtual double Area;
```

#### Conditions
Read-only
### Closed

#### Description
Returns true if the curve is closed.
```text
public bool Closed;
```

#### Conditions
Read-only
### EndParam

#### Description
Accesses the parameter of the endpoint of the curve.
```text
public virtual double EndParam;
```

#### Conditions
Read-only
### EndPoint

#### Description
Accesses the end point (in WCS coordinates) of the curve.
```text
public virtual Point3d EndPoint;
```

#### Conditions
Read / Write
### IsPeriodic

#### Description
Returns true if the curve is periodic.
```text
public virtual bool IsPeriodic;
```

#### Conditions
Read-only
### Spline

#### Description
Returns pointing to a spline approximation of the curve
```text
public virtual Autodesk.AutoCAD.DatabaseServices.Spline Spline;
```

#### Conditions
Read-only
### StartParam

#### Description
Returns the parameter of the start of the curve
```text
public virtual double StartParam;
```

#### Conditions
Read / Write
### StartPoint

#### Description
Returns the starting point of the curve
```text
public virtual Point3d StartPoint;
```

#### Conditions
Read / Write