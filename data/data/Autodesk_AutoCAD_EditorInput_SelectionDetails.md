# SelectionDetails Class

## Overview

#### Description
This class represents additional details about the selection.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.SelectionDetails
```

```text
public class SelectionDetails;
```

### Methods

- [GetContainers](#getcontainers)
- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [Transform](#transform)


## Methods Details

### GetContainers

#### Description
Returns an array of object IDs representing the containers of this nested entity.
```text
public ObjectId\[\] GetContainers();
```

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public override string ToString();
```

### ToString(IFormatProvider)

#### Description
Returns an equivalent string representation of this object, in the culture-specific format defined by provider.
```text
public string ToString(
    IFormatProvider provider
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| IFormatProvider provider | Input for culture-specific format |

### Transform

#### Description
Gets the transformation matrix that is applied to the picked object by its containers.
```text
public Matrix3d Transform;
```

#### Conditions
Read-only