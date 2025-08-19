# AssocEdgeActionParam Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocEdgeActionParam](AcDbAssocEdgeActionParam.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocEdgeActionParam
```

```text
public class AssocEdgeActionParam : AssocActionParam;
```

### Constructors

- [AssocEdgeActionParam](#assocedgeactionparam)

### Methods

- [GetEdgeRef](#getedgeref)
- [SetEdgeRef(EdgeRef)](#setedgeref(edgeref))
- [SetEdgeRef(EdgeRef, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#setedgeref(edgeref,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))

### Properties

- [DependentOnCompoundObject](#dependentoncompoundobject)


## Constructors Details

### AssocEdgeActionParam

#### Description
This wraps the ObjectARX [AcDbAssocEdgeActionParam::AcDbAssocEdgeActionParam](AcDbAssocEdgeActionParam__AcDbAssocEdgeActionParam@AcDbAssocCreateImpObject.md)() method.
```text
public AssocEdgeActionParam();
```

### GetEdgeRef

#### Description
This wraps the ObjectARX [AcDbAssocEdgeActionParam::getEdgeRef](AcDbAssocEdgeActionParam__getEdgeRef@AcArray_AcDbEdgeRef__@const.md)() method.
```text
public EdgeRef\[\] GetEdgeRef();
```

### SetEdgeRef(EdgeRef)

#### Description
This wraps the ObjectARX AcDbAssocEdgeActionParam::setEdgeRef() method.
```text
public void SetEdgeRef(
    EdgeRef edgeRef
);
```

### SetEdgeRef(EdgeRef, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX AcDbAssocEdgeActionParam::setEdgeRef() method.
```text
public void SetEdgeRef(
    EdgeRef edgeRef, 
    [MarshalAs(UnmanagedType.U1)] bool isReadDep, 
    [MarshalAs(UnmanagedType.U1)] bool isWriteDep
);
```

### DependentOnCompoundObject

#### Description
This wraps the ObjectARX[AcDbAssocEdgeActionParam::getDependentOnCompoundObject](AcDbAssocEdgeActionParam__getDependentOnCompoundObject@AcDbCompoundObjectId_@const.md)() method.
```text
public CompoundObjectId DependentOnCompoundObject;
```
