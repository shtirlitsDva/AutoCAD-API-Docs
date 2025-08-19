# AssocPlaneSurfaceActionBody Class

## Overview

#### Description
This wraps the ObjectARX [AcDbAssocPlaneSurfaceActionBody](AcDbAssocPlaneSurfaceActionBody.md) class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.AssocActionBody
        Autodesk.AutoCAD.DatabaseServices.AssocParamBasedActionBody
            Autodesk.AutoCAD.DatabaseServices.AssocSurfaceActionBody
                Autodesk.AutoCAD.DatabaseServices.AssocPathBasedSurfaceActionBody
                    Autodesk.AutoCAD.DatabaseServices.AssocPlaneSurfaceActionBody
```

```text
public class AssocPlaneSurfaceActionBody : AssocPathBasedSurfaceActionBody;
```

### Constructors

- [AssocPlaneSurfaceActionBody](#assocplanesurfaceactionbody)

### Methods

- [CreateInstance](#createinstance)


## Constructors Details

### AssocPlaneSurfaceActionBody

#### Description
This wraps the ObjectARX [AcDbAssocPlaneSurfaceActionBody::AcDbAssocPlaneSurfaceActionBody](AcDbAssocPlaneSurfaceActionBody__AcDbAssocPlaneSurfaceActionBody@AcDbAssocCreateImpObject.md)() method.
```text
public AssocPlaneSurfaceActionBody();
```

### CreateInstance

#### Description
This wraps the ObjectARX [AcDbAssocPlaneSurfaceActionBody::createInstance](AcDbAssocPlaneSurfaceActionBody__createInstance@AcDbObjectId_@AcDbPathRef_@bool@AcDbObjectId_.md)() method.
```text
public static ObjectId CreateInstance(
    ObjectId resultingSurfaceId, 
    PathRef inputPath, 
    [MarshalAs(UnmanagedType.U1)] bool enable
);
```
