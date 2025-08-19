# HighlightOverrule Class

## Overview

#### Description
This .NET class wraps the ObjectARX class [AcDbHighlightOverrule](AcDbHighlightOverrule.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.HighlightOverrule
```

```text
public abstract class HighlightOverrule : Overrule;
```

### Methods

- [Highlight](#highlight)
- [SetCustomFilter](#setcustomfilter)
- [SetExtensionDictionaryEntryFilter](#setextensiondictionaryentryfilter)
- [SetIdFilter](#setidfilter)
- [SetNoFilter](#setnofilter)
- [SetXDataFilter](#setxdatafilter)
- [Unhighlight](#unhighlight)


## Methods Details

### Highlight

#### Description
This .NET method wraps the ObjectARX method [AcDbHighlightOverrule::highlight()](AcDbHighlightOverrule__highlight@AcDbEntity_@AcDbFullSubentPath_@Adesk__Boolean.md)
```text
public virtual void Highlight(
    Entity entity, 
    FullSubentityPath subId, 
    [MarshalAs(UnmanagedType.U1)] bool highlightAll
);
```

### SetCustomFilter

#### Description
Enables the use of the IsApplicable method in determining whether an overrule applies.
```text
public sealed override void SetCustomFilter();
```

#### See Also
[HighlightOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_HighlightOverrule_SetNoFilter.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[HighlightOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_HighlightOverrule_SetNoFilter.md)

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
[HighlightOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_HighlightOverrule_SetNoFilter.md)

### SetNoFilter

#### Description
Disables all of the filter methods (SetCustomFilter, SetExtensionDictionaryEntryFilter, SetIdFilter, SetXDataFilter) as well as the IsApplicable() method in determining whether an overrule applies.
```text
public sealed override void SetNoFilter();
```

#### See Also
[HighlightOverrule.SetCustomFilter Method](Autodesk_AutoCAD_DatabaseServices_HighlightOverrule_SetCustomFilter.md); [HighlightOverrule.SetExtensionDictionaryEntryFilter Method](Autodesk_AutoCAD_DatabaseServices_HighlightOverrule_SetExtensionDictionaryEntryFilter@string.md); [HighlightOverrule.SetIdFilter Method](Autodesk_AutoCAD_DatabaseServices_HighlightOverrule_SetIdFilter@ObjectId\[\].md); [HighlightOverrule.SetXDataFilter Method](Autodesk_AutoCAD_DatabaseServices_HighlightOverrule_SetXDataFilter@string.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[HighlightOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_HighlightOverrule_SetNoFilter.md)

### Unhighlight

#### Description
This .NET method wraps the ObjectARX method [AcDbHighlightOverrule::unhighlight()](AcDbHighlightOverrule__unhighlight@AcDbEntity_@AcDbFullSubentPath_@Adesk__Boolean.md).
```text
public virtual void Unhighlight(
    Entity entity, 
    FullSubentityPath subId, 
    [MarshalAs(UnmanagedType.U1)] bool highlightAll
);
```
