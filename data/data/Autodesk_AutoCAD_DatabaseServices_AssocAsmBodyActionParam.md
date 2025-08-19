# AssocAsmBodyActionParam Class

## Overview

#### Description
This is class Autodesk.AutoCAD.DatabaseServices.AssocAsmBodyActionParam.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocAsmBodyActionParam
```

```text
public class AssocAsmBodyActionParam : AssocActionParam;
```

### Constructors

- [AssocAsmBodyActionParam](#assocasmbodyactionparam)

### Methods

- [SetBody(Entity, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#setbody(entity,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))
- [SetBody(ObjectId, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)](#setbody(objectid,-[marshalas(unmanagedtype.u1)]-bool,-[marshalas(unmanagedtype.u1)]-bool))

### Properties

- [DependentOnCompoundObject](#dependentoncompoundobject)


## Constructors Details

### AssocAsmBodyActionParam

#### Description
This wraps the ObjectARX [AcDbAssocAsmBodyActionParam::AcDbAssocAsmBodyActionParam](AcDbAssocAsmBodyActionParam__AcDbAssocAsmBodyActionParam@AcDbAssocCreateImpObject.md)() method.
```text
public AssocAsmBodyActionParam();
```

### SetBody(Entity, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX AcDbAssocAsmBodyActionParam::setBody() method.
```text
public void SetBody(
    Entity entity, 
    [MarshalAs(UnmanagedType.U1)] bool isReadDep, 
    [MarshalAs(UnmanagedType.U1)] bool isWriteDep
);
```

### SetBody(ObjectId, [MarshalAs(UnmanagedType.U1)] bool, [MarshalAs(UnmanagedType.U1)] bool)

#### Description
This wraps the ObjectARX AcDbAssocAsmBodyActionParam::setBody() method.
```text
public void SetBody(
    ObjectId bodyId, 
    [MarshalAs(UnmanagedType.U1)] bool isReadDep, 
    [MarshalAs(UnmanagedType.U1)] bool isWriteDep
);
```

### DependentOnCompoundObject

#### Description
This wraps the ObjectARX [AcDbAssocAsmBodyActionParam::getDependentOnCompoundObject](AcDbAssocAsmBodyActionParam__getDependentOnCompoundObject@AcDbCompoundObjectId_@const.md)() method.
```text
public CompoundObjectId DependentOnCompoundObject;
```
