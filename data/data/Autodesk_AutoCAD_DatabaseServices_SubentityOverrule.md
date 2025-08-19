# SubentityOverrule Class

## Overview

#### Description
This .NET class wraps the ObjectARX class [AcDbSubentityOverrule](AcDbSubentityOverrule.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.SubentityOverrule
```

```text
public abstract class SubentityOverrule : Overrule;
```

### Methods

- [AddSubentPaths](#addsubentpaths)
- [DeleteSubentPaths](#deletesubentpaths)
- [GetCompoundObjectTransform](#getcompoundobjecttransform)
- [GetGripPointsAtSubentPath](#getgrippointsatsubentpath)
- [GetGsMarkersAtSubentPath](#getgsmarkersatsubentpath)
- [GetSubentClassId](#getsubentclassid)
- [GetSubentPathGeomExtents](#getsubentpathgeomextents)
- [GetSubentPathsAtGsMarker](#getsubentpathsatgsmarker)
- [MoveGripPointsAtSubentPaths](#movegrippointsatsubentpaths)
- [OnSubentGripStatusChanged](#onsubentgripstatuschanged)
- [SetCustomFilter](#setcustomfilter)
- [SetExtensionDictionaryEntryFilter](#setextensiondictionaryentryfilter)
- [SetIdFilter](#setidfilter)
- [SetNoFilter](#setnofilter)
- [SetXDataFilter](#setxdatafilter)
- [SubentPtr](#subentptr)
- [TransformSubentPathsBy](#transformsubentpathsby)


## Methods Details

### AddSubentPaths

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::addSubentPaths()](AcDbSubentityOverrule__addSubentPaths@AcDbEntity_@AcDbFullSubentPathArray_.md).
```text
public virtual void AddSubentPaths(
    Entity entity, 
    FullSubentityPath\[\] paths
);
```

### DeleteSubentPaths

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::deleteSubentPaths()](AcDbSubentityOverrule__deleteSubentPaths@AcDbEntity_@AcDbFullSubentPathArray_.md).
```text
public virtual void DeleteSubentPaths(
    Entity entity, 
    FullSubentityPath\[\] paths
);
```

### GetCompoundObjectTransform

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::getCompoundObjectTransform()](AcDbSubentityOverrule__getCompoundObjectTransform@AcDbEntity_@AcGeMatrix3d__.md).
```text
public virtual Matrix3d GetCompoundObjectTransform(
    Entity entity
);
```

### GetGripPointsAtSubentPath

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::getGripPointsAtSubentPath()](AcDbSubentityOverrule__getGripPointsAtSubentPath@AcDbEntity_@AcDbFullSubentPath_@AcDbGripDataPtrArray_@double@int@AcGeVector3d_@int.md).
```text
public virtual void GetGripPointsAtSubentPath(
    Entity entity, 
    FullSubentityPath subPath, 
    GripDataCollection grips, 
    double curViewUnitSize, 
    int gripSize, 
    Vector3d curViewDir, 
    GetGripPointsFlags bitFlags
);
```

### GetGsMarkersAtSubentPath

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::getGsMarkersAtSubentPath()](AcDbSubentityOverrule__getGsMarkersAtSubentPath@AcDbEntity_@AcDbFullSubentPath_@AcArray_Adesk__GsMarker__.md).
```text
public virtual IntPtr\[\] GetGsMarkersAtSubentPath(
    Entity entity, 
    FullSubentityPath subPath
);
```

### GetSubentClassId

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::getSubentClassId()](AcDbSubentityOverrule__getSubentClassId@AcDbEntity_@AcDbFullSubentPath_@CLSID_.md).
```text
public virtual Guid GetSubentClassId(
    Entity entity, 
    FullSubentityPath path
);
```

### GetSubentPathGeomExtents

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::getSubentPathGeomExtents()](AcDbSubentityOverrule__getSubentPathGeomExtents@AcDbEntity_@AcDbFullSubentPath_@AcDbExtents_.md).
```text
public virtual Extents3d GetSubentPathGeomExtents(
    Entity entity, 
    FullSubentityPath path
);
```

### GetSubentPathsAtGsMarker

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::getSubentPathsAtGsMarker()](AcDbSubentityOverrule__getSubentPathsAtGsMarker@AcDbEntity_@AcDb__SubentType@Adesk__GsMarker@AcGePoint3d_@AcGeMatrix3d_@int_@AcDbFullSubentPath__@int@AcDbObjectId_.md).
```text
public virtual FullSubentityPath\[\] GetSubentPathsAtGsMarker(
    Entity entity, 
    SubentityType type, 
    IntPtr gsMark, 
    Point3d pickPoint, 
    Matrix3d viewXform, 
    ObjectId\[\] entAndInsertStack
);
```

### MoveGripPointsAtSubentPaths

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::moveGripPointsAtSubentPaths()](AcDbSubentityOverrule__moveGripPointsAtSubentPaths@AcDbEntity_@AcDbFullSubentPathArray_@AcDbVoidPtrArray_@AcGeVector3d_@int.md).
```text
public virtual void MoveGripPointsAtSubentPaths(
    Entity entity, 
    FullSubentityPath\[\] path, 
    GripDataCollection grips, 
    Vector3d offset, 
    MoveGripPointsFlags bitFlags
);
```

### OnSubentGripStatusChanged

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::subentGripStatus()](AcDbSubentityOverrule__subentGripStatus@AcDbEntity_@AcDb__GripStat@AcDbFullSubentPath_.md)
```text
public virtual void OnSubentGripStatusChanged(
    Entity entity, 
    GripStatus status, 
    FullSubentityPath subentity
);
```

### SetCustomFilter

#### Description
Enables the use of the IsApplicable method in determining whether an overrule applies.
```text
public sealed override void SetCustomFilter();
```

#### See Also
[SubentityOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_SubentityOverrule_SetNoFilter.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[SubentityOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_SubentityOverrule_SetNoFilter.md)

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
[SubentityOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_SubentityOverrule_SetNoFilter.md)

### SetNoFilter

#### Description
Disables all of the filter methods (SetCustomFilter, SetExtensionDictionaryEntryFilter, SetIdFilter, SetXDataFilter) as well as the IsApplicable() method in determining whether an overrule applies.
```text
public sealed override void SetNoFilter();
```

#### See Also
[SubentityOverrule.SetCustomFilter Method](Autodesk_AutoCAD_DatabaseServices_SubentityOverrule_SetCustomFilter.md); [SubentityOverrule.SetExtensionDictionaryEntryFilter Method](Autodesk_AutoCAD_DatabaseServices_SubentityOverrule_SetExtensionDictionaryEntryFilter@string.md); [SubentityOverrule.SetIdFilter Method](Autodesk_AutoCAD_DatabaseServices_SubentityOverrule_SetIdFilter@ObjectId\[\].md); [SubentityOverrule.SetXDataFilter Method](Autodesk_AutoCAD_DatabaseServices_SubentityOverrule_SetXDataFilter@string.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[SubentityOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_SubentityOverrule_SetNoFilter.md)

### SubentPtr

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::subentPtr()](AcDbSubentityOverrule__subentPtr@AcDbEntity_@AcDbFullSubentPath_.md).
```text
public virtual Entity SubentPtr(
    Entity entity, 
    FullSubentityPath id
);
```

### TransformSubentPathsBy

#### Description
This .NET method wraps the ObjectARX method [AcDbSubentityOverrule::transformSubentPathsBy()](AcDbSubentityOverrule__transformSubentPathsBy@AcDbEntity_@AcDbFullSubentPathArray_@AcGeMatrix3d_.md).
```text
public virtual void TransformSubentPathsBy(
    Entity entity, 
    FullSubentityPath\[\] paths, 
    Matrix3d xform
);
```
