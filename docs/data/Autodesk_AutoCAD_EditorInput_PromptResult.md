# PromptResult Class

## Overview

#### Description
This is the base class for classes that hold the result of a prompt operation.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.PromptResult
    Autodesk.AutoCAD.EditorInput.PromptDoubleResult
    Autodesk.AutoCAD.EditorInput.PromptEntityResult
    Autodesk.AutoCAD.EditorInput.PromptFileNameResult
    Autodesk.AutoCAD.EditorInput.PromptIntegerResult
    Autodesk.AutoCAD.EditorInput.PromptPointResult
```

```text
public class PromptResult;
```

### Methods

- [ToString()](#tostring())
- [ToString(IFormatProvider)](#tostring(iformatprovider))

### Properties

- [Status](#status)
- [StringResult](#stringresult)


## Methods Details

### ToString()

#### Description
Returns an equivalent string representation of this object
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

### Status

#### Description
Gets the status result of the prompt operation.
```text
public Autodesk.AutoCAD.EditorInput.PromptStatus Status;
```

#### Conditions
Read-only
### StringResult

#### Description
Gets the optional string result of the prompt operation. This value is set when Status is PromptStatus.Keyword or a prompt that returns a string as its primary result.
```text
public string StringResult;
```

#### Conditions
Read-only