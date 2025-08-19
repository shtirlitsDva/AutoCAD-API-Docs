# NurbSurface Class

## Overview

#### Description
This wraps the ObjectARX [AcDbNurbSurface](AcDbNurbSurface.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.NurbSurface
```

```text
public class NurbSurface : Autodesk.AutoCAD.DatabaseServices.Surface;
```

### Constructors

- [NurbSurface()](#nurbsurface())
- [NurbSurface(int, int, [MarshalAs(UnmanagedType.U1)] bool, int, int, Point3dCollection, DoubleCollection, KnotCollection, KnotCollection)](#nurbsurface(int,-int,-[marshalas(unmanagedtype.u1)]-bool,-int,-int,-point3dcollection,-doublecollection,-knotcollection,-knotcollection))

### Methods

- [Evaluate(double, double)](#evaluate(double,-double))
- [Evaluate(double, double, int, Point3d, Vector3dCollection)](#evaluate(double,-double,-int,-point3d,-vector3dcollection))
- [Evaluate(double, double, Point3d, Vector3d, Vector3d)](#evaluate(double,-double,-point3d,-vector3d,-vector3d))
- [Evaluate(double, double, Point3d, Vector3d, Vector3d, Vector3d, Vector3d, Vector3d)](#evaluate(double,-double,-point3d,-vector3d,-vector3d,-vector3d,-vector3d,-vector3d))
- [GetControlPointAt](#getcontrolpointat)
- [GetIsolineAtU](#getisolineatu)
- [GetIsolineAtV](#getisolineatv)
- [GetNormal](#getnormal)
- [GetParameterOfPoint](#getparameterofpoint)
- [GetWeight](#getweight)
- [InsertControlPointsAtU](#insertcontrolpointsatu)
- [InsertControlPointsAtV](#insertcontrolpointsatv)
- [InsertKnotAtU](#insertknotatu)
- [InsertKnotAtV](#insertknotatv)
- [IsPlanar](#isplanar)
- [IsPointOnSurface](#ispointonsurface)
- [ModifyPosition](#modifyposition)
- [ModifyPositionAndTangent](#modifypositionandtangent)
- [Rebuild(int, int, int, int)](#rebuild(int,-int,-int,-int))
- [Rebuild(int, int, int, int, [MarshalAs(UnmanagedType.U1)] bool)](#rebuild(int,-int,-int,-int,-[marshalas(unmanagedtype.u1)]-bool))
- [RemoveControlPointsAtU](#removecontrolpointsatu)
- [RemoveControlPointsAtV](#removecontrolpointsatv)
- [Set](#set)
- [SetControlPointAt](#setcontrolpointat)
- [SetControlPoints](#setcontrolpoints)
- [SetWeight](#setweight)

### Properties

- [ControlPoints](#controlpoints)
- [DegreeInU](#degreeinu)
- [DegreeInV](#degreeinv)
- [IsClosedInU](#isclosedinu)
- [IsClosedInV](#isclosedinv)
- [IsPeriodicInU](#isperiodicinu)
- [IsPeriodicInV](#isperiodicinv)
- [IsRational](#isrational)
- [NumberOfControlPointsInU](#numberofcontrolpointsinu)
- [NumberOfControlPointsInV](#numberofcontrolpointsinv)
- [NumberOfKnotsInU](#numberofknotsinu)
- [NumberOfKnotsInV](#numberofknotsinv)
- [NumberOfSpansInU](#numberofspansinu)
- [NumberOfSpansInV](#numberofspansinv)
- [PeriodInU](#periodinu)
- [PeriodInV](#periodinv)
- [UKnots](#uknots)
- [VKnots](#vknots)


## Constructors Details

### NurbSurface()

#### Description
This wraps the ObjectARX [AcDbNurbSurface::AcDbNurbSurface](AcDbNurbSurface__AcDbNurbSurface.md)() method
```text
public NurbSurface();
```

### NurbSurface(int, int, [MarshalAs(UnmanagedType.U1)] bool, int, int, Point3dCollection, DoubleCollection, KnotCollection, KnotCollection)

#### Description
This wraps the ObjectARX [AcDbNurbSurface::AcDbNurbSurface](AcDbNurbSurface__AcDbNurbSurface@int@int@bool@int@int@AcGePoint3dArray_@AcGeDoubleArray_@AcGeKnotVector_@AcGeKnotVector_.md)() method
```text
public NurbSurface(
    int uDegree, 
    int vDegree, 
    [MarshalAs(UnmanagedType.U1)] bool rational, 
    int uNumControlPoints, 
    int vNumControlPoints, 
    Point3dCollection ctrlPts, 
    DoubleCollection weights, 
    KnotCollection uKnots, 
    KnotCollection vKnots
);
```

### Evaluate(double, double)

#### Description
This wraps the ObjectARX evaluate(double u, double v, AcGePoint3d&amp; pos) method
```text
public Point3d Evaluate(
    double u, 
    double v
);
```

### Evaluate(double, double, int, Point3d, Vector3dCollection)

#### Description
This wraps the ObjectARX evaluate(double u, double v, int derivDegree, AcGePoint3d&amp; point, AcGeVector3dArray&amp; derivatives) method
```text
public void Evaluate(
    double u, 
    double v, 
    int derivDegree, 
    ref Point3d point, 
    ref Vector3dCollection derivatives
);
```

### Evaluate(double, double, Point3d, Vector3d, Vector3d)

#### Description
This wraps the ObjectARX evaluate(double u, double v, AcGePoint3d&amp; pos, AcGeVector3d&amp; uDeriv, AcGeVector3d&amp; vDeriv) method
```text
public void Evaluate(
    double u, 
    double v, 
    ref Point3d pos, 
    ref Vector3d uDeriv, 
    ref Vector3d vDeriv
);
```

### Evaluate(double, double, Point3d, Vector3d, Vector3d, Vector3d, Vector3d, Vector3d)

#### Description
This wraps the ObjectARX evaluate(double u, double v, AcGePoint3d&amp; pos, AcGeVector3d&amp; uDeriv, AcGeVector3d&amp; vDeriv, AcGeVector3d&amp; uuDeriv, AcGeVector3d&amp; uvDeriv, AcGeVector3d&amp; vvDeriv) method
```text
public void Evaluate(
    double u, 
    double v, 
    ref Point3d pos, 
    ref Vector3d uDeriv, 
    ref Vector3d vDeriv, 
    ref Vector3d uuDeriv, 
    ref Vector3d uvDeriv, 
    ref Vector3d vvDeriv
);
```

### GetControlPointAt

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getControlPointAt](AcDbNurbSurface__getControlPointAt@int@int@AcGePoint3d_@const.md)() method
```text
public Point3d GetControlPointAt(
    int uIndex, 
    int vIndex
);
```

### GetIsolineAtU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getIsolineAtU](AcDbNurbSurface__getIsolineAtU@double@AcArray_AcDbCurve___@const.md)() method
```text
public Curve\[\] GetIsolineAtU(
    double u
);
```

### GetIsolineAtV

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getIsolineAtV](AcDbNurbSurface__getIsolineAtV@double@AcArray_AcDbCurve___@const.md)() method
```text
public Curve\[\] GetIsolineAtV(
    double v
);
```

### GetNormal

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getNormal](AcDbNurbSurface__getNormal@double@double@AcGeVector3d_@const.md)() method
```text
public Vector3d GetNormal(
    double u, 
    double v
);
```

### GetParameterOfPoint

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getParameterOfPoint](AcDbNurbSurface__getParameterOfPoint@AcGePoint3d_@double_@double_@const.md)() method
```text
public void GetParameterOfPoint(
    Point3d point, 
    out double u, 
    out double v
);
```

### GetWeight

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getWeight](AcDbNurbSurface__getWeight@int@int@double_@const.md)() method
```text
public double GetWeight(
    int uIndex, 
    int vIndex
);
```

### InsertControlPointsAtU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::InsertControlPointsAtU](AcDbNurbSurface__InsertControlPointsAtU@double@AcGePoint3dArray_@AcGeDoubleArray_.md)() method
```text
public void InsertControlPointsAtU(
    double u, 
    Point3dCollection vCtrlPts, 
    DoubleCollection vWeights
);
```

### InsertControlPointsAtV

#### Description
This wraps the ObjectARX [AcDbNurbSurface::InsertControlPointsAtV](AcDbNurbSurface__InsertControlPointsAtV@double@AcGePoint3dArray_@AcGeDoubleArray_.md)() method
```text
public void InsertControlPointsAtV(
    double v, 
    Point3dCollection uCtrlPts, 
    DoubleCollection uWeights
);
```

### InsertKnotAtU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::InsertKnotAtU](AcDbNurbSurface__InsertKnotAtU@double.md)() method
```text
public void InsertKnotAtU(
    double u
);
```

### InsertKnotAtV

#### Description
This wraps the ObjectARX [AcDbNurbSurface::InsertKnotAtV](AcDbNurbSurface__InsertKnotAtV@double.md)() method
```text
public void InsertKnotAtV(
    double v
);
```

### IsPlanar

#### Description
This wraps the ObjectARX [AcDbNurbSurface::isPlanar](AcDbNurbSurface__isPlanar@bool_@AcGePoint3d_@AcGeVector3d_@const.md)() method
```text
public bool IsPlanar(
    out Point3d ptOnSurface, 
    out Vector3d normal
);
```

### IsPointOnSurface

#### Description
This wraps the ObjectARX [AcDbNurbSurface::isPointOnSurface](AcDbNurbSurface__isPointOnSurface@AcGePoint3d_@bool_@const.md)() method
```text
public bool IsPointOnSurface(
    Point3d point
);
```

### ModifyPosition

#### Description
This wraps the ObjectARX [AcDbNurbSurface::modifyPositionAndTangent](AcDbNurbSurface__modifyPositionAndTangent@double@double@AcGePoint3d_@AcGeVector3d_@AcGeVector3d_.md)() method
```text
public void ModifyPosition(
    double u, 
    double v, 
    Point3d point
);
```

### ModifyPositionAndTangent

#### Description
This wraps the ObjectARX [AcDbNurbSurface::modifyPositionAndTangent](AcDbNurbSurface__modifyPositionAndTangent@double@double@AcGePoint3d_@AcGeVector3d_@AcGeVector3d_.md)() method
```text
public void ModifyPositionAndTangent(
    double u, 
    double v, 
    Point3d point, 
    Vector3d uDeriv, 
    Vector3d vDeriv
);
```

### Rebuild(int, int, int, int)

#### Description
This wraps the ObjectARX [AcDbNurbSurface::rebuild](AcDbNurbSurface__rebuild@int@int@int@int@bool.md)() method.
```text
public void Rebuild(
    int uDegree, 
    int vDegree, 
    int numUCtrlPts, 
    int numVCtrlPts
);
```

### Rebuild(int, int, int, int, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbNurbSurface::rebuild](AcDbNurbSurface__rebuild@int@int@int@int@bool.md)() method.
```text
public void Rebuild(
    int uDegree, 
    int vDegree, 
    int numUCtrlPts, 
    int numVCtrlPts, 
    [MarshalAs(UnmanagedType.U1)] bool bRestore
);
```

### RemoveControlPointsAtU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::RemoveControlPointsAtU](AcDbNurbSurface__RemoveControlPointsAtU@int.md)() method
```text
public void RemoveControlPointsAtU(
    int uIndex
);
```

### RemoveControlPointsAtV

#### Description
This wraps the ObjectARX[AcDbNurbSurface::RemoveControlPointsAtV](AcDbNurbSurface__RemoveControlPointsAtV@int.md)() method
```text
public void RemoveControlPointsAtV(
    int vIndex
);
```

### Set

#### Description
This wraps the ObjectARX [AcDbNurbSurface::set](AcDbNurbSurface__set@int@int@bool@int@int@AcGePoint3dArray_@AcGeDoubleArray_@AcGeKnotVector_@AcGeKnotVector_.md) () method
```text
public void Set(
    int uDegree, 
    int vDegree, 
    [MarshalAs(UnmanagedType.U1)] bool rational, 
    int uNumControlPoints, 
    int vNumControlPoints, 
    Point3dCollection ctrlPts, 
    DoubleCollection weights, 
    KnotCollection uKnots, 
    KnotCollection vKnots
);
```

### SetControlPointAt

#### Description
This wraps the ObjectARX [AcDbNurbSurface::setControlPointAt](AcDbNurbSurface__setControlPointAt@int@int@AcGePoint3d_.md)() method
```text
public void SetControlPointAt(
    int uIndex, 
    int vIndex, 
    Point3d point
);
```

### SetControlPoints

#### Description
This wraps the ObjectARX [AcDbNurbSurface::setControlPoints](AcDbNurbSurface__setControlPoints@int@int@AcGePoint3dArray_.md)() method
```text
public void SetControlPoints(
    int uCount, 
    int vCount, 
    Point3dCollection points
);
```

### SetWeight

#### Description
This wraps the ObjectARX [AcDbNurbSurface::setWeight](AcDbNurbSurface__setWeight@int@int@double.md)() method
```text
public void SetWeight(
    int uIndex, 
    int vIndex, 
    double weight
);
```

### ControlPoints

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getControlPoints](AcDbNurbSurface__getControlPoints@int_@int_@AcGePoint3dArray_@const.md)() method
```text
public Point3dCollection ControlPoints;
```

### DegreeInU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getDegreeInU](AcDbNurbSurface__getDegreeInU@int_@const.md)() method
```text
public int DegreeInU;
```

### DegreeInV

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getDegreeInV](AcDbNurbSurface__getDegreeInV@int_@const.md)() method
```text
public int DegreeInV;
```

### IsClosedInU

#### Description
This wraps [AcDbNurbSurface::isClosedInU](AcDbNurbSurface__isClosedInU@bool_@const.md)() method
```text
public bool IsClosedInU;
```

### IsClosedInV

#### Description
This wraps the ObjectARX [AcDbNurbSurface::isClosedInV](AcDbNurbSurface__isClosedInV@bool_@const.md)() method
```text
public bool IsClosedInV;
```

### IsPeriodicInU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::isPeriodicInU](AcDbNurbSurface__isPeriodicInU@bool_@const.md)() method
```text
public bool IsPeriodicInU;
```

### IsPeriodicInV

#### Description
This wraps the ObjectARX[AcDbNurbSurface::isPeriodicInV](AcDbNurbSurface__isPeriodicInV@bool_@const.md)() method
```text
public bool IsPeriodicInV;
```

### IsRational

#### Description
This wraps the ObjectARX [AcDbNurbSurface::isRational](AcDbNurbSurface__isRational@bool_@const.md)() method
```text
public bool IsRational;
```

### NumberOfControlPointsInU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getNumberOfControlPointsInU](AcDbNurbSurface__getNumberOfControlPointsInU@int_@const.md)() method
```text
public int NumberOfControlPointsInU;
```

### NumberOfControlPointsInV

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getNumberOfControlPointsInV](AcDbNurbSurface__getNumberOfControlPointsInV@int_@const.md)() method
```text
public int NumberOfControlPointsInV;
```

### NumberOfKnotsInU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getNumberOfKnotsInU](AcDbNurbSurface__getNumberOfKnotsInU@int_@const.md)() method
```text
public int NumberOfKnotsInU;
```

### NumberOfKnotsInV

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getNumberOfKnotsInV](AcDbNurbSurface__getNumberOfKnotsInV@int_@const.md)() method
```text
public int NumberOfKnotsInV;
```

### NumberOfSpansInU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getNormal](AcDbNurbSurface__getNormal@double@double@AcGeVector3d_@const.md)() method
```text
public int NumberOfSpansInU;
```

### NumberOfSpansInV

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getIsolineAtU](AcDbNurbSurface__getIsolineAtU@double@AcArray_AcDbCurve___@const.md)() method
```text
public int NumberOfSpansInV;
```

### PeriodInU

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getPeriodInU](AcDbNurbSurface__getPeriodInU@double_@const.md)() method
```text
public double PeriodInU;
```

### PeriodInV

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getPeriodInV](AcDbNurbSurface__getPeriodInV@double_@const.md)() method
```text
public double PeriodInV;
```

### UKnots

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getUKnots](AcDbNurbSurface__getUKnots@AcGeKnotVector_@const.md)() method
```text
public KnotCollection UKnots;
```

### VKnots

#### Description
This wraps the ObjectARX [AcDbNurbSurface::getVKnots](AcDbNurbSurface__getVKnots@AcGeKnotVector_@const.md)() method
```text
public KnotCollection VKnots;
```
