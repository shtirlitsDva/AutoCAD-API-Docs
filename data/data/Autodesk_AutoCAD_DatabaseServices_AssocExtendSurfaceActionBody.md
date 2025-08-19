# AssocExtendSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocExtendSurfaceActionBody](AcDbAssocExtendSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocExtendSurfaceActionBody
```

```text
public class AssocExtendSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocExtendSurfaceActionBody](#assocextendsurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetDistance](#getdistance)
- [SetDistance](#setdistance)

### Properties

- [Distance](#distance)


## Constructors Details

### AssocExtendSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocExtendSurfaceActionBody::AcDbAssocExtendSurfaceActionBody](AcDbAssocExtendSurfaceActionBody__AcDbAssocExtendSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocExtendSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocExtendSurfaceActionBody::createInstance](AcDbAssocExtendSurfaceActionBody__createInstance@AcDbObjectId_@AcArray_AcDbEdgeRef__@double@AcDbSurface__EdgeExtensionType@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    EdgeRef\[\] extendEdges, 
    double distance, 
    Surface.EdgeExtensionType extendOption, 
    [MarshalAs(UnmanagedType.U1)] bool enabled
);
```

### GetDistance

#### Description
This wraps the ObjectARX [AcDbAssocExtendSurfaceActionBody::distance](AcDbAssocExtendSurfaceActionBody__distance@AcString_@AcString_@const.md)() method.
```text
public double GetDistance(
    out string expression, 
    out string evaluatorId
);
```

### SetDistance

#### Description
This wraps the ObjectARX [AcDbAssocExtendSurfaceActionBody::setDistance](AcDbAssocExtendSurfaceActionBody__setDistance@double@AcString_@AcString_.md)() method.
```text
public void SetDistance(
    double distance, 
    string expression, 
    string evaluatorId
);
```

### Distance

#### Description
This wraps the ObjectARX [AcDbAssocExtendSurfaceActionBody::distance](AcDbAssocExtendSurfaceActionBody__distance@AcString_@AcString_@const.md)() and [AcDbAssocExtendSurfaceActionBody::setDistance](AcDbAssocExtendSurfaceActionBody__setDistance@double@AcString_@AcString_.md)() methods.
```text
public double Distance;
```
