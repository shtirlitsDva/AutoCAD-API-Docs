# GeometryOverrule Class

## Overview

#### Description
This .NET class wraps the ObjectARX class [AcDbGeometryOverrule](AcDbGeometryOverrule.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.GeometryOverrule
```

```text
public abstract class GeometryOverrule : Overrule;
```

### Methods

- [GetGeomExtents](#getgeomextents)
- [IntersectWith(Entity, Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, IntPtr, IntPtr)](#intersectwith(entity,-entity,-autodesk.autocad.databaseservices.intersect,-plane,-point3dcollection,-intptr,-intptr))
- [IntersectWith(Entity, Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, IntPtr, IntPtr)](#intersectwith(entity,-entity,-autodesk.autocad.databaseservices.intersect,-point3dcollection,-intptr,-intptr))
- [SetCustomFilter](#setcustomfilter)
- [SetExtensionDictionaryEntryFilter](#setextensiondictionaryentryfilter)
- [SetIdFilter](#setidfilter)
- [SetNoFilter](#setnofilter)
- [SetXDataFilter](#setxdatafilter)


## Methods Details

### GetGeomExtents

#### Description
This .NET method wraps the ObjectARX method [AcDbGeometryOverrule::getGeomExtents()](AcDbGeometryOverrule__getGeomExtents@AcDbEntity_@AcDbExtents_.md).
```text
public virtual Extents3d GetGeomExtents(
    Entity entity
);
```

### IntersectWith(Entity, Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Plane, Point3dCollection, IntPtr, IntPtr)

#### Description
This .NET method wraps the ObjectARX method: 
[AcDbGeometryOverrule::intersectWith (AcDbEntity*, AcDbEntity*, AcDb::Intersect, AcGePlane&, AcGePoint3dArray&, Adesk::GsMarker, Adesk::GsMarker)](AcDbGeometryOverrule__intersectWith@AcDbEntity_@AcDbEntity_@AcDb__Intersect@AcGePlane_@AcGePoint3dArray_@Adesk__GsMarker@Adesk__GsMarker.md).
```text
public virtual void IntersectWith(
    Entity entity, 
    Entity ent, 
    Autodesk.AutoCAD.DatabaseServices.Intersect intType, 
    Plane projPlane, 
    Point3dCollection points, 
    IntPtr thisGsMarker, 
    IntPtr otherGsMarker
);
```

### IntersectWith(Entity, Entity, Autodesk.AutoCAD.DatabaseServices.Intersect, Point3dCollection, IntPtr, IntPtr)

#### Description
This .NET method wraps the ObjectARX method: 
[AcDbGeometryOverrule::intersectWith (AcDbEntity*, AcDbEntity*, AcDb::Intersect, AcGePoint3dArray&, Adesk::GsMarker, Adesk::GsMarker)](AcDbGeometryOverrule__intersectWith@AcDbEntity_@AcDbEntity_@AcDb__Intersect@AcGePoint3dArray_@Adesk__GsMarker@Adesk__GsMarker.md).
```text
public virtual void IntersectWith(
    Entity entity, 
    Entity ent, 
    Autodesk.AutoCAD.DatabaseServices.Intersect intType, 
    Point3dCollection points, 
    IntPtr thisGsMarker, 
    IntPtr otherGsMarker
);
```

### SetCustomFilter

#### Description
Enables the use of the IsApplicable method in determining whether an overrule applies.
```text
public sealed override void SetCustomFilter();
```

#### See Also
[GeometryOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_GeometryOverrule_SetNoFilter.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

### SetExtensionDictionaryEntryFilter

#### Description
Enables the use of an extension dictionary lookup to determine whether overrules apply. 
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
[GeometryOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_GeometryOverrule_SetNoFilter.md)

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
[GeometryOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_GeometryOverrule_SetNoFilter.md)

### SetNoFilter

#### Description
Disables all of the filter methods (SetCustomFilter, SetExtensionDictionaryEntryFilter, SetIdFilter, SetXDataFilter) as well as the IsApplicable() method in determining whether an overrule applies.
```text
public sealed override void SetNoFilter();
```

#### See Also
[GeometryOverrule.SetCustomFilter Method](Autodesk_AutoCAD_DatabaseServices_GeometryOverrule_SetCustomFilter.md); [GeometryOverrule.SetExtensionDictionaryEntryFilter Method](Autodesk_AutoCAD_DatabaseServices_GeometryOverrule_SetExtensionDictionaryEntryFilter@string.md); [GeometryOverrule.SetIdFilter Method](Autodesk_AutoCAD_DatabaseServices_GeometryOverrule_SetIdFilter@ObjectId\[\].md); [GeometryOverrule.SetXDataFilter Method](Autodesk_AutoCAD_DatabaseServices_GeometryOverrule_SetXDataFilter@string.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md);

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
