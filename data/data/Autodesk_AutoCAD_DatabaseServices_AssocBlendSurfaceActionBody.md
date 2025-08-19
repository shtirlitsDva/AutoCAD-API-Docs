# AssocBlendSurfaceActionBody Class

## Overview

#### Description
This is class Autodesk.AutoCAD.DatabaseServices.AssocBlendSurfaceActionBody.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocBlendSurfaceActionBody
```

```text
public class AssocBlendSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocBlendSurfaceActionBody](#assocblendsurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetContinuityGripPoints](#getcontinuitygrippoints)
- [GetEndEdgeBulge](#getendedgebulge)
- [GetEndEdgeContinuity](#getendedgecontinuity)
- [GetProfiles](#getprofiles)
- [GetStartEdgeBulge](#getstartedgebulge)
- [GetStartEdgeContinuity](#getstartedgecontinuity)
- [SetEndEdgeBulge](#setendedgebulge)
- [SetEndEdgeContinuity](#setendedgecontinuity)
- [SetStartEdgeBulge](#setstartedgebulge)
- [SetStartEdgeContinuity](#setstartedgecontinuity)

### Properties

- [BlendOption](#blendoption)
- [EndEdgeBulge](#endedgebulge)
- [EndEdgeContinuity](#endedgecontinuity)
- [StartEdgeBulge](#startedgebulge)
- [StartEdgeContinuity](#startedgecontinuity)


## Constructors Details

### AssocBlendSurfaceActionBody

#### Description
This wraps the ObjectARX[AcDbAssocBlendSurfaceActionBody::AcDbAssocBlendSurfaceActionBody](AcDbAssocBlendSurfaceActionBody__AcDbAssocBlendSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocBlendSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::createInstance](AcDbAssocBlendSurfaceActionBody__createInstance@AcDbObjectId_@AcDbLoftProfile_@AcDbLoftProfile_@AcDbBlendOptions_@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    LoftProfile startProfile, 
    LoftProfile endProfile, 
    BlendOptions blendOptions, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```

### GetContinuityGripPoints

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::getContinuityGripPoints](AcDbAssocBlendSurfaceActionBody__getContinuityGripPoints@AcGePoint3d_@AcGePoint3d_@const.md)() method.
```text
public void GetContinuityGripPoints(
    out Point3d startEdgePt, 
    out Point3d endEdgePt
);
```

### GetEndEdgeBulge

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::endEdgeBulge](AcDbAssocBlendSurfaceActionBody__endEdgeBulge@AcString_@AcString_@const.md)() method.
```text
public double GetEndEdgeBulge(
    out string expression, 
    out string evaluatorId
);
```

### GetEndEdgeContinuity

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::endEdgeContinuity](AcDbAssocBlendSurfaceActionBody__endEdgeContinuity@AcString_@AcString_@const.md)() method.
```text
public short GetEndEdgeContinuity(
    out string expression, 
    out string evaluatorId
);
```

### GetProfiles

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::getProfiles](AcDbAssocBlendSurfaceActionBody__getProfiles@AcDbLoftProfile___@AcDbLoftProfile___@const.md)() method.
```text
public void GetProfiles(
    out LoftProfile startProfile, 
    out LoftProfile endProfile
);
```

### GetStartEdgeBulge

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::startEdgeBulge](AcDbAssocBlendSurfaceActionBody__startEdgeBulge@AcString_@AcString_@const.md)() method.
```text
public double GetStartEdgeBulge(
    out string expression, 
    out string evaluatorId
);
```

### GetStartEdgeContinuity

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::startEdgeContinuity](AcDbAssocBlendSurfaceActionBody__startEdgeContinuity@AcString_@AcString_@const.md)() method.
```text
public short GetStartEdgeContinuity(
    out string expression, 
    out string evaluatorId
);
```

### SetEndEdgeBulge

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::setEndEdgeBulge](AcDbAssocBlendSurfaceActionBody__setEndEdgeBulge@double@AcString_@AcString_.md) () method.
```text
public void SetEndEdgeBulge(
    double value, 
    string expression, 
    string evaluatorId
);
```

### SetEndEdgeContinuity

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::setEndEdgeContinuity](AcDbAssocBlendSurfaceActionBody__setEndEdgeContinuity@Adesk__Int16@AcString_@AcString_.md) () method.
```text
public void SetEndEdgeContinuity(
    short value, 
    string expression, 
    string evaluatorId
);
```

### SetStartEdgeBulge

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::setStartEdgeBulge](AcDbAssocBlendSurfaceActionBody__setStartEdgeBulge@double@AcString_@AcString_.md) () method.
```text
public void SetStartEdgeBulge(
    double value, 
    string expression, 
    string evaluatorId
);
```

### SetStartEdgeContinuity

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::setStartEdgeContinuity](AcDbAssocBlendSurfaceActionBody__setStartEdgeContinuity@Adesk__Int16@AcString_@AcString_.md) () method.
```text
public void SetStartEdgeContinuity(
    short value, 
    string expression, 
    string evaluatorId
);
```

### BlendOption

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::getBlendOptions](AcDbAssocBlendSurfaceActionBody__getBlendOptions@AcDbBlendOptions_@const.md)() and [AcDbAssocBlendSurfaceActionBody::setBlendOptions](AcDbAssocBlendSurfaceActionBody__setBlendOptions@AcDbBlendOptions_.md)() methods.
```text
public BlendOptions BlendOption;
```

### EndEdgeBulge

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::endEdgeBulge](AcDbAssocBlendSurfaceActionBody__endEdgeBulge@AcString_@AcString_@const.md)() and [AcDbAssocBlendSurfaceActionBody::setEndEdgeBulge](AcDbAssocBlendSurfaceActionBody__setEndEdgeBulge@double@AcString_@AcString_.md)() methods.
```text
public double EndEdgeBulge;
```

### EndEdgeContinuity

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::endEdgeContinuity](AcDbAssocBlendSurfaceActionBody__endEdgeContinuity@AcString_@AcString_@const.md)() and [AcDbAssocBlendSurfaceActionBody::setEndEdgeContinuity](AcDbAssocBlendSurfaceActionBody__setEndEdgeContinuity@Adesk__Int16@AcString_@AcString_.md) () methods.
```text
public short EndEdgeContinuity;
```

### StartEdgeBulge

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::startEdgeBulge](AcDbAssocBlendSurfaceActionBody__startEdgeBulge@AcString_@AcString_@const.md)() and [AcDbAssocBlendSurfaceActionBody::setStartEdgeBulge](AcDbAssocBlendSurfaceActionBody__setStartEdgeBulge@double@AcString_@AcString_.md)() methods.
```text
public double StartEdgeBulge;
```

### StartEdgeContinuity

#### Description
This wraps the ObjectARX [AcDbAssocBlendSurfaceActionBody::startEdgeContinuity](AcDbAssocBlendSurfaceActionBody__startEdgeContinuity@AcString_@AcString_@const.md)() and [AcDbAssocBlendSurfaceActionBody::setStartEdgeContinuity](AcDbAssocBlendSurfaceActionBody__setStartEdgeContinuity@Adesk__Int16@AcString_@AcString_.md) () methods.
```text
public short StartEdgeContinuity;
```
