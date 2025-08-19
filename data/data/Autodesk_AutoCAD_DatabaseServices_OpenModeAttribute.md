# OpenModeAttribute Class

## Overview

#### Description
Reports the open mode. See the OpenMode enum documentation for more information.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.OpenModeAttribute
```

```text
public sealed class OpenModeAttribute : Attribute;
```

### Constructors

- [OpenModeAttribute](#openmodeattribute)

### Properties

- [OpenMode](#openmode)


## Constructors Details

### OpenModeAttribute

#### Description
Constructor.
```text
public OpenModeAttribute(
    Autodesk.AutoCAD.DatabaseServices.OpenMode mode
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| Autodesk.AutoCAD.DatabaseServices.OpenMode mode | Mode of open object |

### OpenMode

#### Description
Accesses the open mode.
```text
public Autodesk.AutoCAD.DatabaseServices.OpenMode OpenMode;
```

#### Conditions
Read-only