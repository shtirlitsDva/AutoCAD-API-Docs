# AssocNetworkSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocNetworkSurfaceActionBody](AcDbAssocNetworkSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocNetworkSurfaceActionBody
```

```text
public class AssocNetworkSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocNetworkSurfaceActionBody](#assocnetworksurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetBulge(AssocLoftedSurfaceActionBody.ProfileType)](#getbulge(assocloftedsurfaceactionbody.profiletype))
- [GetBulge(AssocLoftedSurfaceActionBody.ProfileType, out string, out string)](#getbulge(assocloftedsurfaceactionbody.profiletype,-out-string,-out-string))
- [GetContinuity(AssocLoftedSurfaceActionBody.ProfileType)](#getcontinuity(assocloftedsurfaceactionbody.profiletype))
- [GetContinuity(AssocLoftedSurfaceActionBody.ProfileType, out string, out string)](#getcontinuity(assocloftedsurfaceactionbody.profiletype,-out-string,-out-string))
- [SetBulge(AssocLoftedSurfaceActionBody.ProfileType, double)](#setbulge(assocloftedsurfaceactionbody.profiletype,-double))
- [SetBulge(AssocLoftedSurfaceActionBody.ProfileType, double, string, string)](#setbulge(assocloftedsurfaceactionbody.profiletype,-double,-string,-string))
- [SetContinuity(AssocLoftedSurfaceActionBody.ProfileType, int)](#setcontinuity(assocloftedsurfaceactionbody.profiletype,-int))
- [SetContinuity(AssocLoftedSurfaceActionBody.ProfileType, int, string, string)](#setcontinuity(assocloftedsurfaceactionbody.profiletype,-int,-string,-string))


## Constructors Details

### AssocNetworkSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocNetworkSurfaceActionBody::AcDbAssocNetworkSurfaceActionBody](AcDbAssocNetworkSurfaceActionBody__AcDbAssocNetworkSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocNetworkSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocNetworkSurfaceActionBody::createInstance](AcDbAssocNetworkSurfaceActionBody__createInstance@AcDbObjectId_@AcArray_AcDbPathRef__@AcArray_AcDbPathRef__@AcArray_int__@AcArray_double__@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    PathRef\[\] crossSections, 
    PathRef\[\] guideCurves, 
    int\[\] continuityArray, 
    double\[\] bulgeArray, 
    [MarshalAs(UnmanagedType.U1)] bool bEnable
);
```

### GetBulge(AssocLoftedSurfaceActionBody.ProfileType)

#### Description
This wraps the ObjectARX [AcDbAssocNetworkSurfaceActionBody::getBulge](AcDbAssocNetworkSurfaceActionBody__getBulge@AcDbAssocLoftedSurfaceActionBody__ProfileType@double__@AcString_@AcString_@const.md)() method.
```text
public double GetBulge(
    AssocLoftedSurfaceActionBody.ProfileType type
);
```

### GetBulge(AssocLoftedSurfaceActionBody.ProfileType, out string, out string)

#### Description
This wraps the ObjectARX [AcDbAssocNetworkSurfaceActionBody::getBulge](AcDbAssocNetworkSurfaceActionBody__getBulge@AcDbAssocLoftedSurfaceActionBody__ProfileType@double__@AcString_@AcString_@const.md)() method.
```text
public double GetBulge(
    AssocLoftedSurfaceActionBody.ProfileType type, 
    out string expression, 
    out string evaluatorId
);
```

### GetContinuity(AssocLoftedSurfaceActionBody.ProfileType)

#### Description
This wraps the ObjectARX[AcDbAssocNetworkSurfaceActionBody::getContinuity](AcDbAssocNetworkSurfaceActionBody__getContinuity@AcDbAssocLoftedSurfaceActionBody__ProfileType@int__@AcString_@AcString_@const.md)() method.
```text
public int GetContinuity(
    AssocLoftedSurfaceActionBody.ProfileType type
);
```

### GetContinuity(AssocLoftedSurfaceActionBody.ProfileType, out string, out string)

#### Description
This wraps the ObjectARX[AcDbAssocNetworkSurfaceActionBody::getContinuity](AcDbAssocNetworkSurfaceActionBody__getContinuity@AcDbAssocLoftedSurfaceActionBody__ProfileType@int__@AcString_@AcString_@const.md)() method.
```text
public int GetContinuity(
    AssocLoftedSurfaceActionBody.ProfileType type, 
    out string expression, 
    out string evaluatorId
);
```

### SetBulge(AssocLoftedSurfaceActionBody.ProfileType, double)

#### Description
This wraps the ObjectARX [AcDbAssocNetworkSurfaceActionBody::setBulge](AcDbAssocNetworkSurfaceActionBody__setBulge@AcDbAssocLoftedSurfaceActionBody__ProfileType@double@AcString_@AcString_.md)() method.
```text
public void SetBulge(
    AssocLoftedSurfaceActionBody.ProfileType type, 
    double value
);
```

### SetBulge(AssocLoftedSurfaceActionBody.ProfileType, double, string, string)

#### Description
This wraps the ObjectARX [AcDbAssocNetworkSurfaceActionBody::setBulge](AcDbAssocNetworkSurfaceActionBody__setBulge@AcDbAssocLoftedSurfaceActionBody__ProfileType@double@AcString_@AcString_.md)() method.
```text
public void SetBulge(
    AssocLoftedSurfaceActionBody.ProfileType type, 
    double value, 
    string expression, 
    string evaluatorId
);
```

### SetContinuity(AssocLoftedSurfaceActionBody.ProfileType, int)

#### Description
This wraps the ObjectARX [AcDbAssocNetworkSurfaceActionBody::setContinuity](AcDbAssocNetworkSurfaceActionBody__setContinuity@AcDbAssocLoftedSurfaceActionBody__ProfileType@int@AcString_@AcString_.md)() method.
```text
public void SetContinuity(
    AssocLoftedSurfaceActionBody.ProfileType type, 
    int value
);
```

### SetContinuity(AssocLoftedSurfaceActionBody.ProfileType, int, string, string)

#### Description
This wraps the ObjectARX [AcDbAssocNetworkSurfaceActionBody::setContinuity](AcDbAssocNetworkSurfaceActionBody__setContinuity@AcDbAssocLoftedSurfaceActionBody__ProfileType@int@AcString_@AcString_.md)() method.
```text
public void SetContinuity(
    AssocLoftedSurfaceActionBody.ProfileType type, 
    int value, 
    string expression, 
    string evaluatorId
);
```
