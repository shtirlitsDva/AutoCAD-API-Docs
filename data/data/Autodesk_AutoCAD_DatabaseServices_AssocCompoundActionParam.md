# AssocCompoundActionParam Class

## Overview

#### Description
This is class Autodesk.AutoCAD.DatabaseServices.AssocCompoundActionParam.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocCompoundActionParam
            Autodesk.AutoCAD.DatabaseServices.AssocPathActionParam
```

```text
public class AssocCompoundActionParam : AssocActionParam;
```

### Constructors

- [AssocCompoundActionParam](#assoccompoundactionparam)

### Methods

- [AddParam](#addparam)
- [ParamAtIndex](#paramatindex)
- [ParamAtName(string)](#paramatname(string))
- [ParamAtName(string, int)](#paramatname(string,-int))
- [ParamsAtName](#paramsatname)
- [RemoveAllParams](#removeallparams)
- [RemoveParam](#removeparam)

### Properties

- [OwnedParams](#ownedparams)
- [ParamCount](#paramcount)


## Constructors Details

### AssocCompoundActionParam

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::AcDbAssocCompoundActionParam](AcDbAssocCompoundActionParam__AcDbAssocCompoundActionParam@AcDbAssocCreateImpObject.md)() method.
```text
public AssocCompoundActionParam();
```

### AddParam

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::addParam](AcDbAssocCompoundActionParam__addParam@AcDbObjectId_@int_.md) () method.
```text
public int AddParam(
    ObjectId paramId
);
```

### ParamAtIndex

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::paramAtIndex](AcDbAssocCompoundActionParam__paramAtIndex@int@const.md)() method.
```text
public ObjectId ParamAtIndex(
    int index
);
```

### ParamAtName(string)

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::paramAtName](AcDbAssocCompoundActionParam__paramAtName@AcString_@int@const.md)() method.
```text
public ObjectId ParamAtName(
    string paramName
);
```

### ParamAtName(string, int)

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::paramAtName](AcDbAssocCompoundActionParam__paramAtName@AcString_@int@const.md)() method.
```text
public ObjectId ParamAtName(
    string paramName, 
    int index
);
```

### ParamsAtName

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::paramsAtName](AcDbAssocCompoundActionParam__paramsAtName@AcString_@const.md) () method.
```text
public ObjectIdCollection ParamsAtName(
    string paramName
);
```

### RemoveAllParams

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::removeAllParams](AcDbAssocCompoundActionParam__removeAllParams@bool.md)() method.
```text
public void RemoveAllParams(
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseThem
);
```

### RemoveParam

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::removeParam](AcDbAssocCompoundActionParam__removeParam@AcDbObjectId_@bool.md) () method.
```text
public void RemoveParam(
    ObjectId paramId, 
    [MarshalAs(UnmanagedType.U1)] bool alsoEraseIt
);
```

### OwnedParams

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::ownedParams](AcDbAssocCompoundActionParam__ownedParams@const.md) () method.
```text
public ObjectIdCollection OwnedParams;
```

### ParamCount

#### Description
This wraps the ObjectARX [AssocCompoundActionParam::paramCount](AcDbAssocCompoundActionParam__paramCount@const.md)() method.
```text
public int ParamCount;
```
