# AssocExtrudedSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocExtrudedSurfaceActionBody](AcDbAssocExtrudedSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocExtrudedSurfaceActionBody
```

```text
public class AssocExtrudedSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocExtrudedSurfaceActionBody](#assocextrudedsurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetHeight](#getheight)
- [GetTaperAngle](#gettaperangle)
- [SetHeight](#setheight)
- [SetTaperAngle](#settaperangle)

### Properties

- [Height](#height)
- [TaperAngle](#taperangle)


## Constructors Details

### AssocExtrudedSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocExtrudedSurfaceActionBody::AcDbAssocExtrudedSurfaceActionBody](AcDbAssocExtrudedSurfaceActionBody__AcDbAssocExtrudedSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocExtrudedSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX[AcDbAssocExtrudedSurfaceActionBody::createInstance](AcDbAssocExtrudedSurfaceActionBody__createInstance@AcDbObjectId_@AcDbPathRef_@AcGeVector3d_@AcDbSweepOptions_@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    PathRef inputPath, 
    Vector3d directionVec, 
    SweepOptions sweepOptions, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

### GetHeight

#### Description
This wraps the ObjectARX [AcDbAssocExtrudedSurfaceActionBody::height](AcDbAssocExtrudedSurfaceActionBody__height@AcString_@AcString_@const.md)() method.
```text
public double GetHeight(
    out string expression, 
    out string evaluatorId
);
```

### GetTaperAngle

#### Description
This wraps the ObjectARX [AcDbAssocExtrudedSurfaceActionBody::taperAngle](AcDbAssocExtrudedSurfaceActionBody__taperAngle@AcString_@AcString_@const.md)() method.
```text
public double GetTaperAngle(
    out string expression, 
    out string evaluatorId
);
```

### SetHeight

#### Description
This wraps the ObjectARX [AcDbAssocExtrudedSurfaceActionBody::setHeight](AcDbAssocExtrudedSurfaceActionBody__setHeight@double@AcString_@AcString_.md)() method.
```text
public void SetHeight(
    double height, 
    string expression, 
    string evaluatorId
);
```

### SetTaperAngle

#### Description
This wraps the ObjectARX [AcDbAssocExtrudedSurfaceActionBody::setTaperAngle](AcDbAssocExtrudedSurfaceActionBody__setTaperAngle@double@AcString_@AcString_.md)() method.
```text
public void SetTaperAngle(
    double taperAngle, 
    string expression, 
    string evaluatorId
);
```

### Height

#### Description
This wraps the ObjectARX [AcDbAssocExtrudedSurfaceActionBody::height](AcDbAssocExtrudedSurfaceActionBody__height@AcString_@AcString_@const.md)() and [AcDbAssocExtrudedSurfaceActionBody::setHeight](AcDbAssocExtrudedSurfaceActionBody__setHeight@double@AcString_@AcString_.md)() methods.
```text
public double Height;
```

### TaperAngle

#### Description
This wraps the ObjectARX [AcDbAssocExtrudedSurfaceActionBody::taperAngle](AcDbAssocExtrudedSurfaceActionBody__taperAngle@AcString_@AcString_@const.md)() and [AcDbAssocExtrudedSurfaceActionBody::setTaperAngle](AcDbAssocExtrudedSurfaceActionBody__setTaperAngle@double@AcString_@AcString_.md)() methods.
```text
public double TaperAngle;
```
