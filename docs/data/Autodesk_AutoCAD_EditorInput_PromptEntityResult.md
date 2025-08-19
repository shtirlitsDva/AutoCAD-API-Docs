# PromptEntityResult Class

## Overview

#### Description
This class holds the result of a prompt that returns an entity as its primary result.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptResult
    Autodesk.AutoCAD.EditorInput.PromptEntityResult
        Autodesk.AutoCAD.EditorInput.PromptNestedEntityResult
```

```text
public class PromptEntityResult : PromptResult;
```

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [ObjectId](#objectid)
- [PickedPoint](#pickedpoint)


## Methods Details

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

### ObjectId

#### Description
Gets the entity that the user picked.
```text
public Autodesk.AutoCAD.DatabaseServices.ObjectId ObjectId;
```

#### Conditions
Read-only
### PickedPoint

#### Description
Gets the point that was used to pick the entity.
```text
public Point3d PickedPoint;
```

#### Conditions
Read-only