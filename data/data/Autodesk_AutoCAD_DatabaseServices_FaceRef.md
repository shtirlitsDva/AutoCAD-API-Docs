# FaceRef Class

## Overview

#### Description
This wraps the ObjectARX [AcDbFaceRef](AcDbFaceRef.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GeomRef
    Autodesk.AutoCAD.DatabaseServices.SubentRef
        Autodesk.AutoCAD.DatabaseServices.FaceRef
```

```text
public class FaceRef : SubentRef;
```

### Constructors

- [FaceRef()](#faceref())
- [FaceRef(CompoundObjectId)](#faceref(compoundobjectid))
- [FaceRef(CompoundObjectId, SubentityId)](#faceref(compoundobjectid,-subentityid))


## Constructors Details

### FaceRef()

#### Description
This wraps the ObjectARX [AcDbFaceRef::AcDbFaceRef](AcDbFaceRef__AcDbFaceRef.md)() method
```text
public FaceRef();
```

### FaceRef(CompoundObjectId)

#### Description
This wraps the ObjectARX[AcDbFaceRef::AcDbFaceRef](AcDbFaceRef__AcDbFaceRef@AcDbCompoundObjectId_@AcDbSubentId_@class_BODY_.md)(const AcDbCompoundObjectId&amp;, const AcDbSubentId&amp;, const AcGeCurve3d*) method.
```text
public FaceRef(
    CompoundObjectId compoundObjectId
);
```

### FaceRef(CompoundObjectId, SubentityId)

#### Description
This wraps the ObjectARX[AcDbFaceRef::AcDbFaceRef](AcDbFaceRef__AcDbFaceRef@AcDbCompoundObjectId_@AcDbSubentId_@class_BODY_.md)(const AcDbCompoundObjectId&amp;, const AcDbSubentId&amp;, const AcGeCurve3d*) method.
```text
public FaceRef(
    CompoundObjectId compoundObjectId, 
    SubentityId subentId
);
```
