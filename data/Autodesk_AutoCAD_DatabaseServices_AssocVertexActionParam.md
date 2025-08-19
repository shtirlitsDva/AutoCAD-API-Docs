# AssocVertexActionParam Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocVertexActionParam](AcDbAssocVertexActionParam.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocVertexActionParam
```

```text
public class AssocVertexActionParam : AssocActionParam;
```

### Constructors

- [AssocVertexActionParam](#assocvertexactionparam)

### Methods

- [GetVertexRef](#getvertexref)
- [SetVertexRef](#setvertexref)

### Properties

- [DependentOnCompoundObject](#dependentoncompoundobject)


## Constructors Details

### AssocVertexActionParam

#### Description
This wraps the ObjectARX [AssocVertexActionParam::AcDbAssocVertexActionParam](AcDbAssocVertexActionParam__AcDbAssocVertexActionParam@AcDbAssocCreateImpObject.md)() method.
```text
public AssocVertexActionParam();
```

### GetVertexRef

#### Description
This wraps the ObjectARX AssocVertexActionParam::getVertexRef() method.
```text
public VertexRef GetVertexRef();
```

### SetVertexRef

#### Description
This wraps the ObjectARX AssocVertexActionParam::setVertexRef() method.
```text
public void SetVertexRef(
    VertexRef pointRef, 
    [MarshalAs(UnmanagedType.U1)] bool isReadDep, 
    [MarshalAs(UnmanagedType.U1)] bool isWriteDep
);
```

### DependentOnCompoundObject

#### Description
This wraps the ObjectARX [AcDbAssocVertexActionParam::getDependentOnCompoundObject](AcDbAssocVertexActionParam__getDependentOnCompoundObject@AcDbCompoundObjectId_@const.md)() method.
```text
public CompoundObjectId DependentOnCompoundObject;
```
