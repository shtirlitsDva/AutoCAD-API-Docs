# AssocPatchSurfaceActionBody Class

## Overview

#### Description
This wraps [AcDbAssocPatchSurfaceActionBody](AcDbAssocPatchSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocPatchSurfaceActionBody
```

```text
public class AssocPatchSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocPatchSurfaceActionBody](#assocpatchsurfaceactionbody)

### Methods

- [CreateInstance(ObjectId, EdgeRef[], EdgeRef[], VertexRef[], [MarshalAs(UnmanagedType.U1)] bool)](#createinstance(objectid,-edgeref[],-edgeref[],-vertexref[],-[marshalas(unmanagedtype.u1)]-bool))
- [CreateInstance(ObjectId, EdgeRef[], EdgeRef[], VertexRef[], int, double, [MarshalAs(UnmanagedType.U1)] bool)](#createinstance(objectid,-edgeref[],-edgeref[],-vertexref[],-int,-double,-[marshalas(unmanagedtype.u1)]-bool))
- [GetBulge](#getbulge)
- [GetContinuity](#getcontinuity)
- [SetBulge](#setbulge)
- [SetConstraintCurves](#setconstraintcurves)
- [SetConstraintPoints](#setconstraintpoints)
- [SetContinuity](#setcontinuity)

### Properties

- [Bulge](#bulge)
- [Continuity](#continuity)
- [ContinuityGripPoint](#continuitygrippoint)


## Constructors Details

### AssocPatchSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::AcDbAssocPatchSurfaceActionBody](AcDbAssocPatchSurfaceActionBody__AcDbAssocPatchSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocPatchSurfaceActionBody();
```

### CreateInstance(ObjectId, EdgeRef[], EdgeRef[], VertexRef[], [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::createInstance](AcDbAssocPatchSurfaceActionBody__createInstance@AcDbObjectId_@AcArray_AcDbEdgeRef__@AcArray_AcDbEdgeRef__@AcArray_AcDbVertexRef__@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId patchSurfaceId, 
    EdgeRef\[\] profileCurves, 
    EdgeRef\[\] constraintCurves, 
    VertexRef\[\] constraintPoints, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

### CreateInstance(ObjectId, EdgeRef[], EdgeRef[], VertexRef[], int, double, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::createInstance](AcDbAssocPatchSurfaceActionBody__createInstance@AcDbObjectId_@AcArray_AcDbEdgeRef__@AcArray_AcDbEdgeRef__@AcArray_AcDbVertexRef__@int@double@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId patchSurfaceId, 
    EdgeRef\[\] edgeCurves, 
    EdgeRef\[\] constraintCurves, 
    VertexRef\[\] constraintPoints, 
    int nContinuity, 
    double dBulge, 
    [MarshalAs(UnmanagedType.U1)] bool bEnabled
);
```

### GetBulge

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::bulge](AcDbAssocPatchSurfaceActionBody__bulge@AcString_@AcString_@const.md)() method.
```text
public double GetBulge(
    out string expression, 
    out string evaluatorId
);
```

### GetContinuity

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::continuity](AcDbAssocPatchSurfaceActionBody__continuity@AcString_@AcString_@const.md)() method.
```text
public int GetContinuity(
    out string expression, 
    out string evaluatorId
);
```

### SetBulge

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::setBulge](AcDbAssocPatchSurfaceActionBody__setBulge@double@AcString_@AcString_.md)() method.
```text
public void SetBulge(
    double value, 
    string expression, 
    string evaluatorId
);
```

### SetConstraintCurves

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::setConstraintCurves](AcDbAssocPatchSurfaceActionBody__setConstraintCurves@AcArray_AcDbEdgeRef___.md)() method.
```text
public void SetConstraintCurves(
    EdgeRef\[\] constraintCurves
);
```

### SetConstraintPoints

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::setConstraintPoints](AcDbAssocPatchSurfaceActionBody__setConstraintPoints@AcArray_AcDbVertexRef___.md)() method.
```text
public void SetConstraintPoints(
    VertexRef\[\] constraintPoints
);
```

### SetContinuity

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::setContinuity](AcDbAssocPatchSurfaceActionBody__setContinuity@int@AcString_@AcString_.md)() method.
```text
public void SetContinuity(
    int value, 
    string expression, 
    string evaluatorId
);
```

### Bulge

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::bulge](AcDbAssocPatchSurfaceActionBody__bulge@AcString_@AcString_@const.md)() and [AcDbAssocPatchSurfaceActionBody::setBulge](AcDbAssocPatchSurfaceActionBody__setBulge@double@AcString_@AcString_.md)() methods.
```text
public double Bulge;
```

### Continuity

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::continuity](AcDbAssocPatchSurfaceActionBody__continuity@AcString_@AcString_@const.md)() and [AcDbAssocPatchSurfaceActionBody::setContinuity](AcDbAssocPatchSurfaceActionBody__setContinuity@int@AcString_@AcString_.md) ()methods.
```text
public int Continuity;
```

### ContinuityGripPoint

#### Description
This wraps the ObjectARX [AcDbAssocPatchSurfaceActionBody::getContinuityGripPoint](AcDbAssocPatchSurfaceActionBody__getContinuityGripPoint@AcGePoint3d_@const.md)() method.
```text
public Point3d ContinuityGripPoint;
```
