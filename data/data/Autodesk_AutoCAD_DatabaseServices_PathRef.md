# PathRef Class

## Overview

#### Description
This wraps the ObjectARX [AcDbPathRef](AcDbPathRef.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GeomRef
    Autodesk.AutoCAD.DatabaseServices.PathRef
```

```text
public class PathRef : GeomRef;
```

### Constructors

- [PathRef()](#pathref())
- [PathRef(EdgeRef[])](#pathref(edgeref[]))
- [PathRef(FullSubentityPath[], FullSubentityPath[])](#pathref(fullsubentitypath[],-fullsubentitypath[]))

### Methods

- [GetEntityArray](#getentityarray)
- [IsEqualTo](#isequalto)
- [IsReferencePath](#isreferencepath)

### Properties

- [EdgeRefs](#edgerefs)


## Constructors Details

### PathRef()

#### Description
This wraps the ObjectARX [AcDbPathRef::AcDbPathRef](AcDbPathRef__AcDbPathRef.md)() method
```text
public PathRef();
```

### PathRef(EdgeRef[])

#### Description
This wraps the ObjectARX AcDbPathRef::AcDbPathRef() method
```text
public PathRef(
    EdgeRef\[\] edges
);
```

### PathRef(FullSubentityPath[], FullSubentityPath[])

#### Description
This wraps the ObjectARX [AcDbPathRef::AcDbPathRef](AcDbPathRef__AcDbPathRef@AcDbFullSubentPathArray_@AcDbFullSubentPathArray_.md) () method.
```text
public PathRef(
    FullSubentityPath\[\] edgeSubentPathArr, 
    FullSubentityPath\[\] faceSubentPathArr
);
```

### GetEntityArray

#### Description
This wraps the ObjectARX AcDbPathRef::getEntityArray() method
```text
public Entity\[\] GetEntityArray(
    [MarshalAs(UnmanagedType.U1)] bool bConcatenate
);
```

### IsEqualTo

#### Description
This wraps the ObjectARX [AcDbPathRef::isEqualTo](AcDbPathRef__isEqualTo@AcGeCurve3d_.md)() method
```text
public bool IsEqualTo(
    Curve3d curve
);
```

### IsReferencePath

#### Description
This wraps the ObjectARX [AcDbPathRef::isReferencePath](AcDbPathRef__isReferencePath.md)() method
```text
public bool IsReferencePath();
```

### EdgeRefs

#### Description
This wraps the ObjectARX [AcDbPathRef::edgeRefs](AcDbPathRef__edgeRefs@const.md)() and [AcDbPathRef::setEdgeRefs](AcDbPathRef__setEdgeRefs@AcArray_AcDbEdgeRef__.md)() methods.
```text
public EdgeRef EdgeRefs;
```
