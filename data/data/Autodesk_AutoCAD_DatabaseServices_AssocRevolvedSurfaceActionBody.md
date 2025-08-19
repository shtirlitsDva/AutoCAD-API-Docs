# AssocRevolvedSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocRevolvedSurfaceActionBody](AcDbAssocRevolvedSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocRevolvedSurfaceActionBody
```

```text
public class AssocRevolvedSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocRevolvedSurfaceActionBody](#assocrevolvedsurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetRevolveAngle](#getrevolveangle)
- [SetRevolveAngle](#setrevolveangle)

### Properties

- [RevolveAngle](#revolveangle)


## Constructors Details

### AssocRevolvedSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocRevolvedSurfaceActionBody::AcDbAssocRevolvedSurfaceActionBody](AcDbAssocRevolvedSurfaceActionBody__AcDbAssocRevolvedSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocRevolvedSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocRevolvedSurfaceActionBody::createInstance](AcDbAssocRevolvedSurfaceActionBody__createInstance@AcDbObjectId_@AcDbPathRef_@AcDbPathRef_@double@double@AcDbRevolveOptions_@bool@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    PathRef revolvePath, 
    PathRef axisPath, 
    double angle, 
    double startAngle, 
    RevolveOptions revolveOptions, 
    [MarshalAs(UnmanagedType.U1)] bool flipAxisDirection, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

### GetRevolveAngle

#### Description
This wraps the ObjectARX [AcDbAssocRevolvedSurfaceActionBody::revolveAngle](AcDbAssocRevolvedSurfaceActionBody__revolveAngle@AcString_@AcString_@const.md)() method.
```text
public double GetRevolveAngle(
    out string expression, 
    out string evaluatorId
);
```

### SetRevolveAngle

#### Description
This wraps the ObjectARX [AcDbAssocRevolvedSurfaceActionBody::setRevolveAngle](AcDbAssocRevolvedSurfaceActionBody__setRevolveAngle@double@AcString_@AcString_.md)() method.
```text
public void SetRevolveAngle(
    double value, 
    string expression, 
    string evaluatorId
);
```

### RevolveAngle

#### Description
This wraps the ObjectARX [AcDbAssocRevolvedSurfaceActionBody::revolveAngle](AcDbAssocRevolvedSurfaceActionBody__revolveAngle@AcString_@AcString_@const.md)() and [AcDbAssocRevolvedSurfaceActionBody::setRevolveAngle](AcDbAssocRevolvedSurfaceActionBody__setRevolveAngle@double@AcString_@AcString_.md)() methods.
```text
public double RevolveAngle;
```
