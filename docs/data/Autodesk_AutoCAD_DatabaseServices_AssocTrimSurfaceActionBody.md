# AssocTrimSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocTrimSurfaceActionBody](AcDbAssocTrimSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocTrimSurfaceActionBody
```

```text
public class AssocTrimSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocTrimSurfaceActionBody](#assoctrimsurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [MakeTrimPermanent](#maketrimpermanent)
- [SetTrimInfo](#settriminfo)
- [Untrim](#untrim)

### Properties

- [TrimmedArea](#trimmedarea)


## Constructors Details

### AssocTrimSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocTrimSurfaceActionBody::AcDbAssocTrimSurfaceActionBody](AcDbAssocTrimSurfaceActionBody__AcDbAssocTrimSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocTrimSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocTrimSurfaceActionBody::createInstance](AcDbAssocTrimSurfaceActionBody__createInstance@AcDbObjectId_@AcArray_AcDbSurfaceTrimInfo__@bool@bool@AcDbObjectIdArray_.md)() method.
```text
public static ObjectIdCollection CreateInstance(
    ObjectId resultingSurfaceId, 
    SurfaceTrimInfo\[\] trimInfo, 
    [MarshalAs(UnmanagedType.U1)] bool autoExtend, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

### MakeTrimPermanent

#### Description
This wraps the ObjectARX [AcDbAssocTrimSurfaceActionBody::makeTrimPermanent](AcDbAssocTrimSurfaceActionBody__makeTrimPermanent.md)() method.
```text
public void MakeTrimPermanent();
```

### SetTrimInfo

#### Description
This wraps the ObjectARX [AcDbAssocTrimSurfaceActionBody::setTrimInfo](AcDbAssocTrimSurfaceActionBody__setTrimInfo@AcArray_AcDbSurfaceTrimInfo_@bool.md)() method.
```text
public void SetTrimInfo(
    SurfaceTrimInfo\[\] trimInfoArray, 
    [MarshalAs(UnmanagedType.U1)] bool autoExtend
);
```

### Untrim

#### Description
This wraps the ObjectARX [AcDbAssocTrimSurfaceActionBody::untrim](AcDbAssocTrimSurfaceActionBody__untrim.md)() method.
```text
public void Untrim();
```

### TrimmedArea

#### Description
This wraps the ObjectARX [AcDbAssocTrimSurfaceActionBody::getTrimmedArea](AcDbAssocTrimSurfaceActionBody__getTrimmedArea@const.md)() method.
```text
public double TrimmedArea;
```
