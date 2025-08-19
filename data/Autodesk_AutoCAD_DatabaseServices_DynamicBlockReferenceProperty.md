# DynamicBlockReferenceProperty Class

## Overview

#### Description
This .NET class wraps the AcDbDynBlockReferenceProperty ObjectARX class. 
This class encapsulates a property on a dynamic block reference, and provides a mutator for the property's value.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DynamicBlockReferenceProperty
```

```text
public sealed class DynamicBlockReferenceProperty;
```

### Methods

- [GetAllowedValues](#getallowedvalues)

### Properties

- [BlockId](#blockid)
- [Description](#description)
- [PropertyName](#propertyname)
- [PropertyTypeCode](#propertytypecode)
- [ReadOnly](#readonly)
- [Show](#show)
- [UnitsType](#unitstype)
- [Value](#value)
- [VisibleInCurrentVisibilityState](#visibleincurrentvisibilitystate)


## Methods Details

### GetAllowedValues

#### Description
Returns the allowed values for the property.
```text
public object\[\] GetAllowedValues();
```

### BlockId

#### Description
Accesses the ObjectId of the dynamic block reference containing the property represented by the DynamicBlockReferenceProperty.
```text
public ObjectId BlockId;
```

#### Conditions
Read-only
### Description

#### Description
Accesses the property description.
```text
public string Description;
```

#### Conditions
Read-only
### PropertyName

#### Description
Accesses the name of the property.
```text
public string PropertyName;
```

#### Conditions
Read-only
### PropertyTypeCode

#### Description
Accesses the property type.
```text
public short PropertyTypeCode;
```

#### Conditions
Read-only
### ReadOnly

#### Description
Assesses whether the property is read only.
```text
public bool ReadOnly;
```

#### Conditions
Read-only
### Show

#### Description
Accesses
```text
public bool Show;
```

#### Conditions
Read-only
### UnitsType

#### Description
Accesses the format type of the property.
```text
public DynamicBlockReferencePropertyUnitsType UnitsType;
```

#### Conditions
Read-only
### Value

#### Description
Accesses the current value of the property on the block.
```text
public object Value;
```

#### Conditions
Read / Write
### VisibleInCurrentVisibilityState

#### Description
Indicates whether the property is visible in the current visibility state.
```text
public bool VisibleInCurrentVisibilityState;
```

#### Conditions
Read-only