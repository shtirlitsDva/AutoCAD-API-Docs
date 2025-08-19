# PromptSelectionResult Class

## Overview

#### Description
This class represents the result of a prompt for a selection of objects.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptSelectionResult
```

```text
public sealed class PromptSelectionResult;
```

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [Status](#status)
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

### Status

#### Description
Gets the status result of the prompt operation.
```text
public Autodesk.AutoCAD.EditorInput.PromptStatus Status;
```

#### Conditions
Read-only
### Value

#### Description
Gets the SelectionSet that the user selected.
```text
public SelectionSet Value;
```

#### Conditions
Read-only