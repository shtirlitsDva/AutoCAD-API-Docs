# PromptDoubleResult Class

## Overview

#### Description
This class holds the result of a prompt that returns a double as its primary result.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptResult
    Autodesk.AutoCAD.EditorInput.PromptDoubleResult
```

```text
public sealed class PromptDoubleResult : PromptResult;
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
Gets the double that the user entered.
```text
public double Value;
```

#### Conditions
Read / Write