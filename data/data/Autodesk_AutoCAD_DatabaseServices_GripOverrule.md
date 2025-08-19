# GripOverrule Class

## Overview

#### Description
This .NET class wraps the ObjectARX class [AcDbGripOverrule](AcDbGripOverrule.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GripOverrule
```

```text
public abstract class GripOverrule : Overrule;
```

### Methods

- [GetGripPoints(Entity, GripDataCollection, double, int, Vector3d, GetGripPointsFlags)](#getgrippoints(entity,-gripdatacollection,-double,-int,-vector3d,-getgrippointsflags))
- [GetGripPoints(Entity, Point3dCollection, IntegerCollection, IntegerCollection)](#getgrippoints(entity,-point3dcollection,-integercollection,-integercollection))
- [GetStretchPoints](#getstretchpoints)
- [MoveGripPointsAt(Entity, GripDataCollection, Vector3d, MoveGripPointsFlags)](#movegrippointsat(entity,-gripdatacollection,-vector3d,-movegrippointsflags))
- [MoveGripPointsAt(Entity, IntegerCollection, Vector3d)](#movegrippointsat(entity,-integercollection,-vector3d))
- [MoveStretchPointsAt](#movestretchpointsat)
- [OnGripStatusChanged](#ongripstatuschanged)
- [SetCustomFilter](#setcustomfilter)
- [SetExtensionDictionaryEntryFilter](#setextensiondictionaryentryfilter)
- [SetIdFilter](#setidfilter)
- [SetNoFilter](#setnofilter)
- [SetXDataFilter](#setxdatafilter)


## Methods Details

### GetGripPoints(Entity, GripDataCollection, double, int, Vector3d, GetGripPointsFlags)

#### Description
This .NET method wraps the ObjectARX method: 
[AcDbGripOverrule::getGripPoints (AcDbEntity*, AcDbGripDataPtrArray&, double, int, AcGeVector3d&, int)](AcDbGripOverrule__getGripPoints@AcDbEntity_@AcDbGripDataPtrArray_@double@int@AcGeVector3d_@int.md).
```text
public virtual void GetGripPoints(
    Entity entity, 
    GripDataCollection grips, 
    double curViewUnitSize, 
    int gripSize, 
    Vector3d curViewDir, 
    GetGripPointsFlags bitFlags
);
```

### GetGripPoints(Entity, Point3dCollection, IntegerCollection, IntegerCollection)

#### Description
This .NET method wraps the ObjectARX method: 
[AcDbGripOverrule::getGripPoints (AcDbEntity*, AcGePoint3dArray&, AcDbIntArray &, AcDbIntArray &)](AcDbGripOverrule__getGripPoints@AcDbEntity_@AcGePoint3dArray_@AcDbIntArray__@AcDbIntArray__.md).
```text
public virtual void GetGripPoints(
    Entity entity, 
    Point3dCollection gripPoints, 
    IntegerCollection snapModes, 
    IntegerCollection geometryIds
);
```

### GetStretchPoints

#### Description
This .NET method wraps the ObjectARX method [AcDbGripOverrule::getStretchPoints()](AcDbGripOverrule__getStretchPoints@AcDbEntity_@AcGePoint3dArray_.md).
```text
public virtual void GetStretchPoints(
    Entity entity, 
    Point3dCollection stretchPoints
);
```

### MoveGripPointsAt(Entity, GripDataCollection, Vector3d, MoveGripPointsFlags)

#### Description
This .NET method wraps the ObjectARX method: 
[AcDbGripOverrule::moveGripPointsAt (AcDbEntity*, AcDbVoidPtrArray&, AcGeVector3d&, int)](AcDbGripOverrule__moveGripPointsAt@AcDbEntity_@AcDbVoidPtrArray_@AcGeVector3d_@int.md).
```text
public virtual void MoveGripPointsAt(
    Entity entity, 
    GripDataCollection grips, 
    Vector3d offset, 
    MoveGripPointsFlags bitFlags
);
```

### MoveGripPointsAt(Entity, IntegerCollection, Vector3d)

#### Description
This .NET method wraps the ObjectARX method: 
[AcDbGripOverrule::moveGripPointsAt (AcDbEntity*, AcDbIntArray &, AcGeVector3d&)](AcDbGripOverrule__moveGripPointsAt@AcDbEntity_@AcDbIntArray__@AcGeVector3d_.md).
```text
public virtual void MoveGripPointsAt(
    Entity entity, 
    IntegerCollection indices, 
    Vector3d offset
);
```

### MoveStretchPointsAt

#### Description
This .NET method wraps the ObjectARX method [AcDbGripOverrule::moveStretchPointsAt()](AcDbGripOverrule__moveStretchPointsAt@AcDbEntity_@AcDbIntArray__@AcGeVector3d_.md).
```text
public virtual void MoveStretchPointsAt(
    Entity entity, 
    IntegerCollection indices, 
    Vector3d offset
);
```

### OnGripStatusChanged

#### Description
This .NET method wraps the ObjectARX method [AcDbGripOverrule::gripStatus()](AcDbGripOverrule__gripStatus@AcDbEntity_@AcDb__GripStat.md).
```text
public virtual void OnGripStatusChanged(
    Entity entity, 
    GripStatus status
);
```

### SetCustomFilter

#### Description
Enables the use of the IsApplicable method in determining whether an overrule applies.
```text
public sealed override void SetCustomFilter();
```

#### See Also
[GripOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_GripOverrule_SetNoFilter.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[GripOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_GripOverrule_SetNoFilter.md)

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
[GripOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_GripOverrule_SetNoFilter.md)

### SetNoFilter

#### Description
Disables all of the filter methods (SetCustomFilter, SetExtensionDictionaryEntryFilter, SetIdFilter, SetXDataFilter) as well as the IsApplicable() method in determining whether an overrule applies.
```text
public sealed override void SetNoFilter();
```

#### See Also
[GripOverrule.SetCustomFilter Method](Autodesk_AutoCAD_DatabaseServices_GripOverrule_SetCustomFilter.md); [GripOverrule.SetExtensionDictionaryEntryFilter Method](Autodesk_AutoCAD_DatabaseServices_GripOverrule_SetExtensionDictionaryEntryFilter@string.md); [GripOverrule.SetIdFilter Method](Autodesk_AutoCAD_DatabaseServices_GripOverrule_SetIdFilter@ObjectId\[\].md); [GripOverrule.SetXDataFilter Method](Autodesk_AutoCAD_DatabaseServices_GripOverrule_SetXDataFilter@string.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
