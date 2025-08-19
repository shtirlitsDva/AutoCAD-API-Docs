# AssocLoftedSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody](AcDbAssocLoftedSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocLoftedSurfaceActionBody
```

```text
public class AssocLoftedSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocLoftedSurfaceActionBody](#assocloftedsurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)
- [GetBulge(ProfileType)](#getbulge(profiletype))
- [GetBulge(ProfileType, out string, out string)](#getbulge(profiletype,-out-string,-out-string))
- [GetContinuity(ProfileType)](#getcontinuity(profiletype))
- [GetContinuity(ProfileType, out string, out string)](#getcontinuity(profiletype,-out-string,-out-string))
- [SetBulge(ProfileType, double)](#setbulge(profiletype,-double))
- [SetBulge(ProfileType, double, string, string)](#setbulge(profiletype,-double,-string,-string))
- [SetContinuity(ProfileType, int)](#setcontinuity(profiletype,-int))
- [SetContinuity(ProfileType, int, string, string)](#setcontinuity(profiletype,-int,-string,-string))

### Other

- [AutoCAD.DatabaseServices.AssocLoftedSurfaceActionBody.ProfileType Enumeration](#autocad.databaseservices.assocloftedsurfaceactionbody.profiletype-enumeration)


## Constructors Details

### AssocLoftedSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::AcDbAssocLoftedSurfaceActionBody](AcDbAssocLoftedSurfaceActionBody__AcDbAssocLoftedSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocLoftedSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::createInstance](AcDbAssocLoftedSurfaceActionBody__createInstance@AcDbObjectId_@AcArray_AcDbGeomRef____@AcArray_AcDbPathRef__@AcDbPathRef_@AcDbLoftOptions_@AcArray_int__@AcArray_double__@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    SubentRef\[\] crossSections, 
    PathRef\[\] guideCurves, 
    PathRef pathCurve, 
    LoftOptions loftOptions, 
    int\[\] continuityArray, 
    double\[\] bulgeArray, 
    [MarshalAs(UnmanagedType.U1)] bool bEnable
);
```

### GetBulge(ProfileType)

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::getBulge](AcDbAssocLoftedSurfaceActionBody__getBulge@ProfileType@double__@AcString_@AcString_@const.md)() method.
```text
public double GetBulge(
    ProfileType type
);
```

### GetBulge(ProfileType, out string, out string)

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::getBulge](AcDbAssocLoftedSurfaceActionBody__getBulge@ProfileType@double__@AcString_@AcString_@const.md)() method.
```text
public double GetBulge(
    ProfileType type, 
    out string expression, 
    out string evaluatorId
);
```

### GetContinuity(ProfileType)

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::getContinuity](AcDbAssocLoftedSurfaceActionBody__getContinuity@ProfileType@int__@AcString_@AcString_@const.md)() method.
```text
public int GetContinuity(
    ProfileType type
);
```

### GetContinuity(ProfileType, out string, out string)

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::getContinuity](AcDbAssocLoftedSurfaceActionBody__getContinuity@ProfileType@int__@AcString_@AcString_@const.md)() method.
```text
public int GetContinuity(
    ProfileType type, 
    out string expression, 
    out string evaluatorId
);
```

### SetBulge(ProfileType, double)

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::setBulge](AcDbAssocLoftedSurfaceActionBody__setBulge@ProfileType@double@AcString_@AcString_.md)() method.
```text
public void SetBulge(
    ProfileType type, 
    double value
);
```

### SetBulge(ProfileType, double, string, string)

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::setBulge](AcDbAssocLoftedSurfaceActionBody__setBulge@ProfileType@double@AcString_@AcString_.md)() method.
```text
public void SetBulge(
    ProfileType type, 
    double value, 
    string expression, 
    string evaluatorId
);
```

### SetContinuity(ProfileType, int)

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::setContinuity](AcDbAssocLoftedSurfaceActionBody__setContinuity@ProfileType@int@AcString_@AcString_.md)() method.
```text
public void SetContinuity(
    ProfileType type, 
    int value
);
```

### SetContinuity(ProfileType, int, string, string)

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::setContinuity](AcDbAssocLoftedSurfaceActionBody__setContinuity@ProfileType@int@AcString_@AcString_.md)() method.
```text
public void SetContinuity(
    ProfileType type, 
    int value, 
    string expression, 
    string evaluatorId
);
```

### AutoCAD.DatabaseServices.AssocLoftedSurfaceActionBody.ProfileType Enumeration

#### Description
This wraps the ObjectARX [AcDbAssocLoftedSurfaceActionBody::ProfileType](AcDbAssocLoftedSurfaceActionBody__ProfileType.md) enum.
```text
public enum ProfileType {
  EndCrossSection = 2,
  EndGuide = 8,
  StartCrossSection = 1,
  StartGuide = 4
}
```