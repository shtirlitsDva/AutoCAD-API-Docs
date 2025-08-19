# EdgeRef Class

## Overview

#### Description
This wraps the ObjectARX [AcDbEdgeRef](AcDbEdgeRef.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GeomRef
    Autodesk.AutoCAD.DatabaseServices.SubentRef
        Autodesk.AutoCAD.DatabaseServices.EdgeRef
```

```text
public class EdgeRef : SubentRef;
```

### Constructors

- [EdgeRef()](#edgeref())
- [EdgeRef(CompoundObjectId)](#edgeref(compoundobjectid))
- [EdgeRef(CompoundObjectId, SubentityId)](#edgeref(compoundobjectid,-subentityid))
- [EdgeRef(CompoundObjectId, SubentityId, SubentityId)](#edgeref(compoundobjectid,-subentityid,-subentityid))
- [EdgeRef(CompoundObjectId, SubentityId, SubentityId, Curve3d)](#edgeref(compoundobjectid,-subentityid,-subentityid,-curve3d))
- [EdgeRef(Curve3d)](#edgeref(curve3d))
- [EdgeRef(Entity)](#edgeref(entity))
- [EdgeRef(FullSubentityPath)](#edgeref(fullsubentitypath))
- [EdgeRef(IntPtr, [MarshalAs(UnmanagedType.U1)] bool)](#edgeref(intptr,-[marshalas(unmanagedtype.u1)]-bool))

### Properties

- [Curve](#curve)
- [FaceSubentity](#facesubentity)


## Constructors Details

### EdgeRef()

#### Description
This wraps the ObjectARX [AcDbEdgeRef::AcDbEdgeRef](AcDbEdgeRef__AcDbEdgeRef.md) method
```text
public EdgeRef();
```

### EdgeRef(CompoundObjectId)

#### Description
This wraps the ObjectARX [AcDbEdgeRef::AcDbEdgeRef](AcDbEdgeRef__AcDbEdgeRef@AcDbCompoundObjectId_@AcDbSubentId_@AcDbSubentId_@AcGeCurve3d_.md)() method.
```text
public EdgeRef(
    CompoundObjectId compoundObjectId
);
```

### EdgeRef(CompoundObjectId, SubentityId)

#### Description
This wraps the ObjectARX [AcDbEdgeRef::AcDbEdgeRef](AcDbEdgeRef__AcDbEdgeRef@AcDbCompoundObjectId_@AcDbSubentId_@AcDbSubentId_@AcGeCurve3d_.md)() method.
```text
public EdgeRef(
    CompoundObjectId compoundObjectId, 
    SubentityId edgeSubentId
);
```

### EdgeRef(CompoundObjectId, SubentityId, SubentityId)

#### Description
This wraps the ObjectARX [AcDbEdgeRef::AcDbEdgeRef](AcDbEdgeRef__AcDbEdgeRef@AcDbCompoundObjectId_@AcDbSubentId_@AcDbSubentId_@AcGeCurve3d_.md)() method.
```text
public EdgeRef(
    CompoundObjectId compoundObjectId, 
    SubentityId edgeSubentId, 
    SubentityId faceSubentId
);
```

### EdgeRef(CompoundObjectId, SubentityId, SubentityId, Curve3d)

#### Description
This wraps the ObjectARX [AcDbEdgeRef::AcDbEdgeRef](AcDbEdgeRef__AcDbEdgeRef@AcDbCompoundObjectId_@AcDbSubentId_@AcDbSubentId_@AcGeCurve3d_.md)() method.
```text
public EdgeRef(
    CompoundObjectId compoundObjectId, 
    SubentityId edgeSubentId, 
    SubentityId faceSubentId, 
    Curve3d curve
);
```

### EdgeRef(Curve3d)

#### Description
This wraps the ObjectARX[AcDbEdgeRef::AcDbEdgeRef](AcDbEdgeRef__AcDbEdgeRef@AcGeCurve3d_.md)() method
```text
public EdgeRef(
    Curve3d curve
);
```

### EdgeRef(Entity)

#### Description
This wraps the ObjectARX [AcDbEdgeRef::AcDbEdgeRef](AcDbEdgeRef__AcDbEdgeRef@AcDbEntity_.md)() method
```text
public EdgeRef(
    Entity entity
);
```

### EdgeRef(FullSubentityPath)

#### Description
This wraps the ObjectARX [AcDbEdgeRef::AcDbEdgeRef](AcDbEdgeRef__AcDbEdgeRef@AcDbFullSubentPath_.md)() method
```text
public EdgeRef(
    FullSubentityPath path
);
```

### EdgeRef(IntPtr, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
EdgeRef
```text
protected internal EdgeRef(
    IntPtr unmanagedObjPtr, 
    [MarshalAs(UnmanagedType.U1)] bool autoDelete
);
```

### Curve

#### Description
This wraps the ObjectARX [AcDbEdgeRef::curve](AcDbEdgeRef__curve@const.md)() method
```text
public Curve3d Curve;
```

### FaceSubentity

#### Description
This wraps the ObjectARX [AcDbEdgeRef::faceSubentId](AcDbEdgeRef__faceSubentId@const.md)() and [AcDbEdgeRef::setFaceSubentity](AcDbEdgeRef__setFaceSubentity@AcDbSubentId_.md)() methods.
```text
public SubentityId FaceSubentity;
```
