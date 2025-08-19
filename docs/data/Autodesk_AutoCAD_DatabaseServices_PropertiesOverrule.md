# PropertiesOverrule Class

## Overview

#### Description
This .NET class wraps the ObjectARX class [AcDbPropertiesOverrule](AcDbPropertiesOverrule.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.PropertiesOverrule
```

```text
public abstract class PropertiesOverrule : Overrule;
```

### Methods

- [GetClassID](#getclassid)
- [List](#list)
- [SetCustomFilter](#setcustomfilter)
- [SetExtensionDictionaryEntryFilter](#setextensiondictionaryentryfilter)
- [SetIdFilter](#setidfilter)
- [SetNoFilter](#setnofilter)
- [SetXDataFilter](#setxdatafilter)


## Methods Details

### GetClassID

#### Description
This .NET method wraps the ObjectARX method [AcDbPropertiesOverrule::getClassID()](AcDbPropertiesOverrule__getClassID@AcDbObject_@CLSID_.md).
```text
public virtual Guid GetClassID(
    DBObject entity
);
```

### List

#### Description
This .NET method wraps the ObjectARX method [AcDbPropertiesOverrule::list()](AcDbPropertiesOverrule__list@AcDbEntity_.md).
```text
public virtual void List(
    Entity entity
);
```

### SetCustomFilter

#### Description
Enables the use of the IsApplicable method in determining whether an overrule applies.
```text
public sealed override void SetCustomFilter();
```

#### See Also
[PropertiesOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_PropertiesOverrule_SetNoFilter.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[PropertiesOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_PropertiesOverrule_SetNoFilter.md)

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
[PropertiesOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_PropertiesOverrule_SetNoFilter.md)

### SetNoFilter

#### Description
Disables all of the filter methods (SetCustomFilter, SetExtensionDictionaryEntryFilter, SetIdFilter, SetXDataFilter) as well as the IsApplicable() method in determining whether an overrule applies.
```text
public sealed override void SetNoFilter();
```

#### See Also
[PropertiesOverrule.SetCustomFilter Method](Autodesk_AutoCAD_DatabaseServices_PropertiesOverrule_SetCustomFilter.md); [PropertiesOverrule.SetExtensionDictionaryEntryFilter Method](Autodesk_AutoCAD_DatabaseServices_PropertiesOverrule_SetExtensionDictionaryEntryFilter@string.md); [PropertiesOverrule.SetIdFilter Method](Autodesk_AutoCAD_DatabaseServices_PropertiesOverrule_SetIdFilter@ObjectId\[\].md); [PropertiesOverrule.SetXDataFilter Method](Autodesk_AutoCAD_DatabaseServices_PropertiesOverrule_SetXDataFilter@string.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[PropertiesOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_PropertiesOverrule_SetNoFilter.md)