# AssocFaceActionParam Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocFaceActionParam](AcDbAssocFaceActionParam.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocFaceActionParam
```

```text
public class AssocFaceActionParam : AssocActionParam;
```

### Constructors

- [AssocFaceActionParam](#assocfaceactionparam)

### Methods

- [GetFaceRef](#getfaceref)
- [SetFaceRef(FaceRef)](#setfaceref(faceref))
- [SetFaceRef(FaceRef, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#setfaceref(faceref,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))

### Properties

- [DependentOnCompoundObject](#dependentoncompoundobject)


## Constructors Details

### AssocFaceActionParam

#### Description
This wraps the ObjectARX [AcDbAssocFaceActionParam::AcDbAssocFaceActionParam](AcDbAssocFaceActionParam__AcDbAssocFaceActionParam@AcDbAssocCreateImpObject.md)() method.
```text
public AssocFaceActionParam();
```

### GetFaceRef

#### Description
This wraps the ObjectARX [AcDbAssocFaceActionParam::getFaceRef](AcDbAssocFaceActionParam__getFaceRef@AcArray_AcDbFaceRef__@const.md)() method.
```text
public FaceRef\[\] GetFaceRef();
```

### SetFaceRef(FaceRef)

#### Description
This wraps the ObjectARX AcDbAssocFaceActionParam::setFaceRef() method.
```text
public void SetFaceRef(
    FaceRef faceRef
);
```

### SetFaceRef(FaceRef, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX AcDbAssocFaceActionParam::setFaceRef() method.
```text
public void SetFaceRef(
    FaceRef faceRef, 
    [MarshalAs(UnmanagedType.U1)] bool isReadDependency, 
    [MarshalAs(UnmanagedType.U1)] bool isWriteDependency
);
```

### DependentOnCompoundObject

#### Description
This wraps the ObjectARX [AcDbAssocFaceActionParam::getDependentOnCompoundObject](AcDbAssocFaceActionParam__getDependentOnCompoundObject@AcDbCompoundObjectId_@const.md)() method.
```text
public CompoundObjectId DependentOnCompoundObject;
```
