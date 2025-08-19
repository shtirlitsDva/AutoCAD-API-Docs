# ObjectOverrule Class

## Overview

#### Description
This .NET class wraps the ObjectARX class [AcDbObjectOverrule](AcDbObjectOverrule.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.ObjectOverrule
```

```text
public abstract class ObjectOverrule : Overrule;
```

### Methods

- [Cancel](#cancel)
- [Close](#close)
- [DeepClone](#deepclone)
- [Erase](#erase)
- [Open](#open)
- [SetCustomFilter](#setcustomfilter)
- [SetExtensionDictionaryEntryFilter](#setextensiondictionaryentryfilter)
- [SetIdFilter](#setidfilter)
- [SetNoFilter](#setnofilter)
- [SetXDataFilter](#setxdatafilter)
- [WblockClone](#wblockclone)


## Methods Details

### Cancel

#### Description
This .NET method wraps the ObjectARX method [AcDbObjectOverrule::cancel()](AcDbObjectOverrule__cancel@AcDbObject_.md).
```text
public virtual void Cancel(
    DBObject dbObject
);
```

### Close

#### Description
This .NET method wraps the ObjectARX method [AcDbObjectOverrule::close()](AcDbObjectOverrule__close@AcDbObject_.md).
```text
public virtual void Close(
    DBObject dbObject
);
```

### DeepClone

#### Description
This .NET method wraps the ObjectARX method [AcDbObjectOverrule::deepClone()](AcDbObjectOverrule__deepClone@AcDbObject_@AcDbObject_@AcDbObject__@AcDbIdMapping_@Adesk__Boolean.md).
```text
public virtual DBObject DeepClone(
    DBObject dbObject, 
    DBObject ownerObject, 
    IdMapping idMap, 
    [MarshalAs(UnmanagedType.U1)] bool isPrimary
);
```

### Erase

#### Description
This .NET method wraps the ObjectARX method [AcDbObjectOverrule::erase()](AcDbObjectOverrule__erase@AcDbObject_@Adesk__Boolean.md).
```text
public virtual void Erase(
    DBObject dbObject, 
    [MarshalAs(UnmanagedType.U1)] bool erasing
);
```

### Open

#### Description
This .NET method wraps the ObjectARX method [AcDbObjectOverrule::open()](AcDbObjectOverrule__open@AcDbObject_@AcDb__OpenMode.md).
```text
public virtual void Open(
    DBObject dbObject, 
    Autodesk.AutoCAD.DatabaseServices.OpenMode mode
);
```

### SetCustomFilter

#### Description
Enables the use of the IsApplicable method in determining whether an overrule applies.
```text
public sealed override void SetCustomFilter();
```

#### See Also
[ObjectOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_ObjectOverrule_SetNoFilter.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[ObjectOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_ObjectOverrule_SetNoFilter.md)

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
[ObjectOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_ObjectOverrule_SetNoFilter.md)

### SetNoFilter

#### Description
Disables all of the filter methods (SetCustomFilter, SetExtensionDictionaryEntryFilter, SetIdFilter, SetXDataFilter) as well as the IsApplicable() method in determining whether an overrule applies.
```text
public sealed override void SetNoFilter();
```

#### See Also
[ObjectOverrule.SetCustomFilter Method](Autodesk_AutoCAD_DatabaseServices_ObjectOverrule_SetCustomFilter.md); [ObjectOverrule.SetExtensionDictionaryEntryFilter Method](Autodesk_AutoCAD_DatabaseServices_ObjectOverrule_SetExtensionDictionaryEntryFilter@string.md); [ObjectOverrule.SetIdFilter Method](Autodesk_AutoCAD_DatabaseServices_ObjectOverrule_SetIdFilter@ObjectId\[\].md); [ObjectOverrule.SetXDataFilter Method](Autodesk_AutoCAD_DatabaseServices_ObjectOverrule_SetXDataFilter@string.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[ObjectOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_ObjectOverrule_SetNoFilter.md)

### WblockClone

#### Description
This .NET method wraps the ObjectARX method [AcDbObjectOverrule::wblockClone()](AcDbObjectOverrule__wblockClone@AcDbObject_@AcRxObject_@AcDbObject__@AcDbIdMapping_@Adesk__Boolean.md).
```text
public virtual DBObject WblockClone(
    DBObject dbObject, 
    RXObject ownerObject, 
    IdMapping idMap, 
    [MarshalAs(UnmanagedType.U1)] bool isPrimary
);
```
