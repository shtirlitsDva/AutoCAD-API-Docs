# TransformOverrule Class

## Overview

#### Description
This .NET class wraps the ObjectARX class [AcDbTransformOverrule](AcDbTransformOverrule.md).
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.TransformOverrule
```

```text
public abstract class TransformOverrule : Overrule;
```

### Methods

- [CloneMeForDragging](#clonemefordragging)
- [Explode](#explode)
- [GetTransformedCopy](#gettransformedcopy)
- [HideMeForDragging](#hidemefordragging)
- [SetCustomFilter](#setcustomfilter)
- [SetExtensionDictionaryEntryFilter](#setextensiondictionaryentryfilter)
- [SetIdFilter](#setidfilter)
- [SetNoFilter](#setnofilter)
- [SetXDataFilter](#setxdatafilter)
- [TransformBy](#transformby)


## Methods Details

### CloneMeForDragging

#### Description
This .NET method wraps the ObjectARX method [AcDbTransformOverrule::cloneMeForDragging()](AcDbTransformOverrule__cloneMeForDragging@AcDbEntity_.md).
```text
public virtual bool CloneMeForDragging(
    Entity entity
);
```

### Explode

#### Description
This .NET method wraps the ObjectARX method [AcDbTransformOverrule::explode()](AcDbTransformOverrule__explode@AcDbEntity_@AcDbVoidPtrArray_.md).
```text
public virtual void Explode(
    Entity entity, 
    DBObjectCollection entitySet
);
```

### GetTransformedCopy

#### Description
This .NET method wraps the ObjectARX method [AcDbTransformOverrule::getTransformedCopy()](AcDbTransformOverrule__getTransformedCopy@AcDbEntity_@AcGeMatrix3d_@AcDbEntity__.md).
```text
public virtual Entity GetTransformedCopy(
    Entity entity, 
    Matrix3d transform
);
```

### HideMeForDragging

#### Description
This .NET method wraps the ObjectARX method [AcDbTransformOverrule::hideMeForDragging()](AcDbTransformOverrule__hideMeForDragging@AcDbEntity_.md).
```text
public virtual bool HideMeForDragging(
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
[TransformOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_TransformOverrule_SetNoFilter.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[TransformOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_TransformOverrule_SetNoFilter.md)

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
[TransformOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_TransformOverrule_SetNoFilter.md)

### SetNoFilter

#### Description
Disables all of the filter methods (SetCustomFilter, SetExtensionDictionaryEntryFilter, SetIdFilter, SetXDataFilter) as well as the IsApplicable() method in determining whether an overrule applies.
```text
public sealed override void SetNoFilter();
```

#### See Also
[TransformOverrule.SetCustomFilter Method](Autodesk_AutoCAD_DatabaseServices_TransformOverrule_SetCustomFilter.md); [TransformOverrule.SetExtensionDictionaryEntryFilter Method](Autodesk_AutoCAD_DatabaseServices_TransformOverrule_SetExtensionDictionaryEntryFilter@string.md); [TransformOverrule.SetIdFilter Method](Autodesk_AutoCAD_DatabaseServices_TransformOverrule_SetIdFilter@ObjectId\[\].md); [TransformOverrule.SetXDataFilter Method](Autodesk_AutoCAD_DatabaseServices_TransformOverrule_SetXDataFilter@string.md); [Overrule.IsApplicable Method](Autodesk_AutoCAD_Runtime_Overrule_IsApplicable@RXObject.md)

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
[TransformOverrule.SetNoFilter Method](Autodesk_AutoCAD_DatabaseServices_TransformOverrule_SetNoFilter.md)

### TransformBy

#### Description
This .NET method wraps the ObjectARX method [AcDbTransformOverrule::transformBy()](AcDbTransformOverrule__transformBy@AcDbEntity_@AcGeMatrix3d_.md).
```text
public virtual void TransformBy(
    Entity entity, 
    Matrix3d transform
);
```
