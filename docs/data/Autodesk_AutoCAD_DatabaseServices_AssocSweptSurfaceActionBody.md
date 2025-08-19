# AssocSweptSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody](AcDbAssocSweptSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocSweptSurfaceActionBody
```

```text
public class AssocSweptSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocSweptSurfaceActionBody](#assocsweptsurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetAlignAngle](#getalignangle)
- [GetScaleFactor](#getscalefactor)
- [GetTwistAngle](#gettwistangle)
- [SetAlignAngle](#setalignangle)
- [SetScaleFactor](#setscalefactor)
- [SetTwistAngle](#settwistangle)

### Properties

- [AlignAngle](#alignangle)
- [ScaleFactor](#scalefactor)
- [TwistAngle](#twistangle)


## Constructors Details

### AssocSweptSurfaceActionBody

#### Description
This wraps the ObjectARX[AcDbAssocSweptSurfaceActionBody::AcDbAssocSweptSurfaceActionBody](AcDbAssocSweptSurfaceActionBody__AcDbAssocSweptSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocSweptSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody::createInstance](AcDbAssocSweptSurfaceActionBody__createInstance@AcDbObjectId_@AcDbPathRef_@AcDbPathRef_@AcDbSweepOptions_@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    PathRef sweptPath, 
    PathRef path, 
    SweepOptions sweptOptions, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

### GetAlignAngle

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody::alignAngle](AcDbAssocSweptSurfaceActionBody__alignAngle@AcString_@AcString_@const.md)() method.
```text
public double GetAlignAngle(
    out string expression, 
    out string evaluatorId
);
```

### GetScaleFactor

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody::scaleFactor](AcDbAssocSweptSurfaceActionBody__scaleFactor@AcString_@AcString_@const.md)() method.
```text
public double GetScaleFactor(
    out string expression, 
    out string evaluatorId
);
```

### GetTwistAngle

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody::twistAngle](AcDbAssocSweptSurfaceActionBody__twistAngle@AcString_@AcString_@const.md)() method.
```text
public double GetTwistAngle(
    out string expression, 
    out string evaluatorId
);
```

### SetAlignAngle

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody::setAlignAngle](AcDbAssocSweptSurfaceActionBody__setAlignAngle@double@AcString_@AcString_.md)() method.
```text
public void SetAlignAngle(
    double value, 
    string expression, 
    string evaluatorId
);
```

### SetScaleFactor

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody::setScaleFactor](AcDbAssocSweptSurfaceActionBody__setScaleFactor@double@AcString_@AcString_.md)() method.
```text
public void SetScaleFactor(
    double value, 
    string expression, 
    string evaluatorId
);
```

### SetTwistAngle

#### Description
This wraps the ObjectARX[AcDbAssocSweptSurfaceActionBody::setTwistAngle](AcDbAssocSweptSurfaceActionBody__setTwistAngle@double@AcString_@AcString_.md)() method.
```text
public void SetTwistAngle(
    double value, 
    string expression, 
    string evaluatorId
);
```

### AlignAngle

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody::alignAngle](AcDbAssocSweptSurfaceActionBody__alignAngle@AcString_@AcString_@const.md)() and [AcDbAssocSweptSurfaceActionBody::setAlignAngle](AcDbAssocSweptSurfaceActionBody__setAlignAngle@double@AcString_@AcString_.md) ()methods.
```text
public double AlignAngle;
```

### ScaleFactor

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody::scaleFactor](AcDbAssocSweptSurfaceActionBody__scaleFactor@AcString_@AcString_@const.md)() and [AcDbAssocSweptSurfaceActionBody::setScaleFactor](AcDbAssocSweptSurfaceActionBody__setScaleFactor@double@AcString_@AcString_.md) () methods.
```text
public double ScaleFactor;
```

### TwistAngle

#### Description
This wraps the ObjectARX [AcDbAssocSweptSurfaceActionBody::twistAngle](AcDbAssocSweptSurfaceActionBody__twistAngle@AcString_@AcString_@const.md)() and [AcDbAssocSweptSurfaceActionBody::setTwistAngle](AcDbAssocSweptSurfaceActionBody__setTwistAngle@double@AcString_@AcString_.md) () methods.
```text
public double TwistAngle;
```
