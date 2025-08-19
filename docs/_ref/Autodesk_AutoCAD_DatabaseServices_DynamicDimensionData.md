# DynamicDimensionData Class

## Overview

#### Description
This .NET class wraps the AcDbDimData ObjectARX class. 
The DynamicDimensionData class supports dynamic dimensions for objects derived from Entity. 
Dynamic dimensions are temporary Dimension objects that can be invoked and displayed when new database entities or grip-editing database-resident entities are created. DynamicDimensionData objects are usually created by an application or custom object and displayed and managed by AutoCAD.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DynamicDimensionData
```

```text
public sealed class DynamicDimensionData : DisposableWrapper;
```

### Constructors

- [DynamicDimensionData()](#dynamicdimensiondata())

### Properties

- [ApplicationData](#applicationdata)
- [Dimension](#dimension)
- [Editable](#editable)
- [Focal](#focal)
- [HideIfValueIsZero](#hideifvalueiszero)
- [Visible](#visible)


## Constructors Details

### DynamicDimensionData()

#### Description
Default constructor.
```text
public DynamicDimensionData();
public DynamicDimensionData(
    Autodesk.AutoCAD.DatabaseServices.Dimension dimension
);
public DynamicDimensionData(
    Autodesk.AutoCAD.DatabaseServices.Dimension dimension, 
    [MarshalAs(UnmanagedType.U1)] bool editable
);
public DynamicDimensionData(
    Autodesk.AutoCAD.DatabaseServices.Dimension dimension, 
    [MarshalAs(UnmanagedType.U1)] bool editable, 
    [MarshalAs(UnmanagedType.U1)] bool hideIfValueIsZero
);
```

### ApplicationData

#### Description
Accesses application-specific data associated with the object. 
The application data can be anything needed by the application. For example, the application can create application data to store the identifier for the dynamic dimension or a data structure describing the association between the custom entity and the dynamic dimension.
```text
public object ApplicationData;
```

#### Conditions
Read / Write
### Dimension

#### Description
Accesses the dynamic dimension object. It returns null if the application does not create a dynamic dimension and set the pointer.
```text
public Autodesk.AutoCAD.DatabaseServices.Dimension Dimension;
```

#### Conditions
Read / Write
### Editable

#### Description
Assesses if the object is editable. An editable dynamic dimension can be either an active or potential type. An informational type of dynamic dimension is not editable.
```text
public bool Editable;
```

#### Conditions
Read / Write
### Focal

#### Description
Accesses the current focus dynamic dimension; it returns false if this object is not the current focus.
```text
public bool Focal;
```

#### Conditions
Read / Write
### HideIfValueIsZero

#### Description
Returns true if the object is always invisible when its value is zero
```text
public bool HideIfValueIsZero;
```

#### Conditions
Read / Write
### Visible

#### Description
Returns true if the object is invisible; it returns false it is visible.
```text
public bool Visible;
```

#### Conditions
Read / Write