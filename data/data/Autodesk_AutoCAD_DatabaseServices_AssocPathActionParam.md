# AssocPathActionParam Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocPathActionParam](AcDbAssocPathActionParam.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionParam
        Autodesk.AutoCAD.DatabaseServices.AssocCompoundActionParam
            Autodesk.AutoCAD.DatabaseServices.AssocPathActionParam
```

```text
public class AssocPathActionParam : AssocCompoundActionParam;
```

### Constructors

- [AssocPathActionParam](#assocpathactionparam)

### Methods

- [GetEdgeRefArray](#getedgerefarray)
- [SetEdgeRefArray](#setedgerefarray)
- [UpdateEdgeRef](#updateedgeref)


## Constructors Details

### AssocPathActionParam

#### Description
This wraps the ObjectARX [AssocPathActionParam::AcDbAssocPathActionParam](AcDbAssocPathActionParam__AcDbAssocPathActionParam@AcDbAssocCreateImpObject.md)() method.
```text
public AssocPathActionParam();
```

### GetEdgeRefArray

#### Description
This wraps the ObjectARX [AssocPathActionParam::getEdgeRefArray](AcDbAssocPathActionParam__getEdgeRefArray@AcArray_AcArray_AcDbEdgeRef____@const.md)() method.
```text
public EdgeRef\[\]\[\] GetEdgeRefArray();
```

### SetEdgeRefArray

#### Description
This wraps the ObjectARX AssocPathActionParam::setEdgeRefArray() method.
```text
public void SetEdgeRefArray(
    EdgeRef\[\] edgeRef
);
```

### UpdateEdgeRef

#### Description
This wraps the ObjectARX [AssocPathActionParam::updateEdgeRef](AcDbAssocPathActionParam__updateEdgeRef@int@AcDbEdgeRef_.md)() method.
```text
public void UpdateEdgeRef(
    int index, 
    EdgeRef edge
);
```
