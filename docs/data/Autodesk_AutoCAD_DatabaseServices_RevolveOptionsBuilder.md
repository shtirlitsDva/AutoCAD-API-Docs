# RevolveOptionsBuilder Class

## Overview

#### Description
This class is used to edit the properties of the RevolveOptions class, which is an immutable value type.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.RevolveOptionsBuilder
```

```text
public class RevolveOptionsBuilder;
```

### Constructors

- [RevolveOptionsBuilder()](#revolveoptionsbuilder())
- [RevolveOptionsBuilder(RevolveOptions)](#revolveoptionsbuilder(revolveoptions))

### Methods

- [ToRevolveOptions](#torevolveoptions)

### Properties

- [CloseToAxis](#closetoaxis)
- [DraftAngle](#draftangle)
- [TwistAngle](#twistangle)


## Constructors Details

### RevolveOptionsBuilder()

#### Description
Constructor.
```text
public RevolveOptionsBuilder();
```

### RevolveOptionsBuilder(RevolveOptions)

#### Description
Copy constructor.
```text
public RevolveOptionsBuilder(
    RevolveOptions value
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| RevolveOptions value | Input constructor to copy. |

### ToRevolveOptions

#### Description
Accesses the starting angle.
```text
public RevolveOptions ToRevolveOptions();
```

#### Conditions
Read-only
### CloseToAxis

#### Description
Accesses the close to axis option. If this option is set for an open profile, then the ends of the profile will be extended to the axis of revolution before revolving. The default value of this option is false.
```text
public bool CloseToAxis;
```

#### Conditions
Read / Write
### DraftAngle

#### Description
Accesses the draft angle in radians. 
This is the angle by which profile will taper as it is revolved around the axis. The default value of this option is 0.
```text
public double DraftAngle;
```

#### Conditions
Read / Write
### TwistAngle

#### Description
Accesses the angle by which the profile will be twisted as it revolves around the axis. The default value of this option is 0. 
Returns the twist angle in radians.
```text
public double TwistAngle;
```

#### Conditions
Read / Write