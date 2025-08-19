# PromptNestedEntityResult Class

## Overview

#### Description
This class holds the result of a prompt that returns a nested entity as its primary result.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptResult
    Autodesk.AutoCAD.EditorInput.PromptEntityResult
        Autodesk.AutoCAD.EditorInput.PromptNestedEntityResult
```

```text
public sealed class PromptNestedEntityResult : PromptEntityResult;
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
Gets an array of containers in which this entity is nested. 
Returns an array of object IDs representing the containers of this nested entity.
```text
public ObjectId\[\] GetContainers();
```

### ToString()

#### Description
Returns an equivalent string representation of this object.
```text
public sealed override string ToString();
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