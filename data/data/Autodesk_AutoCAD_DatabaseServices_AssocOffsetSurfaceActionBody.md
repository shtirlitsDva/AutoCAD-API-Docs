# AssocOffsetSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocOffsetSurfaceActionBody](AcDbAssocOffsetSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocOffsetSurfaceActionBody
```

```text
public class AssocOffsetSurfaceActionBody : AssocSurfaceActionBody;
```

### Constructors

- [AssocOffsetSurfaceActionBody](#assocoffsetsurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetDistance](#getdistance)
- [SetDistance](#setdistance)

### Properties

- [Distance](#distance)


## Constructors Details

### AssocOffsetSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocOffsetSurfaceActionBody::AcDbAssocOffsetSurfaceActionBody](AcDbAssocOffsetSurfaceActionBody__AcDbAssocOffsetSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocOffsetSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocOffsetSurfaceActionBody::createInstance](AcDbAssocOffsetSurfaceActionBody__createInstance@AcDbObjectId_@AcDbObjectId_@double@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    ObjectId inputSurfaceId, 
    double distance, 
    [MarshalAs(UnmanagedType.U1)] bool bEnable
);
```

### GetDistance

#### Description
This wraps the ObjectARX [AcDbAssocOffsetSurfaceActionBody::distance](AcDbAssocOffsetSurfaceActionBody__distance@AcString_@AcString_@const.md)() method.
```text
public double GetDistance(
    out string expression, 
    out string evaluatorId
);
```

### SetDistance

#### Description
This wraps the ObjectARX [AcDbAssocOffsetSurfaceActionBody::setDistance](AcDbAssocOffsetSurfaceActionBody__setDistance@double@AcString_@AcString_.md)() method.
```text
public void SetDistance(
    double distance, 
    string expression, 
    string evaluatorId
);
```

### Distance

#### Description
This wraps the ObjectARX [AcDbAssocOffsetSurfaceActionBody::distance](AcDbAssocOffsetSurfaceActionBody__distance@AcString_@AcString_@const.md)() and [AcDbAssocOffsetSurfaceActionBody::setDistance](AcDbAssocOffsetSurfaceActionBody__setDistance@double@AcString_@AcString_.md) ()methods.
```text
public double Distance;
```
