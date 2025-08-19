# OsnapOverrule Class

## Overview

#### Description
This .NET class wraps the ObjectARX class [AcDbOsnapOverrule](AcDbOsnapOverrule.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.OsnapOverrule
```

```text
public abstract class OsnapOverrule : Overrule;
```

### Methods

- [GetObjectSnapPoints(Entity, ObjectSnapModes, IntPtr, Point3d, Point3d, Matrix3d, Point3dCollection, IntegerCollection)](#getobjectsnappoints(entity,-objectsnapmodes,-intptr,-point3d,-point3d,-matrix3d,-point3dcollection,-integercollection))
- [GetObjectSnapPoints(Entity, ObjectSnapModes, IntPtr, Point3d, Point3d, Matrix3d, Point3dCollection, IntegerCollection, Matrix3d)](#getobjectsnappoints(entity,-objectsnapmodes,-intptr,-point3d,-point3d,-matrix3d,-point3dcollection,-integercollection,-matrix3d))
- [SetCustomFilter](#setcustomfilter)
- [SetExtensionDictionaryEntryFilter](#setextensiondictionaryentryfilter)
- [SetIdFilter](#setidfilter)
- [SetNoFilter](#setnofilter)
- [SetXDataFilter](#setxdatafilter)


## Methods Details

### GetObjectSnapPoints(Entity, ObjectSnapModes, IntPtr, Point3d, Point3d, Matrix3d, Point3dCollection, IntegerCollection)

#### Description
This .NET method wraps the ObjectARX method: 
[AcDbOsnapOverrule::getOsnapPoints (AcDbEntity*, AcDb::OsnapMode, Adesk::GsMarker, AcGePoint3d&, AcGePoint3d&, AcGeMatrix3d&, AcGePoint3dArray&, AcDbIntArray &)](AcDbOsnapOverrule__getOsnapPoints@AcDbEntity_@AcDb__OsnapMode@Adesk__GsMarker@AcGePoint3d_@AcGePoint3d_@AcGeMatrix3d_@AcGePoint3dArray_@AcDbIntArray__.md).
```text
public virtual void GetObjectSnapPoints(
    Entity entity, 
    ObjectSnapModes snapMode, 
    IntPtr gsSelectionMark, 
    Point3d pickPoint, 
    Point3d lastPoint, 
    Matrix3d viewTransform, 
    Point3dCollection snapPoints, 
    IntegerCollection geometryIds
);
```

### GetObjectSnapPoints(Entity, ObjectSnapModes, IntPtr, Point3d, Point3d, Matrix3d, Point3dCollection, IntegerCollection, Matrix3d)

#### Description
This .NET method wraps the ObjectARX method: 
[AcDbOsnapOverrule::getOsnapPoints (AcDbEntity*, AcDb::OsnapMode, Adesk::GsMarker, AcGePoint3d&, AcGePoint3d&, AcGeMatrix3d&, AcGePoint3dArray&, AcDbIntArray &, AcGeMatrix3d&)](AcDbOsnapOverrule__getOsnapPoints@AcDbEntity_@AcDb__OsnapMode@Adesk__GsMarker@AcGePoint3d_@AcGePoint3d_@AcGeMatrix3d_@AcGePoint3dArray_@AcDbIntArray__@AcGeMatrix3d_.md).
```text
public virtual void GetObjectSnapPoints(
    Entity entity, 
    ObjectSnapModes snapMode, 
    IntPtr gsSelectionMark, 
    Point3d pickPoint, 
    Point3d lastPoint, 
    Matrix3d viewTransform, 
    Point3dCollection snapPoints, 
    IntegerCollection geometryIds, 
    Matrix3d insertionMat
);
```

### SetCustomFilter

#### Description
Enables the use of the IsApplicable method in determining whether an overrule applies.
```text
public sealed override void SetCustomFilter();
```

#### See Also
[OsnapOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_OsnapOverrule_SetNoFilter.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

### SetExtensionDictionaryEntryFilter

#### Description
Enables the use of extension dictionary lookups to determine whether overrules apply. 
Use this method when you want AutoCAD to look for an extension dictionary entry with entryName on the overruled subject before calling any of your overrules. The overrules won't be called if entryName is not present in the extension dictionary.
```text
public sealed override void SetExtensionDictionaryEntryFilter(
    string entryName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string entryName | Input the name of the entry. |

#### See Also
[OsnapOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_OsnapOverrule_SetNoFilter.md)

### SetIdFilter

#### Description
Enables the use of id lookups to determine whether overrules apply. 
Use this method when you want AutoCAD to only call your overrule for objects with a matching id in ids.
```text
public sealed override void SetIdFilter(
    ObjectId\[\] ids
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId[] ids | Input an array of ObjectId. |

#### See Also
[OsnapOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_OsnapOverrule_SetNoFilter.md)

### SetNoFilter

#### Description
Disables all of the filter methods (SetCustomFilter, SetExtensionDictionaryEntryFilter, SetIdFilter, SetXDataFilter) as well as the IsApplicable() method in determining whether an overrule applies.
```text
public sealed override void SetNoFilter();
```

#### See Also
[OsnapOverrule.SetCustomFilter Method](Autodesk_AutoCAD_DatabaseServices_OsnapOverrule_SetCustomFilter.md); [OsnapOverrule.SetExtensionDictionaryEntryFilter Method](Autodesk_AutoCAD_DatabaseServices_OsnapOverrule_SetExtensionDictionaryEntryFilter@string.md); [OsnapOverrule.SetIdFilter Method](Autodesk_AutoCAD_DatabaseServices_OsnapOverrule_SetIdFilter@ObjectId\[\].md); [OsnapOverrule.SetXDataFilter Method](Autodesk_AutoCAD_DatabaseServices_OsnapOverrule_SetXDataFilter@string.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

### SetXDataFilter

#### Description
Enables the use of xdata in determining whether overrules apply. Use this method when you want AutoCAD to look for xdata with registeredApplicationName on the overruled subject before calling any of your overrules.
```text
public sealed override void SetXDataFilter(
    string registeredApplicationName
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| string registeredApplicationName | Input the name of the registered application. |

#### See Also
[OsnapOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_OsnapOverrule_SetNoFilter.md)