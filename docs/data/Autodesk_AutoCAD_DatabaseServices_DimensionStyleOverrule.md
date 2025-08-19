# DimensionStyleOverrule Class

## Overview

#### Description
This .NET class wraps ObjectARX class AcDbDimensionStyleOverrule. it overrules a subset of dimension style related operations that Dimension (AcDbDimension) class specifies. It is intended as a base class for clients who want to alter some or all behavior of a given AcDbDimension-derived class. At the base level, each default implementation simply calls the corresponding method in the target class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DimensionStyleOverrule
```

```text
public abstract class DimensionStyleOverrule : Overrule;
```

### Methods

- [DimensionStyle](#dimensionstyle)
- [GetDimstyleData](#getdimstyledata)
- [SetCustomFilter](#setcustomfilter)
- [SetDimensionStyle](#setdimensionstyle)
- [SetDimstyleData(Dimension, DimStyleTableRecord)](#setdimstyledata(dimension,-dimstyletablerecord))
- [SetDimstyleData(Dimension, ObjectId)](#setdimstyledata(dimension,-objectid))
- [SetExtensionDictionaryEntryFilter](#setextensiondictionaryentryfilter)
- [SetIdFilter](#setidfilter)
- [SetNoFilter](#setnofilter)
- [SetXDataFilter](#setxdatafilter)


## Methods Details

### DimensionStyle

#### Description
This .NET method wraps the ObjectARX [AcDbDimensionStyleOverrule::dimensionStyle Method](AcDbDimensionStyleOverrule__dimensionStyle@AcDbDimension_.md)
```text
public virtual ObjectId DimensionStyle(
    Dimension dimension
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Dimension dimension | Dimension that this overrule is applied against. |

#### Returns
The object ID of the DimStyleTableRecord referenced by the dimension.
### GetDimstyleData

#### Description
This .NET method wraps the ObjectARX [AcDbDimensionStyleOverrule::getDimstyleData Method](AcDbDimensionStyleOverrule__getDimstyleData@AcDbDimension_@AcDbDimStyleTableRecord__.md).
```text
public virtual void GetDimstyleData(
    Dimension dimension, 
    DimStyleTableRecord style
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Dimension dimension | Dimension that this overrule is applied against. |
| DimStyleTableRecord style | Existing DimStyleTableRecord to which the dimension variable data will be copied. |

### SetCustomFilter

#### Description
Enables the use of the IsApplicable method in determining whether an overrule applies.
```text
public sealed override void SetCustomFilter();
```

#### See Also
DimensionStyleOverrule.SetNoFilter Method; DimensionStyleOverrule.IsApplicable Method

### SetDimensionStyle

#### Description
This .NET method wraps the ObjectARX [AcDbDimensionStyleOverrule::setDimensionStyle Method](AcDbDimensionStyleOverrule__setDimensionStyle@AcDbDimension_@AcDbObjectId.md).
```text
public virtual void SetDimensionStyle(
    Dimension dimension, 
    ObjectId id
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Dimension dimension | Dimension that this overrule is applied against. |
| ObjectId id | Input the object ID of the desired DimStyleTableRecord to be used by the dimension. |

#### Returns
Acad::ErrorStatus.
### SetDimstyleData(Dimension, DimStyleTableRecord)

#### Description
This .NET method wraps the ObjectARX [AcDbDimensionStyleOverrule::setDimstyleData Method](AcDbDimensionStyleOverrule__setDimstyleData@AcDbDimension_@AcDbDimStyleTableRecord_.md).
```text
public virtual void SetDimstyleData(
    Dimension dimension, 
    DimStyleTableRecord style
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Dimension dimension | Dimension that this overrule is applied against. |
| DimStyleTableRecord style | DimStyleTableRecord from which to copy the dimension variable information. |

### SetDimstyleData(Dimension, ObjectId)

#### Description
This .NET method wraps the ObjectARX method [AcDbDimensionStyleOverrule::setDimstyleData Method](AcDbDimensionStyleOverrule__setDimstyleData@AcDbDimension_@AcDbObjectId.md)
```text
public virtual void SetDimstyleData(
    Dimension dimension, 
    ObjectId dimstyleId
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| Dimension dimension | Dimension that this overrule is applied against. |
| ObjectId dimstyleId | Object ID of DimStyleTableRecord from which to copy dimension variable information. |

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
| string entryName | Name of dictionary entry. |

#### See Also
DimensionStyleOverrule.SetNoFilter Method

### SetIdFilter

#### Description
Enables the use of id lookups to determine whether overrules apply. 
Use this method when you want AutoCAD to only call your overrule for objects with a matching id in _ids_.
```text
public sealed override void SetIdFilter(
    ObjectId\[\] ids
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| ObjectId[] ids | Array of ids defining the lookup table |

#### See Also
DimensionStyleOverrule.SetNoFilter Method

### SetNoFilter

#### Description
Disables all of the filter methods (SetCustomFilter, SetExtensionDictionaryEntryFilter, SetIdFilter, SetXDataFilter) as well as the IsApplicable() method in determining whether an overrule applies.
```text
public sealed override void SetNoFilter();
```

#### See Also
DimensionStyleOverrule.SetCustomFilter Method; DimensionStyleOverrule.SetExtensionDictionaryEntryFilter Method; DimensionStyleOverrule.SetIdFilter Method; DimensionStyleOverrule.SetXDataFilter Method; DimensionStyleOverrule.IsApplicable Method

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
| string registeredApplicationName | Name of the registered application. |

#### See Also
DimensionStyleOverrule.SetNoFilter Method