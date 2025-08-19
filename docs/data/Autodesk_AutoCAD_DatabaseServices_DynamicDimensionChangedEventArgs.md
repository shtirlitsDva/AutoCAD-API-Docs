# DynamicDimensionChangedEventArgs Class

## Overview

#### Description
This class provides data for the OnDimensionValueChanged function of the Jig class.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DynamicDimensionChangedEventArgs
```

```text
public sealed class DynamicDimensionChangedEventArgs : EventArgs;
```

### Constructors

- [DynamicDimensionChangedEventArgs](#dynamicdimensionchangedeventargs)

### Properties

- [Index](#index)
- [Value](#value)


## Constructors Details

### DynamicDimensionChangedEventArgs

#### Description
This constructor sets the index and value for the new object.
```text
public DynamicDimensionChangedEventArgs(
    int index, 
    double value
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| int index | Input the index of the dimension |
| double value | Input the floating point value of the dimension |

### Index

#### Description
Accesses the index value
```text
public int Index;
```

#### Conditions
Read-only
### Value

#### Description
Accesses the value of the dimension
```text
public double Value;
```

#### Conditions
Read-only