# PromptPointResult Class

## Overview

#### Description
This class holds the result of a prompt that returns a point as its primary result.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptResult
    Autodesk.AutoCAD.EditorInput.PromptPointResult
```

```text
public sealed class PromptPointResult : PromptResult;
```

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [Value](#value)


## Methods Details

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

### Value

#### Description
Gets the point that the user entered.
```text
public Point3d Value;
```

#### Conditions
Read-only